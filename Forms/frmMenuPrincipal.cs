using System;
using System.Windows.Forms;
using WalkiriaPapeleria.Helpers;

namespace WalkiriaPapeleria.Forms
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            if (SessionManager.IsLoggedIn)
            {
                lblUsuario.Text = SessionManager.UsuarioActual.NombreCompleto;
                lblRol.Text = SessionManager.UsuarioActual.RolNombre;
                lblTurno.Text = SessionManager.TurnoActual ?? "No asignado";

                lblBienvenida.Text =
                    "Bienvenido, " + SessionManager.UsuarioActual.NombreEmpleado;
            }

            ConfigurarPermisos();
        }

        private void ConfigurarPermisos()
        {
            btnClientes.Visible = false;
            btnProductos.Visible = false;
            btnServicios.Visible = false;
            btnVentas.Visible = false;
            btnHistorial.Visible = false;
            btnEmpleados.Visible = false;
            btnCierreCaja.Visible = false;
            btnReiniciarSistema.Visible = false;

            if (SessionManager.IsAdmin)
            {
                btnClientes.Visible = true;
                btnProductos.Visible = true;
                btnServicios.Visible = true;
                btnVentas.Visible = true;
                btnHistorial.Visible = true;
                btnEmpleados.Visible = true;
                btnCierreCaja.Visible = true;
                btnReiniciarSistema.Visible = true;
            }
            else if (SessionManager.IsSupervisor)
            {
                btnClientes.Visible = true;
                btnProductos.Visible = true;
                btnServicios.Visible = true;
                btnVentas.Visible = true;
                btnHistorial.Visible = true;
                btnCierreCaja.Visible = true;
                btnEmpleados.Visible = false;
                btnReiniciarSistema.Visible = false;
            }
            else if (SessionManager.IsCajero)
            {
                btnClientes.Visible = true;
                btnVentas.Visible = true;
                btnHistorial.Visible = true;
                btnProductos.Visible = false;
                btnServicios.Visible = false;
                btnEmpleados.Visible = false;
                btnCierreCaja.Visible = false;
                btnReiniciarSistema.Visible = false;
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea cerrar sesión?",
                "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                SessionManager.Logout();
                this.Close();
                frmLogin login = new frmLogin();
                login.Show();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea salir del sistema?",
                "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmClientes clientes = new frmClientes();
            clientes.ShowDialog();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            frmProductos productos = new frmProductos();
            productos.ShowDialog();
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            frmServicios servicios = new frmServicios();
            servicios.ShowDialog();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            frmVentas ventas = new frmVentas();
            ventas.ShowDialog();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            frmHistorialFacturas historial = new frmHistorialFacturas();
            historial.ShowDialog();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            frmEmpleados empleados = new frmEmpleados();
            empleados.ShowDialog();
        }

        private void btnCierreCaja_Click(object sender, EventArgs e)
        {
            frmCierreCaja cierre = new frmCierreCaja();
            cierre.ShowDialog();
        }

        // ============================================================
        // BOTÓN REINICIAR SISTEMA
        // ============================================================
        private void btnReiniciarSistema_Click(object sender, EventArgs e)
        {
            if (!SessionManager.IsAdmin)
            {
                MessageBox.Show("Solo el Administrador puede realizar esta acción.",
                    "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmReinicioSistema reinicio = new frmReinicioSistema();
            reinicio.ShowDialog();
        }
    }
}