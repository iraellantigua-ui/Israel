using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WalkiriaPapeleria.Forms
{
    partial class frmMenuPrincipal
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panelSuperior;
        private Label lblTitulo;
        private Label lblUsuario;
        private Label lblRol;
        private Button btnCerrarSesion;
        private Button btnSalir;
        private Panel panelMenu;
        private Button btnClientes;
        private Button btnProductos;
        private Button btnServicios;
        private Button btnVentas;
        private Button btnHistorial;
        private Button btnEmpleados;
        private Button btnCierreCaja;
        private Button btnReiniciarSistema;
        private Panel panelContenido;
        private Label lblBienvenida;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelSuperior = new Panel();
            this.lblTitulo = new Label();
            this.lblUsuario = new Label();
            this.lblRol = new Label();
            this.btnCerrarSesion = new Button();
            this.btnSalir = new Button();
            this.panelMenu = new Panel();
            this.btnClientes = new Button();
            this.btnProductos = new Button();
            this.btnServicios = new Button();
            this.btnVentas = new Button();
            this.btnHistorial = new Button();
            this.btnEmpleados = new Button();
            this.btnCierreCaja = new Button();
            this.btnReiniciarSistema = new Button();
            this.panelContenido = new Panel();
            this.lblBienvenida = new Label();
            this.panelSuperior.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelContenido.SuspendLayout();
            this.SuspendLayout();

            // panelSuperior
            this.panelSuperior.BackColor = Color.FromArgb(44, 62, 80);
            this.panelSuperior.Controls.Add(this.lblTitulo);
            this.panelSuperior.Controls.Add(this.lblUsuario);
            this.panelSuperior.Controls.Add(this.lblRol);
            this.panelSuperior.Controls.Add(this.btnCerrarSesion);
            this.panelSuperior.Controls.Add(this.btnSalir);
            this.panelSuperior.Dock = DockStyle.Top;
            this.panelSuperior.Location = new Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new Size(1000, 110);
            this.panelSuperior.TabIndex = 0;
            this.panelSuperior.Paint += new PaintEventHandler(this.panelSuperior_Paint);

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            this.lblTitulo.ForeColor = Color.White;
            this.lblTitulo.Location = new Point(30, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new Size(373, 45);
            this.lblTitulo.Text = "WALKIRIA PAPELERIA";

            // lblUsuario
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new Font("Segoe UI", 11F);
            this.lblUsuario.ForeColor = Color.FromArgb(189, 195, 199);
            this.lblUsuario.Location = new Point(30, 65);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new Size(120, 20);
            this.lblUsuario.Text = "Usuario: Admin";

            // lblRol
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblRol.ForeColor = Color.FromArgb(46, 204, 113);
            this.lblRol.Location = new Point(30, 85);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new Size(95, 20);
            this.lblRol.Text = "Rol: Admin";

            // btnCerrarSesion
            this.btnCerrarSesion.BackColor = Color.FromArgb(231, 76, 60);
            this.btnCerrarSesion.FlatAppearance.BorderColor = Color.FromArgb(192, 57, 43);
            this.btnCerrarSesion.FlatAppearance.BorderSize = 2;
            this.btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            this.btnCerrarSesion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnCerrarSesion.ForeColor = Color.White;
            this.btnCerrarSesion.Location = new Point(770, 60);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new Size(130, 35);
            this.btnCerrarSesion.Text = "Cerrar Sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);

            // btnSalir
            this.btnSalir.BackColor = Color.FromArgb(192, 57, 43);
            this.btnSalir.FlatAppearance.BorderColor = Color.FromArgb(160, 40, 30);
            this.btnSalir.FlatAppearance.BorderSize = 2;
            this.btnSalir.FlatStyle = FlatStyle.Flat;
            this.btnSalir.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnSalir.ForeColor = Color.White;
            this.btnSalir.Location = new Point(910, 60);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new Size(70, 35);
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);

            // panelMenu
            this.panelMenu.BackColor = Color.FromArgb(44, 62, 80);
            this.panelMenu.Controls.Add(this.btnClientes);
            this.panelMenu.Controls.Add(this.btnProductos);
            this.panelMenu.Controls.Add(this.btnServicios);
            this.panelMenu.Controls.Add(this.btnVentas);
            this.panelMenu.Controls.Add(this.btnHistorial);
            this.panelMenu.Controls.Add(this.btnEmpleados);
            this.panelMenu.Controls.Add(this.btnCierreCaja);
            this.panelMenu.Controls.Add(this.btnReiniciarSistema);
            this.panelMenu.Dock = DockStyle.Left;
            this.panelMenu.Location = new Point(0, 110);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new Size(220, 490);
            this.panelMenu.TabIndex = 1;
            this.panelMenu.Paint += new PaintEventHandler(this.panelMenu_Paint);

            // btnClientes
            this.btnClientes.BackColor = Color.FromArgb(52, 73, 94);
            this.btnClientes.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = FlatStyle.Flat;
            this.btnClientes.Font = new Font("Segoe UI", 11F);
            this.btnClientes.ForeColor = Color.White;
            this.btnClientes.Location = new Point(0, 20);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new Size(220, 45);
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = ContentAlignment.MiddleLeft;
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);

            // btnProductos
            this.btnProductos.BackColor = Color.FromArgb(52, 73, 94);
            this.btnProductos.FlatAppearance.BorderColor = Color.FromArgb(41, 128, 185);
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatStyle = FlatStyle.Flat;
            this.btnProductos.Font = new Font("Segoe UI", 11F);
            this.btnProductos.ForeColor = Color.White;
            this.btnProductos.Location = new Point(0, 65);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new Size(220, 45);
            this.btnProductos.Text = "Productos";
            this.btnProductos.TextAlign = ContentAlignment.MiddleLeft;
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);

            // btnServicios
            this.btnServicios.BackColor = Color.FromArgb(52, 73, 94);
            this.btnServicios.FlatAppearance.BorderColor = Color.FromArgb(39, 174, 96);
            this.btnServicios.FlatAppearance.BorderSize = 0;
            this.btnServicios.FlatStyle = FlatStyle.Flat;
            this.btnServicios.Font = new Font("Segoe UI", 11F);
            this.btnServicios.ForeColor = Color.White;
            this.btnServicios.Location = new Point(0, 110);
            this.btnServicios.Name = "btnServicios";
            this.btnServicios.Size = new Size(220, 45);
            this.btnServicios.Text = "Servicios";
            this.btnServicios.TextAlign = ContentAlignment.MiddleLeft;
            this.btnServicios.UseVisualStyleBackColor = false;
            this.btnServicios.Click += new System.EventHandler(this.btnServicios_Click);

            // btnVentas
            this.btnVentas.BackColor = Color.FromArgb(52, 73, 94);
            this.btnVentas.FlatAppearance.BorderColor = Color.FromArgb(211, 84, 0);
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatStyle = FlatStyle.Flat;
            this.btnVentas.Font = new Font("Segoe UI", 11F);
            this.btnVentas.ForeColor = Color.White;
            this.btnVentas.Location = new Point(0, 155);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new Size(220, 45);
            this.btnVentas.Text = "Ventas";
            this.btnVentas.TextAlign = ContentAlignment.MiddleLeft;
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);

            // btnHistorial
            this.btnHistorial.BackColor = Color.FromArgb(52, 73, 94);
            this.btnHistorial.FlatAppearance.BorderColor = Color.FromArgb(192, 57, 43);
            this.btnHistorial.FlatAppearance.BorderSize = 0;
            this.btnHistorial.FlatStyle = FlatStyle.Flat;
            this.btnHistorial.Font = new Font("Segoe UI", 11F);
            this.btnHistorial.ForeColor = Color.White;
            this.btnHistorial.Location = new Point(0, 200);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new Size(220, 45);
            this.btnHistorial.Text = "Historial";
            this.btnHistorial.TextAlign = ContentAlignment.MiddleLeft;
            this.btnHistorial.UseVisualStyleBackColor = false;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);

            // btnEmpleados
            this.btnEmpleados.BackColor = Color.FromArgb(52, 73, 94);
            this.btnEmpleados.FlatAppearance.BorderColor = Color.FromArgb(22, 160, 133);
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.FlatStyle = FlatStyle.Flat;
            this.btnEmpleados.Font = new Font("Segoe UI", 11F);
            this.btnEmpleados.ForeColor = Color.White;
            this.btnEmpleados.Location = new Point(0, 245);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new Size(220, 45);
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.TextAlign = ContentAlignment.MiddleLeft;
            this.btnEmpleados.UseVisualStyleBackColor = false;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);

            // btnCierreCaja
            this.btnCierreCaja.BackColor = Color.FromArgb(52, 73, 94);
            this.btnCierreCaja.FlatAppearance.BorderColor = Color.FromArgb(241, 196, 15);
            this.btnCierreCaja.FlatAppearance.BorderSize = 0;
            this.btnCierreCaja.FlatStyle = FlatStyle.Flat;
            this.btnCierreCaja.Font = new Font("Segoe UI", 11F);
            this.btnCierreCaja.ForeColor = Color.White;
            this.btnCierreCaja.Location = new Point(0, 290);
            this.btnCierreCaja.Name = "btnCierreCaja";
            this.btnCierreCaja.Size = new Size(220, 45);
            this.btnCierreCaja.Text = "Cierre de Caja";
            this.btnCierreCaja.TextAlign = ContentAlignment.MiddleLeft;
            this.btnCierreCaja.UseVisualStyleBackColor = false;
            this.btnCierreCaja.Click += new System.EventHandler(this.btnCierreCaja_Click);

            // btnReiniciarSistema
            this.btnReiniciarSistema.BackColor = Color.FromArgb(192, 57, 43);
            this.btnReiniciarSistema.FlatAppearance.BorderColor = Color.FromArgb(160, 40, 30);
            this.btnReiniciarSistema.FlatAppearance.BorderSize = 0;
            this.btnReiniciarSistema.FlatAppearance.MouseDownBackColor = Color.FromArgb(140, 30, 20);
            this.btnReiniciarSistema.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, 40, 30);
            this.btnReiniciarSistema.FlatStyle = FlatStyle.Flat;
            this.btnReiniciarSistema.Font = new Font("Segoe UI", 11F);
            this.btnReiniciarSistema.ForeColor = Color.White;
            this.btnReiniciarSistema.Location = new Point(0, 335);
            this.btnReiniciarSistema.Name = "btnReiniciarSistema";
            this.btnReiniciarSistema.Size = new Size(220, 45);
            this.btnReiniciarSistema.Text = "🔄 Reiniciar Sistema";
            this.btnReiniciarSistema.TextAlign = ContentAlignment.MiddleLeft;
            this.btnReiniciarSistema.UseVisualStyleBackColor = false;
            this.btnReiniciarSistema.Visible = false;
            this.btnReiniciarSistema.Click += new System.EventHandler(this.btnReiniciarSistema_Click);

            // panelContenido
            this.panelContenido.BackColor = Color.FromArgb(236, 240, 241);
            this.panelContenido.Controls.Add(this.lblBienvenida);
            this.panelContenido.Dock = DockStyle.Fill;
            this.panelContenido.Location = new Point(220, 110);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new Size(780, 490);
            this.panelContenido.TabIndex = 2;

            // lblBienvenida
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            this.lblBienvenida.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblBienvenida.Location = new Point(140, 180);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new Size(420, 51);
            this.lblBienvenida.Text = "Bienvenido al Sistema";

            // frmMenuPrincipal
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1000, 600);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelSuperior);
            this.Font = new Font("Segoe UI", 9F);
            this.Name = "frmMenuPrincipal";
            this.Text = "Walkiria Papeleria";
            this.WindowState = FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelContenido.ResumeLayout(false);
            this.panelContenido.PerformLayout();
            this.ResumeLayout(false);
        }

        private void panelSuperior_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(
                this.panelSuperior.ClientRectangle,
                Color.FromArgb(44, 62, 80),
                Color.FromArgb(52, 73, 94),
                LinearGradientMode.Horizontal))
            {
                e.Graphics.FillRectangle(brush, this.panelSuperior.ClientRectangle);
            }
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(
                this.panelMenu.ClientRectangle,
                Color.FromArgb(44, 62, 80),
                Color.FromArgb(52, 73, 94),
                LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, this.panelMenu.ClientRectangle);
            }
        }
    }
}