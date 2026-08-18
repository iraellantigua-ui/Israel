using System.Drawing;
using System.Windows.Forms;

namespace WalkiriaPapeleria.Forms
{
    partial class frmClientes
    {
        private System.ComponentModel.IContainer components = null;

        private Panel panelSuperior;
        private Label lblTituloFormulario;
        private Label lblSubtitulo;
        private Label lblTotal;

        private Panel panelBusqueda;
        private Label lblBuscar;
        private TextBox txtBuscar;

        private DataGridView dgvClientes;

        private Panel panelBotones;
        private Button btnNuevo;
        private Button btnEditar;
        private Button btnEliminar;

        private Panel panelDatos;
        private Label lblTituloDatos;

        private Label lblCedula;
        private TextBox txtCedula;

        private Label lblNombre;
        private TextBox txtNombre;

        private Label lblApellido;
        private TextBox txtApellido;

        private Label lblTelefono;
        private TextBox txtTelefono;

        private Label lblCorreo;
        private TextBox txtCorreo;

        private Label lblDireccion;
        private TextBox txtDireccion;

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

            this.dgvClientes = new DataGridView();

            this.panelBotones = new Panel();
            this.btnNuevo = new Button();
            this.btnEditar = new Button();
            this.btnEliminar = new Button();

            this.panelDatos = new Panel();
            this.lblTituloDatos = new Label();
            this.lblCedula = new Label();
            this.txtCedula = new TextBox();
            this.lblNombre = new Label();
            this.txtNombre = new TextBox();
            this.lblApellido = new Label();
            this.txtApellido = new TextBox();
            this.lblTelefono = new Label();
            this.txtTelefono = new TextBox();
            this.lblCorreo = new Label();
            this.txtCorreo = new TextBox();
            this.lblDireccion = new Label();
            this.txtDireccion = new TextBox();

            this.panelAcciones = new Panel();
            this.btnGuardar = new Button();
            this.btnCancelar = new Button();

            this.panelSuperior.SuspendLayout();
            this.panelBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.panelBotones.SuspendLayout();
            this.panelDatos.SuspendLayout();
            this.panelAcciones.SuspendLayout();
            this.SuspendLayout();

            // =====================================================
            // panelSuperior
            // =====================================================
            this.panelSuperior.BackColor = Color.FromArgb(15, 38, 71);
            this.panelSuperior.Controls.Add(this.lblTituloFormulario);
            this.panelSuperior.Controls.Add(this.lblSubtitulo);
            this.panelSuperior.Controls.Add(this.lblTotal);
            this.panelSuperior.Dock = DockStyle.Top;
            this.panelSuperior.Location = new Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new Size(1280, 92);
            this.panelSuperior.TabIndex = 0;

            // =====================================================
            // lblTituloFormulario
            // =====================================================
            this.lblTituloFormulario.AutoSize = true;
            this.lblTituloFormulario.Font =
                new Font("Segoe UI", 22F, FontStyle.Bold);

            this.lblTituloFormulario.ForeColor = Color.White;
            this.lblTituloFormulario.Location = new Point(28, 16);
            this.lblTituloFormulario.Name = "lblTituloFormulario";
            this.lblTituloFormulario.Size = new Size(318, 41);
            this.lblTituloFormulario.TabIndex = 0;
            this.lblTituloFormulario.Text = "Gestión de Clientes";

            // =====================================================
            // lblSubtitulo
            // =====================================================
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new Font("Segoe UI", 9.5F);
            this.lblSubtitulo.ForeColor = Color.FromArgb(170, 195, 220);
            this.lblSubtitulo.Location = new Point(31, 60);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new Size(356, 17);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text =
                "Clientes • Contacto • Dirección • Historial de registro";

            // =====================================================
            // lblTotal
            // =====================================================
            this.lblTotal.Anchor =
                AnchorStyles.Top | AnchorStyles.Right;

            this.lblTotal.Font =
                new Font("Segoe UI", 11F, FontStyle.Bold);

            this.lblTotal.ForeColor = Color.White;
            this.lblTotal.Location = new Point(930, 32);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new Size(320, 25);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total: 0 clientes";
            this.lblTotal.TextAlign = ContentAlignment.MiddleRight;

            // =====================================================
            // panelBusqueda
            // =====================================================
            this.panelBusqueda.BackColor = Color.White;
            this.panelBusqueda.Controls.Add(this.lblBuscar);
            this.panelBusqueda.Controls.Add(this.txtBuscar);
            this.panelBusqueda.Location = new Point(24, 115);
            this.panelBusqueda.Name = "panelBusqueda";
            this.panelBusqueda.Size = new Size(500, 52);
            this.panelBusqueda.TabIndex = 1;

            // =====================================================
            // lblBuscar
            // =====================================================
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font =
                new Font("Segoe UI", 9F, FontStyle.Bold);

            this.lblBuscar.ForeColor = Color.FromArgb(90, 100, 110);
            this.lblBuscar.Location = new Point(15, 17);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new Size(50, 15);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "BUSCAR";

            // =====================================================
            // txtBuscar
            // =====================================================
            this.txtBuscar.BorderStyle = BorderStyle.None;
            this.txtBuscar.Font = new Font("Segoe UI", 10.5F);
            this.txtBuscar.ForeColor = Color.Gray;
            this.txtBuscar.Location = new Point(85, 15);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new Size(390, 19);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.Text = "Buscar por nombre o cédula...";
            this.txtBuscar.TextChanged +=
                new System.EventHandler(this.txtBuscar_TextChanged);

            // =====================================================
            // dgvClientes
            // =====================================================
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToResizeRows = false;

            this.dgvClientes.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Bottom |
                AnchorStyles.Left |
                AnchorStyles.Right;

            this.dgvClientes.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvClientes.BackgroundColor = Color.White;
            this.dgvClientes.BorderStyle = BorderStyle.None;
            this.dgvClientes.CellBorderStyle =
                DataGridViewCellBorderStyle.SingleHorizontal;

            this.dgvClientes.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.None;

            this.dgvClientes.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(25, 45, 70);

            this.dgvClientes.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            this.dgvClientes.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 9.5F, FontStyle.Bold);

            this.dgvClientes.ColumnHeadersDefaultCellStyle.SelectionBackColor =
                Color.FromArgb(25, 45, 70);

            this.dgvClientes.ColumnHeadersDefaultCellStyle.SelectionForeColor =
                Color.White;

            this.dgvClientes.ColumnHeadersHeight = 42;
            this.dgvClientes.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            this.dgvClientes.DefaultCellStyle.BackColor = Color.White;
            this.dgvClientes.DefaultCellStyle.ForeColor =
                Color.FromArgb(55, 65, 75);

            this.dgvClientes.DefaultCellStyle.Font =
                new Font("Segoe UI", 9.5F);

            this.dgvClientes.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(220, 235, 244);

            this.dgvClientes.DefaultCellStyle.SelectionForeColor =
                Color.FromArgb(25, 45, 70);

            this.dgvClientes.GridColor =
                Color.FromArgb(232, 236, 240);

            this.dgvClientes.Location = new Point(24, 185);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.RowTemplate.Height = 36;
            this.dgvClientes.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            this.dgvClientes.Size = new Size(820, 440);
            this.dgvClientes.TabIndex = 2;

            this.dgvClientes.SelectionChanged +=
                new System.EventHandler(
                    this.dgvClientes_SelectionChanged
                );

            // =====================================================
            // panelBotones
            // =====================================================
            this.panelBotones.Anchor =
                AnchorStyles.Bottom |
                AnchorStyles.Left |
                AnchorStyles.Right;

            this.panelBotones.BackColor = Color.White;
            this.panelBotones.Controls.Add(this.btnNuevo);
            this.panelBotones.Controls.Add(this.btnEditar);
            this.panelBotones.Controls.Add(this.btnEliminar);
            this.panelBotones.Location = new Point(24, 640);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new Size(820, 74);
            this.panelBotones.TabIndex = 3;

            // =====================================================
            // btnNuevo
            // =====================================================
            this.btnNuevo.BackColor = Color.FromArgb(25, 125, 160);
            this.btnNuevo.Cursor = Cursors.Hand;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = FlatStyle.Flat;
            this.btnNuevo.Font =
                new Font("Segoe UI", 10F, FontStyle.Bold);

            this.btnNuevo.ForeColor = Color.White;
            this.btnNuevo.Location = new Point(18, 15);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new Size(150, 42);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo Cliente";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click +=
                new System.EventHandler(this.btnNuevo_Click);

            // =====================================================
            // btnEditar
            // =====================================================
            this.btnEditar.BackColor = Color.FromArgb(238, 241, 244);
            this.btnEditar.Cursor = Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = FlatStyle.Flat;
            this.btnEditar.Font =
                new Font("Segoe UI", 10F, FontStyle.Bold);

            this.btnEditar.ForeColor = Color.FromArgb(60, 75, 90);
            this.btnEditar.Location = new Point(180, 15);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new Size(130, 42);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click +=
                new System.EventHandler(this.btnEditar_Click);

            // =====================================================
            // btnEliminar
            // =====================================================
            this.btnEliminar.BackColor = Color.FromArgb(185, 55, 55);
            this.btnEliminar.Cursor = Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = FlatStyle.Flat;
            this.btnEliminar.Font =
                new Font("Segoe UI", 10F, FontStyle.Bold);

            this.btnEliminar.ForeColor = Color.White;
            this.btnEliminar.Location = new Point(322, 15);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new Size(130, 42);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click +=
                new System.EventHandler(this.btnEliminar_Click);

            // =====================================================
            // panelDatos
            // =====================================================
            this.panelDatos.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Bottom |
                AnchorStyles.Right;

            this.panelDatos.BackColor = Color.White;
            this.panelDatos.Controls.Add(this.lblTituloDatos);
            this.panelDatos.Controls.Add(this.lblCedula);
            this.panelDatos.Controls.Add(this.txtCedula);
            this.panelDatos.Controls.Add(this.lblNombre);
            this.panelDatos.Controls.Add(this.txtNombre);
            this.panelDatos.Controls.Add(this.lblApellido);
            this.panelDatos.Controls.Add(this.txtApellido);
            this.panelDatos.Controls.Add(this.lblTelefono);
            this.panelDatos.Controls.Add(this.txtTelefono);
            this.panelDatos.Controls.Add(this.lblCorreo);
            this.panelDatos.Controls.Add(this.txtCorreo);
            this.panelDatos.Controls.Add(this.lblDireccion);
            this.panelDatos.Controls.Add(this.txtDireccion);

            this.panelDatos.Location = new Point(870, 115);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new Size(386, 510);
            this.panelDatos.TabIndex = 4;

            // =====================================================
            // lblTituloDatos
            // =====================================================
            this.lblTituloDatos.AutoSize = true;
            this.lblTituloDatos.Font =
                new Font("Segoe UI", 14F, FontStyle.Bold);

            this.lblTituloDatos.ForeColor = Color.FromArgb(25, 45, 70);
            this.lblTituloDatos.Location = new Point(25, 22);
            this.lblTituloDatos.Name = "lblTituloDatos";
            this.lblTituloDatos.Size = new Size(176, 25);
            this.lblTituloDatos.TabIndex = 0;
            this.lblTituloDatos.Text = "Datos del cliente";

            // =====================================================
            // lblCedula
            // =====================================================
            this.lblCedula.AutoSize = true;
            this.lblCedula.Font =
                new Font("Segoe UI", 9F, FontStyle.Bold);

            this.lblCedula.ForeColor = Color.FromArgb(90, 100, 110);
            this.lblCedula.Location = new Point(25, 70);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new Size(54, 15);
            this.lblCedula.Text = "CÉDULA";

            // =====================================================
            // txtCedula
            // =====================================================
            this.txtCedula.BorderStyle = BorderStyle.FixedSingle;
            this.txtCedula.Enabled = false;
            this.txtCedula.Font = new Font("Segoe UI", 10.5F);
            this.txtCedula.Location = new Point(25, 92);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new Size(335, 26);
            this.txtCedula.TabIndex = 1;

            // =====================================================
            // lblNombre
            // =====================================================
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font =
                new Font("Segoe UI", 9F, FontStyle.Bold);

            this.lblNombre.ForeColor = Color.FromArgb(90, 100, 110);
            this.lblNombre.Location = new Point(25, 138);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new Size(58, 15);
            this.lblNombre.Text = "NOMBRE";

            // =====================================================
            // txtNombre
            // =====================================================
            this.txtNombre.BorderStyle = BorderStyle.FixedSingle;
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new Font("Segoe UI", 10.5F);
            this.txtNombre.Location = new Point(25, 160);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new Size(160, 26);
            this.txtNombre.TabIndex = 2;

            // =====================================================
            // lblApellido
            // =====================================================
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font =
                new Font("Segoe UI", 9F, FontStyle.Bold);

            this.lblApellido.ForeColor = Color.FromArgb(90, 100, 110);
            this.lblApellido.Location = new Point(200, 138);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new Size(64, 15);
            this.lblApellido.Text = "APELLIDO";

            // =====================================================
            // txtApellido
            // =====================================================
            this.txtApellido.BorderStyle = BorderStyle.FixedSingle;
            this.txtApellido.Enabled = false;
            this.txtApellido.Font = new Font("Segoe UI", 10.5F);
            this.txtApellido.Location = new Point(200, 160);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new Size(160, 26);
            this.txtApellido.TabIndex = 3;

            // =====================================================
            // lblTelefono
            // =====================================================
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font =
                new Font("Segoe UI", 9F, FontStyle.Bold);

            this.lblTelefono.ForeColor = Color.FromArgb(90, 100, 110);
            this.lblTelefono.Location = new Point(25, 208);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new Size(66, 15);
            this.lblTelefono.Text = "TELÉFONO";

            // =====================================================
            // txtTelefono
            // =====================================================
            this.txtTelefono.BorderStyle = BorderStyle.FixedSingle;
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Font = new Font("Segoe UI", 10.5F);
            this.txtTelefono.Location = new Point(25, 230);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new Size(335, 26);
            this.txtTelefono.TabIndex = 4;

            // =====================================================
            // lblCorreo
            // =====================================================
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font =
                new Font("Segoe UI", 9F, FontStyle.Bold);

            this.lblCorreo.ForeColor = Color.FromArgb(90, 100, 110);
            this.lblCorreo.Location = new Point(25, 278);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new Size(55, 15);
            this.lblCorreo.Text = "CORREO";

            // =====================================================
            // txtCorreo
            // =====================================================
            this.txtCorreo.BorderStyle = BorderStyle.FixedSingle;
            this.txtCorreo.Enabled = false;
            this.txtCorreo.Font = new Font("Segoe UI", 10.5F);
            this.txtCorreo.Location = new Point(25, 300);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new Size(335, 26);
            this.txtCorreo.TabIndex = 5;

            // =====================================================
            // lblDireccion
            // =====================================================
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font =
                new Font("Segoe UI", 9F, FontStyle.Bold);

            this.lblDireccion.ForeColor = Color.FromArgb(90, 100, 110);
            this.lblDireccion.Location = new Point(25, 348);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new Size(70, 15);
            this.lblDireccion.Text = "DIRECCIÓN";

            // =====================================================
            // txtDireccion
            // =====================================================
            this.txtDireccion.BorderStyle = BorderStyle.FixedSingle;
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Font = new Font("Segoe UI", 10F);
            this.txtDireccion.Location = new Point(25, 370);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ScrollBars = ScrollBars.Vertical;
            this.txtDireccion.Size = new Size(335, 75);
            this.txtDireccion.TabIndex = 6;

            // =====================================================
            // panelAcciones
            // =====================================================
            this.panelAcciones.Anchor =
                AnchorStyles.Bottom |
                AnchorStyles.Right;

            this.panelAcciones.BackColor = Color.White;
            this.panelAcciones.Controls.Add(this.btnGuardar);
            this.panelAcciones.Controls.Add(this.btnCancelar);
            this.panelAcciones.Location = new Point(870, 640);
            this.panelAcciones.Name = "panelAcciones";
            this.panelAcciones.Size = new Size(386, 74);
            this.panelAcciones.TabIndex = 5;

            // =====================================================
            // btnGuardar
            // =====================================================
            this.btnGuardar.BackColor = Color.FromArgb(25, 125, 160);
            this.btnGuardar.Cursor = Cursors.Hand;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = FlatStyle.Flat;
            this.btnGuardar.Font =
                new Font("Segoe UI", 10F, FontStyle.Bold);

            this.btnGuardar.ForeColor = Color.White;
            this.btnGuardar.Location = new Point(25, 15);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new Size(160, 42);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click +=
                new System.EventHandler(this.btnGuardar_Click);

            // =====================================================
            // btnCancelar
            // =====================================================
            this.btnCancelar.BackColor = Color.FromArgb(238, 241, 244);
            this.btnCancelar.Cursor = Cursors.Hand;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = FlatStyle.Flat;
            this.btnCancelar.Font =
                new Font("Segoe UI", 10F, FontStyle.Bold);

            this.btnCancelar.ForeColor = Color.FromArgb(70, 80, 90);
            this.btnCancelar.Location = new Point(200, 15);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new Size(160, 42);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click +=
                new System.EventHandler(this.btnCancelar_Click);

            // =====================================================
            // frmClientes
            // =====================================================
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(241, 244, 247);
            this.ClientSize = new Size(1280, 740);

            this.Controls.Add(this.panelAcciones);
            this.Controls.Add(this.panelDatos);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.panelBusqueda);
            this.Controls.Add(this.panelSuperior);

            this.Font = new Font("Segoe UI", 9F);
            this.MinimumSize = new Size(1100, 650);
            this.Name = "frmClientes";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Israel Papelería | Gestión de Clientes";
            this.WindowState = FormWindowState.Maximized;
            this.Load +=
                new System.EventHandler(this.frmClientes_Load);

            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();

            this.panelBusqueda.ResumeLayout(false);
            this.panelBusqueda.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();

            this.panelBotones.ResumeLayout(false);

            this.panelDatos.ResumeLayout(false);
            this.panelDatos.PerformLayout();

            this.panelAcciones.ResumeLayout(false);

            this.ResumeLayout(false);
        }
    }
}