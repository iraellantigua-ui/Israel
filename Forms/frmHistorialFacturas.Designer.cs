using System.Drawing;
using System.Windows.Forms;

namespace WalkiriaPapeleria.Forms
{
    partial class frmHistorialFacturas
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panelSuperior;
        private Label lblTitulo;
        private Label lblTotal;
        private Panel panelFiltros;
        private Label lblFechaInicio;
        private DateTimePicker dtpFechaInicio;
        private Label lblFechaFin;
        private DateTimePicker dtpFechaFin;
        private Button btnBuscar;
        private Button btnLimpiarFiltros;
        private DataGridView dgvFacturas;
        private Panel panelBotones;
        private Button btnVerDetalle;
        private Button btnReimprimir;
        private Button btnAnular;
        private Button btnCerrar;

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
            this.lblTotal = new Label();
            this.panelFiltros = new Panel();
            this.lblFechaInicio = new Label();
            this.dtpFechaInicio = new DateTimePicker();
            this.lblFechaFin = new Label();
            this.dtpFechaFin = new DateTimePicker();
            this.btnBuscar = new Button();
            this.btnLimpiarFiltros = new Button();
            this.dgvFacturas = new DataGridView();
            this.panelBotones = new Panel();
            this.btnVerDetalle = new Button();
            this.btnReimprimir = new Button();
            this.btnAnular = new Button();
            this.btnCerrar = new Button();
            this.panelSuperior.SuspendLayout();
            this.panelFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
            this.panelBotones.SuspendLayout();
            this.SuspendLayout();

            // panelSuperior
            this.panelSuperior.BackColor = Color.FromArgb(44, 62, 80);
            this.panelSuperior.Controls.Add(this.lblTitulo);
            this.panelSuperior.Controls.Add(this.lblTotal);
            this.panelSuperior.Dock = DockStyle.Top;
            this.panelSuperior.Location = new Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new Size(1100, 70);
            this.panelSuperior.TabIndex = 0;

            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            this.lblTitulo.ForeColor = Color.White;
            this.lblTitulo.Location = new Point(20, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new Size(230, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "📋 Historial de Facturas";

            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new Font("Segoe UI", 12F);
            this.lblTotal.ForeColor = Color.FromArgb(189, 195, 199);
            this.lblTotal.Location = new Point(900, 24);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new Size(120, 21);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total: 0 facturas";

            // panelFiltros
            this.panelFiltros.BackColor = Color.White;
            this.panelFiltros.BorderStyle = BorderStyle.FixedSingle;
            this.panelFiltros.Controls.Add(this.lblFechaInicio);
            this.panelFiltros.Controls.Add(this.dtpFechaInicio);
            this.panelFiltros.Controls.Add(this.lblFechaFin);
            this.panelFiltros.Controls.Add(this.dtpFechaFin);
            this.panelFiltros.Controls.Add(this.btnBuscar);
            this.panelFiltros.Controls.Add(this.btnLimpiarFiltros);
            this.panelFiltros.Location = new Point(10, 80);
            this.panelFiltros.Name = "panelFiltros";
            this.panelFiltros.Size = new Size(1080, 50);
            this.panelFiltros.TabIndex = 1;

            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblFechaInicio.Location = new Point(15, 15);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new Size(90, 19);
            this.lblFechaInicio.TabIndex = 0;
            this.lblFechaInicio.Text = "Fecha Inicio:";

            this.dtpFechaInicio.Font = new Font("Segoe UI", 10F);
            this.dtpFechaInicio.Location = new Point(115, 12);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new Size(200, 25);
            this.dtpFechaInicio.TabIndex = 1;

            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblFechaFin.Location = new Point(340, 15);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new Size(77, 19);
            this.lblFechaFin.TabIndex = 2;
            this.lblFechaFin.Text = "Fecha Fin:";

            this.dtpFechaFin.Font = new Font("Segoe UI", 10F);
            this.dtpFechaFin.Location = new Point(425, 12);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new Size(200, 25);
            this.dtpFechaFin.TabIndex = 3;

            this.btnBuscar.BackColor = Color.FromArgb(41, 128, 185);
            this.btnBuscar.FlatStyle = FlatStyle.Flat;
            this.btnBuscar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnBuscar.ForeColor = Color.White;
            this.btnBuscar.Location = new Point(650, 10);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new Size(100, 30);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "🔍 Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);

            this.btnLimpiarFiltros.BackColor = Color.FromArgb(149, 165, 166);
            this.btnLimpiarFiltros.FlatStyle = FlatStyle.Flat;
            this.btnLimpiarFiltros.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnLimpiarFiltros.ForeColor = Color.White;
            this.btnLimpiarFiltros.Location = new Point(760, 10);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new Size(120, 30);
            this.btnLimpiarFiltros.TabIndex = 5;
            this.btnLimpiarFiltros.Text = "🧹 Limpiar Filtros";
            this.btnLimpiarFiltros.UseVisualStyleBackColor = false;
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.btnLimpiarFiltros_Click);

            // dgvFacturas
            this.dgvFacturas.AllowUserToAddRows = false;
            this.dgvFacturas.AllowUserToDeleteRows = false;
            this.dgvFacturas.BackgroundColor = Color.White;
            this.dgvFacturas.BorderStyle = BorderStyle.None;
            this.dgvFacturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturas.Location = new Point(10, 140);
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.ReadOnly = true;
            this.dgvFacturas.RowHeadersVisible = false;
            this.dgvFacturas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvFacturas.Size = new Size(1080, 400);
            this.dgvFacturas.TabIndex = 2;
            this.dgvFacturas.SelectionChanged += new System.EventHandler(this.dgvFacturas_SelectionChanged);

            // panelBotones
            this.panelBotones.BackColor = Color.FromArgb(236, 240, 241);
            this.panelBotones.Controls.Add(this.btnVerDetalle);
            this.panelBotones.Controls.Add(this.btnReimprimir);
            this.panelBotones.Controls.Add(this.btnAnular);
            this.panelBotones.Controls.Add(this.btnCerrar);
            this.panelBotones.Location = new Point(10, 550);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new Size(1080, 60);
            this.panelBotones.TabIndex = 3;

            this.btnVerDetalle.BackColor = Color.FromArgb(41, 128, 185);
            this.btnVerDetalle.FlatStyle = FlatStyle.Flat;
            this.btnVerDetalle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnVerDetalle.ForeColor = Color.White;
            this.btnVerDetalle.Location = new Point(20, 10);
            this.btnVerDetalle.Name = "btnVerDetalle";
            this.btnVerDetalle.Size = new Size(140, 40);
            this.btnVerDetalle.TabIndex = 0;
            this.btnVerDetalle.Text = "📄 Ver Detalle";
            this.btnVerDetalle.UseVisualStyleBackColor = false;
            this.btnVerDetalle.Click += new System.EventHandler(this.btnVerDetalle_Click);

            this.btnReimprimir.BackColor = Color.FromArgb(39, 174, 96);
            this.btnReimprimir.FlatStyle = FlatStyle.Flat;
            this.btnReimprimir.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnReimprimir.ForeColor = Color.White;
            this.btnReimprimir.Location = new Point(170, 10);
            this.btnReimprimir.Name = "btnReimprimir";
            this.btnReimprimir.Size = new Size(140, 40);
            this.btnReimprimir.TabIndex = 1;
            this.btnReimprimir.Text = "🖨️ Reimprimir";
            this.btnReimprimir.UseVisualStyleBackColor = false;
            this.btnReimprimir.Click += new System.EventHandler(this.btnReimprimir_Click);

            this.btnAnular.BackColor = Color.FromArgb(192, 57, 43);
            this.btnAnular.FlatStyle = FlatStyle.Flat;
            this.btnAnular.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnAnular.ForeColor = Color.White;
            this.btnAnular.Location = new Point(320, 10);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new Size(140, 40);
            this.btnAnular.TabIndex = 2;
            this.btnAnular.Text = "🚫 Anular";
            this.btnAnular.UseVisualStyleBackColor = false;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);

            this.btnCerrar.BackColor = Color.FromArgb(149, 165, 166);
            this.btnCerrar.FlatStyle = FlatStyle.Flat;
            this.btnCerrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnCerrar.ForeColor = Color.White;
            this.btnCerrar.Location = new Point(900, 10);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new Size(160, 40);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "✖ Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);

            // frmHistorialFacturas
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(236, 240, 241);
            this.ClientSize = new Size(1100, 630);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.dgvFacturas);
            this.Controls.Add(this.panelFiltros);
            this.Controls.Add(this.panelSuperior);
            this.Font = new Font("Segoe UI", 9F);
            this.Name = "frmHistorialFacturas";
            this.Text = "Historial de Facturas";
            this.WindowState = FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHistorialFacturas_Load);
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.panelFiltros.ResumeLayout(false);
            this.panelFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
            this.panelBotones.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}