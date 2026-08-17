using System.Drawing;
using System.Windows.Forms;

namespace WalkiriaPapeleria.Forms
{
    partial class frmImpresionFactura
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panelSuperior;
        private Label lblTitulo;
        private TextBox txtFactura;
        private Panel panelBotones;
        private Button btnImprimir;
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
            this.txtFactura = new TextBox();
            this.panelBotones = new Panel();
            this.btnImprimir = new Button();
            this.btnCerrar = new Button();
            this.panelSuperior.SuspendLayout();
            this.panelBotones.SuspendLayout();
            this.SuspendLayout();

            // panelSuperior
            this.panelSuperior.BackColor = Color.FromArgb(44, 62, 80);
            this.panelSuperior.Controls.Add(this.lblTitulo);
            this.panelSuperior.Dock = DockStyle.Top;
            this.panelSuperior.Location = new Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new Size(500, 60);
            this.panelSuperior.TabIndex = 0;

            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.lblTitulo.ForeColor = Color.White;
            this.lblTitulo.Location = new Point(20, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new Size(245, 30);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "🖨️ Vista Previa Factura";

            // txtFactura
            this.txtFactura.Font = new Font("Courier New", 10F);
            this.txtFactura.Location = new Point(10, 70);
            this.txtFactura.Multiline = true;
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.ReadOnly = true;
            this.txtFactura.ScrollBars = ScrollBars.Vertical;
            this.txtFactura.Size = new Size(480, 450);
            this.txtFactura.TabIndex = 1;

            // panelBotones
            this.panelBotones.BackColor = Color.FromArgb(236, 240, 241);
            this.panelBotones.Controls.Add(this.btnImprimir);
            this.panelBotones.Controls.Add(this.btnCerrar);
            this.panelBotones.Location = new Point(10, 530);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new Size(480, 50);
            this.panelBotones.TabIndex = 2;

            this.btnImprimir.BackColor = Color.FromArgb(39, 174, 96);
            this.btnImprimir.FlatStyle = FlatStyle.Flat;
            this.btnImprimir.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnImprimir.ForeColor = Color.White;
            this.btnImprimir.Location = new Point(10, 8);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new Size(150, 35);
            this.btnImprimir.TabIndex = 0;
            this.btnImprimir.Text = "🖨️ Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);

            this.btnCerrar.BackColor = Color.FromArgb(192, 57, 43);
            this.btnCerrar.FlatStyle = FlatStyle.Flat;
            this.btnCerrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnCerrar.ForeColor = Color.White;
            this.btnCerrar.Location = new Point(320, 8);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new Size(150, 35);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "✖ Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);

            // frmImpresionFactura
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            this.ClientSize = new Size(500, 600);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.txtFactura);
            this.Controls.Add(this.panelSuperior);
            this.Font = new Font("Segoe UI", 9F);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmImpresionFactura";
            this.Text = "Vista Previa de Factura";
            this.Load += new System.EventHandler(this.frmImpresionFactura_Load);
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.panelBotones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}