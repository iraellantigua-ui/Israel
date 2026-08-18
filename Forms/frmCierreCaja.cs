using System;
using System.Data;
using System.Windows.Forms;
using WalkiriaPapeleria.DAO;
using WalkiriaPapeleria.Models;
using WalkiriaPapeleria.Helpers;

namespace WalkiriaPapeleria.Forms
{
    public partial class frmCierreCaja : Form
    {
        private CierreCajaDAO cierreCajaDAO;
        private int idAsignacionTurnoSeleccionada = 0;

        public frmCierreCaja()
        {
            InitializeComponent();
            cierreCajaDAO = new CierreCajaDAO();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
        }

        private void frmCierreCaja_Load(object sender, EventArgs e)
        {
            // Configurar ComboBox de Turno
            cmbTurnoCierre.Items.Clear();
            cmbTurnoCierre.Items.Add("Matutino");
            cmbTurnoCierre.Items.Add("Vespertino");
            cmbTurnoCierre.SelectedIndex = -1;

            // Configurar fecha por defecto
            dtpFechaCierre.Value = DateTime.Now;

            // Cargar listas
            CargarCajeros();
            CargarSupervisores();

            LimpiarCampos();
            btnGuardarCierre.Enabled = false;
            btnCalcular.Enabled = false;
            chkCierreConfirmado.Checked = false;
            btnBuscar.Enabled = true;

            // Mostrar turno desde SessionManager
            if (SessionManager.IsLoggedIn)
            {
                lblTurnoActual.Text = "🕐 Turno: " + (SessionManager.TurnoActual ?? "No asignado");
            }
            else
            {
                lblTurnoActual.Text = "🕐 Turno: No autenticado";
            }
        }

        private void CargarCajeros()
        {
            try
            {
                DataTable dt = cierreCajaDAO.ObtenerCajeros();
                cmbCajero.DataSource = dt;
                cmbCajero.DisplayMember = "NombreCompleto";
                cmbCajero.ValueMember = "ID_Usuario";
                cmbCajero.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar cajeros: " + ex.Message);
            }
        }

        private void CargarSupervisores()
        {
            try
            {
                DataTable dt = cierreCajaDAO.ObtenerSupervisores();
                cmbSupervisor.DataSource = dt;
                cmbSupervisor.DisplayMember = "NombreCompleto";
                cmbSupervisor.ValueMember = "ID_Usuario";
                cmbSupervisor.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar supervisores: " + ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar selección de cajero
                if (cmbCajero.SelectedIndex < 0)
                {
                    MessageBox.Show("Seleccione un cajero.");
                    cmbCajero.Focus();
                    return;
                }

                // Validar selección de turno
                if (cmbTurnoCierre.SelectedIndex < 0)
                {
                    MessageBox.Show("Seleccione un turno.");
                    cmbTurnoCierre.Focus();
                    return;
                }

                int idCajero = Convert.ToInt32(cmbCajero.SelectedValue);
                string turno = cmbTurnoCierre.SelectedItem.ToString();
                DateTime fecha = dtpFechaCierre.Value.Date;

                // Buscar asignación de turno
                DataTable dtAsignacion = cierreCajaDAO.ObtenerAsignacionPorCajeroFechaTurno(idCajero, fecha, turno);

                if (dtAsignacion.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontró asignación de turno para el cajero seleccionado en la fecha y turno indicados.\n\n" +
                                   "Asegúrese de que:\n" +
                                   "1. El cajero inició sesión en ese turno\n" +
                                   "2. La fecha es correcta\n" +
                                   "3. El turno coincide con el seleccionado al iniciar sesión",
                        "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    btnCalcular.Enabled = false;
                    btnGuardarCierre.Enabled = false;
                    return;
                }

                DataRow row = dtAsignacion.Rows[0];
                idAsignacionTurnoSeleccionada = Convert.ToInt32(row["ID_Asignacion_Turno"]);

                // Verificar si ya tiene cierre
                if (cierreCajaDAO.ExisteCierre(idAsignacionTurnoSeleccionada))
                {
                    MessageBox.Show("Este turno ya tiene un cierre registrado.",
                        "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnGuardarCierre.Enabled = false;
                    btnCalcular.Enabled = false;
                    return;
                }

                CargarTotalesTurno();
                btnCalcular.Enabled = true;
                btnGuardarCierre.Enabled = false;
                chkCierreConfirmado.Checked = false;
                btnBuscar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
        }

        private void CargarTotalesTurno()
        {
            try
            {
                if (idAsignacionTurnoSeleccionada > 0)
                {
                    decimal[] totales = cierreCajaDAO.ObtenerTotalesTurno(idAsignacionTurnoSeleccionada);

                    decimal totalEfectivo = totales[0];
                    decimal totalTarjeta = totales[1];
                    decimal totalTransferencia = totales[2];
                    decimal totalVentas = totales[3];
                    int cantidadFacturas = (int)totales[4];

                    // Mostrar en los labels
                    lblTotalEfectivo.Text = totalEfectivo.ToString("C2");
                    lblTotalTarjeta.Text = totalTarjeta.ToString("C2");
                    lblTotalTransferencia.Text = totalTransferencia.ToString("C2");
                    lblTotalVentas.Text = totalVentas.ToString("C2");
                    lblCantidadFacturas.Text = cantidadFacturas.ToString();

                    // Cargar ventas del turno
                    DataTable dtVentas = cierreCajaDAO.ObtenerVentasTurno(idAsignacionTurnoSeleccionada);
                    dgvVentasTurno.DataSource = dtVentas;
                    ConfigurarDataGridViewVentas();

                    // Asignar valores a los campos
                    txtFondoInicial.Text = "1000.00";
                    txtMontoContado.Text = "0.00";

                    // Calcular diferencia automáticamente
                    CalcularDiferencia();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar totales: " + ex.Message);
            }
        }

        private void ConfigurarDataGridViewVentas()
        {
            try
            {
                if (dgvVentasTurno.Columns.Contains("Numero_Factura"))
                    dgvVentasTurno.Columns["Numero_Factura"].HeaderText = "Factura";

                if (dgvVentasTurno.Columns.Contains("Fecha_Factura"))
                {
                    dgvVentasTurno.Columns["Fecha_Factura"].HeaderText = "Fecha";
                    dgvVentasTurno.Columns["Fecha_Factura"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                }

                if (dgvVentasTurno.Columns.Contains("Cliente"))
                    dgvVentasTurno.Columns["Cliente"].HeaderText = "Cliente";

                if (dgvVentasTurno.Columns.Contains("Metodo_Pago"))
                    dgvVentasTurno.Columns["Metodo_Pago"].HeaderText = "Método Pago";

                if (dgvVentasTurno.Columns.Contains("Total_Factura"))
                {
                    dgvVentasTurno.Columns["Total_Factura"].HeaderText = "Total";
                    dgvVentasTurno.Columns["Total_Factura"].DefaultCellStyle.Format = "C2";
                }

                dgvVentasTurno.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error configurando DataGridView: " + ex.Message);
            }
        }

        private void CalcularDiferencia()
        {
            try
            {
                decimal fondoInicial = decimal.TryParse(txtFondoInicial.Text, out decimal fi) ? fi : 0;
                decimal montoContado = decimal.TryParse(txtMontoContado.Text, out decimal mc) ? mc : 0;

                decimal totalVentas = 0;
                if (decimal.TryParse(lblTotalVentas.Text.Replace("RD$", "").Trim(),
                    System.Globalization.NumberStyles.Currency,
                    System.Globalization.CultureInfo.CurrentCulture, out totalVentas))
                {
                    // OK
                }

                decimal diferencia = montoContado - (fondoInicial + totalVentas);
                lblDiferencia.Text = diferencia.ToString("C2");

                if (diferencia > 0)
                {
                    lblDiferencia.ForeColor = System.Drawing.Color.Green;
                }
                else if (diferencia < 0)
                {
                    lblDiferencia.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    lblDiferencia.ForeColor = System.Drawing.Color.Black;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al calcular diferencia: " + ex.Message);
            }
        }

        private void txtFondoInicial_TextChanged(object sender, EventArgs e)
        {
            if (chkCierreConfirmado.Checked)
            {
                CalcularDiferencia();
            }
        }

        private void txtMontoContado_TextChanged(object sender, EventArgs e)
        {
            if (chkCierreConfirmado.Checked)
            {
                CalcularDiferencia();
            }
        }

        private void chkCierreConfirmado_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCierreConfirmado.Checked)
            {
                btnGuardarCierre.Enabled = true;
                btnCalcular.Enabled = false;
                txtFondoInicial.ReadOnly = false;
                txtMontoContado.ReadOnly = false;
                txtObservacion.ReadOnly = false;
                CalcularDiferencia();
            }
            else
            {
                btnGuardarCierre.Enabled = false;
                btnCalcular.Enabled = true;
                txtFondoInicial.ReadOnly = true;
                txtMontoContado.ReadOnly = true;
                txtObservacion.ReadOnly = true;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (idAsignacionTurnoSeleccionada == 0)
            {
                MessageBox.Show("Primero debe buscar un turno válido.");
                return;
            }

            if (cmbSupervisor.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione un supervisor.");
                return;
            }

            chkCierreConfirmado.Checked = true;
        }

        private void btnGuardarCierre_Click(object sender, EventArgs e)
        {
            try
            {
                if (idAsignacionTurnoSeleccionada == 0)
                {
                    MessageBox.Show("No hay turno seleccionado. Realice una búsqueda primero.");
                    return;
                }

                if (cmbSupervisor.SelectedIndex < 0)
                {
                    MessageBox.Show("Seleccione un supervisor.");
                    return;
                }

                if (string.IsNullOrEmpty(txtFondoInicial.Text))
                {
                    MessageBox.Show("Ingrese el fondo inicial.");
                    txtFondoInicial.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtMontoContado.Text))
                {
                    MessageBox.Show("Ingrese el monto contado.");
                    txtMontoContado.Focus();
                    return;
                }

                decimal fondoInicial = decimal.Parse(txtFondoInicial.Text);
                decimal montoContado = decimal.Parse(txtMontoContado.Text);

                if (fondoInicial < 1000)
                {
                    MessageBox.Show("El fondo inicial debe ser mayor o igual a RD$1,000.00");
                    txtFondoInicial.Focus();
                    return;
                }

                // Confirmar cierre
                DialogResult result = MessageBox.Show(
                    "¿Está seguro que desea realizar el cierre de caja?\n\n" +
                    "Total Ventas: " + lblTotalVentas.Text + "\n" +
                    "Diferencia: " + lblDiferencia.Text + "\n\n" +
                    "Esta acción finalizará el turno.",
                    "Confirmar Cierre",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result != DialogResult.Yes)
                    return;

                // Crear objeto CierreCaja
                CierreCaja cierre = new CierreCaja();
                cierre.ID_Asignacion_Turno = idAsignacionTurnoSeleccionada;
                cierre.ID_Supervisor = Convert.ToInt32(cmbSupervisor.SelectedValue);
                cierre.Fondo_Inicial = fondoInicial;
                cierre.Cantidad_Facturas = int.Parse(lblCantidadFacturas.Text);
                cierre.Total_Efectivo = decimal.Parse(lblTotalEfectivo.Text, System.Globalization.NumberStyles.Currency);
                cierre.Total_Tarjeta = decimal.Parse(lblTotalTarjeta.Text, System.Globalization.NumberStyles.Currency);
                cierre.Total_Transferencia = decimal.Parse(lblTotalTransferencia.Text, System.Globalization.NumberStyles.Currency);
                cierre.Total_Ventas = decimal.Parse(lblTotalVentas.Text, System.Globalization.NumberStyles.Currency);
                cierre.Monto_Contado = montoContado;
                cierre.Diferencia_Caja = decimal.Parse(lblDiferencia.Text, System.Globalization.NumberStyles.Currency);
                cierre.Observacion = string.IsNullOrEmpty(txtObservacion.Text) ? null : txtObservacion.Text;
                cierre.Estado_Cierre = true;

                if (cierreCajaDAO.GuardarCierre(cierre))
                {
                    MessageBox.Show(
                        "✅ Cierre de caja realizado correctamente.\n\n" +
                        "Total Ventas: " + lblTotalVentas.Text + "\n" +
                        "Diferencia: " + lblDiferencia.Text,
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LimpiarCampos();
                    btnBuscar.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar cierre: " + ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            lblTotalEfectivo.Text = "RD$ 0.00";
            lblTotalTarjeta.Text = "RD$ 0.00";
            lblTotalTransferencia.Text = "RD$ 0.00";
            lblTotalVentas.Text = "RD$ 0.00";
            lblCantidadFacturas.Text = "0";
            lblDiferencia.Text = "RD$ 0.00";
            txtFondoInicial.Text = "1000.00";
            txtMontoContado.Text = "0.00";
            txtObservacion.Text = "";
            dgvVentasTurno.DataSource = null;
            cmbSupervisor.SelectedIndex = -1;
            chkCierreConfirmado.Checked = false;
            btnGuardarCierre.Enabled = false;
            btnCalcular.Enabled = false;
            txtFondoInicial.ReadOnly = true;
            txtMontoContado.ReadOnly = true;
            txtObservacion.ReadOnly = true;
            idAsignacionTurnoSeleccionada = 0;
            btnBuscar.Enabled = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}