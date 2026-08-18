using System.Drawing;
using System.Windows.Forms;

namespace WalkiriaPapeleria.Forms
{
    partial class frmVentas
    {
        private System.ComponentModel.IContainer components = null;

        // =========================
        // PANELES
        // =========================
        private Panel panelSuperior;
        private Panel panelDatosFactura;
        private Panel panelDetalle;
        private Panel panelTotales;
        private Panel panelBotones;
        private Panel panelLineaTotal;

        // =========================
        // ENCABEZADO
        // =========================
        private Label lblTitulo;
        private Label lblSubtitulo;
        private Label lblUsuario;
        private Label lblRol;
        private Label lblTurno;

        // =========================
        // DATOS FACTURA
        // =========================
        private Label lblSeccionFactura;

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

        // =========================
        // DETALLE
        // =========================
        private Label lblSeccionDetalle;

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
        private Button btnEliminarDetalle;

        private DataGridView dgvDetalle;

        // =========================
        // TOTALES
        // =========================
        private Label lblResumenTitulo;

        private Label lblSubtotalTexto;
        private Label lblSubtotal;

        private Label lblITBISTexto;
        private Label lblITBIS;

        private Label lblTotalTexto;
        private Label lblTotal;

        private Label lblAyudaTotal;

        // =========================
        // ACCIONES
        // =========================
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
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();

            this.panelDatosFactura = new System.Windows.Forms.Panel();
            this.lblSeccionFactura = new System.Windows.Forms.Label();
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
            this.lblSeccionDetalle = new System.Windows.Forms.Label();
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
            this.lblResumenTitulo = new System.Windows.Forms.Label();
            this.lblSubtotalTexto = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblITBISTexto = new System.Windows.Forms.Label();
            this.lblITBIS = new System.Windows.Forms.Label();
            this.panelLineaTotal = new System.Windows.Forms.Panel();
            this.lblTotalTexto = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblAyudaTotal = new System.Windows.Forms.Label();

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

            // =====================================================
            // panelSuperior
            // =====================================================
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(15, 38, 71);
            this.panelSuperior.Controls.Add(this.lblTitulo);
            this.panelSuperior.Controls.Add(this.lblSubtitulo);
            this.panelSuperior.Controls.Add(this.lblUsuario);
            this.panelSuperior.Controls.Add(this.lblRol);
            this.panelSuperior.Controls.Add(this.lblTurno);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1280, 92);
            this.panelSuperior.TabIndex = 0;

            // =====================================================
            // lblTitulo
            // =====================================================
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font(
                "Segoe UI",
                22F,
                System.Drawing.FontStyle.Bold
            );
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(28, 16);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(229, 41);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Nueva Venta";

            // =====================================================
            // lblSubtitulo
            // =====================================================
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font(
                "Segoe UI",
                9.5F
            );
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(
                170,
                195,
                220
            );
            this.lblSubtitulo.Location = new System.Drawing.Point(31, 60);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(302, 17);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text =
                "Facturación • Productos • Servicios • Clientes";

            // =====================================================
            // lblUsuario
            // =====================================================
            this.lblUsuario.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Right;

            this.lblUsuario.Font = new System.Drawing.Font(
                "Segoe UI",
                9.5F,
                System.Drawing.FontStyle.Bold
            );

            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(820, 13);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(430, 20);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuario:";
            this.lblUsuario.TextAlign =
                System.Drawing.ContentAlignment.MiddleRight;

            // =====================================================
            // lblRol
            // =====================================================
            this.lblRol.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Right;

            this.lblRol.Font = new System.Drawing.Font(
                "Segoe UI",
                9.5F
            );

            this.lblRol.ForeColor = System.Drawing.Color.FromArgb(
                99,
                220,
                180
            );

            this.lblRol.Location = new System.Drawing.Point(820, 35);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(430, 20);
            this.lblRol.TabIndex = 3;
            this.lblRol.Text = "Rol:";
            this.lblRol.TextAlign =
                System.Drawing.ContentAlignment.MiddleRight;

            // =====================================================
            // lblTurno
            // =====================================================
            this.lblTurno.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Right;

            this.lblTurno.Font = new System.Drawing.Font(
                "Segoe UI",
                9.5F,
                System.Drawing.FontStyle.Bold
            );

            this.lblTurno.ForeColor = System.Drawing.Color.FromArgb(
                255,
                195,
                75
            );

            this.lblTurno.Location = new System.Drawing.Point(820, 58);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(430, 20);
            this.lblTurno.TabIndex = 4;
            this.lblTurno.Text = "Turno:";
            this.lblTurno.TextAlign =
                System.Drawing.ContentAlignment.MiddleRight;

            // =====================================================
            // panelDatosFactura
            // =====================================================
            this.panelDatosFactura.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;

            this.panelDatosFactura.BackColor = System.Drawing.Color.White;
            this.panelDatosFactura.Controls.Add(this.lblSeccionFactura);
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
            this.panelDatosFactura.Location = new System.Drawing.Point(24, 112);
            this.panelDatosFactura.Name = "panelDatosFactura";
            this.panelDatosFactura.Size = new System.Drawing.Size(1232, 142);
            this.panelDatosFactura.TabIndex = 1;

            // =====================================================
            // lblSeccionFactura
            // =====================================================
            this.lblSeccionFactura.AutoSize = true;
            this.lblSeccionFactura.Font = new System.Drawing.Font(
                "Segoe UI",
                12F,
                System.Drawing.FontStyle.Bold
            );

            this.lblSeccionFactura.ForeColor =
                System.Drawing.Color.FromArgb(25, 45, 70);

            this.lblSeccionFactura.Location =
                new System.Drawing.Point(20, 14);

            this.lblSeccionFactura.Name = "lblSeccionFactura";
            this.lblSeccionFactura.Size = new System.Drawing.Size(133, 21);
            this.lblSeccionFactura.TabIndex = 0;
            this.lblSeccionFactura.Text = "Datos de factura";

            // =====================================================
            // lblNumeroFactura
            // =====================================================
            this.lblNumeroFactura.AutoSize = true;
            this.lblNumeroFactura.Font = new System.Drawing.Font(
                "Segoe UI",
                8.5F,
                System.Drawing.FontStyle.Bold
            );

            this.lblNumeroFactura.ForeColor =
                System.Drawing.Color.FromArgb(100, 110, 120);

            this.lblNumeroFactura.Location =
                new System.Drawing.Point(20, 49);

            this.lblNumeroFactura.Name = "lblNumeroFactura";
            this.lblNumeroFactura.Size = new System.Drawing.Size(74, 15);
            this.lblNumeroFactura.TabIndex = 1;
            this.lblNumeroFactura.Text = "FACTURA Nº";

            // =====================================================
            // txtNumeroFactura
            // =====================================================
            this.txtNumeroFactura.BackColor =
                System.Drawing.Color.FromArgb(244, 247, 249);

            this.txtNumeroFactura.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.txtNumeroFactura.Enabled = false;

            this.txtNumeroFactura.Font =
                new System.Drawing.Font("Segoe UI", 10.5F);

            this.txtNumeroFactura.Location =
                new System.Drawing.Point(20, 70);

            this.txtNumeroFactura.Name = "txtNumeroFactura";
            this.txtNumeroFactura.Size =
                new System.Drawing.Size(190, 26);

            this.txtNumeroFactura.TabIndex = 2;

            // =====================================================
            // lblFecha
            // =====================================================
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font(
                "Segoe UI",
                8.5F,
                System.Drawing.FontStyle.Bold
            );

            this.lblFecha.ForeColor =
                System.Drawing.Color.FromArgb(100, 110, 120);

            this.lblFecha.Location =
                new System.Drawing.Point(230, 49);

            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(43, 15);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "FECHA";

            // =====================================================
            // dtpFecha
            // =====================================================
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpFecha.Location = new System.Drawing.Point(230, 70);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(250, 25);
            this.dtpFecha.TabIndex = 4;

            // =====================================================
            // lblMetodoPago
            // =====================================================
            this.lblMetodoPago.AutoSize = true;
            this.lblMetodoPago.Font = new System.Drawing.Font(
                "Segoe UI",
                8.5F,
                System.Drawing.FontStyle.Bold
            );

            this.lblMetodoPago.ForeColor =
                System.Drawing.Color.FromArgb(100, 110, 120);

            this.lblMetodoPago.Location =
                new System.Drawing.Point(500, 49);

            this.lblMetodoPago.Name = "lblMetodoPago";
            this.lblMetodoPago.Size = new System.Drawing.Size(107, 15);
            this.lblMetodoPago.TabIndex = 5;
            this.lblMetodoPago.Text = "MÉTODO DE PAGO";

            // =====================================================
            // cmbMetodoPago
            // =====================================================
            this.cmbMetodoPago.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cmbMetodoPago.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.cmbMetodoPago.Font =
                new System.Drawing.Font("Segoe UI", 10.5F);

            this.cmbMetodoPago.FormattingEnabled = true;

            this.cmbMetodoPago.Location =
                new System.Drawing.Point(500, 69);

            this.cmbMetodoPago.Name = "cmbMetodoPago";

            this.cmbMetodoPago.Size =
                new System.Drawing.Size(210, 27);

            this.cmbMetodoPago.TabIndex = 5;

            // =====================================================
            // lblCliente
            // =====================================================
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font(
                "Segoe UI",
                8.5F,
                System.Drawing.FontStyle.Bold
            );

            this.lblCliente.ForeColor =
                System.Drawing.Color.FromArgb(100, 110, 120);

            this.lblCliente.Location =
                new System.Drawing.Point(730, 49);

            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(119, 15);
            this.lblCliente.TabIndex = 6;
            this.lblCliente.Text = "CÉDULA DEL CLIENTE";

            // =====================================================
            // txtBuscarCliente
            // =====================================================
            this.txtBuscarCliente.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Right;

            this.txtBuscarCliente.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.txtBuscarCliente.Font =
                new System.Drawing.Font("Segoe UI", 10.5F);

            this.txtBuscarCliente.Location =
                new System.Drawing.Point(730, 70);

            this.txtBuscarCliente.Name = "txtBuscarCliente";

            this.txtBuscarCliente.Size =
                new System.Drawing.Size(200, 26);

            this.txtBuscarCliente.TabIndex = 6;

            // =====================================================
            // btnBuscarCliente
            // =====================================================
            this.btnBuscarCliente.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Right;

            this.btnBuscarCliente.BackColor =
                System.Drawing.Color.FromArgb(25, 125, 160);

            this.btnBuscarCliente.Cursor =
                System.Windows.Forms.Cursors.Hand;

            this.btnBuscarCliente.FlatAppearance.BorderSize = 0;

            this.btnBuscarCliente.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnBuscarCliente.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold
                );

            this.btnBuscarCliente.ForeColor =
                System.Drawing.Color.White;

            this.btnBuscarCliente.Location =
                new System.Drawing.Point(940, 68);

            this.btnBuscarCliente.Name = "btnBuscarCliente";

            this.btnBuscarCliente.Size =
                new System.Drawing.Size(85, 30);

            this.btnBuscarCliente.TabIndex = 7;
            this.btnBuscarCliente.Text = "Buscar";

            this.btnBuscarCliente.UseVisualStyleBackColor = false;

            this.btnBuscarCliente.Click +=
                new System.EventHandler(
                    this.btnBuscarCliente_Click
                );

            // =====================================================
            // btnLimpiarCliente
            // =====================================================
            this.btnLimpiarCliente.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Right;

            this.btnLimpiarCliente.BackColor =
                System.Drawing.Color.FromArgb(235, 238, 241);

            this.btnLimpiarCliente.Cursor =
                System.Windows.Forms.Cursors.Hand;

            this.btnLimpiarCliente.FlatAppearance.BorderSize = 0;

            this.btnLimpiarCliente.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnLimpiarCliente.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold
                );

            this.btnLimpiarCliente.ForeColor =
                System.Drawing.Color.FromArgb(70, 80, 90);

            this.btnLimpiarCliente.Location =
                new System.Drawing.Point(1035, 68);

            this.btnLimpiarCliente.Name = "btnLimpiarCliente";

            this.btnLimpiarCliente.Size =
                new System.Drawing.Size(85, 30);

            this.btnLimpiarCliente.TabIndex = 8;
            this.btnLimpiarCliente.Text = "Limpiar";

            this.btnLimpiarCliente.UseVisualStyleBackColor = false;

            this.btnLimpiarCliente.Click +=
                new System.EventHandler(
                    this.btnLimpiarCliente_Click
                );

            // =====================================================
            // lblClienteSeleccionado
            // =====================================================
            this.lblClienteSeleccionado.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Right;

            this.lblClienteSeleccionado.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9.5F,
                    System.Drawing.FontStyle.Bold
                );

            this.lblClienteSeleccionado.ForeColor =
                System.Drawing.Color.FromArgb(215, 145, 35);

            this.lblClienteSeleccionado.Location =
                new System.Drawing.Point(730, 107);

            this.lblClienteSeleccionado.Name =
                "lblClienteSeleccionado";

            this.lblClienteSeleccionado.Size =
                new System.Drawing.Size(390, 22);

            this.lblClienteSeleccionado.TabIndex = 9;

            this.lblClienteSeleccionado.Text =
                "Cliente: No registrado";

            // =====================================================
            // panelDetalle
            // =====================================================
            this.panelDetalle.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;

            this.panelDetalle.BackColor = System.Drawing.Color.White;

            this.panelDetalle.Controls.Add(this.lblSeccionDetalle);
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

            this.panelDetalle.Location =
                new System.Drawing.Point(24, 274);

            this.panelDetalle.Name = "panelDetalle";

            this.panelDetalle.Size =
                new System.Drawing.Size(860, 398);

            this.panelDetalle.TabIndex = 2;

            // =====================================================
            // lblSeccionDetalle
            // =====================================================
            this.lblSeccionDetalle.AutoSize = true;

            this.lblSeccionDetalle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    12F,
                    System.Drawing.FontStyle.Bold
                );

            this.lblSeccionDetalle.ForeColor =
                System.Drawing.Color.FromArgb(25, 45, 70);

            this.lblSeccionDetalle.Location =
                new System.Drawing.Point(20, 14);

            this.lblSeccionDetalle.Name =
                "lblSeccionDetalle";

            this.lblSeccionDetalle.Size =
                new System.Drawing.Size(145, 21);

            this.lblSeccionDetalle.TabIndex = 0;

            this.lblSeccionDetalle.Text =
                "Detalle de la venta";

            // =====================================================
            // lblCategoria
            // =====================================================
            this.lblCategoria.AutoSize = true;

            this.lblCategoria.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    8.5F,
                    System.Drawing.FontStyle.Bold
                );

            this.lblCategoria.ForeColor =
                System.Drawing.Color.FromArgb(100, 110, 120);

            this.lblCategoria.Location =
                new System.Drawing.Point(20, 54);

            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(70, 15);
            this.lblCategoria.TabIndex = 1;
            this.lblCategoria.Text = "CATEGORÍA";

            // =====================================================
            // cmbCategoria
            // =====================================================
            this.cmbCategoria.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cmbCategoria.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.cmbCategoria.Font =
                new System.Drawing.Font("Segoe UI", 10F);

            this.cmbCategoria.FormattingEnabled = true;

            this.cmbCategoria.Location =
                new System.Drawing.Point(20, 75);

            this.cmbCategoria.Name = "cmbCategoria";

            this.cmbCategoria.Size =
                new System.Drawing.Size(145, 25);

            this.cmbCategoria.TabIndex = 9;

            this.cmbCategoria.SelectedIndexChanged +=
                new System.EventHandler(
                    this.cmbCategoria_SelectedIndexChanged
                );

            // =====================================================
            // lblItem
            // =====================================================
            this.lblItem.AutoSize = true;

            this.lblItem.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    8.5F,
                    System.Drawing.FontStyle.Bold
                );

            this.lblItem.ForeColor =
                System.Drawing.Color.FromArgb(100, 110, 120);

            this.lblItem.Location =
                new System.Drawing.Point(180, 54);

            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(68, 15);
            this.lblItem.TabIndex = 2;
            this.lblItem.Text = "PRODUCTO";

            // =====================================================
            // cmbProductos
            // =====================================================
            this.cmbProductos.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cmbProductos.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.cmbProductos.Font =
                new System.Drawing.Font("Segoe UI", 10F);

            this.cmbProductos.FormattingEnabled = true;

            this.cmbProductos.Location =
                new System.Drawing.Point(180, 75);

            this.cmbProductos.Name = "cmbProductos";

            this.cmbProductos.Size =
                new System.Drawing.Size(245, 25);

            this.cmbProductos.TabIndex = 10;

            this.cmbProductos.SelectedIndexChanged +=
                new System.EventHandler(
                    this.cmbProductos_SelectedIndexChanged
                );

            // =====================================================
            // cmbServicios
            // =====================================================
            this.cmbServicios.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cmbServicios.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.cmbServicios.Font =
                new System.Drawing.Font("Segoe UI", 10F);

            this.cmbServicios.FormattingEnabled = true;

            this.cmbServicios.Location =
                new System.Drawing.Point(180, 75);

            this.cmbServicios.Name = "cmbServicios";

            this.cmbServicios.Size =
                new System.Drawing.Size(245, 25);

            this.cmbServicios.TabIndex = 11;

            this.cmbServicios.Visible = false;

            this.cmbServicios.SelectedIndexChanged +=
                new System.EventHandler(
                    this.cmbServicios_SelectedIndexChanged
                );

            // =====================================================
            // lblPrecio
            // =====================================================
            this.lblPrecio.AutoSize = true;

            this.lblPrecio.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    8.5F,
                    System.Drawing.FontStyle.Bold
                );

            this.lblPrecio.ForeColor =
                System.Drawing.Color.FromArgb(100, 110, 120);

            this.lblPrecio.Location =
                new System.Drawing.Point(440, 54);

            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(45, 15);
            this.lblPrecio.TabIndex = 3;
            this.lblPrecio.Text = "PRECIO";

            // =====================================================
            // txtPrecio
            // =====================================================
            this.txtPrecio.BackColor =
                System.Drawing.Color.FromArgb(244, 247, 249);

            this.txtPrecio.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.txtPrecio.Enabled = false;

            this.txtPrecio.Font =
                new System.Drawing.Font("Segoe UI", 10F);

            this.txtPrecio.Location =
                new System.Drawing.Point(440, 75);

            this.txtPrecio.Name = "txtPrecio";

            this.txtPrecio.Size =
                new System.Drawing.Size(105, 25);

            this.txtPrecio.TabIndex = 12;

            // =====================================================
            // lblCantidad
            // =====================================================
            this.lblCantidad.AutoSize = true;

            this.lblCantidad.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    8.5F,
                    System.Drawing.FontStyle.Bold
                );

            this.lblCantidad.ForeColor =
                System.Drawing.Color.FromArgb(100, 110, 120);

            this.lblCantidad.Location =
                new System.Drawing.Point(560, 54);

            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(62, 15);
            this.lblCantidad.TabIndex = 4;
            this.lblCantidad.Text = "CANTIDAD";

            // =====================================================
            // txtCantidad
            // =====================================================
            this.txtCantidad.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.txtCantidad.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold
                );

            this.txtCantidad.Location =
                new System.Drawing.Point(560, 75);

            this.txtCantidad.Name = "txtCantidad";

            this.txtCantidad.Size =
                new System.Drawing.Size(80, 25);

            this.txtCantidad.TabIndex = 13;

            this.txtCantidad.Text = "1";

            this.txtCantidad.TextAlign =
                System.Windows.Forms.HorizontalAlignment.Center;

            this.txtCantidad.KeyPress +=
                new System.Windows.Forms.KeyPressEventHandler(
                    this.txtCantidad_KeyPress
                );

            // =====================================================
            // lblStock
            // =====================================================
            this.lblStock.AutoSize = true;

            this.lblStock.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    8.5F,
                    System.Drawing.FontStyle.Bold
                );

            this.lblStock.ForeColor =
                System.Drawing.Color.FromArgb(100, 110, 120);

            this.lblStock.Location =
                new System.Drawing.Point(655, 54);

            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(41, 15);
            this.lblStock.TabIndex = 5;
            this.lblStock.Text = "STOCK";

            // =====================================================
            // txtStock
            // =====================================================
            this.txtStock.BackColor =
                System.Drawing.Color.FromArgb(244, 247, 249);

            this.txtStock.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.txtStock.Enabled = false;

            this.txtStock.Font =
                new System.Drawing.Font("Segoe UI", 10F);

            this.txtStock.Location =
                new System.Drawing.Point(655, 75);

            this.txtStock.Name = "txtStock";

            this.txtStock.Size =
                new System.Drawing.Size(125, 25);

            this.txtStock.TabIndex = 14;

            // =====================================================
            // btnAgregarDetalle
            // =====================================================
            this.btnAgregarDetalle.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Right;

            this.btnAgregarDetalle.BackColor =
                System.Drawing.Color.FromArgb(25, 125, 160);

            this.btnAgregarDetalle.Cursor =
                System.Windows.Forms.Cursors.Hand;

            this.btnAgregarDetalle.FlatAppearance.BorderSize = 0;

            this.btnAgregarDetalle.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnAgregarDetalle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold
                );

            this.btnAgregarDetalle.ForeColor =
                System.Drawing.Color.White;

            this.btnAgregarDetalle.Location =
                new System.Drawing.Point(790, 69);

            this.btnAgregarDetalle.Name =
                "btnAgregarDetalle";

            this.btnAgregarDetalle.Size =
                new System.Drawing.Size(55, 36);

            this.btnAgregarDetalle.TabIndex = 15;

            this.btnAgregarDetalle.Text = "Añadir";

            this.btnAgregarDetalle.UseVisualStyleBackColor =
                false;

            this.btnAgregarDetalle.Click +=
                new System.EventHandler(
                    this.btnAgregarDetalle_Click
                );

            // =====================================================
            // btnModificarDetalle
            // =====================================================
            this.btnModificarDetalle.Anchor =
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left;

            this.btnModificarDetalle.BackColor =
                System.Drawing.Color.FromArgb(235, 238, 241);

            this.btnModificarDetalle.Cursor =
                System.Windows.Forms.Cursors.Hand;

            this.btnModificarDetalle.Enabled = false;

            this.btnModificarDetalle.FlatAppearance.BorderSize = 0;

            this.btnModificarDetalle.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnModificarDetalle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold
                );

            this.btnModificarDetalle.ForeColor =
                System.Drawing.Color.FromArgb(60, 75, 90);

            this.btnModificarDetalle.Location =
                new System.Drawing.Point(20, 350);

            this.btnModificarDetalle.Name =
                "btnModificarDetalle";

            this.btnModificarDetalle.Size =
                new System.Drawing.Size(130, 32);

            this.btnModificarDetalle.TabIndex = 16;

            this.btnModificarDetalle.Text =
                "Modificar";

            this.btnModificarDetalle.UseVisualStyleBackColor =
                false;

            this.btnModificarDetalle.Click +=
                new System.EventHandler(
                    this.btnModificarDetalle_Click
                );

            // =====================================================
            // btnEliminarDetalle
            // =====================================================
            this.btnEliminarDetalle.Anchor =
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left;

            this.btnEliminarDetalle.BackColor =
                System.Drawing.Color.FromArgb(185, 55, 55);

            this.btnEliminarDetalle.Cursor =
                System.Windows.Forms.Cursors.Hand;

            this.btnEliminarDetalle.FlatAppearance.BorderSize = 0;

            this.btnEliminarDetalle.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnEliminarDetalle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold
                );

            this.btnEliminarDetalle.ForeColor =
                System.Drawing.Color.White;

            this.btnEliminarDetalle.Location =
                new System.Drawing.Point(160, 350);

            this.btnEliminarDetalle.Name =
                "btnEliminarDetalle";

            this.btnEliminarDetalle.Size =
                new System.Drawing.Size(150, 32);

            this.btnEliminarDetalle.TabIndex = 17;

            this.btnEliminarDetalle.Text =
                "Eliminar seleccionado";

            this.btnEliminarDetalle.UseVisualStyleBackColor =
                false;

            this.btnEliminarDetalle.Click +=
                new System.EventHandler(
                    this.btnEliminarDetalle_Click
                );

            // =====================================================
            // dgvDetalle
            // =====================================================
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AllowUserToDeleteRows = false;
            this.dgvDetalle.AllowUserToResizeRows = false;

            this.dgvDetalle.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;

            this.dgvDetalle.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvDetalle.BackgroundColor =
                System.Drawing.Color.White;

            this.dgvDetalle.BorderStyle =
                System.Windows.Forms.BorderStyle.None;

            this.dgvDetalle.CellBorderStyle =
                System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;

            this.dgvDetalle.ColumnHeadersBorderStyle =
                System.Windows.Forms.DataGridViewHeaderBorderStyle.None;

            this.dgvDetalle.ColumnHeadersDefaultCellStyle.BackColor =
                System.Drawing.Color.FromArgb(25, 45, 70);

            this.dgvDetalle.ColumnHeadersDefaultCellStyle.ForeColor =
                System.Drawing.Color.White;

            this.dgvDetalle.ColumnHeadersDefaultCellStyle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9.5F,
                    System.Drawing.FontStyle.Bold
                );

            this.dgvDetalle.ColumnHeadersDefaultCellStyle.SelectionBackColor =
                System.Drawing.Color.FromArgb(25, 45, 70);

            this.dgvDetalle.ColumnHeadersDefaultCellStyle.SelectionForeColor =
                System.Drawing.Color.White;

            this.dgvDetalle.ColumnHeadersHeight = 38;
            this.dgvDetalle.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            this.dgvDetalle.DefaultCellStyle.BackColor =
                System.Drawing.Color.White;

            this.dgvDetalle.DefaultCellStyle.ForeColor =
                System.Drawing.Color.FromArgb(55, 65, 75);

            this.dgvDetalle.DefaultCellStyle.Font =
                new System.Drawing.Font("Segoe UI", 9.5F);

            this.dgvDetalle.DefaultCellStyle.SelectionBackColor =
                System.Drawing.Color.FromArgb(220, 235, 244);

            this.dgvDetalle.DefaultCellStyle.SelectionForeColor =
                System.Drawing.Color.FromArgb(25, 45, 70);

            this.dgvDetalle.GridColor =
                System.Drawing.Color.FromArgb(232, 236, 240);

            this.dgvDetalle.Location =
                new System.Drawing.Point(20, 120);

            this.dgvDetalle.MultiSelect = false;
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.ReadOnly = true;

            this.dgvDetalle.RowHeadersVisible = false;
            this.dgvDetalle.RowTemplate.Height = 34;

            this.dgvDetalle.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.dgvDetalle.Size =
                new System.Drawing.Size(825, 215);

            this.dgvDetalle.TabIndex = 18;

            this.dgvDetalle.SelectionChanged +=
                new System.EventHandler(
                    this.dgvDetalle_SelectionChanged
                );

            // =====================================================
            // panelTotales
            // =====================================================
            this.panelTotales.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Right;

            this.panelTotales.BackColor =
                System.Drawing.Color.White;

            this.panelTotales.Controls.Add(this.lblResumenTitulo);
            this.panelTotales.Controls.Add(this.lblSubtotalTexto);
            this.panelTotales.Controls.Add(this.lblSubtotal);
            this.panelTotales.Controls.Add(this.lblITBISTexto);
            this.panelTotales.Controls.Add(this.lblITBIS);
            this.panelTotales.Controls.Add(this.panelLineaTotal);
            this.panelTotales.Controls.Add(this.lblTotalTexto);
            this.panelTotales.Controls.Add(this.lblTotal);
            this.panelTotales.Controls.Add(this.lblAyudaTotal);

            this.panelTotales.Location =
                new System.Drawing.Point(904, 274);

            this.panelTotales.Name =
                "panelTotales";

            this.panelTotales.Size =
                new System.Drawing.Size(352, 398);

            this.panelTotales.TabIndex = 3;

            // =====================================================
            // lblResumenTitulo
            // =====================================================
            this.lblResumenTitulo.AutoSize = true;

            this.lblResumenTitulo.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    13F,
                    System.Drawing.FontStyle.Bold
                );

            this.lblResumenTitulo.ForeColor =
                System.Drawing.Color.FromArgb(25, 45, 70);

            this.lblResumenTitulo.Location =
                new System.Drawing.Point(25, 24);

            this.lblResumenTitulo.Name =
                "lblResumenTitulo";

            this.lblResumenTitulo.Size =
                new System.Drawing.Size(162, 25);

            this.lblResumenTitulo.TabIndex = 0;

            this.lblResumenTitulo.Text =
                "Resumen de venta";

            // =====================================================
            // lblSubtotalTexto
            // =====================================================
            this.lblSubtotalTexto.AutoSize = true;

            this.lblSubtotalTexto.Font =
                new System.Drawing.Font("Segoe UI", 10F);

            this.lblSubtotalTexto.ForeColor =
                System.Drawing.Color.FromArgb(95, 105, 115);

            this.lblSubtotalTexto.Location =
                new System.Drawing.Point(25, 85);

            this.lblSubtotalTexto.Name =
                "lblSubtotalTexto";

            this.lblSubtotalTexto.Size =
                new System.Drawing.Size(61, 19);

            this.lblSubtotalTexto.TabIndex = 1;

            this.lblSubtotalTexto.Text =
                "Subtotal";

            // =====================================================
            // lblSubtotal
            // =====================================================
            this.lblSubtotal.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    11F,
                    System.Drawing.FontStyle.Bold
                );

            this.lblSubtotal.ForeColor =
                System.Drawing.Color.FromArgb(45, 60, 75);

            this.lblSubtotal.Location =
                new System.Drawing.Point(150, 82);

            this.lblSubtotal.Name =
                "lblSubtotal";

            this.lblSubtotal.Size =
                new System.Drawing.Size(170, 24);

            this.lblSubtotal.TabIndex = 2;

            this.lblSubtotal.Text =
                "RD$ 0.00";

            this.lblSubtotal.TextAlign =
                System.Drawing.ContentAlignment.MiddleRight;

            // =====================================================
            // lblITBISTexto
            // =====================================================
            this.lblITBISTexto.AutoSize = true;

            this.lblITBISTexto.Font =
                new System.Drawing.Font("Segoe UI", 10F);

            this.lblITBISTexto.ForeColor =
                System.Drawing.Color.FromArgb(95, 105, 115);

            this.lblITBISTexto.Location =
                new System.Drawing.Point(25, 128);

            this.lblITBISTexto.Name =
                "lblITBISTexto";

            this.lblITBISTexto.Size =
                new System.Drawing.Size(77, 19);

            this.lblITBISTexto.TabIndex = 3;

            this.lblITBISTexto.Text =
                "ITBIS (18%)";

            // =====================================================
            // lblITBIS
            // =====================================================
            this.lblITBIS.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    11F,
                    System.Drawing.FontStyle.Bold
                );

            this.lblITBIS.ForeColor =
                System.Drawing.Color.FromArgb(45, 60, 75);

            this.lblITBIS.Location =
                new System.Drawing.Point(150, 125);

            this.lblITBIS.Name =
                "lblITBIS";

            this.lblITBIS.Size =
                new System.Drawing.Size(170, 24);

            this.lblITBIS.TabIndex = 4;

            this.lblITBIS.Text =
                "RD$ 0.00";

            this.lblITBIS.TextAlign =
                System.Drawing.ContentAlignment.MiddleRight;

            // =====================================================
            // panelLineaTotal
            // =====================================================
            this.panelLineaTotal.BackColor =
                System.Drawing.Color.FromArgb(228, 232, 236);

            this.panelLineaTotal.Location =
                new System.Drawing.Point(25, 180);

            this.panelLineaTotal.Name =
                "panelLineaTotal";

            this.panelLineaTotal.Size =
                new System.Drawing.Size(295, 1);

            this.panelLineaTotal.TabIndex = 5;

            // =====================================================
            // lblTotalTexto
            // =====================================================
            this.lblTotalTexto.AutoSize = true;

            this.lblTotalTexto.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    11F,
                    System.Drawing.FontStyle.Bold
                );

            this.lblTotalTexto.ForeColor =
                System.Drawing.Color.FromArgb(25, 45, 70);

            this.lblTotalTexto.Location =
                new System.Drawing.Point(25, 211);

            this.lblTotalTexto.Name =
                "lblTotalTexto";

            this.lblTotalTexto.Size =
                new System.Drawing.Size(53, 20);

            this.lblTotalTexto.TabIndex = 6;

            this.lblTotalTexto.Text =
                "TOTAL";

            // =====================================================
            // lblTotal
            // =====================================================
            this.lblTotal.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    24F,
                    System.Drawing.FontStyle.Bold
                );

            this.lblTotal.ForeColor =
                System.Drawing.Color.FromArgb(25, 125, 160);

            this.lblTotal.Location =
                new System.Drawing.Point(25, 240);

            this.lblTotal.Name =
                "lblTotal";

            this.lblTotal.Size =
                new System.Drawing.Size(295, 55);

            this.lblTotal.TabIndex = 7;

            this.lblTotal.Text =
                "RD$ 0.00";

            this.lblTotal.TextAlign =
                System.Drawing.ContentAlignment.MiddleRight;

            // =====================================================
            // lblAyudaTotal
            // =====================================================
            this.lblAyudaTotal.Font =
                new System.Drawing.Font("Segoe UI", 8.5F);

            this.lblAyudaTotal.ForeColor =
                System.Drawing.Color.FromArgb(135, 145, 155);

            this.lblAyudaTotal.Location =
                new System.Drawing.Point(25, 316);

            this.lblAyudaTotal.Name =
                "lblAyudaTotal";

            this.lblAyudaTotal.Size =
                new System.Drawing.Size(295, 44);

            this.lblAyudaTotal.TabIndex = 8;

            this.lblAyudaTotal.Text =
                "El total se calcula automáticamente al agregar o modificar artículos.";

            // =====================================================
            // panelBotones
            // =====================================================
            this.panelBotones.Anchor =
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;

            this.panelBotones.BackColor =
                System.Drawing.Color.White;

            this.panelBotones.Controls.Add(this.btnGuardarVenta);
            this.panelBotones.Controls.Add(this.btnCancelarVenta);
            this.panelBotones.Controls.Add(this.btnImprimirUltima);
            this.panelBotones.Controls.Add(this.btnCerrar);

            this.panelBotones.Location =
                new System.Drawing.Point(24, 691);

            this.panelBotones.Name =
                "panelBotones";

            this.panelBotones.Size =
                new System.Drawing.Size(1232, 72);

            this.panelBotones.TabIndex = 4;

            // =====================================================
            // btnGuardarVenta
            // =====================================================
            this.btnGuardarVenta.BackColor =
                System.Drawing.Color.FromArgb(25, 125, 160);

            this.btnGuardarVenta.Cursor =
                System.Windows.Forms.Cursors.Hand;

            this.btnGuardarVenta.FlatAppearance.BorderSize = 0;

            this.btnGuardarVenta.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnGuardarVenta.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold
                );

            this.btnGuardarVenta.ForeColor =
                System.Drawing.Color.White;

            this.btnGuardarVenta.Location =
                new System.Drawing.Point(20, 15);

            this.btnGuardarVenta.Name =
                "btnGuardarVenta";

            this.btnGuardarVenta.Size =
                new System.Drawing.Size(190, 42);

            this.btnGuardarVenta.TabIndex = 19;

            this.btnGuardarVenta.Text =
                "GUARDAR VENTA";

            this.btnGuardarVenta.UseVisualStyleBackColor =
                false;

            this.btnGuardarVenta.Click +=
                new System.EventHandler(
                    this.btnGuardarVenta_Click
                );

            // =====================================================
            // btnCancelarVenta
            // =====================================================
            this.btnCancelarVenta.BackColor =
                System.Drawing.Color.FromArgb(238, 241, 244);

            this.btnCancelarVenta.Cursor =
                System.Windows.Forms.Cursors.Hand;

            this.btnCancelarVenta.FlatAppearance.BorderSize = 0;

            this.btnCancelarVenta.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnCancelarVenta.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9.5F,
                    System.Drawing.FontStyle.Bold
                );

            this.btnCancelarVenta.ForeColor =
                System.Drawing.Color.FromArgb(80, 90, 100);

            this.btnCancelarVenta.Location =
                new System.Drawing.Point(220, 15);

            this.btnCancelarVenta.Name =
                "btnCancelarVenta";

            this.btnCancelarVenta.Size =
                new System.Drawing.Size(170, 42);

            this.btnCancelarVenta.TabIndex = 20;

            this.btnCancelarVenta.Text =
                "Cancelar venta";

            this.btnCancelarVenta.UseVisualStyleBackColor =
                false;

            this.btnCancelarVenta.Click +=
                new System.EventHandler(
                    this.btnCancelarVenta_Click
                );

            // =====================================================
            // btnImprimirUltima
            // =====================================================
            this.btnImprimirUltima.BackColor =
                System.Drawing.Color.FromArgb(40, 65, 90);

            this.btnImprimirUltima.Cursor =
                System.Windows.Forms.Cursors.Hand;

            this.btnImprimirUltima.Enabled = false;

            this.btnImprimirUltima.FlatAppearance.BorderSize = 0;

            this.btnImprimirUltima.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnImprimirUltima.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9.5F,
                    System.Drawing.FontStyle.Bold
                );

            this.btnImprimirUltima.ForeColor =
                System.Drawing.Color.White;

            this.btnImprimirUltima.Location =
                new System.Drawing.Point(400, 15);

            this.btnImprimirUltima.Name =
                "btnImprimirUltima";

            this.btnImprimirUltima.Size =
                new System.Drawing.Size(185, 42);

            this.btnImprimirUltima.TabIndex = 21;

            this.btnImprimirUltima.Text =
                "Reimprimir última";

            this.btnImprimirUltima.UseVisualStyleBackColor =
                false;

            this.btnImprimirUltima.Click +=
                new System.EventHandler(
                    this.btnImprimirUltima_Click
                );

            // =====================================================
            // btnCerrar
            // =====================================================
            this.btnCerrar.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Right;

            this.btnCerrar.BackColor =
                System.Drawing.Color.FromArgb(185, 55, 55);

            this.btnCerrar.Cursor =
                System.Windows.Forms.Cursors.Hand;

            this.btnCerrar.FlatAppearance.BorderSize = 0;

            this.btnCerrar.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnCerrar.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9.5F,
                    System.Drawing.FontStyle.Bold
                );

            this.btnCerrar.ForeColor =
                System.Drawing.Color.White;

            this.btnCerrar.Location =
                new System.Drawing.Point(1075, 15);

            this.btnCerrar.Name =
                "btnCerrar";

            this.btnCerrar.Size =
                new System.Drawing.Size(135, 42);

            this.btnCerrar.TabIndex = 22;

            this.btnCerrar.Text =
                "Cerrar";

            this.btnCerrar.UseVisualStyleBackColor =
                false;

            this.btnCerrar.Click +=
                new System.EventHandler(
                    this.btnCerrar_Click
                );

            // =====================================================
            // frmVentas
            // =====================================================
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(7F, 15F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.BackColor =
                System.Drawing.Color.FromArgb(241, 244, 247);

            this.ClientSize =
                new System.Drawing.Size(1280, 780);

            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.panelTotales);
            this.Controls.Add(this.panelDetalle);
            this.Controls.Add(this.panelDatosFactura);
            this.Controls.Add(this.panelSuperior);

            this.Font =
                new System.Drawing.Font("Segoe UI", 9F);

            this.MinimumSize =
                new System.Drawing.Size(1180, 720);

            this.Name = "frmVentas";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text =
                "Israel Papelería | Punto de Venta";

            this.WindowState =
                System.Windows.Forms.FormWindowState.Maximized;

            this.Load +=
                new System.EventHandler(
                    this.frmVentas_Load
                );

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