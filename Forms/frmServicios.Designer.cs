using System.Drawing;
using System.Windows.Forms;

namespace WalkiriaPapeleria.Forms
{
    partial class frmServicios
    {
        private System.ComponentModel.IContainer components = null;

        private Panel panelSuperior;
        private Label lblTituloFormulario;
        private Label lblSubtitulo;
        private Label lblTotal;

        private Panel panelBusqueda;
        private Label lblBuscar;
        private TextBox txtBuscar;

        private DataGridView dgvServicios;

        private Panel panelBotones;
        private Button btnNuevo;
        private Button btnEditar;
        private Button btnEliminar;

        private Panel panelDatos;
        private Label lblTituloDatos;

        private Label lblNombre;
        private TextBox txtNombre;

        private Label lblDescripcion;
        private TextBox txtDescripcion;

        private Label lblPrecio;
        private TextBox txtPrecio;

        private Label lblEstado;
        private ComboBox cmbEstado;

        private Panel panelAcciones;
        private Button btnGuardar;
        private Button btnCancelar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelSuperior = new Panel();
            this.lblTituloFormulario = new Label();
            this.lblSubtitulo = new Label();
            this.lblTotal = new Label();

            this.panelBusqueda = new Panel();
            this.lblBuscar = new Label();
            this.txtBuscar = new TextBox();

            this.dgvServicios = new DataGridView();

            this.panelBotones = new Panel();
            this.btnNuevo = new Button();
            this.btnEditar = new Button();
            this.btnEliminar = new Button();

            this.panelDatos = new Panel();
            this.lblTituloDatos = new Label();
            this.lblNombre = new Label();
            this.txtNombre = new TextBox();
            this.lblDescripcion = new Label();
            this.txtDescripcion = new TextBox();
            this.lblPrecio = new Label();
            this.txtPrecio = new TextBox();
            this.lblEstado = new Label();
            this.cmbEstado = new ComboBox();

            this.panelAcciones = new Panel();
            this.btnGuardar = new Button();
            this.btnCancelar = new Button();

            this.panelSuperior.SuspendLayout();
            this.panelBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).BeginInit();
            this.panelBotones.SuspendLayout();
            this.panelDatos.SuspendLayout();
            this.panelAcciones.SuspendLayout();
            this.SuspendLayout();

            // =====================================================
            // panelSuperior
            // =====================================================
            this.panelSuperior.BackColor =
                System.Drawing.Color.FromArgb(15, 38, 71);

            this.panelSuperior.Controls.Add(this.lblTituloFormulario);
            this.panelSuperior.Controls.Add(this.lblSubtitulo);
            this.panelSuperior.Controls.Add(this.lblTotal);

            this.panelSuperior.Dock =
                System.Windows.Forms.DockStyle.Top;

            this.panelSuperior.Location =
                new System.Drawing.Point(0, 0);

            this.panelSuperior.Name =
                "panelSuperior";

            this.panelSuperior.Size =
                new System.Drawing.Size(1280, 92);

            this.panelSuperior.TabIndex = 0;

            // =====================================================
            // lblTituloFormulario
            // =====================================================
            this.lblTituloFormulario.AutoSize = true;

            this.lblTituloFormulario.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    22F,
                    System.Drawing.FontStyle.Bold
                );

            this.lblTituloFormulario.ForeColor =
                System.Drawing.Color.White;

            this.lblTituloFormulario.Location =
                new System.Drawing.Point(28, 16);

            this.lblTituloFormulario.Name =
                "lblTituloFormulario";

            this.lblTituloFormulario.Size =
                new System.Drawing.Size(319, 41);

            this.lblTituloFormulario.TabIndex = 0;

            this.lblTituloFormulario.Text =
                "Gestión de Servicios";

            // =====================================================
            // lblSubtitulo
            // =====================================================
            this.lblSubtitulo.AutoSize = true;

            this.lblSubtitulo.Font =
                new System.Drawing.Font("Segoe UI", 9.5F);

            this.lblSubtitulo.ForeColor =
                System.Drawing.Color.FromArgb(170, 195, 220);

            this.lblSubtitulo.Location =
                new System.Drawing.Point(31, 60);

            this.lblSubtitulo.Name =
                "lblSubtitulo";

            this.lblSubtitulo.Size =
                new System.Drawing.Size(322, 17);

            this.lblSubtitulo.TabIndex = 1;

            this.lblSubtitulo.Text =
                "Servicios • Precios • Estado • Disponibilidad";

            // =====================================================
            // lblTotal
            // =====================================================
            this.lblTotal.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Right;

            this.lblTotal.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    11F,
                    System.Drawing.FontStyle.Bold
                );

            this.lblTotal.ForeColor =
                System.Drawing.Color.White;

            this.lblTotal.Location =
                new System.Drawing.Point(930, 32);

            this.lblTotal.Name =
                "lblTotal";

            this.lblTotal.Size =
                new System.Drawing.Size(320, 25);

            this.lblTotal.TabIndex = 2;

            this.lblTotal.Text =
                "Total: 0 servicios";

            this.lblTotal.TextAlign =
                System.Drawing.ContentAlignment.MiddleRight;

            // =====================================================
            // panelBusqueda
            // =====================================================
            this.panelBusqueda.BackColor =
                System.Drawing.Color.White;

            this.panelBusqueda.Controls.Add(this.lblBuscar);
            this.panelBusqueda.Controls.Add(this.txtBuscar);

            this.panelBusqueda.Location =
                new System.Drawing.Point(24, 115);

            this.panelBusqueda.Name =
                "panelBusqueda";

            this.panelBusqueda.Size =
                new System.Drawing.Size(430, 52);

            this.panelBusqueda.TabIndex = 1;

            // =====================================================
            // lblBuscar
            // =====================================================
            this.lblBuscar.AutoSize = true;

            this.lblBuscar.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold
                );

            this.lblBuscar.ForeColor =
                System.Drawing.Color.FromArgb(90, 100, 110);

            this.lblBuscar.Location =
                new System.Drawing.Point(15, 17);

            this.lblBuscar.Name =
                "lblBuscar";

            this.lblBuscar.Size =
                new System.Drawing.Size(50, 15);

            this.lblBuscar.TabIndex = 0;

            this.lblBuscar.Text =
                "BUSCAR";

            // =====================================================
            // txtBuscar
            // =====================================================
            this.txtBuscar.BorderStyle =
                System.Windows.Forms.BorderStyle.None;

            this.txtBuscar.Font =
                new System.Drawing.Font("Segoe UI", 10.5F);

            this.txtBuscar.ForeColor =
                System.Drawing.Color.Gray;

            this.txtBuscar.Location =
                new System.Drawing.Point(85, 15);

            this.txtBuscar.Name =
                "txtBuscar";

            this.txtBuscar.Size =
                new System.Drawing.Size(320, 19);

            this.txtBuscar.TabIndex = 1;

            this.txtBuscar.Text =
                "Buscar...";

            this.txtBuscar.TextChanged +=
                new System.EventHandler(
                    this.txtBuscar_TextChanged
                );

            // =====================================================
            // dgvServicios
            // =====================================================
            this.dgvServicios.AllowUserToAddRows = false;
            this.dgvServicios.AllowUserToDeleteRows = false;
            this.dgvServicios.AllowUserToResizeRows = false;

            this.dgvServicios.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Bottom |
                AnchorStyles.Left |
                AnchorStyles.Right;

            this.dgvServicios.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvServicios.BackgroundColor =
                System.Drawing.Color.White;

            this.dgvServicios.BorderStyle =
                System.Windows.Forms.BorderStyle.None;

            this.dgvServicios.CellBorderStyle =
                DataGridViewCellBorderStyle.SingleHorizontal;

            this.dgvServicios.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.None;

            this.dgvServicios.ColumnHeadersDefaultCellStyle.BackColor =
                System.Drawing.Color.FromArgb(25, 45, 70);

            this.dgvServicios.ColumnHeadersDefaultCellStyle.ForeColor =
                System.Drawing.Color.White;

            this.dgvServicios.ColumnHeadersDefaultCellStyle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9.5F,
                    System.Drawing.FontStyle.Bold
                );

            this.dgvServicios.ColumnHeadersDefaultCellStyle.SelectionBackColor =
                System.Drawing.Color.FromArgb(25, 45, 70);

            this.dgvServicios.ColumnHeadersDefaultCellStyle.SelectionForeColor =
                System.Drawing.Color.White;

            this.dgvServicios.ColumnHeadersHeight = 42;

            this.dgvServicios.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            this.dgvServicios.DefaultCellStyle.BackColor =
                System.Drawing.Color.White;

            this.dgvServicios.DefaultCellStyle.ForeColor =
                System.Drawing.Color.FromArgb(55, 65, 75);

            this.dgvServicios.DefaultCellStyle.Font =
                new System.Drawing.Font("Segoe UI", 9.5F);

            this.dgvServicios.DefaultCellStyle.SelectionBackColor =
                System.Drawing.Color.FromArgb(220, 235, 244);

            this.dgvServicios.DefaultCellStyle.SelectionForeColor =
                System.Drawing.Color.FromArgb(25, 45, 70);

            this.dgvServicios.GridColor =
                System.Drawing.Color.FromArgb(232, 236, 240);

            this.dgvServicios.Location =
                new System.Drawing.Point(24, 185);

            this.dgvServicios.MultiSelect = false;

            this.dgvServicios.Name =
                "dgvServicios";

            this.dgvServicios.ReadOnly = true;

            this.dgvServicios.RowHeadersVisible = false;

            this.dgvServicios.RowTemplate.Height = 36;

            this.dgvServicios.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            this.dgvServicios.Size =
                new System.Drawing.Size(820, 440);

            this.dgvServicios.TabIndex = 2;

            this.dgvServicios.SelectionChanged +=
                new System.EventHandler(
                    this.dgvServicios_SelectionChanged
                );

            // =====================================================
            // panelBotones
            // =====================================================
            this.panelBotones.Anchor =
                AnchorStyles.Bottom |
                AnchorStyles.Left |
                AnchorStyles.Right;

            this.panelBotones.BackColor =
                System.Drawing.Color.White;

            this.panelBotones.Controls.Add(this.btnNuevo);
            this.panelBotones.Controls.Add(this.btnEditar);
            this.panelBotones.Controls.Add(this.btnEliminar);

            this.panelBotones.Location =
                new System.Drawing.Point(24, 640);

            this.panelBotones.Name =
                "panelBotones";

            this.panelBotones.Size =
                new System.Drawing.Size(820, 74);

            this.panelBotones.TabIndex = 3;

            // =====================================================
            // btnNuevo
            // =====================================================
            this.btnNuevo.BackColor =
                System.Drawing.Color.FromArgb(25, 125, 160);

            this.btnNuevo.Cursor =
                System.Windows.Forms.Cursors.Hand;

            this.btnNuevo.FlatAppearance.BorderSize = 0;

            this.btnNuevo.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnNuevo.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold
                );

            this.btnNuevo.ForeColor =
                System.Drawing.Color.White;

            this.btnNuevo.Location =
                new System.Drawing.Point(18, 15);

            this.btnNuevo.Name =
                "btnNuevo";

            this.btnNuevo.Size =
                new System.Drawing.Size(150, 42);

            this.btnNuevo.TabIndex = 0;

            this.btnNuevo.Text =
                "Nuevo Servicio";

            this.btnNuevo.UseVisualStyleBackColor =
                false;

            this.btnNuevo.Click +=
                new System.EventHandler(
                    this.btnNuevo_Click
                );

            // =====================================================
            // btnEditar
            // =====================================================
            this.btnEditar.BackColor =
                System.Drawing.Color.FromArgb(238, 241, 244);

            this.btnEditar.Cursor =
                System.Windows.Forms.Cursors.Hand;

            this.btnEditar.FlatAppearance.BorderSize = 0;

            this.btnEditar.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnEditar.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold
                );

            this.btnEditar.ForeColor =
                System.Drawing.Color.FromArgb(60, 75, 90);

            this.btnEditar.Location =
                new System.Drawing.Point(180, 15);

            this.btnEditar.Name =
                "btnEditar";

            this.btnEditar.Size =
                new System.Drawing.Size(130, 42);

            this.btnEditar.TabIndex = 1;

            this.btnEditar.Text =
                "Editar";

            this.btnEditar.UseVisualStyleBackColor =
                false;

            this.btnEditar.Click +=
                new System.EventHandler(
                    this.btnEditar_Click
                );

            // =====================================================
            // btnEliminar
            // =====================================================
            this.btnEliminar.BackColor =
                System.Drawing.Color.FromArgb(185, 55, 55);

            this.btnEliminar.Cursor =
                System.Windows.Forms.Cursors.Hand;

            this.btnEliminar.FlatAppearance.BorderSize = 0;

            this.btnEliminar.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnEliminar.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold
                );

            this.btnEliminar.ForeColor =
                System.Drawing.Color.White;

            this.btnEliminar.Location =
                new System.Drawing.Point(322, 15);

            this.btnEliminar.Name =
                "btnEliminar";

            this.btnEliminar.Size =
                new System.Drawing.Size(130, 42);

            this.btnEliminar.TabIndex = 2;

            this.btnEliminar.Text =
                "Eliminar";

            this.btnEliminar.UseVisualStyleBackColor =
                false;

            this.btnEliminar.Click +=
                new System.EventHandler(
                    this.btnEliminar_Click
                );

            // =====================================================
            // panelDatos
            // =====================================================
            this.panelDatos.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Bottom |
                AnchorStyles.Right;

            this.panelDatos.BackColor =
                System.Drawing.Color.White;

            this.panelDatos.Controls.Add(this.lblTituloDatos);
            this.panelDatos.Controls.Add(this.lblNombre);
            this.panelDatos.Controls.Add(this.txtNombre);
            this.panelDatos.Controls.Add(this.lblDescripcion);
            this.panelDatos.Controls.Add(this.txtDescripcion);
            this.panelDatos.Controls.Add(this.lblPrecio);
            this.panelDatos.Controls.Add(this.txtPrecio);
            this.panelDatos.Controls.Add(this.lblEstado);
            this.panelDatos.Controls.Add(this.cmbEstado);

            this.panelDatos.Location =
                new System.Drawing.Point(870, 115);

            this.panelDatos.Name =
                "panelDatos";

            this.panelDatos.Size =
                new System.Drawing.Size(386, 510);

            this.panelDatos.TabIndex = 4;

            // =====================================================
            // lblTituloDatos
            // =====================================================
            this.lblTituloDatos.AutoSize = true;

            this.lblTituloDatos.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    14F,
                    System.Drawing.FontStyle.Bold
                );

            this.lblTituloDatos.ForeColor =
                System.Drawing.Color.FromArgb(25, 45, 70);

            this.lblTituloDatos.Location =
                new System.Drawing.Point(25, 22);

            this.lblTituloDatos.Name =
                "lblTituloDatos";

            this.lblTituloDatos.Size =
                new System.Drawing.Size(188, 25);

            this.lblTituloDatos.TabIndex = 0;

            this.lblTituloDatos.Text =
                "Datos del servicio";

            // =====================================================
            // lblNombre
            // =====================================================
            this.lblNombre.AutoSize = true;

            this.lblNombre.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold
                );

            this.lblNombre.ForeColor =
                System.Drawing.Color.FromArgb(90, 100, 110);

            this.lblNombre.Location =
                new System.Drawing.Point(25, 75);

            this.lblNombre.Name =
                "lblNombre";

            this.lblNombre.Size =
                new System.Drawing.Size(58, 15);

            this.lblNombre.TabIndex = 1;

            this.lblNombre.Text =
                "NOMBRE";

            // =====================================================
            // txtNombre
            // =====================================================
            this.txtNombre.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.txtNombre.Enabled = false;

            this.txtNombre.Font =
                new System.Drawing.Font("Segoe UI", 10.5F);

            this.txtNombre.Location =
                new System.Drawing.Point(25, 97);

            this.txtNombre.Name =
                "txtNombre";

            this.txtNombre.Size =
                new System.Drawing.Size(335, 26);

            this.txtNombre.TabIndex = 1;

            // =====================================================
            // lblDescripcion
            // =====================================================
            this.lblDescripcion.AutoSize = true;

            this.lblDescripcion.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold
                );

            this.lblDescripcion.ForeColor =
                System.Drawing.Color.FromArgb(90, 100, 110);

            this.lblDescripcion.Location =
                new System.Drawing.Point(25, 145);

            this.lblDescripcion.Name =
                "lblDescripcion";

            this.lblDescripcion.Size =
                new System.Drawing.Size(84, 15);

            this.lblDescripcion.TabIndex = 2;

            this.lblDescripcion.Text =
                "DESCRIPCIÓN";

            // =====================================================
            // txtDescripcion
            // =====================================================
            this.txtDescripcion.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.txtDescripcion.Enabled = false;

            this.txtDescripcion.Font =
                new System.Drawing.Font("Segoe UI", 10F);

            this.txtDescripcion.Location =
                new System.Drawing.Point(25, 167);

            this.txtDescripcion.Multiline = true;

            this.txtDescripcion.Name =
                "txtDescripcion";

            this.txtDescripcion.ScrollBars =
                System.Windows.Forms.ScrollBars.Vertical;

            this.txtDescripcion.Size =
                new System.Drawing.Size(335, 90);

            this.txtDescripcion.TabIndex = 2;

            // =====================================================
            // lblPrecio
            // =====================================================
            this.lblPrecio.AutoSize = true;

            this.lblPrecio.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold
                );

            this.lblPrecio.ForeColor =
                System.Drawing.Color.FromArgb(90, 100, 110);

            this.lblPrecio.Location =
                new System.Drawing.Point(25, 285);

            this.lblPrecio.Name =
                "lblPrecio";

            this.lblPrecio.Size =
                new System.Drawing.Size(77, 15);

            this.lblPrecio.TabIndex = 3;

            this.lblPrecio.Text =
                "PRECIO RD$";

            // =====================================================
            // txtPrecio
            // =====================================================
            this.txtPrecio.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.txtPrecio.Enabled = false;

            this.txtPrecio.Font =
                new System.Drawing.Font("Segoe UI", 10.5F);

            this.txtPrecio.Location =
                new System.Drawing.Point(25, 307);

            this.txtPrecio.Name =
                "txtPrecio";

            this.txtPrecio.Size =
                new System.Drawing.Size(335, 26);

            this.txtPrecio.TabIndex = 3;

            this.txtPrecio.KeyPress +=
                new System.Windows.Forms.KeyPressEventHandler(
                    this.txtPrecio_KeyPress
                );

            // =====================================================
            // lblEstado
            // =====================================================
            this.lblEstado.AutoSize = true;

            this.lblEstado.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold
                );

            this.lblEstado.ForeColor =
                System.Drawing.Color.FromArgb(90, 100, 110);

            this.lblEstado.Location =
                new System.Drawing.Point(25, 360);

            this.lblEstado.Name =
                "lblEstado";

            this.lblEstado.Size =
                new System.Drawing.Size(54, 15);

            this.lblEstado.TabIndex = 4;

            this.lblEstado.Text =
                "ESTADO";

            // =====================================================
            // cmbEstado
            // =====================================================
            this.cmbEstado.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cmbEstado.Enabled = false;

            this.cmbEstado.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.cmbEstado.Font =
                new System.Drawing.Font("Segoe UI", 10.5F);

            this.cmbEstado.FormattingEnabled = true;

            this.cmbEstado.Location =
                new System.Drawing.Point(25, 382);

            this.cmbEstado.Name =
                "cmbEstado";

            this.cmbEstado.Size =
                new System.Drawing.Size(335, 27);

            this.cmbEstado.TabIndex = 4;

            // =====================================================
            // panelAcciones
            // =====================================================
            this.panelAcciones.Anchor =
                AnchorStyles.Bottom |
                AnchorStyles.Right;

            this.panelAcciones.BackColor =
                System.Drawing.Color.White;

            this.panelAcciones.Controls.Add(this.btnGuardar);
            this.panelAcciones.Controls.Add(this.btnCancelar);

            this.panelAcciones.Location =
                new System.Drawing.Point(870, 640);

            this.panelAcciones.Name =
                "panelAcciones";

            this.panelAcciones.Size =
                new System.Drawing.Size(386, 74);

            this.panelAcciones.TabIndex = 5;

            // =====================================================
            // btnGuardar
            // =====================================================
            this.btnGuardar.BackColor =
                System.Drawing.Color.FromArgb(25, 125, 160);

            this.btnGuardar.Cursor =
                System.Windows.Forms.Cursors.Hand;

            this.btnGuardar.Enabled = false;

            this.btnGuardar.FlatAppearance.BorderSize = 0;

            this.btnGuardar.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnGuardar.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold
                );

            this.btnGuardar.ForeColor =
                System.Drawing.Color.White;

            this.btnGuardar.Location =
                new System.Drawing.Point(25, 15);

            this.btnGuardar.Name =
                "btnGuardar";

            this.btnGuardar.Size =
                new System.Drawing.Size(160, 42);

            this.btnGuardar.TabIndex = 0;

            this.btnGuardar.Text =
                "Guardar";

            this.btnGuardar.UseVisualStyleBackColor =
                false;

            this.btnGuardar.Click +=
                new System.EventHandler(
                    this.btnGuardar_Click
                );

            // =====================================================
            // btnCancelar
            // =====================================================
            this.btnCancelar.BackColor =
                System.Drawing.Color.FromArgb(238, 241, 244);

            this.btnCancelar.Cursor =
                System.Windows.Forms.Cursors.Hand;

            this.btnCancelar.Enabled = false;

            this.btnCancelar.FlatAppearance.BorderSize = 0;

            this.btnCancelar.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnCancelar.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold
                );

            this.btnCancelar.ForeColor =
                System.Drawing.Color.FromArgb(70, 80, 90);

            this.btnCancelar.Location =
                new System.Drawing.Point(200, 15);

            this.btnCancelar.Name =
                "btnCancelar";

            this.btnCancelar.Size =
                new System.Drawing.Size(160, 42);

            this.btnCancelar.TabIndex = 1;

            this.btnCancelar.Text =
                "Cancelar";

            this.btnCancelar.UseVisualStyleBackColor =
                false;

            this.btnCancelar.Click +=
                new System.EventHandler(
                    this.btnCancelar_Click
                );

            // =====================================================
            // frmServicios
            // =====================================================
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(7F, 15F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.BackColor =
                System.Drawing.Color.FromArgb(241, 244, 247);

            this.ClientSize =
                new System.Drawing.Size(1280, 740);

            this.Controls.Add(this.panelAcciones);
            this.Controls.Add(this.panelDatos);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.dgvServicios);
            this.Controls.Add(this.panelBusqueda);
            this.Controls.Add(this.panelSuperior);

            this.Font =
                new System.Drawing.Font("Segoe UI", 9F);

            this.MinimumSize =
                new System.Drawing.Size(1100, 650);

            this.Name =
                "frmServicios";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text =
                "Israel Papelería | Gestión de Servicios";

            this.WindowState =
                System.Windows.Forms.FormWindowState.Maximized;

            this.Load +=
                new System.EventHandler(
                    this.frmServicios_Load
                );

            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();

            this.panelBusqueda.ResumeLayout(false);
            this.panelBusqueda.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).EndInit();

            this.panelBotones.ResumeLayout(false);

            this.panelDatos.ResumeLayout(false);
            this.panelDatos.PerformLayout();

            this.panelAcciones.ResumeLayout(false);

            this.ResumeLayout(false);
        }
    }
}