using System.Drawing;
using System.Windows.Forms;

namespace WalkiriaPapeleria.Forms
{
    partial class frmMenuPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        private Panel panelMenu;
        private Panel panelSuperior;
        private Panel panelContenido;

        private Label lblLogo;
        private Label lblTitulo;
        private Label lblMenuTitulo;
        private Label lblAdminTitulo;

        private Label lblUsuarioTitulo;
        private Label lblUsuario;
        private Label lblRolTitulo;
        private Label lblRol;
        private Label lblTurnoTitulo;
        private Label lblTurno;

        private Label lblBienvenida;
        private Label lblSubtitulo;
        private Label lblDescripcion;

        private Button btnClientes;
        private Button btnProductos;
        private Button btnServicios;
        private Button btnVentas;
        private Button btnHistorial;
        private Button btnEmpleados;
        private Button btnCierreCaja;
        private Button btnReiniciarSistema;

        private Button btnCerrarSesion;
        private Button btnSalir;

        private Panel cardVentas;
        private Panel cardInventario;
        private Panel cardClientes;

        private Label lblCardVentasTitulo;
        private Label lblCardVentasTexto;

        private Label lblCardInventarioTitulo;
        private Label lblCardInventarioTexto;

        private Label lblCardClientesTitulo;
        private Label lblCardClientesTexto;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblMenuTitulo = new System.Windows.Forms.Label();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnServicios = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.lblAdminTitulo = new System.Windows.Forms.Label();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnCierreCaja = new System.Windows.Forms.Button();
            this.btnReiniciarSistema = new System.Windows.Forms.Button();

            this.panelSuperior = new System.Windows.Forms.Panel();
            this.lblUsuarioTitulo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblRolTitulo = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblTurnoTitulo = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();

            this.panelContenido = new System.Windows.Forms.Panel();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();

            this.cardVentas = new System.Windows.Forms.Panel();
            this.lblCardVentasTitulo = new System.Windows.Forms.Label();
            this.lblCardVentasTexto = new System.Windows.Forms.Label();

            this.cardInventario = new System.Windows.Forms.Panel();
            this.lblCardInventarioTitulo = new System.Windows.Forms.Label();
            this.lblCardInventarioTexto = new System.Windows.Forms.Label();

            this.cardClientes = new System.Windows.Forms.Panel();
            this.lblCardClientesTitulo = new System.Windows.Forms.Label();
            this.lblCardClientesTexto = new System.Windows.Forms.Label();

            this.panelMenu.SuspendLayout();
            this.panelSuperior.SuspendLayout();
            this.panelContenido.SuspendLayout();
            this.cardVentas.SuspendLayout();
            this.cardInventario.SuspendLayout();
            this.cardClientes.SuspendLayout();
            this.SuspendLayout();

            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(15, 38, 71);
            this.panelMenu.Controls.Add(this.lblLogo);
            this.panelMenu.Controls.Add(this.lblTitulo);
            this.panelMenu.Controls.Add(this.lblMenuTitulo);
            this.panelMenu.Controls.Add(this.btnVentas);
            this.panelMenu.Controls.Add(this.btnClientes);
            this.panelMenu.Controls.Add(this.btnProductos);
            this.panelMenu.Controls.Add(this.btnServicios);
            this.panelMenu.Controls.Add(this.btnHistorial);
            this.panelMenu.Controls.Add(this.lblAdminTitulo);
            this.panelMenu.Controls.Add(this.btnEmpleados);
            this.panelMenu.Controls.Add(this.btnCierreCaja);
            this.panelMenu.Controls.Add(this.btnReiniciarSistema);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(260, 720);
            this.panelMenu.TabIndex = 0;

            // 
            // lblLogo
            // 
            this.lblLogo.BackColor = System.Drawing.Color.FromArgb(25, 125, 160);
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(20, 20);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(62, 58);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "IP";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(92, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(150, 55);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "ISRAEL\r\nPAPELERÍA";

            // 
            // lblMenuTitulo
            // 
            this.lblMenuTitulo.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblMenuTitulo.ForeColor = System.Drawing.Color.FromArgb(130, 160, 190);
            this.lblMenuTitulo.Location = new System.Drawing.Point(25, 115);
            this.lblMenuTitulo.Name = "lblMenuTitulo";
            this.lblMenuTitulo.Size = new System.Drawing.Size(210, 20);
            this.lblMenuTitulo.TabIndex = 2;
            this.lblMenuTitulo.Text = "MENÚ PRINCIPAL";

            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.Color.FromArgb(15, 38, 71);
            this.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(25, 65, 100);
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnVentas.ForeColor = System.Drawing.Color.White;
            this.btnVentas.Location = new System.Drawing.Point(10, 145);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnVentas.Size = new System.Drawing.Size(240, 48);
            this.btnVentas.TabIndex = 3;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);

            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.FromArgb(15, 38, 71);
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(25, 65, 100);
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.Location = new System.Drawing.Point(10, 193);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnClientes.Size = new System.Drawing.Size(240, 48);
            this.btnClientes.TabIndex = 4;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);

            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.FromArgb(15, 38, 71);
            this.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(25, 65, 100);
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnProductos.ForeColor = System.Drawing.Color.White;
            this.btnProductos.Location = new System.Drawing.Point(10, 241);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnProductos.Size = new System.Drawing.Size(240, 48);
            this.btnProductos.TabIndex = 5;
            this.btnProductos.Text = "Productos";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);

            // 
            // btnServicios
            // 
            this.btnServicios.BackColor = System.Drawing.Color.FromArgb(15, 38, 71);
            this.btnServicios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnServicios.FlatAppearance.BorderSize = 0;
            this.btnServicios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(25, 65, 100);
            this.btnServicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServicios.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnServicios.ForeColor = System.Drawing.Color.White;
            this.btnServicios.Location = new System.Drawing.Point(10, 289);
            this.btnServicios.Name = "btnServicios";
            this.btnServicios.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnServicios.Size = new System.Drawing.Size(240, 48);
            this.btnServicios.TabIndex = 6;
            this.btnServicios.Text = "Servicios";
            this.btnServicios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServicios.UseVisualStyleBackColor = false;
            this.btnServicios.Click += new System.EventHandler(this.btnServicios_Click);

            // 
            // btnHistorial
            // 
            this.btnHistorial.BackColor = System.Drawing.Color.FromArgb(15, 38, 71);
            this.btnHistorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistorial.FlatAppearance.BorderSize = 0;
            this.btnHistorial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(25, 65, 100);
            this.btnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorial.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnHistorial.ForeColor = System.Drawing.Color.White;
            this.btnHistorial.Location = new System.Drawing.Point(10, 337);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnHistorial.Size = new System.Drawing.Size(240, 48);
            this.btnHistorial.TabIndex = 7;
            this.btnHistorial.Text = "Historial de Facturas";
            this.btnHistorial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorial.UseVisualStyleBackColor = false;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);

            // 
            // lblAdminTitulo
            // 
            this.lblAdminTitulo.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblAdminTitulo.ForeColor = System.Drawing.Color.FromArgb(130, 160, 190);
            this.lblAdminTitulo.Location = new System.Drawing.Point(25, 410);
            this.lblAdminTitulo.Name = "lblAdminTitulo";
            this.lblAdminTitulo.Size = new System.Drawing.Size(210, 20);
            this.lblAdminTitulo.TabIndex = 8;
            this.lblAdminTitulo.Text = "ADMINISTRACIÓN";

            // 
            // btnEmpleados
            // 
            this.btnEmpleados.BackColor = System.Drawing.Color.FromArgb(15, 38, 71);
            this.btnEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(25, 65, 100);
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnEmpleados.ForeColor = System.Drawing.Color.White;
            this.btnEmpleados.Location = new System.Drawing.Point(10, 440);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnEmpleados.Size = new System.Drawing.Size(240, 48);
            this.btnEmpleados.TabIndex = 9;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.UseVisualStyleBackColor = false;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);

            // 
            // btnCierreCaja
            // 
            this.btnCierreCaja.BackColor = System.Drawing.Color.FromArgb(15, 38, 71);
            this.btnCierreCaja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCierreCaja.FlatAppearance.BorderSize = 0;
            this.btnCierreCaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(25, 65, 100);
            this.btnCierreCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCierreCaja.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnCierreCaja.ForeColor = System.Drawing.Color.White;
            this.btnCierreCaja.Location = new System.Drawing.Point(10, 488);
            this.btnCierreCaja.Name = "btnCierreCaja";
            this.btnCierreCaja.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnCierreCaja.Size = new System.Drawing.Size(240, 48);
            this.btnCierreCaja.TabIndex = 10;
            this.btnCierreCaja.Text = "Cierre de Caja";
            this.btnCierreCaja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCierreCaja.UseVisualStyleBackColor = false;
            this.btnCierreCaja.Click += new System.EventHandler(this.btnCierreCaja_Click);

            // 
            // btnReiniciarSistema
            // 
            this.btnReiniciarSistema.BackColor = System.Drawing.Color.FromArgb(150, 45, 45);
            this.btnReiniciarSistema.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReiniciarSistema.FlatAppearance.BorderSize = 0;
            this.btnReiniciarSistema.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(180, 55, 55);
            this.btnReiniciarSistema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReiniciarSistema.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnReiniciarSistema.ForeColor = System.Drawing.Color.White;
            this.btnReiniciarSistema.Location = new System.Drawing.Point(20, 570);
            this.btnReiniciarSistema.Name = "btnReiniciarSistema";
            this.btnReiniciarSistema.Size = new System.Drawing.Size(220, 43);
            this.btnReiniciarSistema.TabIndex = 11;
            this.btnReiniciarSistema.Text = "Reiniciar Sistema";
            this.btnReiniciarSistema.UseVisualStyleBackColor = false;
            this.btnReiniciarSistema.Click += new System.EventHandler(this.btnReiniciarSistema_Click);

            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.White;
            this.panelSuperior.Controls.Add(this.lblUsuarioTitulo);
            this.panelSuperior.Controls.Add(this.lblUsuario);
            this.panelSuperior.Controls.Add(this.lblRolTitulo);
            this.panelSuperior.Controls.Add(this.lblRol);
            this.panelSuperior.Controls.Add(this.lblTurnoTitulo);
            this.panelSuperior.Controls.Add(this.lblTurno);
            this.panelSuperior.Controls.Add(this.btnCerrarSesion);
            this.panelSuperior.Controls.Add(this.btnSalir);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(260, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1020, 82);
            this.panelSuperior.TabIndex = 1;

            // 
            // lblUsuarioTitulo
            // 
            this.lblUsuarioTitulo.AutoSize = true;
            this.lblUsuarioTitulo.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblUsuarioTitulo.ForeColor = System.Drawing.Color.Gray;
            this.lblUsuarioTitulo.Location = new System.Drawing.Point(30, 17);
            this.lblUsuarioTitulo.Name = "lblUsuarioTitulo";
            this.lblUsuarioTitulo.Size = new System.Drawing.Size(58, 15);
            this.lblUsuarioTitulo.TabIndex = 0;
            this.lblUsuarioTitulo.Text = "USUARIO";

            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(30, 50, 70);
            this.lblUsuario.Location = new System.Drawing.Point(30, 40);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(112, 20);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Administrador";

            // 
            // lblRolTitulo
            // 
            this.lblRolTitulo.AutoSize = true;
            this.lblRolTitulo.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblRolTitulo.ForeColor = System.Drawing.Color.Gray;
            this.lblRolTitulo.Location = new System.Drawing.Point(270, 17);
            this.lblRolTitulo.Name = "lblRolTitulo";
            this.lblRolTitulo.Size = new System.Drawing.Size(28, 15);
            this.lblRolTitulo.TabIndex = 2;
            this.lblRolTitulo.Text = "ROL";

            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblRol.ForeColor = System.Drawing.Color.FromArgb(25, 125, 160);
            this.lblRol.Location = new System.Drawing.Point(270, 40);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(112, 20);
            this.lblRol.TabIndex = 3;
            this.lblRol.Text = "Administrador";

            // 
            // lblTurnoTitulo
            // 
            this.lblTurnoTitulo.AutoSize = true;
            this.lblTurnoTitulo.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblTurnoTitulo.ForeColor = System.Drawing.Color.Gray;
            this.lblTurnoTitulo.Location = new System.Drawing.Point(470, 17);
            this.lblTurnoTitulo.Name = "lblTurnoTitulo";
            this.lblTurnoTitulo.Size = new System.Drawing.Size(46, 15);
            this.lblTurnoTitulo.TabIndex = 4;
            this.lblTurnoTitulo.Text = "TURNO";

            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTurno.ForeColor = System.Drawing.Color.FromArgb(55, 65, 75);
            this.lblTurno.Location = new System.Drawing.Point(470, 40);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(72, 20);
            this.lblTurno.TabIndex = 5;
            this.lblTurno.Text = "Matutino";

            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(238, 241, 244);
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.FromArgb(65, 75, 85);
            this.btnCerrarSesion.Location = new System.Drawing.Point(775, 22);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(135, 38);
            this.btnCerrarSesion.TabIndex = 6;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);

            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(190, 55, 55);
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(920, 22);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 38);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);

            // 
            // panelContenido
            // 
            this.panelContenido.BackColor = System.Drawing.Color.FromArgb(243, 246, 249);
            this.panelContenido.Controls.Add(this.lblBienvenida);
            this.panelContenido.Controls.Add(this.lblSubtitulo);
            this.panelContenido.Controls.Add(this.lblDescripcion);
            this.panelContenido.Controls.Add(this.cardVentas);
            this.panelContenido.Controls.Add(this.cardInventario);
            this.panelContenido.Controls.Add(this.cardClientes);
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(260, 82);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(1020, 638);
            this.panelContenido.TabIndex = 2;

            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblBienvenida.ForeColor = System.Drawing.Color.FromArgb(25, 45, 70);
            this.lblBienvenida.Location = new System.Drawing.Point(45, 45);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(230, 51);
            this.lblBienvenida.TabIndex = 0;
            this.lblBienvenida.Text = "Bienvenido";

            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(25, 125, 160);
            this.lblSubtitulo.Location = new System.Drawing.Point(50, 105);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(345, 28);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Panel administrativo de Israel Papelería";

            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(110, 120, 130);
            this.lblDescripcion.Location = new System.Drawing.Point(52, 145);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(322, 19);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Selecciona una opción del menú para comenzar.";

            // 
            // cardVentas
            // 
            this.cardVentas.BackColor = System.Drawing.Color.White;
            this.cardVentas.Controls.Add(this.lblCardVentasTitulo);
            this.cardVentas.Controls.Add(this.lblCardVentasTexto);
            this.cardVentas.Location = new System.Drawing.Point(50, 220);
            this.cardVentas.Name = "cardVentas";
            this.cardVentas.Size = new System.Drawing.Size(270, 145);
            this.cardVentas.TabIndex = 3;

            // 
            // lblCardVentasTitulo
            // 
            this.lblCardVentasTitulo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblCardVentasTitulo.ForeColor = System.Drawing.Color.FromArgb(25, 125, 160);
            this.lblCardVentasTitulo.Location = new System.Drawing.Point(20, 25);
            this.lblCardVentasTitulo.Name = "lblCardVentasTitulo";
            this.lblCardVentasTitulo.Size = new System.Drawing.Size(220, 35);
            this.lblCardVentasTitulo.TabIndex = 0;
            this.lblCardVentasTitulo.Text = "VENTAS";

            // 
            // lblCardVentasTexto
            // 
            this.lblCardVentasTexto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCardVentasTexto.ForeColor = System.Drawing.Color.FromArgb(100, 110, 120);
            this.lblCardVentasTexto.Location = new System.Drawing.Point(20, 70);
            this.lblCardVentasTexto.Name = "lblCardVentasTexto";
            this.lblCardVentasTexto.Size = new System.Drawing.Size(220, 50);
            this.lblCardVentasTexto.TabIndex = 1;
            this.lblCardVentasTexto.Text = "Registra facturas, productos y servicios.";

            // 
            // cardInventario
            // 
            this.cardInventario.BackColor = System.Drawing.Color.White;
            this.cardInventario.Controls.Add(this.lblCardInventarioTitulo);
            this.cardInventario.Controls.Add(this.lblCardInventarioTexto);
            this.cardInventario.Location = new System.Drawing.Point(350, 220);
            this.cardInventario.Name = "cardInventario";
            this.cardInventario.Size = new System.Drawing.Size(270, 145);
            this.cardInventario.TabIndex = 4;

            // 
            // lblCardInventarioTitulo
            // 
            this.lblCardInventarioTitulo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblCardInventarioTitulo.ForeColor = System.Drawing.Color.FromArgb(25, 125, 160);
            this.lblCardInventarioTitulo.Location = new System.Drawing.Point(20, 25);
            this.lblCardInventarioTitulo.Name = "lblCardInventarioTitulo";
            this.lblCardInventarioTitulo.Size = new System.Drawing.Size(220, 35);
            this.lblCardInventarioTitulo.TabIndex = 0;
            this.lblCardInventarioTitulo.Text = "INVENTARIO";

            // 
            // lblCardInventarioTexto
            // 
            this.lblCardInventarioTexto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCardInventarioTexto.ForeColor = System.Drawing.Color.FromArgb(100, 110, 120);
            this.lblCardInventarioTexto.Location = new System.Drawing.Point(20, 70);
            this.lblCardInventarioTexto.Name = "lblCardInventarioTexto";
            this.lblCardInventarioTexto.Size = new System.Drawing.Size(220, 50);
            this.lblCardInventarioTexto.TabIndex = 1;
            this.lblCardInventarioTexto.Text = "Administra productos, stock y servicios.";

            // 
            // cardClientes
            // 
            this.cardClientes.BackColor = System.Drawing.Color.White;
            this.cardClientes.Controls.Add(this.lblCardClientesTitulo);
            this.cardClientes.Controls.Add(this.lblCardClientesTexto);
            this.cardClientes.Location = new System.Drawing.Point(650, 220);
            this.cardClientes.Name = "cardClientes";
            this.cardClientes.Size = new System.Drawing.Size(270, 145);
            this.cardClientes.TabIndex = 5;

            // 
            // lblCardClientesTitulo
            // 
            this.lblCardClientesTitulo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblCardClientesTitulo.ForeColor = System.Drawing.Color.FromArgb(25, 125, 160);
            this.lblCardClientesTitulo.Location = new System.Drawing.Point(20, 25);
            this.lblCardClientesTitulo.Name = "lblCardClientesTitulo";
            this.lblCardClientesTitulo.Size = new System.Drawing.Size(220, 35);
            this.lblCardClientesTitulo.TabIndex = 0;
            this.lblCardClientesTitulo.Text = "CLIENTES";

            // 
            // lblCardClientesTexto
            // 
            this.lblCardClientesTexto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCardClientesTexto.ForeColor = System.Drawing.Color.FromArgb(100, 110, 120);
            this.lblCardClientesTexto.Location = new System.Drawing.Point(20, 70);
            this.lblCardClientesTexto.Name = "lblCardClientesTexto";
            this.lblCardClientesTexto.Size = new System.Drawing.Size(220, 50);
            this.lblCardClientesTexto.TabIndex = 1;
            this.lblCardClientesTexto.Text = "Consulta y administra los clientes registrados.";

            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(243, 246, 249);
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1100, 650);
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Israel Papelería | Sistema Administrativo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);

            this.panelMenu.ResumeLayout(false);
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.cardVentas.ResumeLayout(false);
            this.cardInventario.ResumeLayout(false);
            this.cardClientes.ResumeLayout(false);
            this.panelContenido.ResumeLayout(false);
            this.panelContenido.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}