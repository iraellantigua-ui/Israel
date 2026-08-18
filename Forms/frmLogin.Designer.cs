using System.Drawing;
using System.Windows.Forms;

namespace WalkiriaPapeleria.Forms
{
    partial class frmLogin
    {
        private System.ComponentModel.IContainer components = null;

        private Panel panelMarca;
        private Panel panelLogin;

        private Label lblLogo;
        private Label lblMarca;
        private Label lblDescripcion;
        private Label lblVersion;

        private Label lblBienvenido;
        private Label lblInstruccion;

        private Label lblUsuario;
        private Label lblClave;
        private Label lblTurno;

        private TextBox txtUsuario;
        private TextBox txtClave;
        private ComboBox cmbTurno;

        private Label lblMensaje;

        private Button btnLogin;
        private Button btnCancelar;

        private Label lblSeguridad;
        private Panel lineaUsuario;
        private Panel lineaClave;
        private Panel lineaTurno;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelMarca = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();

            this.panelLogin = new System.Windows.Forms.Panel();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.lblInstruccion = new System.Windows.Forms.Label();

            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lineaUsuario = new System.Windows.Forms.Panel();

            this.lblClave = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lineaClave = new System.Windows.Forms.Panel();

            this.lblTurno = new System.Windows.Forms.Label();
            this.cmbTurno = new System.Windows.Forms.ComboBox();
            this.lineaTurno = new System.Windows.Forms.Panel();

            this.lblMensaje = new System.Windows.Forms.Label();

            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();

            this.lblSeguridad = new System.Windows.Forms.Label();

            this.panelMarca.SuspendLayout();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();

            // =========================================================
            // PANEL IZQUIERDO - MARCA
            // =========================================================
            this.panelMarca.BackColor = System.Drawing.Color.FromArgb(15, 38, 71);
            this.panelMarca.Controls.Add(this.lblLogo);
            this.panelMarca.Controls.Add(this.lblMarca);
            this.panelMarca.Controls.Add(this.lblDescripcion);
            this.panelMarca.Controls.Add(this.lblVersion);
            this.panelMarca.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMarca.Location = new System.Drawing.Point(0, 0);
            this.panelMarca.Name = "panelMarca";
            this.panelMarca.Size = new System.Drawing.Size(350, 570);
            this.panelMarca.TabIndex = 0;

            // lblLogo
            this.lblLogo.BackColor = System.Drawing.Color.FromArgb(25, 125, 160);
            this.lblLogo.Font = new System.Drawing.Font(
                "Segoe UI",
                30F,
                System.Drawing.FontStyle.Bold
            );
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(112, 85);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(125, 110);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "IP";
            this.lblLogo.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            // lblMarca
            this.lblMarca.Font = new System.Drawing.Font(
                "Segoe UI",
                23F,
                System.Drawing.FontStyle.Bold
            );
            this.lblMarca.ForeColor = System.Drawing.Color.White;
            this.lblMarca.Location = new System.Drawing.Point(25, 220);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(300, 55);
            this.lblMarca.TabIndex = 1;
            this.lblMarca.Text = "ISRAEL PAPELERÍA";
            this.lblMarca.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            // lblDescripcion
            this.lblDescripcion.Font = new System.Drawing.Font(
                "Segoe UI",
                11F
            );
            this.lblDescripcion.ForeColor =
                System.Drawing.Color.FromArgb(185, 205, 225);
            this.lblDescripcion.Location =
                new System.Drawing.Point(40, 285);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size =
                new System.Drawing.Size(270, 65);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text =
                "Sistema administrativo\r\nVentas • Inventario • Facturación";
            this.lblDescripcion.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            // lblVersion
            this.lblVersion.Font = new System.Drawing.Font(
                "Segoe UI",
                8.5F
            );
            this.lblVersion.ForeColor =
                System.Drawing.Color.FromArgb(130, 160, 190);
            this.lblVersion.Location =
                new System.Drawing.Point(25, 520);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size =
                new System.Drawing.Size(300, 25);
            this.lblVersion.TabIndex = 3;
            this.lblVersion.Text = "Sistema de Gestión • 2026";
            this.lblVersion.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            // =========================================================
            // PANEL DERECHO - LOGIN
            // =========================================================
            this.panelLogin.BackColor = System.Drawing.Color.White;
            this.panelLogin.Controls.Add(this.lblBienvenido);
            this.panelLogin.Controls.Add(this.lblInstruccion);

            this.panelLogin.Controls.Add(this.lblUsuario);
            this.panelLogin.Controls.Add(this.txtUsuario);
            this.panelLogin.Controls.Add(this.lineaUsuario);

            this.panelLogin.Controls.Add(this.lblClave);
            this.panelLogin.Controls.Add(this.txtClave);
            this.panelLogin.Controls.Add(this.lineaClave);

            this.panelLogin.Controls.Add(this.lblTurno);
            this.panelLogin.Controls.Add(this.cmbTurno);
            this.panelLogin.Controls.Add(this.lineaTurno);

            this.panelLogin.Controls.Add(this.lblMensaje);

            this.panelLogin.Controls.Add(this.btnLogin);
            this.panelLogin.Controls.Add(this.btnCancelar);

            this.panelLogin.Controls.Add(this.lblSeguridad);

            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogin.Location =
                new System.Drawing.Point(350, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size =
                new System.Drawing.Size(470, 570);
            this.panelLogin.TabIndex = 1;

            // lblBienvenido
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font(
                "Segoe UI",
                25F,
                System.Drawing.FontStyle.Bold
            );
            this.lblBienvenido.ForeColor =
                System.Drawing.Color.FromArgb(25, 45, 70);
            this.lblBienvenido.Location =
                new System.Drawing.Point(55, 65);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size =
                new System.Drawing.Size(230, 46);
            this.lblBienvenido.TabIndex = 0;
            this.lblBienvenido.Text = "Bienvenido";

            // lblInstruccion
            this.lblInstruccion.AutoSize = true;
            this.lblInstruccion.Font =
                new System.Drawing.Font("Segoe UI", 10F);
            this.lblInstruccion.ForeColor =
                System.Drawing.Color.FromArgb(120, 130, 140);
            this.lblInstruccion.Location =
                new System.Drawing.Point(59, 118);
            this.lblInstruccion.Name = "lblInstruccion";
            this.lblInstruccion.Size =
                new System.Drawing.Size(273, 19);
            this.lblInstruccion.TabIndex = 1;
            this.lblInstruccion.Text =
                "Ingresa tus credenciales para continuar.";

            // =========================================================
            // USUARIO
            // =========================================================
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font(
                "Segoe UI",
                9.5F,
                System.Drawing.FontStyle.Bold
            );
            this.lblUsuario.ForeColor =
                System.Drawing.Color.FromArgb(65, 75, 85);
            this.lblUsuario.Location =
                new System.Drawing.Point(60, 170);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Text = "USUARIO";

            this.txtUsuario.BackColor = System.Drawing.Color.White;
            this.txtUsuario.BorderStyle =
                System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font =
                new System.Drawing.Font("Segoe UI", 12F);
            this.txtUsuario.Location =
                new System.Drawing.Point(63, 198);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size =
                new System.Drawing.Size(340, 22);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.KeyPress +=
                new System.Windows.Forms.KeyPressEventHandler(
                    this.txtUsuario_KeyPress
                );

            this.lineaUsuario.BackColor =
                System.Drawing.Color.FromArgb(200, 207, 215);
            this.lineaUsuario.Location =
                new System.Drawing.Point(60, 226);
            this.lineaUsuario.Name = "lineaUsuario";
            this.lineaUsuario.Size =
                new System.Drawing.Size(345, 2);

            // =========================================================
            // CONTRASEÑA
            // =========================================================
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font(
                "Segoe UI",
                9.5F,
                System.Drawing.FontStyle.Bold
            );
            this.lblClave.ForeColor =
                System.Drawing.Color.FromArgb(65, 75, 85);
            this.lblClave.Location =
                new System.Drawing.Point(60, 250);
            this.lblClave.Name = "lblClave";
            this.lblClave.Text = "CONTRASEÑA";

            this.txtClave.BackColor = System.Drawing.Color.White;
            this.txtClave.BorderStyle =
                System.Windows.Forms.BorderStyle.None;
            this.txtClave.Font =
                new System.Drawing.Font("Segoe UI", 12F);
            this.txtClave.Location =
                new System.Drawing.Point(63, 278);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size =
                new System.Drawing.Size(340, 22);
            this.txtClave.TabIndex = 2;
            this.txtClave.UseSystemPasswordChar = true;
            this.txtClave.KeyPress +=
                new System.Windows.Forms.KeyPressEventHandler(
                    this.txtClave_KeyPress
                );

            this.lineaClave.BackColor =
                System.Drawing.Color.FromArgb(200, 207, 215);
            this.lineaClave.Location =
                new System.Drawing.Point(60, 306);
            this.lineaClave.Name = "lineaClave";
            this.lineaClave.Size =
                new System.Drawing.Size(345, 2);

            // =========================================================
            // TURNO
            // =========================================================
            this.lblTurno.AutoSize = true;
            this.lblTurno.Font = new System.Drawing.Font(
                "Segoe UI",
                9.5F,
                System.Drawing.FontStyle.Bold
            );
            this.lblTurno.ForeColor =
                System.Drawing.Color.FromArgb(65, 75, 85);
            this.lblTurno.Location =
                new System.Drawing.Point(60, 330);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Text = "TURNO";

            this.cmbTurno.BackColor = System.Drawing.Color.White;
            this.cmbTurno.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTurno.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.cmbTurno.Font =
                new System.Drawing.Font("Segoe UI", 11F);
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.Location =
                new System.Drawing.Point(60, 356);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size =
                new System.Drawing.Size(345, 28);
            this.cmbTurno.TabIndex = 3;

            this.lineaTurno.BackColor =
                System.Drawing.Color.FromArgb(200, 207, 215);
            this.lineaTurno.Location =
                new System.Drawing.Point(60, 386);
            this.lineaTurno.Name = "lineaTurno";
            this.lineaTurno.Size =
                new System.Drawing.Size(345, 2);

            // =========================================================
            // MENSAJE
            // =========================================================
            this.lblMensaje.Font = new System.Drawing.Font(
                "Segoe UI",
                9F,
                System.Drawing.FontStyle.Bold
            );
            this.lblMensaje.ForeColor =
                System.Drawing.Color.FromArgb(200, 55, 55);
            this.lblMensaje.Location =
                new System.Drawing.Point(60, 397);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size =
                new System.Drawing.Size(345, 30);
            this.lblMensaje.TabIndex = 4;
            this.lblMensaje.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMensaje.Visible = false;

            // =========================================================
            // BOTÓN LOGIN
            // =========================================================
            this.btnLogin.BackColor =
                System.Drawing.Color.FromArgb(25, 125, 160);
            this.btnLogin.Cursor =
                System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font(
                "Segoe UI",
                10.5F,
                System.Drawing.FontStyle.Bold
            );
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location =
                new System.Drawing.Point(60, 435);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size =
                new System.Drawing.Size(220, 45);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "INICIAR SESIÓN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click +=
                new System.EventHandler(this.btnLogin_Click);

            // =========================================================
            // BOTÓN SALIR
            // =========================================================
            this.btnCancelar.BackColor =
                System.Drawing.Color.FromArgb(238, 241, 244);
            this.btnCancelar.Cursor =
                System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font(
                "Segoe UI",
                10F,
                System.Drawing.FontStyle.Bold
            );
            this.btnCancelar.ForeColor =
                System.Drawing.Color.FromArgb(80, 90, 100);
            this.btnCancelar.Location =
                new System.Drawing.Point(290, 435);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size =
                new System.Drawing.Size(115, 45);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "SALIR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click +=
                new System.EventHandler(this.btnCancelar_Click);

            // lblSeguridad
            this.lblSeguridad.Font =
                new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSeguridad.ForeColor =
                System.Drawing.Color.FromArgb(150, 155, 160);
            this.lblSeguridad.Location =
                new System.Drawing.Point(60, 505);
            this.lblSeguridad.Name = "lblSeguridad";
            this.lblSeguridad.Size =
                new System.Drawing.Size(345, 25);
            this.lblSeguridad.Text =
                "Acceso exclusivo para personal autorizado";
            this.lblSeguridad.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            // =========================================================
            // FRM LOGIN
            // =========================================================
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize =
                new System.Drawing.Size(820, 570);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.panelMarca);
            this.Font =
                new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.Name = "frmLogin";
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Israel Papelería | Inicio de Sesión";
            this.Load +=
                new System.EventHandler(this.frmLogin_Load);

            this.panelMarca.ResumeLayout(false);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}