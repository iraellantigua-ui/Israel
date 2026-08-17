using System.Drawing;
using System.Windows.Forms;

namespace WalkiriaPapeleria.Forms
{
    partial class frmReinicioSistema
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panelSuperior;
        private Label lblTitulo;
        private Label lblUsuario;
        private Label lblRol;
        private Panel panelContenido;
        private TextBox txtAdvertencia;
        private Label lblEstado;
        private Label lblConfirmacion;
        private TextBox txtConfirmacion;
        private Panel panelBotones;
        private Button btnReiniciar;
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
            this.lblTitulo = new Label();
            this.lblUsuario = new Label();
            this.lblRol = new Label();
            this.panelContenido = new Panel();
            this.txtAdvertencia = new TextBox();
            this.lblEstado = new Label();
            this.lblConfirmacion = new Label();
            this.txtConfirmacion = new TextBox();
            this.panelBotones = new Panel();
            this.btnReiniciar = new Button();
            this.btnCancelar = new Button();
            this.panelSuperior.SuspendLayout();
            this.panelContenido.SuspendLayout();
            this.panelBotones.SuspendLayout();
            this.SuspendLayout();

            // ==================== panelSuperior ====================
            this.panelSuperior.BackColor = Color.FromArgb(192, 57, 43);
            this.panelSuperior.Controls.Add(this.lblTitulo);
            this.panelSuperior.Controls.Add(this.lblUsuario);
            this.panelSuperior.Controls.Add(this.lblRol);
            this.panelSuperior.Dock = DockStyle.Top;
            this.panelSuperior.Location = new Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new Size(600, 80);
            this.panelSuperior.TabIndex = 0;

            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            this.lblTitulo.ForeColor = Color.White;
            this.lblTitulo.Location = new Point(20, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new Size(277, 32);
            this.lblTitulo.Text = "🔄 Reiniciar Sistema";

            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new Font("Segoe UI", 10F);
            this.lblUsuario.ForeColor = Color.FromArgb(236, 240, 241);
            this.lblUsuario.Location = new Point(400, 15);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new Size(90, 19);
            this.lblUsuario.Text = "👤 Usuario: ";

            this.lblRol.AutoSize = true;
            this.lblRol.Font = new Font("Segoe UI", 10F);
            this.lblRol.ForeColor = Color.FromArgb(46, 204, 113);
            this.lblRol.Location = new Point(400, 40);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new Size(55, 19);
            this.lblRol.Text = "🎭 Rol: ";

            // ==================== panelContenido ====================
            this.panelContenido.BackColor = Color.White;
            this.panelContenido.Controls.Add(this.txtAdvertencia);
            this.panelContenido.Controls.Add(this.lblEstado);
            this.panelContenido.Controls.Add(this.lblConfirmacion);
            this.panelContenido.Controls.Add(this.txtConfirmacion);
            this.panelContenido.Location = new Point(10, 90);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new Size(580, 370);
            this.panelContenido.TabIndex = 1;

            // txtAdvertencia
            this.txtAdvertencia.BackColor = Color.FromArgb(255, 240, 240);
            this.txtAdvertencia.BorderStyle = BorderStyle.FixedSingle;
            this.txtAdvertencia.Font = new Font("Segoe UI", 10F);
            this.txtAdvertencia.Location = new Point(10, 10);
            this.txtAdvertencia.Multiline = true;
            this.txtAdvertencia.Name = "txtAdvertencia";
            this.txtAdvertencia.ReadOnly = true;
            this.txtAdvertencia.Size = new Size(560, 220);
            this.txtAdvertencia.TabIndex = 0;
            this.txtAdvertencia.Text = "⚠️ ADVERTENCIA ⚠️";

            // lblEstado
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblEstado.Location = new Point(10, 245);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new Size(138, 21);
            this.lblEstado.Text = "Estado del sistema:";

            // lblConfirmacion
            this.lblConfirmacion.AutoSize = true;
            this.lblConfirmacion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblConfirmacion.Location = new Point(10, 280);
            this.lblConfirmacion.Name = "lblConfirmacion";
            this.lblConfirmacion.Size = new Size(176, 19);
            this.lblConfirmacion.Text = "Confirmar con contraseña:";

            // txtConfirmacion
            this.txtConfirmacion.Font = new Font("Segoe UI", 10F);
            this.txtConfirmacion.Location = new Point(10, 305);
            this.txtConfirmacion.Name = "txtConfirmacion";
            this.txtConfirmacion.Size = new Size(300, 25);
            this.txtConfirmacion.TabIndex = 1;
            this.txtConfirmacion.UseSystemPasswordChar = true;

            // ==================== panelBotones ====================
            this.panelBotones.BackColor = Color.FromArgb(236, 240, 241);
            this.panelBotones.Controls.Add(this.btnReiniciar);
            this.panelBotones.Controls.Add(this.btnCancelar);
            this.panelBotones.Location = new Point(10, 470);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new Size(580, 60);
            this.panelBotones.TabIndex = 2;

            // btnReiniciar
            this.btnReiniciar.BackColor = Color.FromArgb(192, 57, 43);
            this.btnReiniciar.FlatStyle = FlatStyle.Flat;
            this.btnReiniciar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnReiniciar.ForeColor = Color.White;
            this.btnReiniciar.Location = new Point(10, 10);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new Size(180, 40);
            this.btnReiniciar.TabIndex = 0;
            this.btnReiniciar.Text = "🔴 Reiniciar Sistema";
            this.btnReiniciar.UseVisualStyleBackColor = false;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);

            // btnCancelar
            this.btnCancelar.BackColor = Color.FromArgb(149, 165, 166);
            this.btnCancelar.FlatStyle = FlatStyle.Flat;
            this.btnCancelar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnCancelar.ForeColor = Color.White;
            this.btnCancelar.Location = new Point(390, 10);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new Size(180, 40);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "❌ Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);

            // ==================== frmReinicioSistema ====================
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(236, 240, 241);
            this.ClientSize = new Size(600, 550);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelSuperior);
            this.Font = new Font("Segoe UI", 9F);
            this.Name = "frmReinicioSistema";
            this.Text = "Reiniciar Sistema - Walkiria Papelería";
            this.Load += new System.EventHandler(this.frmReinicioSistema_Load);
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.panelContenido.ResumeLayout(false);
            this.panelContenido.PerformLayout();
            this.panelBotones.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}