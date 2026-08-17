using System.Drawing;
using System.Windows.Forms;

namespace WalkiriaPapeleria.Forms
{
    partial class frmVentas
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panelSuperior;
        private Label lblTitulo;
        private Label lblUsuario;
        private Label lblRol;
        private Label lblTurno;
        private Panel panelDatosFactura;
        private Label lblNumeroFactura;
        private TextBox txtNumeroFactura;
        private Label lblFecha;
        private DateTimePicker dtpFecha;
        private Label lblCliente;
        private TextBox txtBuscarCliente;
        private Button btnBuscarCliente;
        private Button btnLimpiarCliente;
        private Label lblClienteSeleccionado;
        private Label lblMetodoPago;
        private ComboBox cmbMetodoPago;
        private Panel panelDetalle;
        private Label lblCategoria;
        private ComboBox cmbCategoria;
        private Label lblItem;
        private ComboBox cmbProductos;
        private ComboBox cmbServicios;
        private Label lblPrecio;
        private TextBox txtPrecio;
        private Label lblCantidad;
        private TextBox txtCantidad;
        private Label lblStock;
        private TextBox txtStock;
        private Button btnAgregarDetalle;
        private Button btnModificarDetalle;
        private DataGridView dgvDetalle;
        private Button btnEliminarDetalle;
        private Panel panelTotales;
        private Label lblSubtotalTexto;
        private Label lblSubtotal;
        private Label lblITBISTexto;
        private Label lblITBIS;
        private Label lblTotalTexto;
        private Label lblTotal;
        private Panel panelBotones;
        private Button btnGuardarVenta;
        private Button btnCancelarVenta;
        private Button btnImprimirUltima;
        private Button btnCerrar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.panelDatosFactura = new System.Windows.Forms.Panel();
            this.lblNumeroFactura = new System.Windows.Forms.Label();
            this.txtNumeroFactura = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.btnLimpiarCliente = new System.Windows.Forms.Button();
            this.lblClienteSeleccionado = new System.Windows.Forms.Label();
            this.lblMetodoPago = new System.Windows.Forms.Label();
            this.cmbMetodoPago = new System.Windows.Forms.ComboBox();
            this.panelDetalle = new System.Windows.Forms.Panel();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lblItem = new System.Windows.Forms.Label();
            this.cmbProductos = new System.Windows.Forms.ComboBox();
            this.cmbServicios = new System.Windows.Forms.ComboBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.btnAgregarDetalle = new System.Windows.Forms.Button();
            this.btnModificarDetalle = new System.Windows.Forms.Button();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.btnEliminarDetalle = new System.Windows.Forms.Button();
            this.panelTotales = new System.Windows.Forms.Panel();
            this.lblSubtotalTexto = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblITBISTexto = new System.Windows.Forms.Label();
            this.lblITBIS = new System.Windows.Forms.Label();
            this.lblTotalTexto = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btnGuardarVenta = new System.Windows.Forms.Button();
            this.btnCancelarVenta = new System.Windows.Forms.Button();
            this.btnImprimirUltima = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panelSuperior.SuspendLayout();
            this.panelDatosFactura.SuspendLayout();
            this.panelDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.panelTotales.SuspendLayout();
            this.panelBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panelSuperior.Controls.Add(this.lblTitulo);
            this.panelSuperior.Controls.Add(this.lblUsuario);
            this.panelSuperior.Controls.Add(this.lblRol);
            this.panelSuperior.Controls.Add(this.lblTurno);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1100, 85);
            this.panelSuperior.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(20, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(262, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "💰 Módulo de Ventas";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(700, 8);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(92, 19);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "👤 Usuario: ";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.lblRol.Location = new System.Drawing.Point(700, 32);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(58, 19);
            this.lblRol.TabIndex = 2;
            this.lblRol.Text = "🎭 Rol: ";
            this.lblRol.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTurno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.lblTurno.Location = new System.Drawing.Point(700, 56);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(79, 19);
            this.lblTurno.TabIndex = 3;
            this.lblTurno.Text = "🕐 Turno: ";
            this.lblTurno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelDatosFactura
            // 
            this.panelDatosFactura.BackColor = System.Drawing.Color.White;
            this.panelDatosFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDatosFactura.Controls.Add(this.lblNumeroFactura);
            this.panelDatosFactura.Controls.Add(this.txtNumeroFactura);
            this.panelDatosFactura.Controls.Add(this.lblFecha);
            this.panelDatosFactura.Controls.Add(this.dtpFecha);
            this.panelDatosFactura.Controls.Add(this.lblCliente);
            this.panelDatosFactura.Controls.Add(this.txtBuscarCliente);
            this.panelDatosFactura.Controls.Add(this.btnBuscarCliente);
            this.panelDatosFactura.Controls.Add(this.btnLimpiarCliente);
            this.panelDatosFactura.Controls.Add(this.lblClienteSeleccionado);
            this.panelDatosFactura.Controls.Add(this.lblMetodoPago);
            this.panelDatosFactura.Controls.Add(this.cmbMetodoPago);
            this.panelDatosFactura.Location = new System.Drawing.Point(10, 95);
            this.panelDatosFactura.Name = "panelDatosFactura";
            this.panelDatosFactura.Size = new System.Drawing.Size(1080, 100);
            this.panelDatosFactura.TabIndex = 1;
            // 
            // lblNumeroFactura
            // 
            this.lblNumeroFactura.AutoSize = true;
            this.lblNumeroFactura.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNumeroFactura.Location = new System.Drawing.Point(15, 15);
            this.lblNumeroFactura.Name = "lblNumeroFactura";
            this.lblNumeroFactura.Size = new System.Drawing.Size(83, 19);
            this.lblNumeroFactura.TabIndex = 0;
            this.lblNumeroFactura.Text = "Factura Nº:";
            // 
            // txtNumeroFactura
            // 
            this.txtNumeroFactura.Enabled = false;
            this.txtNumeroFactura.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNumeroFactura.Location = new System.Drawing.Point(104, 15);
            this.txtNumeroFactura.Name = "txtNumeroFactura";
            this.txtNumeroFactura.Size = new System.Drawing.Size(226, 25);
            this.txtNumeroFactura.TabIndex = 1;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFecha.Location = new System.Drawing.Point(355, 15);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(51, 19);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpFecha.Location = new System.Drawing.Point(412, 12);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(280, 25);
            this.dtpFecha.TabIndex = 3;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCliente.Location = new System.Drawing.Point(15, 50);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(59, 19);
            this.lblCliente.TabIndex = 4;
            this.lblCliente.Text = "Cliente:";
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBuscarCliente.Location = new System.Drawing.Point(85, 47);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(245, 25);
            this.txtBuscarCliente.TabIndex = 5;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBuscarCliente.ForeColor = System.Drawing.Color.White;
            this.btnBuscarCliente.Location = new System.Drawing.Point(345, 45);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(80, 30);
            this.btnBuscarCliente.TabIndex = 6;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // btnLimpiarCliente
            // 
            this.btnLimpiarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnLimpiarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarCliente.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLimpiarCliente.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarCliente.Location = new System.Drawing.Point(430, 45);
            this.btnLimpiarCliente.Name = "btnLimpiarCliente";
            this.btnLimpiarCliente.Size = new System.Drawing.Size(80, 30);
            this.btnLimpiarCliente.TabIndex = 7;
            this.btnLimpiarCliente.Text = "Limpiar";
            this.btnLimpiarCliente.UseVisualStyleBackColor = false;
            this.btnLimpiarCliente.Click += new System.EventHandler(this.btnLimpiarCliente_Click);
            // 
            // lblClienteSeleccionado
            // 
            this.lblClienteSeleccionado.AutoSize = true;
            this.lblClienteSeleccionado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblClienteSeleccionado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.lblClienteSeleccionado.Location = new System.Drawing.Point(535, 50);
            this.lblClienteSeleccionado.Name = "lblClienteSeleccionado";
            this.lblClienteSeleccionado.Size = new System.Drawing.Size(157, 19);
            this.lblClienteSeleccionado.TabIndex = 8;
            this.lblClienteSeleccionado.Text = "Cliente: No registrado";
            // 
            // lblMetodoPago
            // 
            this.lblMetodoPago.AutoSize = true;
            this.lblMetodoPago.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMetodoPago.Location = new System.Drawing.Point(735, 12);
            this.lblMetodoPago.Name = "lblMetodoPago";
            this.lblMetodoPago.Size = new System.Drawing.Size(105, 19);
            this.lblMetodoPago.TabIndex = 9;
            this.lblMetodoPago.Text = "Método Pago:";
            // 
            // cmbMetodoPago
            // 
            this.cmbMetodoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMetodoPago.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbMetodoPago.Location = new System.Drawing.Point(739, 47);
            this.cmbMetodoPago.Name = "cmbMetodoPago";
            this.cmbMetodoPago.Size = new System.Drawing.Size(212, 25);
            this.cmbMetodoPago.TabIndex = 10;
            // 
            // panelDetalle
            // 
            this.panelDetalle.BackColor = System.Drawing.Color.White;
            this.panelDetalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDetalle.Controls.Add(this.lblCategoria);
            this.panelDetalle.Controls.Add(this.cmbCategoria);
            this.panelDetalle.Controls.Add(this.lblItem);
            this.panelDetalle.Controls.Add(this.cmbProductos);
            this.panelDetalle.Controls.Add(this.cmbServicios);
            this.panelDetalle.Controls.Add(this.lblPrecio);
            this.panelDetalle.Controls.Add(this.txtPrecio);
            this.panelDetalle.Controls.Add(this.lblCantidad);
            this.panelDetalle.Controls.Add(this.txtCantidad);
            this.panelDetalle.Controls.Add(this.lblStock);
            this.panelDetalle.Controls.Add(this.txtStock);
            this.panelDetalle.Controls.Add(this.btnAgregarDetalle);
            this.panelDetalle.Controls.Add(this.btnModificarDetalle);
            this.panelDetalle.Controls.Add(this.dgvDetalle);
            this.panelDetalle.Controls.Add(this.btnEliminarDetalle);
            this.panelDetalle.Location = new System.Drawing.Point(10, 205);
            this.panelDetalle.Name = "panelDetalle";
            this.panelDetalle.Size = new System.Drawing.Size(750, 400);
            this.panelDetalle.TabIndex = 2;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCategoria.Location = new System.Drawing.Point(15, 15);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(79, 19);
            this.lblCategoria.TabIndex = 0;
            this.lblCategoria.Text = "Categoría:";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCategoria.Location = new System.Drawing.Point(100, 12);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(120, 25);
            this.cmbCategoria.TabIndex = 1;
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblItem.Location = new System.Drawing.Point(240, 15);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(75, 19);
            this.lblItem.TabIndex = 2;
            this.lblItem.Text = "Producto:";
            // 
            // cmbProductos
            // 
            this.cmbProductos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbProductos.Location = new System.Drawing.Point(315, 12);
            this.cmbProductos.Name = "cmbProductos";
            this.cmbProductos.Size = new System.Drawing.Size(180, 25);
            this.cmbProductos.TabIndex = 3;
            this.cmbProductos.SelectedIndexChanged += new System.EventHandler(this.cmbProductos_SelectedIndexChanged);
            // 
            // cmbServicios
            // 
            this.cmbServicios.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbServicios.Location = new System.Drawing.Point(315, 12);
            this.cmbServicios.Name = "cmbServicios";
            this.cmbServicios.Size = new System.Drawing.Size(180, 25);
            this.cmbServicios.TabIndex = 4;
            this.cmbServicios.Visible = false;
            this.cmbServicios.SelectedIndexChanged += new System.EventHandler(this.cmbServicios_SelectedIndexChanged);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPrecio.Location = new System.Drawing.Point(15, 50);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(56, 19);
            this.lblPrecio.TabIndex = 5;
            this.lblPrecio.Text = "Precio:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPrecio.Location = new System.Drawing.Point(80, 47);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 25);
            this.txtPrecio.TabIndex = 6;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCantidad.Location = new System.Drawing.Point(200, 50);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(73, 19);
            this.lblCantidad.TabIndex = 7;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCantidad.Location = new System.Drawing.Point(280, 47);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(80, 25);
            this.txtCantidad.TabIndex = 8;
            this.txtCantidad.Text = "1";
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStock.Location = new System.Drawing.Point(380, 50);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(51, 19);
            this.lblStock.TabIndex = 9;
            this.lblStock.Text = "Stock:";
            // 
            // txtStock
            // 
            this.txtStock.Enabled = false;
            this.txtStock.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtStock.Location = new System.Drawing.Point(430, 47);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(100, 25);
            this.txtStock.TabIndex = 10;
            // 
            // btnAgregarDetalle
            // 
            this.btnAgregarDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnAgregarDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarDetalle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAgregarDetalle.ForeColor = System.Drawing.Color.White;
            this.btnAgregarDetalle.Location = new System.Drawing.Point(550, 45);
            this.btnAgregarDetalle.Name = "btnAgregarDetalle";
            this.btnAgregarDetalle.Size = new System.Drawing.Size(90, 30);
            this.btnAgregarDetalle.TabIndex = 11;
            this.btnAgregarDetalle.Text = "➕ Agregar";
            this.btnAgregarDetalle.UseVisualStyleBackColor = false;
            this.btnAgregarDetalle.Click += new System.EventHandler(this.btnAgregarDetalle_Click);
            // 
            // btnModificarDetalle
            // 
            this.btnModificarDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnModificarDetalle.Enabled = false;
            this.btnModificarDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarDetalle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnModificarDetalle.ForeColor = System.Drawing.Color.White;
            this.btnModificarDetalle.Location = new System.Drawing.Point(550, 10);
            this.btnModificarDetalle.Name = "btnModificarDetalle";
            this.btnModificarDetalle.Size = new System.Drawing.Size(90, 30);
            this.btnModificarDetalle.TabIndex = 12;
            this.btnModificarDetalle.Text = "✏️ Modificar";
            this.btnModificarDetalle.UseVisualStyleBackColor = false;
            this.btnModificarDetalle.Click += new System.EventHandler(this.btnModificarDetalle_Click);
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AllowUserToDeleteRows = false;
            this.dgvDetalle.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Location = new System.Drawing.Point(10, 90);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.ReadOnly = true;
            this.dgvDetalle.RowHeadersVisible = false;
            this.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalle.Size = new System.Drawing.Size(725, 260);
            this.dgvDetalle.TabIndex = 13;
            this.dgvDetalle.SelectionChanged += new System.EventHandler(this.dgvDetalle_SelectionChanged);
            // 
            // btnEliminarDetalle
            // 
            this.btnEliminarDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnEliminarDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarDetalle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEliminarDetalle.ForeColor = System.Drawing.Color.White;
            this.btnEliminarDetalle.Location = new System.Drawing.Point(10, 360);
            this.btnEliminarDetalle.Name = "btnEliminarDetalle";
            this.btnEliminarDetalle.Size = new System.Drawing.Size(180, 30);
            this.btnEliminarDetalle.TabIndex = 14;
            this.btnEliminarDetalle.Text = "🗑️ Eliminar Seleccionado";
            this.btnEliminarDetalle.UseVisualStyleBackColor = false;
            this.btnEliminarDetalle.Click += new System.EventHandler(this.btnEliminarDetalle_Click);
            // 
            // panelTotales
            // 
            this.panelTotales.BackColor = System.Drawing.Color.White;
            this.panelTotales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTotales.Controls.Add(this.lblSubtotalTexto);
            this.panelTotales.Controls.Add(this.lblSubtotal);
            this.panelTotales.Controls.Add(this.lblITBISTexto);
            this.panelTotales.Controls.Add(this.lblITBIS);
            this.panelTotales.Controls.Add(this.lblTotalTexto);
            this.panelTotales.Controls.Add(this.lblTotal);
            this.panelTotales.Location = new System.Drawing.Point(770, 205);
            this.panelTotales.Name = "panelTotales";
            this.panelTotales.Size = new System.Drawing.Size(320, 400);
            this.panelTotales.TabIndex = 3;
            // 
            // lblSubtotalTexto
            // 
            this.lblSubtotalTexto.AutoSize = true;
            this.lblSubtotalTexto.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblSubtotalTexto.Location = new System.Drawing.Point(20, 50);
            this.lblSubtotalTexto.Name = "lblSubtotalTexto";
            this.lblSubtotalTexto.Size = new System.Drawing.Size(93, 25);
            this.lblSubtotalTexto.TabIndex = 0;
            this.lblSubtotalTexto.Text = "Subtotal:";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblSubtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblSubtotal.Location = new System.Drawing.Point(150, 50);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(85, 25);
            this.lblSubtotal.TabIndex = 1;
            this.lblSubtotal.Text = "RD$ 0.00";
            // 
            // lblITBISTexto
            // 
            this.lblITBISTexto.AutoSize = true;
            this.lblITBISTexto.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblITBISTexto.Location = new System.Drawing.Point(20, 100);
            this.lblITBISTexto.Name = "lblITBISTexto";
            this.lblITBISTexto.Size = new System.Drawing.Size(120, 25);
            this.lblITBISTexto.TabIndex = 2;
            this.lblITBISTexto.Text = "ITBIS (18%):";
            // 
            // lblITBIS
            // 
            this.lblITBIS.AutoSize = true;
            this.lblITBIS.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblITBIS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblITBIS.Location = new System.Drawing.Point(170, 100);
            this.lblITBIS.Name = "lblITBIS";
            this.lblITBIS.Size = new System.Drawing.Size(85, 25);
            this.lblITBIS.TabIndex = 3;
            this.lblITBIS.Text = "RD$ 0.00";
            // 
            // lblTotalTexto
            // 
            this.lblTotalTexto.AutoSize = true;
            this.lblTotalTexto.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTotalTexto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblTotalTexto.Location = new System.Drawing.Point(20, 160);
            this.lblTotalTexto.Name = "lblTotalTexto";
            this.lblTotalTexto.Size = new System.Drawing.Size(105, 37);
            this.lblTotalTexto.TabIndex = 4;
            this.lblTotalTexto.Text = "TOTAL:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.lblTotal.Location = new System.Drawing.Point(140, 155);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(133, 37);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "RD$ 0.00";
            // 
            // panelBotones
            // 
            this.panelBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panelBotones.Controls.Add(this.btnGuardarVenta);
            this.panelBotones.Controls.Add(this.btnCancelarVenta);
            this.panelBotones.Controls.Add(this.btnImprimirUltima);
            this.panelBotones.Controls.Add(this.btnCerrar);
            this.panelBotones.Location = new System.Drawing.Point(10, 615);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(1080, 60);
            this.panelBotones.TabIndex = 4;
            // 
            // btnGuardarVenta
            // 
            this.btnGuardarVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnGuardarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarVenta.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGuardarVenta.ForeColor = System.Drawing.Color.White;
            this.btnGuardarVenta.Location = new System.Drawing.Point(20, 10);
            this.btnGuardarVenta.Name = "btnGuardarVenta";
            this.btnGuardarVenta.Size = new System.Drawing.Size(160, 40);
            this.btnGuardarVenta.TabIndex = 0;
            this.btnGuardarVenta.Text = "💾 Guardar Venta";
            this.btnGuardarVenta.UseVisualStyleBackColor = false;
            this.btnGuardarVenta.Click += new System.EventHandler(this.btnGuardarVenta_Click);
            // 
            // btnCancelarVenta
            // 
            this.btnCancelarVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnCancelarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarVenta.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelarVenta.ForeColor = System.Drawing.Color.White;
            this.btnCancelarVenta.Location = new System.Drawing.Point(190, 10);
            this.btnCancelarVenta.Name = "btnCancelarVenta";
            this.btnCancelarVenta.Size = new System.Drawing.Size(160, 40);
            this.btnCancelarVenta.TabIndex = 1;
            this.btnCancelarVenta.Text = "❌ Cancelar Venta";
            this.btnCancelarVenta.UseVisualStyleBackColor = false;
            this.btnCancelarVenta.Click += new System.EventHandler(this.btnCancelarVenta_Click);
            // 
            // btnImprimirUltima
            // 
            this.btnImprimirUltima.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnImprimirUltima.Enabled = false;
            this.btnImprimirUltima.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimirUltima.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnImprimirUltima.ForeColor = System.Drawing.Color.White;
            this.btnImprimirUltima.Location = new System.Drawing.Point(360, 10);
            this.btnImprimirUltima.Name = "btnImprimirUltima";
            this.btnImprimirUltima.Size = new System.Drawing.Size(180, 40);
            this.btnImprimirUltima.TabIndex = 2;
            this.btnImprimirUltima.Text = "🖨️ Reimprimir Última";
            this.btnImprimirUltima.UseVisualStyleBackColor = false;
            this.btnImprimirUltima.Click += new System.EventHandler(this.btnImprimirUltima_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(900, 10);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(160, 40);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "✖ Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.panelTotales);
            this.Controls.Add(this.panelDetalle);
            this.Controls.Add(this.panelDatosFactura);
            this.Controls.Add(this.panelSuperior);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "frmVentas";
            this.Text = "Módulo de Ventas - Walkiria Papelería";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmVentas_Load);
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.panelDatosFactura.ResumeLayout(false);
            this.panelDatosFactura.PerformLayout();
            this.panelDetalle.ResumeLayout(false);
            this.panelDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.panelTotales.ResumeLayout(false);
            this.panelTotales.PerformLayout();
            this.panelBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}