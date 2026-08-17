using System;
using System.Data;
using System.Windows.Forms;
using WalkiriaPapeleria.DAO;
using WalkiriaPapeleria.Helpers;

namespace WalkiriaPapeleria.Forms
{
    public partial class frmHistorialFacturas : Form
    {
        private FacturaDAO facturaDAO;
        private int idFacturaSeleccionada = 0;

        public frmHistorialFacturas()
        {
            InitializeComponent();
            facturaDAO = new FacturaDAO();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
        }

        private void frmHistorialFacturas_Load(object sender, EventArgs e)
        {
            // Configurar fechas
            dtpFechaInicio.Value = DateTime.Now.AddDays(-30);
            dtpFechaFin.Value = DateTime.Now;

            CargarFacturas();
            btnVerDetalle.Enabled = false;
            btnReimprimir.Enabled = false;
            btnAnular.Enabled = false;
        }

        private void CargarFacturas()
        {
            try
            {
                DataTable dt = facturaDAO.ObtenerTodas();
                dgvFacturas.DataSource = dt;
                ConfigurarDataGridView();
                lblTotal.Text = "Total: " + dt.Rows.Count + " facturas";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar facturas: " + ex.Message);
            }
        }

        private void ConfigurarDataGridView()
        {
            try
            {
                if (dgvFacturas.Columns.Contains("ID_Factura"))
                    dgvFacturas.Columns["ID_Factura"].Visible = false;

                if (dgvFacturas.Columns.Contains("Numero_Factura"))
                    dgvFacturas.Columns["Numero_Factura"].HeaderText = "Factura Nº";

                if (dgvFacturas.Columns.Contains("Fecha_Factura"))
                {
                    dgvFacturas.Columns["Fecha_Factura"].HeaderText = "Fecha";
                    dgvFacturas.Columns["Fecha_Factura"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                }

                if (dgvFacturas.Columns.Contains("Cliente"))
                    dgvFacturas.Columns["Cliente"].HeaderText = "Cliente";

                if (dgvFacturas.Columns.Contains("Usuario"))
                    dgvFacturas.Columns["Usuario"].HeaderText = "Usuario";

                if (dgvFacturas.Columns.Contains("Metodo_Pago"))
                    dgvFacturas.Columns["Metodo_Pago"].HeaderText = "Método Pago";

                if (dgvFacturas.Columns.Contains("Subtotal"))
                {
                    dgvFacturas.Columns["Subtotal"].HeaderText = "Subtotal";
                    dgvFacturas.Columns["Subtotal"].DefaultCellStyle.Format = "C2";
                }

                if (dgvFacturas.Columns.Contains("Descuento"))
                {
                    dgvFacturas.Columns["Descuento"].HeaderText = "Descuento";
                    dgvFacturas.Columns["Descuento"].DefaultCellStyle.Format = "C2";
                }

                if (dgvFacturas.Columns.Contains("ITBIS"))
                {
                    dgvFacturas.Columns["ITBIS"].HeaderText = "ITBIS";
                    dgvFacturas.Columns["ITBIS"].DefaultCellStyle.Format = "C2";
                }

                if (dgvFacturas.Columns.Contains("Total_Factura"))
                {
                    dgvFacturas.Columns["Total_Factura"].HeaderText = "Total";
                    dgvFacturas.Columns["Total_Factura"].DefaultCellStyle.Format = "C2";
                }

                if (dgvFacturas.Columns.Contains("Estado_Factura"))
                {
                    dgvFacturas.Columns["Estado_Factura"].HeaderText = "Estado";
                    dgvFacturas.Columns["Estado_Factura"].DefaultCellStyle.Format = "Activa;Anulada";
                }

                dgvFacturas.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error configurando DataGridView: " + ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaInicio = dtpFechaInicio.Value.Date;
                DateTime fechaFin = dtpFechaFin.Value.Date.AddDays(1).AddSeconds(-1);

                DataTable dt = facturaDAO.ObtenerPorFechas(fechaInicio, fechaFin);
                dgvFacturas.DataSource = dt;
                ConfigurarDataGridView();
                lblTotal.Text = "Total: " + dt.Rows.Count + " facturas encontradas";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar facturas: " + ex.Message);
            }
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            dtpFechaInicio.Value = DateTime.Now.AddDays(-30);
            dtpFechaFin.Value = DateTime.Now;
            CargarFacturas();
        }

        private void dgvFacturas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvFacturas.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvFacturas.SelectedRows[0];
                idFacturaSeleccionada = Convert.ToInt32(row.Cells["ID_Factura"].Value);
                btnVerDetalle.Enabled = true;
                btnReimprimir.Enabled = true;

                // Verificar si la factura está activa para permitir anulación
                bool estadoActivo = Convert.ToBoolean(row.Cells["Estado_Factura"].Value);
                btnAnular.Enabled = estadoActivo && (SessionManager.IsAdmin || SessionManager.IsSupervisor);
            }
            else
            {
                btnVerDetalle.Enabled = false;
                btnReimprimir.Enabled = false;
                btnAnular.Enabled = false;
            }
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            if (idFacturaSeleccionada == 0)
            {
                MessageBox.Show("Seleccione una factura para ver el detalle.");
                return;
            }

            try
            {
                DataTable dtDetalle = facturaDAO.ObtenerDetalle(idFacturaSeleccionada);
                DataTable dtFactura = facturaDAO.ObtenerPorID(idFacturaSeleccionada);

                if (dtDetalle.Rows.Count > 0)
                {
                    string detalle = "=== DETALLE DE FACTURA ===\n\n";
                    detalle += "Factura: " + dtFactura.Rows[0]["Numero_Factura"].ToString() + "\n";
                    detalle += "Fecha: " + Convert.ToDateTime(dtFactura.Rows[0]["Fecha_Factura"]).ToString("dd/MM/yyyy HH:mm") + "\n";
                    detalle += "Cliente: " + dtFactura.Rows[0]["Cliente"].ToString() + "\n";
                    detalle += "Usuario: " + dtFactura.Rows[0]["Usuario"].ToString() + "\n";
                    detalle += "Método Pago: " + dtFactura.Rows[0]["Metodo_Pago"].ToString() + "\n\n";
                    detalle += "--- ITEMS ---\n";

                    foreach (DataRow row in dtDetalle.Rows)
                    {
                        detalle += row["NombreItem"].ToString() + " | ";
                        detalle += "Cant: " + row["Cantidad"].ToString() + " | ";
                        detalle += "Precio: " + Convert.ToDecimal(row["Precio_Unitario"]).ToString("C2") + " | ";
                        detalle += "Total: " + Convert.ToDecimal(row["Total_Detalle"]).ToString("C2") + "\n";
                    }

                    detalle += "\n--- TOTALES ---\n";
                    detalle += "Subtotal: " + Convert.ToDecimal(dtFactura.Rows[0]["Subtotal"]).ToString("C2") + "\n";
                    detalle += "ITBIS: " + Convert.ToDecimal(dtFactura.Rows[0]["ITBIS"]).ToString("C2") + "\n";
                    detalle += "Total: " + Convert.ToDecimal(dtFactura.Rows[0]["Total_Factura"]).ToString("C2") + "\n";

                    MessageBox.Show(detalle, "Detalle de Factura", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se encontraron detalles para esta factura.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar detalle: " + ex.Message);
            }
        }

        private void btnReimprimir_Click(object sender, EventArgs e)
        {
            if (idFacturaSeleccionada == 0)
            {
                MessageBox.Show("Seleccione una factura para reimprimir.");
                return;
            }

            try
            {
                frmImpresionFactura impresion = new frmImpresionFactura(idFacturaSeleccionada);
                impresion.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al reimprimir: " + ex.Message);
            }
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            if (idFacturaSeleccionada == 0)
            {
                MessageBox.Show("Seleccione una factura para anular.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "¿Está seguro que desea ANULAR esta factura?\n" +
                "Esta acción no se puede deshacer.",
                "Confirmar anulación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    if (facturaDAO.AnularFactura(idFacturaSeleccionada))
                    {
                        MessageBox.Show("Factura anulada correctamente.",
                            "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarFacturas();
                        btnAnular.Enabled = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al anular factura: " + ex.Message);
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}