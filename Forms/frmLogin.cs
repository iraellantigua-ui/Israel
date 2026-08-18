using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using WalkiriaPapeleria.DAO;
using WalkiriaPapeleria.Helpers;
using WalkiriaPapeleria.Models;

namespace WalkiriaPapeleria.Forms
{
    public partial class frmLogin : Form
    {
        private UsuarioDAO usuarioDAO;

        public frmLogin()
        {
            InitializeComponent();
            usuarioDAO = new UsuarioDAO();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.AcceptButton = btnLogin;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            cmbTurno.Items.Clear();
            cmbTurno.Items.Add("Matutino");
            cmbTurno.Items.Add("Vespertino");
            cmbTurno.SelectedIndex = -1;

            if (DatabaseConnection.TestConnection())
            {
                Console.WriteLine("✅ Conexión exitosa.");
            }
            else
            {
                MessageBox.Show("❌ No se pudo conectar a la base de datos.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtUsuario.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                lblMensaje.Visible = false;

                string usuario = txtUsuario.Text.Trim();
                string clave = txtClave.Text;

                if (string.IsNullOrEmpty(usuario))
                {
                    MostrarError("⚠️ Ingrese el usuario.");
                    txtUsuario.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(clave))
                {
                    MostrarError("⚠️ Ingrese la contraseña.");
                    txtClave.Focus();
                    return;
                }

                if (cmbTurno.SelectedIndex < 0)
                {
                    MostrarError("⚠️ Seleccione un turno.");
                    cmbTurno.Focus();
                    return;
                }

                btnLogin.Enabled = false;
                btnLogin.Text = "Verificando...";

                Usuario user = usuarioDAO.Autenticar(usuario, clave);

                if (user != null)
                {
                    SessionManager.UsuarioActual = user;

                    string turnoSeleccionado = cmbTurno.SelectedItem.ToString();
                    SessionManager.TurnoActual = turnoSeleccionado;

                    // Registrar asignación de turno
                    bool turnoRegistrado = RegistrarAsignacionTurno(user.ID_Usuario, turnoSeleccionado);

                    if (!turnoRegistrado)
                    {
                        MessageBox.Show("⚠️ No se pudo registrar el turno. Verifique que el turno exista en la base de datos.",
                            "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    MessageBox.Show($"✅ ¡Bienvenido {user.NombreCompleto}!\n" +
                                   $"🕐 Turno: {turnoSeleccionado}",
                        "Acceso concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    frmMenuPrincipal menu = new frmMenuPrincipal();
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MostrarError("❌ Usuario o contraseña incorrectos.");
                    txtClave.Clear();
                    txtUsuario.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnLogin.Enabled = true;
                btnLogin.Text = "Iniciar Sesión";
            }
        }

        private bool RegistrarAsignacionTurno(int idUsuario, string turno)
        {
            try
            {
                // 1. Obtener ID del turno
                string queryTurno = "SELECT ID_Turno FROM T_Turno WHERE Nombre_Turno = @Turno";
                SqlParameter[] parametersTurno = new SqlParameter[]
                {
                    new SqlParameter("@Turno", turno)
                };

                DataTable result = DatabaseConnection.ExecuteQuery(queryTurno, parametersTurno);

                if (result.Rows.Count == 0)
                {
                    MessageBox.Show($"El turno '{turno}' no existe en la base de datos.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                int idTurno = Convert.ToInt32(result.Rows[0]["ID_Turno"]);

                // 2. Verificar si ya existe asignación para hoy
                string queryCheck = @"
                    SELECT COUNT(*) FROM T_Asignacion_Turno 
                    WHERE ID_Usuario = @IDUsuario 
                    AND CAST(Fecha_Asignacion AS DATE) = CAST(GETDATE() AS DATE)";

                SqlParameter[] parametersCheck = new SqlParameter[]
                {
                    new SqlParameter("@IDUsuario", idUsuario)
                };

                int count = Convert.ToInt32(DatabaseConnection.ExecuteScalar(queryCheck, parametersCheck));

                if (count > 0)
                {
                    // Actualizar turno existente
                    string queryUpdate = @"
                        UPDATE T_Asignacion_Turno 
                        SET ID_Turno = @IDTurno, Estado_Asignacion = 1, Fecha_Registro = GETDATE()
                        WHERE ID_Usuario = @IDUsuario 
                        AND CAST(Fecha_Asignacion AS DATE) = CAST(GETDATE() AS DATE)";

                    SqlParameter[] parametersUpdate = new SqlParameter[]
                    {
                        new SqlParameter("@IDUsuario", idUsuario),
                        new SqlParameter("@IDTurno", idTurno)
                    };

                    DatabaseConnection.ExecuteNonQuery(queryUpdate, parametersUpdate);
                    Console.WriteLine($"✅ Turno actualizado para usuario {idUsuario}");
                }
                else
                {
                    // Insertar nueva asignación
                    string queryInsert = @"
                        INSERT INTO T_Asignacion_Turno 
                        (ID_Usuario, ID_Turno, Fecha_Asignacion, Estado_Asignacion)
                        VALUES (@IDUsuario, @IDTurno, GETDATE(), 1)";

                    SqlParameter[] parametersInsert = new SqlParameter[]
                    {
                        new SqlParameter("@IDUsuario", idUsuario),
                        new SqlParameter("@IDTurno", idTurno)
                    };

                    DatabaseConnection.ExecuteNonQuery(queryInsert, parametersInsert);
                    Console.WriteLine($"✅ Nuevo turno registrado para usuario {idUsuario}");
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error al registrar turno: {ex.Message}");
                return false;
            }
        }

        private void MostrarError(string mensaje)
        {
            lblMensaje.Text = mensaje;
            lblMensaje.Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtClave.Focus();
            }
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}