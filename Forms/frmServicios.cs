using System;
using System.Data;
using System.Windows.Forms;
using WalkiriaPapeleria.DAO;
using WalkiriaPapeleria.Models;

namespace WalkiriaPapeleria.Forms
{
    public partial class frmServicios : Form
    {
        private ServicioDAO servicioDAO;
        private bool esEdicion = false;
        private int idServicioSeleccionado = 0;

        public frmServicios()
        {
            InitializeComponent();
            servicioDAO = new ServicioDAO();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
        }

        private void frmServicios_Load(object sender, EventArgs e)
        {
            // Configurar ComboBox de Estado
            cmbEstado.Items.Clear();
            cmbEstado.Items.Add("Disponible");
            cmbEstado.Items.Add("No Disponible");
            cmbEstado.SelectedIndex = 0;

            CargarServicios();
            LimpiarCampos();
            btnEliminar.Enabled = false;
            btnEditar.Enabled = false;
        }

        private void CargarServicios()
        {
            try
            {
                DataTable dt = servicioDAO.ObtenerTodos();
                dgvServicios.DataSource = dt;
                ConfigurarDataGridView();
                lblTotal.Text = "Total: " + dt.Rows.Count + " servicios";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar servicios: " + ex.Message);
            }
        }

        private void ConfigurarDataGridView()
        {
            try
            {
                if (dgvServicios.Columns.Contains("ID_Servicio"))
                    dgvServicios.Columns["ID_Servicio"].Visible = false;

                if (dgvServicios.Columns.Contains("Nombre_Servicio"))
                    dgvServicios.Columns["Nombre_Servicio"].HeaderText = "Servicio";

                if (dgvServicios.Columns.Contains("Descripcion_Servicio"))
                    dgvServicios.Columns["Descripcion_Servicio"].HeaderText = "Descripción";

                if (dgvServicios.Columns.Contains("Precio_Servicio"))
                {
                    dgvServicios.Columns["Precio_Servicio"].HeaderText = "Precio";
                    dgvServicios.Columns["Precio_Servicio"].DefaultCellStyle.Format = "C2";
                }

                if (dgvServicios.Columns.Contains("Estado_Servicio"))
                    dgvServicios.Columns["Estado_Servicio"].HeaderText = "Estado";

                if (dgvServicios.Columns.Contains("Fecha_Registro"))
                {
                    dgvServicios.Columns["Fecha_Registro"].HeaderText = "Fecha Registro";
                    dgvServicios.Columns["Fecha_Registro"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                }

                dgvServicios.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error configurando DataGridView: " + ex.Message);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string busqueda = txtBuscar.Text.Trim();

            if (string.IsNullOrEmpty(busqueda) || busqueda == "Buscar...")
            {
                CargarServicios();
                return;
            }

            try
            {
                DataTable dt = servicioDAO.BuscarPorNombre(busqueda);
                dgvServicios.DataSource = dt;
                ConfigurarDataGridView();
                lblTotal.Text = "Total: " + dt.Rows.Count + " servicios encontrados";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
        }

        private void dgvServicios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvServicios.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvServicios.SelectedRows[0];
                idServicioSeleccionado = Convert.ToInt32(row.Cells["ID_Servicio"].Value);
                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
            }
            else
            {
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            esEdicion = false;
            idServicioSeleccionado = 0;
            LimpiarCampos();
            HabilitarCampos(true);
            txtNombre.Focus();
            btnGuardar.Text = "Guardar";
            lblTituloFormulario.Text = "Nuevo Servicio";
            cmbEstado.SelectedIndex = 0;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (idServicioSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un servicio para editar.");
                return;
            }

            try
            {
                esEdicion = true;
                Servicio servicio = servicioDAO.ObtenerPorID(idServicioSeleccionado);

                if (servicio != null)
                {
                    txtNombre.Text = servicio.Nombre_Servicio;
                    txtDescripcion.Text = servicio.Descripcion_Servicio;
                    txtPrecio.Text = servicio.Precio_Servicio.ToString("F2");
                    cmbEstado.SelectedIndex = servicio.Estado_Servicio ? 0 : 1;
                }

                HabilitarCampos(true);
                txtNombre.Focus();
                btnGuardar.Text = "Actualizar";
                lblTituloFormulario.Text = "Editar Servicio";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos())
                    return;

                Servicio servicio = new Servicio();
                servicio.Nombre_Servicio = txtNombre.Text.Trim();
                servicio.Descripcion_Servicio = string.IsNullOrEmpty(txtDescripcion.Text.Trim()) ? null : txtDescripcion.Text.Trim();
                servicio.Precio_Servicio = Convert.ToDecimal(txtPrecio.Text.Trim());
                servicio.Estado_Servicio = cmbEstado.SelectedIndex == 0;

                if (esEdicion)
                {
                    servicio.ID_Servicio = idServicioSeleccionado;

                    if (servicioDAO.Actualizar(servicio))
                        MessageBox.Show("Servicio actualizado correctamente.");
                }
                else
                {
                    if (servicioDAO.ExisteNombre(servicio.Nombre_Servicio))
                    {
                        MessageBox.Show("Ya existe un servicio con este nombre.");
                        txtNombre.Focus();
                        return;
                    }

                    if (servicioDAO.Insertar(servicio))
                        MessageBox.Show("Servicio registrado correctamente.");
                }

                CargarServicios();
                LimpiarCampos();
                HabilitarCampos(false);
                btnGuardar.Text = "Guardar";
                lblTituloFormulario.Text = "Gestión de Servicios";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idServicioSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un servicio para eliminar.");
                return;
            }

            DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar este servicio?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    if (servicioDAO.Eliminar(idServicioSeleccionado))
                    {
                        MessageBox.Show("Servicio eliminado correctamente.");
                        CargarServicios();
                        LimpiarCampos();
                        HabilitarCampos(false);
                        btnGuardar.Text = "Guardar";
                        lblTituloFormulario.Text = "Gestión de Servicios";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            HabilitarCampos(false);
            btnGuardar.Text = "Guardar";
            lblTituloFormulario.Text = "Gestión de Servicios";
            esEdicion = false;
            idServicioSeleccionado = 0;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            cmbEstado.SelectedIndex = 0;
        }

        private void HabilitarCampos(bool habilitar)
        {
            txtNombre.Enabled = habilitar;
            txtDescripcion.Enabled = habilitar;
            txtPrecio.Enabled = habilitar;
            cmbEstado.Enabled = habilitar;
            btnGuardar.Enabled = habilitar;
            btnCancelar.Enabled = habilitar;
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre del servicio es obligatorio.");
                txtNombre.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                MessageBox.Show("El precio es obligatorio.");
                txtPrecio.Focus();
                return false;
            }

            decimal precio;
            if (!decimal.TryParse(txtPrecio.Text, out precio) || precio <= 0)
            {
                MessageBox.Show("Ingrese un precio válido mayor a 0.");
                txtPrecio.Focus();
                return false;
            }

            return true;
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && txtPrecio.Text.Contains("."))
            {
                e.Handled = true;
            }
        }
    }
}
