using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WalkiriaPapeleria.DAO;
using WalkiriaPapeleria.Helpers;

namespace WalkiriaPapeleria.Forms
{
    public partial class frmReinicioSistema : Form
    {
        private ReinicioDAO reinicioDAO;

        public frmReinicioSistema()
        {
            InitializeComponent();
            reinicioDAO = new ReinicioDAO();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void frmReinicioSistema_Load(object sender, EventArgs e)
        {
            txtAdvertencia.Text =
                "⚠️ ADVERTENCIA ⚠️\n\n" +
                "Esta acción ELIMINARÁ PERMANENTEMENTE los siguientes datos:\n\n" +
                "• Todas las facturas y sus detalles\n" +
                "• Todos los clientes creados\n" +
                "• Todos los empleados (excepto el administrador)\n" +
                "• Todos los usuarios (excepto el administrador)\n" +
                "• Todos los productos agregados\n" +
                "• Todos los servicios agregados\n" +
                "• Todas las asignaciones de turno\n" +
                "• Todos los cierres de caja\n\n" +
                "Los contadores (ID) se reiniciarán a 1.\n\n" +
                "🔴 Esta acción NO SE PUEDE DESHACER.";

            if (!reinicioDAO.HayDatosParaReiniciar())
            {
                btnReiniciar.Enabled = false;
                lblEstado.Text = "✅ El sistema ya está en su estado original.";
                lblEstado.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                btnReiniciar.Enabled = true;
                lblEstado.Text = "🔴 Hay datos que pueden ser eliminados.";
                lblEstado.ForeColor = System.Drawing.Color.FromArgb(192, 57, 43);
            }

            if (SessionManager.IsLoggedIn)
            {
                lblUsuario.Text = "👤 Usuario: " + SessionManager.UsuarioActual.NombreCompleto;
                lblRol.Text = "🎭 Rol: " + SessionManager.UsuarioActual.RolNombre;
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtConfirmacion.Text))
                {
                    MessageBox.Show("Ingrese su contraseña para confirmar.",
                        "Confirmación requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtConfirmacion.Focus();
                    return;
                }

                if (!SessionManager.IsAdmin)
                {
                    MessageBox.Show("Solo los Administradores pueden realizar esta acción.",
                        "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Obtener la contraseña del usuario desde la base de datos
                string claveBD = ObtenerClaveUsuario(SessionManager.UsuarioActual.ID_Usuario);

                if (string.IsNullOrEmpty(claveBD))
                {
                    MessageBox.Show("No se pudo obtener la contraseña del usuario.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validar contraseña
                if (txtConfirmacion.Text != claveBD)
                {
                    MessageBox.Show("Contraseña incorrecta.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtConfirmacion.Clear();
                    txtConfirmacion.Focus();
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "⚠️ ¿ESTÁ SEGURO DE REINICIAR EL SISTEMA?\n\n" +
                    "Se perderán TODOS los datos de prueba.\n" +
                    "Esta acción NO SE PUEDE DESHACER.",
                    "Confirmación final",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result != DialogResult.Yes)
                    return;

                btnReiniciar.Enabled = false;
                btnReiniciar.Text = "Reiniciando...";
                this.Cursor = Cursors.WaitCursor;

                if (reinicioDAO.ReiniciarSistema())
                {
                    MessageBox.Show(
                        "✅ Sistema reiniciado correctamente.\n\n" +
                        "• Todas las facturas fueron eliminadas\n" +
                        "• Todos los datos de prueba fueron eliminados\n" +
                        "• Los contadores fueron reiniciados\n\n" +
                        "El sistema está en su estado original.",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    DialogResult cerrarSesion = MessageBox.Show(
                        "¿Desea cerrar sesión para reiniciar la aplicación?",
                        "Reinicio completado",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (cerrarSesion == DialogResult.Yes)
                    {
                        SessionManager.Logout();
                        this.Close();
                        Application.Restart();
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Error al reiniciar sistema: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnReiniciar.Enabled = true;
                btnReiniciar.Text = "🔴 Reiniciar Sistema";
                this.Cursor = Cursors.Default;
            }
        }

        // ============================================================
        // OBTENER CONTRASEÑA DEL USUARIO DESDE LA BASE DE DATOS
        // ============================================================
        private string ObtenerClaveUsuario(int idUsuario)
        {
            try
            {
                string query = "SELECT Clave FROM T_Usuarios WHERE ID_Usuario = @IDUsuario";
                System.Data.SqlClient.SqlParameter[] parameters = new System.Data.SqlClient.SqlParameter[]
                {
                    new System.Data.SqlClient.SqlParameter("@IDUsuario", idUsuario)
                };

                System.Data.DataTable result = DatabaseConnection.ExecuteQuery(query, parameters);

                if (result.Rows.Count > 0)
                {
                    return result.Rows[0]["Clave"].ToString();
                }
                return null;
            }
            catch
            {
                return null;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}