using System;
using System.Data;
using System.Windows.Forms;
using WalkiriaPapeleria.DAO;
using WalkiriaPapeleria.Models;
using WalkiriaPapeleria.Helpers;

namespace WalkiriaPapeleria.Forms
{
    public partial class frmEmpleados : Form
    {
        private EmpleadoDAO empleadoDAO;
        private bool esEdicion = false;
        private int idEmpleadoSeleccionado = 0;

        public frmEmpleados()
        {
            InitializeComponent();
            empleadoDAO = new EmpleadoDAO();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            // Configurar ComboBox de Sexo
            cmbSexo.Items.Clear();
            cmbSexo.Items.Add("M");
            cmbSexo.Items.Add("F");
            cmbSexo.SelectedIndex = -1;

            // Configurar ComboBox de Tipo Sangre
            cmbTipoSangre.Items.Clear();
            cmbTipoSangre.Items.Add("A+");
            cmbTipoSangre.Items.Add("A-");
            cmbTipoSangre.Items.Add("B+");
            cmbTipoSangre.Items.Add("B-");
            cmbTipoSangre.Items.Add("AB+");
            cmbTipoSangre.Items.Add("AB-");
            cmbTipoSangre.Items.Add("O+");
            cmbTipoSangre.Items.Add("O-");
            cmbTipoSangre.SelectedIndex = -1;

            // Configurar ComboBox de Roles
            CargarRoles();

            CargarEmpleados();
            LimpiarCampos();
            btnEliminar.Enabled = false;
            btnEditar.Enabled = false;
            HabilitarCampos(false);
        }

        private void CargarRoles()
        {
            try
            {
                DataTable dt = empleadoDAO.ObtenerRoles();
                cmbRol.DataSource = dt;
                cmbRol.DisplayMember = "Nombre_Rol";
                cmbRol.ValueMember = "ID_Rol";
                cmbRol.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar roles: " + ex.Message);
            }
        }

        private void CargarEmpleados()
        {
            try
            {
                DataTable dt = empleadoDAO.ObtenerTodos();
                dgvEmpleados.DataSource = dt;
                ConfigurarDataGridView();
                lblTotal.Text = "Total: " + dt.Rows.Count + " empleados";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar empleados: " + ex.Message);
            }
        }

        private void ConfigurarDataGridView()
        {
            try
            {
                if (dgvEmpleados.Columns.Contains("ID_Empleado"))
                    dgvEmpleados.Columns["ID_Empleado"].Visible = false;

                if (dgvEmpleados.Columns.Contains("Cedula_Empleado"))
                    dgvEmpleados.Columns["Cedula_Empleado"].HeaderText = "Cédula";

                if (dgvEmpleados.Columns.Contains("Nombre_Empleado"))
                    dgvEmpleados.Columns["Nombre_Empleado"].HeaderText = "Nombre";

                if (dgvEmpleados.Columns.Contains("Apellido_Empleado"))
                    dgvEmpleados.Columns["Apellido_Empleado"].HeaderText = "Apellido";

                if (dgvEmpleados.Columns.Contains("Sexo"))
                    dgvEmpleados.Columns["Sexo"].HeaderText = "Sexo";

                if (dgvEmpleados.Columns.Contains("Celular_Empleado"))
                    dgvEmpleados.Columns["Celular_Empleado"].HeaderText = "Celular";

                if (dgvEmpleados.Columns.Contains("Correo_Empleado"))
                    dgvEmpleados.Columns["Correo_Empleado"].HeaderText = "Correo";

                if (dgvEmpleados.Columns.Contains("Nombre_Rol"))
                    dgvEmpleados.Columns["Nombre_Rol"].HeaderText = "Rol";

                if (dgvEmpleados.Columns.Contains("Usuario"))
                    dgvEmpleados.Columns["Usuario"].HeaderText = "Usuario";

                if (dgvEmpleados.Columns.Contains("Estatus_Empleado"))
                {
                    dgvEmpleados.Columns["Estatus_Empleado"].HeaderText = "Estatus";
                    dgvEmpleados.Columns["Estatus_Empleado"].DefaultCellStyle.Format = "Activo;Inactivo";
                }

                if (dgvEmpleados.Columns.Contains("Estado_Usuario"))
                {
                    dgvEmpleados.Columns["Estado_Usuario"].HeaderText = "Estado Usuario";
                    dgvEmpleados.Columns["Estado_Usuario"].DefaultCellStyle.Format = "Activo;Inactivo";
                }

                dgvEmpleados.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error configurando DataGridView: " + ex.Message);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string busqueda = txtBuscar.Text.Trim();

            if (string.IsNullOrEmpty(busqueda) || busqueda == "Buscar por cédula...")
            {
                CargarEmpleados();
                return;
            }

            try
            {
                DataTable dt = empleadoDAO.BuscarPorCedula(busqueda);
                dgvEmpleados.DataSource = dt;
                ConfigurarDataGridView();
                lblTotal.Text = "Total: " + dt.Rows.Count + " empleados encontrados";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
        }

        private void dgvEmpleados_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvEmpleados.SelectedRows[0];
                idEmpleadoSeleccionado = Convert.ToInt32(row.Cells["ID_Empleado"].Value);
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
            idEmpleadoSeleccionado = 0;
            LimpiarCampos();
            HabilitarCampos(true);
            txtCedula.Focus();
            btnGuardar.Text = "Guardar";
            lblTituloFormulario.Text = "Nuevo Empleado";
            chkActivo.Checked = true;
            chkUsuarioActivo.Checked = true;
            chkCrearUsuario.Checked = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (idEmpleadoSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un empleado para editar.");
                return;
            }

            try
            {
                esEdicion = true;
                Empleado empleado = empleadoDAO.ObtenerPorID(idEmpleadoSeleccionado);

                if (empleado != null)
                {
                    txtCedula.Text = empleado.Cedula_Empleado;
                    txtNombre.Text = empleado.Nombre_Empleado;
                    txtApellido.Text = empleado.Apellido_Empleado;
                    cmbSexo.SelectedItem = empleado.Sexo;
                    dtpFechaNacimiento.Value = empleado.Fecha_Nacimiento;
                    cmbTipoSangre.SelectedItem = empleado.Tipo_Sangre;
                    txtCelular.Text = empleado.Celular_Empleado;
                    txtTelefonoExtra.Text = empleado.Telefono_Extra;
                    txtCorreo.Text = empleado.Correo_Empleado;
                    txtDireccion.Text = empleado.Direccion_Empleado;
                    chkActivo.Checked = empleado.Estatus_Empleado;

                    if (empleado.ID_Usuario > 0)
                    {
                        chkCrearUsuario.Checked = true;
                        txtUsuario.Text = empleado.Usuario;
                        cmbRol.SelectedValue = empleado.ID_Rol;
                        txtClave.Text = empleado.Clave;
                        chkUsuarioActivo.Checked = empleado.Estado_Usuario;
                    }
                    else
                    {
                        chkCrearUsuario.Checked = false;
                        txtUsuario.Clear();
                        cmbRol.SelectedIndex = -1;
                        txtClave.Clear();
                        chkUsuarioActivo.Checked = true;
                    }
                }

                HabilitarCampos(true);
                txtCedula.Focus();
                btnGuardar.Text = "Actualizar";
                lblTituloFormulario.Text = "Editar Empleado";
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

                Empleado empleado = new Empleado();
                empleado.Cedula_Empleado = txtCedula.Text.Trim();
                empleado.Nombre_Empleado = txtNombre.Text.Trim();
                empleado.Apellido_Empleado = txtApellido.Text.Trim();
                empleado.Sexo = cmbSexo.SelectedItem.ToString();
                empleado.Fecha_Nacimiento = dtpFechaNacimiento.Value;
                empleado.Tipo_Sangre = cmbTipoSangre.SelectedItem?.ToString();
                empleado.Celular_Empleado = txtCelular.Text.Trim();
                empleado.Telefono_Extra = string.IsNullOrEmpty(txtTelefonoExtra.Text.Trim()) ? null : txtTelefonoExtra.Text.Trim();
                empleado.Correo_Empleado = txtCorreo.Text.Trim();
                empleado.Direccion_Empleado = txtDireccion.Text.Trim();
                empleado.Estatus_Empleado = chkActivo.Checked;

                // Datos de usuario
                empleado.Usuario = string.IsNullOrEmpty(txtUsuario.Text.Trim()) ? null : txtUsuario.Text.Trim();
                empleado.Clave = string.IsNullOrEmpty(txtClave.Text) ? null : txtClave.Text;
                empleado.ID_Rol = cmbRol.SelectedIndex >= 0 ? Convert.ToInt32(cmbRol.SelectedValue) : 0;
                empleado.Estado_Usuario = chkUsuarioActivo.Checked;

                if (esEdicion)
                {
                    empleado.ID_Empleado = idEmpleadoSeleccionado;

                    if (empleadoDAO.Actualizar(empleado))
                        MessageBox.Show("Empleado actualizado correctamente.");
                }
                else
                {
                    if (empleadoDAO.ExisteCedula(empleado.Cedula_Empleado))
                    {
                        MessageBox.Show("Ya existe un empleado con esta cédula.");
                        txtCedula.Focus();
                        return;
                    }

                    if (!string.IsNullOrEmpty(empleado.Usuario) && empleadoDAO.ExisteUsuario(empleado.Usuario))
                    {
                        MessageBox.Show("El nombre de usuario ya está en uso.");
                        txtUsuario.Focus();
                        return;
                    }

                    if (empleadoDAO.Insertar(empleado))
                        MessageBox.Show("Empleado registrado correctamente.");
                }

                CargarEmpleados();
                LimpiarCampos();
                HabilitarCampos(false);
                btnGuardar.Text = "Guardar";
                lblTituloFormulario.Text = "Gestión de Empleados";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idEmpleadoSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un empleado para eliminar.");
                return;
            }

            // Verificar que no sea el mismo usuario logueado
            if (SessionManager.IsLoggedIn && SessionManager.UsuarioActual.ID_Empleado == idEmpleadoSeleccionado)
            {
                MessageBox.Show("No puede eliminar su propio usuario.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "¿Está seguro que desea eliminar este empleado?\n" +
                "Se eliminarán todos sus datos de contacto, usuario y estatus.",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    if (empleadoDAO.Eliminar(idEmpleadoSeleccionado))
                    {
                        MessageBox.Show("Empleado eliminado correctamente.");
                        CargarEmpleados();
                        LimpiarCampos();
                        HabilitarCampos(false);
                        btnGuardar.Text = "Guardar";
                        lblTituloFormulario.Text = "Gestión de Empleados";
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
            lblTituloFormulario.Text = "Gestión de Empleados";
            esEdicion = false;
            idEmpleadoSeleccionado = 0;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void LimpiarCampos()
        {
            txtCedula.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            cmbSexo.SelectedIndex = -1;
            dtpFechaNacimiento.Value = DateTime.Now.AddYears(-25);
            cmbTipoSangre.SelectedIndex = -1;
            txtCelular.Text = "";
            txtTelefonoExtra.Text = "";
            txtCorreo.Text = "";
            txtDireccion.Text = "";
            chkActivo.Checked = true;
            txtUsuario.Text = "";
            cmbRol.SelectedIndex = -1;
            txtClave.Text = "";
            chkUsuarioActivo.Checked = true;
            chkCrearUsuario.Checked = false;
        }

        private void HabilitarCampos(bool habilitar)
        {
            txtCedula.Enabled = habilitar;
            txtNombre.Enabled = habilitar;
            txtApellido.Enabled = habilitar;
            cmbSexo.Enabled = habilitar;
            dtpFechaNacimiento.Enabled = habilitar;
            cmbTipoSangre.Enabled = habilitar;
            txtCelular.Enabled = habilitar;
            txtTelefonoExtra.Enabled = habilitar;
            txtCorreo.Enabled = habilitar;
            txtDireccion.Enabled = habilitar;
            chkActivo.Enabled = habilitar;
            chkCrearUsuario.Enabled = habilitar;

            // Los campos de usuario se habilitan según el checkbox
            bool usuarioHabilitado = habilitar && chkCrearUsuario.Checked;
            txtUsuario.Enabled = usuarioHabilitado;
            cmbRol.Enabled = usuarioHabilitado;
            txtClave.Enabled = usuarioHabilitado;
            chkUsuarioActivo.Enabled = usuarioHabilitado;

            btnGuardar.Enabled = habilitar;
            btnCancelar.Enabled = habilitar;
        }

        private void chkCrearUsuario_CheckedChanged(object sender, EventArgs e)
        {
            bool habilitar = chkCrearUsuario.Checked;

            // Solo habilitar si el panel de datos está habilitado
            bool datosHabilitados = txtNombre.Enabled;

            txtUsuario.Enabled = datosHabilitados && habilitar;
            cmbRol.Enabled = datosHabilitados && habilitar;
            txtClave.Enabled = datosHabilitados && habilitar;
            chkUsuarioActivo.Enabled = datosHabilitados && habilitar;

            if (!habilitar)
            {
                txtUsuario.Clear();
                cmbRol.SelectedIndex = -1;
                txtClave.Clear();
                chkUsuarioActivo.Checked = true;
            }
        }

        private bool ValidarCampos()
        {
            // Validar cédula
            if (string.IsNullOrWhiteSpace(txtCedula.Text))
            {
                MessageBox.Show("La cédula es obligatoria.");
                txtCedula.Focus();
                return false;
            }

            if (txtCedula.Text.Length < 11)
            {
                MessageBox.Show("La cédula debe tener 11 dígitos.");
                txtCedula.Focus();
                return false;
            }

            // Validar nombre
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio.");
                txtNombre.Focus();
                return false;
            }

            // Validar apellido
            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("El apellido es obligatorio.");
                txtApellido.Focus();
                return false;
            }

            // Validar sexo
            if (cmbSexo.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione el sexo.");
                cmbSexo.Focus();
                return false;
            }

            // Validar celular
            if (string.IsNullOrWhiteSpace(txtCelular.Text))
            {
                MessageBox.Show("El celular es obligatorio.");
                txtCelular.Focus();
                return false;
            }

            if (txtCelular.Text.Length < 10)
            {
                MessageBox.Show("El celular debe tener 10 dígitos.");
                txtCelular.Focus();
                return false;
            }

            // Validar correo
            if (string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show("El correo es obligatorio.");
                txtCorreo.Focus();
                return false;
            }

            if (!txtCorreo.Text.Contains("@") || !txtCorreo.Text.Contains("."))
            {
                MessageBox.Show("Ingrese un correo electrónico válido.");
                txtCorreo.Focus();
                return false;
            }

            // Validar dirección
            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("La dirección es obligatoria.");
                txtDireccion.Focus();
                return false;
            }

            // Validar usuario si se está creando
            if (chkCrearUsuario.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtUsuario.Text))
                {
                    MessageBox.Show("El usuario es obligatorio.");
                    txtUsuario.Focus();
                    return false;
                }

                if (txtUsuario.Text.Length < 3)
                {
                    MessageBox.Show("El usuario debe tener al menos 3 caracteres.");
                    txtUsuario.Focus();
                    return false;
                }

                if (cmbRol.SelectedIndex < 0)
                {
                    MessageBox.Show("Seleccione un rol para el usuario.");
                    cmbRol.Focus();
                    return false;
                }

                if (string.IsNullOrWhiteSpace(txtClave.Text))
                {
                    MessageBox.Show("La contraseña es obligatoria.");
                    txtClave.Focus();
                    return false;
                }

                if (txtClave.Text.Length < 4)
                {
                    MessageBox.Show("La contraseña debe tener al menos 4 caracteres.");
                    txtClave.Focus();
                    return false;
                }
            }

            return true;
        }
    }
}