using System.Drawing;
using System.Windows.Forms;

namespace WalkiriaPapeleria.Forms
{
    partial class frmLogin
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panelTitulo;
        private Label lblTitulo;
        private Label lblUsuario;
        private Label lblClave;
        private TextBox txtUsuario;
        private TextBox txtClave;
        private Button btnLogin;
        private Button btnCancelar;
        private Label lblMensaje;
        private Label lblTurno;
        private ComboBox cmbTurno;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelTitulo = new Panel();
            this.lblTitulo = new Label();
            this.lblUsuario = new Label();
            this.lblClave = new Label();
            this.txtUsuario = new TextBox();
            this.txtClave = new TextBox();
            this.btnLogin = new Button();
            this.btnCancelar = new Button();
            this.lblMensaje = new Label();
            this.lblTurno = new Label();
            this.cmbTurno = new ComboBox();
            this.panelTitulo.SuspendLayout();
            this.SuspendLayout();

            // panelTitulo
            this.panelTitulo.BackColor = Color.FromArgb(44, 62, 80);
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Dock = DockStyle.Top;
            this.panelTitulo.Location = new Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new Size(400, 80);
            this.panelTitulo.TabIndex = 0;

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            this.lblTitulo.ForeColor = Color.White;
            this.lblTitulo.Location = new Point(50, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new Size(300, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "WALKIRIA PAPELERIA";

            // lblUsuario
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new Font("Segoe UI", 10F);
            this.lblUsuario.Location = new Point(40, 100);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new Size(55, 19);
            this.lblUsuario.Text = "Usuario:";

            // lblClave
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new Font("Segoe UI", 10F);
            this.lblClave.Location = new Point(40, 155);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new Size(76, 19);
            this.lblClave.Text = "Contraseña:";

            // lblTurno
            this.lblTurno.AutoSize = true;
            this.lblTurno.Font = new Font("Segoe UI", 10F);
            this.lblTurno.Location = new Point(40, 210);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new Size(47, 19);
            this.lblTurno.Text = "Turno:";

            // txtUsuario
            this.txtUsuario.Font = new Font("Segoe UI", 10F);
            this.txtUsuario.Location = new Point(40, 122);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new Size(320, 25);
            this.txtUsuario.TabIndex = 1;

            // txtClave
            this.txtClave.Font = new Font("Segoe UI", 10F);
            this.txtClave.Location = new Point(40, 177);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new Size(320, 25);
            this.txtClave.TabIndex = 2;
            this.txtClave.UseSystemPasswordChar = true;

            // cmbTurno
            this.cmbTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbTurno.Font = new Font("Segoe UI", 10F);
            this.cmbTurno.Location = new Point(40, 232);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new Size(320, 25);
            this.cmbTurno.TabIndex = 3;

            // btnLogin
            this.btnLogin.BackColor = Color.FromArgb(39, 174, 96);
            this.btnLogin.FlatStyle = FlatStyle.Flat;
            this.btnLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnLogin.ForeColor = Color.White;
            this.btnLogin.Location = new Point(60, 280);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new Size(130, 40);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Iniciar Sesion";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // btnCancelar
            this.btnCancelar.BackColor = Color.FromArgb(231, 76, 60);
            this.btnCancelar.FlatStyle = FlatStyle.Flat;
            this.btnCancelar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnCancelar.ForeColor = Color.White;
            this.btnCancelar.Location = new Point(210, 280);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new Size(130, 40);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);

            // lblMensaje
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new Font("Segoe UI", 9F);
            this.lblMensaje.ForeColor = Color.Red;
            this.lblMensaje.Location = new Point(40, 260);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new Size(0, 15);
            this.lblMensaje.Visible = false;

            // frmLogin
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(400, 350);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.cmbTurno);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.panelTitulo);
            this.Font = new Font("Segoe UI", 9F);
            this.Name = "frmLogin";
            this.Text = "Inicio de Sesion - Walkiria Papeleria";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}