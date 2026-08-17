using System;
using System.Data;
using System.Windows.Forms;
using WalkiriaPapeleria.DAO;
using WalkiriaPapeleria.Models;

namespace WalkiriaPapeleria.Forms
{
    public partial class frmClientes : Form
    {
        private ClienteDAO clienteDAO;
        private bool esEdicion = false;
        private int idClienteSeleccionado = 0;

        public frmClientes()
        {
            InitializeComponent();
            clienteDAO = new ClienteDAO();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            CargarClientes();
            LimpiarCampos();
            btnEliminar.Enabled = false;
            btnEditar.Enabled = false;
        }

        private void CargarClientes()
        {
            try
            {
                DataTable dt = clienteDAO.ObtenerTodos();
                dgvClientes.DataSource = dt;
                ConfigurarDataGridView();
                lblTotal.Text = "Total: " + dt.Rows.Count + " clientes";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarDataGridView()
        {
            try
            {
                if (dgvClientes.Columns.Contains("ID_Cliente"))
                    dgvClientes.Columns["ID_Cliente"].Visible = false;

                if (dgvClientes.Columns.Contains("Cedula_Cliente"))
                    dgvClientes.Columns["Cedula_Cliente"].HeaderText = "Cédula";

                if (dgvClientes.Columns.Contains("Nombre_Cliente"))
                    dgvClientes.Columns["Nombre_Cliente"].HeaderText = "Nombre";

                if (dgvClientes.Columns.Contains("Apellido_Cliente"))
                    dgvClientes.Columns["Apellido_Cliente"].HeaderText = "Apellido";

                if (dgvClientes.Columns.Contains("Telefono_Cliente"))
                    dgvClientes.Columns["Telefono_Cliente"].HeaderText = "Teléfono";

                if (dgvClientes.Columns.Contains("Correo_Cliente"))
                    dgvClientes.Columns["Correo_Cliente"].HeaderText = "Correo";

                if (dgvClientes.Columns.Contains("Direccion_Cliente"))
                    dgvClientes.Columns["Direccion_Cliente"].HeaderText = "Dirección";

                if (dgvClientes.Columns.Contains("Fecha_Registro_Cliente"))
                    dgvClientes.Columns["Fecha_Registro_Cliente"].HeaderText = "Fecha Registro";

                dgvClientes.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error configurando DataGridView: " + ex.Message);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string busqueda = txtBuscar.Text.Trim();

            if (string.IsNullOrEmpty(busqueda) || busqueda == "Buscar por nombre o cédula...")
            {
                CargarClientes();
                return;
            }

            try
            {
                DataTable dt;
                bool esNumero = false;
                foreach (char c in busqueda)
                {
                    if (char.IsDigit(c))
                    {
                        esNumero = true;
                        break;
                    }
                }

                if (esNumero)
                    dt = clienteDAO.BuscarPorCedula(busqueda);
                else
                    dt = clienteDAO.BuscarPorNombre(busqueda);

                dgvClientes.DataSource = dt;
                ConfigurarDataGridView();
                lblTotal.Text = "Total: " + dt.Rows.Count + " clientes encontrados";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvClientes.SelectedRows[0];
                idClienteSeleccionado = Convert.ToInt32(row.Cells["ID_Cliente"].Value);
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
            idClienteSeleccionado = 0;
            LimpiarCampos();
            HabilitarCampos(true);
            txtCedula.Focus();
            btnGuardar.Text = "Guardar";
            lblTituloFormulario.Text = "Nuevo Cliente";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (idClienteSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un cliente para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                esEdicion = true;
                Cliente cliente = clienteDAO.ObtenerPorID(idClienteSeleccionado);
                ContactoCliente contacto = clienteDAO.ObtenerContactoPorIDCliente(idClienteSeleccionado);

                if (cliente != null)
                {
                    txtCedula.Text = cliente.Cedula_Cliente;
                    txtNombre.Text = cliente.Nombre_Cliente;
                    txtApellido.Text = cliente.Apellido_Cliente;

                    if (contacto != null)
                    {
                        txtTelefono.Text = contacto.Telefono_Cliente;
                        txtCorreo.Text = contacto.Correo_Cliente;
                        txtDireccion.Text = contacto.Direccion_Cliente;
                    }
                }

                HabilitarCampos(true);
                txtCedula.Focus();
                btnGuardar.Text = "Actualizar";
                lblTituloFormulario.Text = "Editar Cliente";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos())
                    return;

                Cliente cliente = new Cliente();
                cliente.Cedula_Cliente = txtCedula.Text.Trim();
                cliente.Nombre_Cliente = txtNombre.Text.Trim();
                cliente.Apellido_Cliente = txtApellido.Text.Trim();

                ContactoCliente contacto = new ContactoCliente();
                contacto.Telefono_Cliente = txtTelefono.Text.Trim();
                contacto.Correo_Cliente = string.IsNullOrEmpty(txtCorreo.Text.Trim()) ? null : txtCorreo.Text.Trim();
                contacto.Direccion_Cliente = txtDireccion.Text.Trim();

                if (esEdicion)
                {
                    cliente.ID_Cliente = idClienteSeleccionado;
                    contacto.ID_Cliente = idClienteSeleccionado;

                    if (clienteDAO.Actualizar(cliente, contacto))
                        MessageBox.Show("Cliente actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (clienteDAO.ExisteCedula(cliente.Cedula_Cliente))
                    {
                        MessageBox.Show("Ya existe un cliente con esta cédula.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCedula.Focus();
                        return;
                    }

                    if (clienteDAO.Insertar(cliente, contacto))
                        MessageBox.Show("Cliente registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                CargarClientes();
                LimpiarCampos();
                HabilitarCampos(false);
                btnGuardar.Text = "Guardar";
                lblTituloFormulario.Text = "Gestión de Clientes";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idClienteSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un cliente para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar este cliente?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    if (clienteDAO.Eliminar(idClienteSeleccionado))
                    {
                        MessageBox.Show("Cliente eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarClientes();
                        LimpiarCampos();
                        HabilitarCampos(false);
                        btnGuardar.Text = "Guardar";
                        lblTituloFormulario.Text = "Gestión de Clientes";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            HabilitarCampos(false);
            btnGuardar.Text = "Guardar";
            lblTituloFormulario.Text = "Gestión de Clientes";
            esEdicion = false;
            idClienteSeleccionado = 0;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void LimpiarCampos()
        {
            txtCedula.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            txtDireccion.Text = "";
        }

        private void HabilitarCampos(bool habilitar)
        {
            txtCedula.Enabled = habilitar;
            txtNombre.Enabled = habilitar;
            txtApellido.Enabled = habilitar;
            txtTelefono.Enabled = habilitar;
            txtCorreo.Enabled = habilitar;
            txtDireccion.Enabled = habilitar;
            btnGuardar.Enabled = habilitar;
            btnCancelar.Enabled = habilitar;
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtCedula.Text))
            {
                MessageBox.Show("La cédula es obligatoria.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCedula.Focus();
                return false;
            }

            if (txtCedula.Text.Length < 11)
            {
                MessageBox.Show("La cédula debe tener 11 dígitos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCedula.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("El apellido es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtApellido.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("El teléfono es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefono.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("La dirección es obligatoria.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDireccion.Focus();
                return false;
            }

            return true;
        }
    }
}