using System.Drawing;
using System.Windows.Forms;

namespace WalkiriaPapeleria.Forms
{
    partial class frmEmpleados
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panelSuperior;
        private Label lblTituloFormulario;
        private Label lblTotal;
        private Panel panelBusqueda;
        private Label lblBuscar;
        private TextBox txtBuscar;
        private DataGridView dgvEmpleados;
        private Panel panelBotones;
        private Button btnNuevo;
        private Button btnEditar;
        private Button btnEliminar;
        private Panel panelDatos;
        private Label lblCedula;
        private TextBox txtCedula;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblApellido;
        private TextBox txtApellido;
        private Label lblSexo;
        private ComboBox cmbSexo;
        private Label lblFechaNacimiento;
        private DateTimePicker dtpFechaNacimiento;
        private Label lblTipoSangre;
        private ComboBox cmbTipoSangre;
        private Label lblCelular;
        private TextBox txtCelular;
        private Label lblTelefonoExtra;
        private TextBox txtTelefonoExtra;
        private Label lblCorreo;
        private TextBox txtCorreo;
        private Label lblDireccion;
        private TextBox txtDireccion;
        private CheckBox chkActivo;
        private Panel panelUsuario;
        private CheckBox chkCrearUsuario;
        private Label lblUsuario;
        private TextBox txtUsuario;
        private Label lblRol;
        private ComboBox cmbRol;
        private Label lblClave;
        private TextBox txtClave;
        private CheckBox chkUsuarioActivo;
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
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.lblTituloFormulario = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panelBusqueda = new System.Windows.Forms.Panel();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.panelDatos = new System.Windows.Forms.Panel();
            this.lblCedula = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblTipoSangre = new System.Windows.Forms.Label();
            this.cmbTipoSangre = new System.Windows.Forms.ComboBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.lblTelefonoExtra = new System.Windows.Forms.Label();
            this.txtTelefonoExtra = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.panelUsuario = new System.Windows.Forms.Panel();
            this.chkCrearUsuario = new System.Windows.Forms.CheckBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.chkUsuarioActivo = new System.Windows.Forms.CheckBox();
            this.panelAcciones = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panelSuperior.SuspendLayout();
            this.panelBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.panelBotones.SuspendLayout();
            this.panelDatos.SuspendLayout();
            this.panelUsuario.SuspendLayout();
            this.panelAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panelSuperior.Controls.Add(this.lblTituloFormulario);
            this.panelSuperior.Controls.Add(this.lblTotal);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1100, 60);
            this.panelSuperior.TabIndex = 0;
            // 
            // lblTituloFormulario
            // 
            this.lblTituloFormulario.AutoSize = true;
            this.lblTituloFormulario.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTituloFormulario.ForeColor = System.Drawing.Color.White;
            this.lblTituloFormulario.Location = new System.Drawing.Point(20, 14);
            this.lblTituloFormulario.Name = "lblTituloFormulario";
            this.lblTituloFormulario.Size = new System.Drawing.Size(308, 32);
            this.lblTituloFormulario.TabIndex = 0;
            this.lblTituloFormulario.Text = "👥 Gestión de Empleados";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.lblTotal.Location = new System.Drawing.Point(900, 18);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(138, 21);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total: 0 empleados";
            // 
            // panelBusqueda
            // 
            this.panelBusqueda.BackColor = System.Drawing.Color.White;
            this.panelBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBusqueda.Controls.Add(this.lblBuscar);
            this.panelBusqueda.Controls.Add(this.txtBuscar);
            this.panelBusqueda.Location = new System.Drawing.Point(20, 70);
            this.panelBusqueda.Name = "panelBusqueda";
            this.panelBusqueda.Size = new System.Drawing.Size(300, 35);
            this.panelBusqueda.TabIndex = 1;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblBuscar.Location = new System.Drawing.Point(10, 8);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(28, 19);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "🔍";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBuscar.Location = new System.Drawing.Point(40, 8);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(245, 18);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.Text = "Buscar por cédula...";
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AllowUserToDeleteRows = false;
            this.dgvEmpleados.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(20, 115);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.RowHeadersVisible = false;
            this.dgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpleados.Size = new System.Drawing.Size(700, 230);
            this.dgvEmpleados.TabIndex = 2;
            this.dgvEmpleados.SelectionChanged += new System.EventHandler(this.dgvEmpleados_SelectionChanged);
            // 
            // panelBotones
            // 
            this.panelBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panelBotones.Controls.Add(this.btnNuevo);
            this.panelBotones.Controls.Add(this.btnEditar);
            this.panelBotones.Controls.Add(this.btnEliminar);
            this.panelBotones.Location = new System.Drawing.Point(20, 355);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(700, 45);
            this.panelBotones.TabIndex = 3;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(10, 5);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(120, 35);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "➕ Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(140, 5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(120, 35);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "✏️ Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(270, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(120, 35);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "🗑️ Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // panelDatos
            // 
            this.panelDatos.BackColor = System.Drawing.Color.White;
            this.panelDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDatos.Controls.Add(this.lblCedula);
            this.panelDatos.Controls.Add(this.txtCedula);
            this.panelDatos.Controls.Add(this.lblNombre);
            this.panelDatos.Controls.Add(this.txtNombre);
            this.panelDatos.Controls.Add(this.lblApellido);
            this.panelDatos.Controls.Add(this.txtApellido);
            this.panelDatos.Controls.Add(this.lblSexo);
            this.panelDatos.Controls.Add(this.cmbSexo);
            this.panelDatos.Controls.Add(this.lblFechaNacimiento);
            this.panelDatos.Controls.Add(this.dtpFechaNacimiento);
            this.panelDatos.Controls.Add(this.lblTipoSangre);
            this.panelDatos.Controls.Add(this.cmbTipoSangre);
            this.panelDatos.Controls.Add(this.lblCelular);
            this.panelDatos.Controls.Add(this.txtCelular);
            this.panelDatos.Controls.Add(this.lblTelefonoExtra);
            this.panelDatos.Controls.Add(this.txtTelefonoExtra);
            this.panelDatos.Controls.Add(this.lblCorreo);
            this.panelDatos.Controls.Add(this.txtCorreo);
            this.panelDatos.Controls.Add(this.lblDireccion);
            this.panelDatos.Controls.Add(this.txtDireccion);
            this.panelDatos.Controls.Add(this.chkActivo);
            this.panelDatos.Location = new System.Drawing.Point(730, 70);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(350, 369);
            this.panelDatos.TabIndex = 4;
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCedula.Location = new System.Drawing.Point(10, 8);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(47, 15);
            this.lblCedula.TabIndex = 0;
            this.lblCedula.Text = "Cédula:";
            // 
            // txtCedula
            // 
            this.txtCedula.Enabled = false;
            this.txtCedula.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCedula.Location = new System.Drawing.Point(10, 26);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(325, 23);
            this.txtCedula.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNombre.Location = new System.Drawing.Point(10, 55);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 15);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombre.Location = new System.Drawing.Point(10, 73);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(325, 23);
            this.txtNombre.TabIndex = 3;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblApellido.Location = new System.Drawing.Point(10, 102);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(55, 15);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtApellido
            // 
            this.txtApellido.Enabled = false;
            this.txtApellido.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtApellido.Location = new System.Drawing.Point(10, 120);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(325, 23);
            this.txtApellido.TabIndex = 5;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSexo.Location = new System.Drawing.Point(10, 149);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(38, 15);
            this.lblSexo.TabIndex = 6;
            this.lblSexo.Text = "Sexo:";
            // 
            // cmbSexo
            // 
            this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexo.Enabled = false;
            this.cmbSexo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbSexo.Location = new System.Drawing.Point(10, 167);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(120, 23);
            this.cmbSexo.TabIndex = 7;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFechaNacimiento.Location = new System.Drawing.Point(140, 149);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(109, 15);
            this.lblFechaNacimiento.TabIndex = 8;
            this.lblFechaNacimiento.Text = "Fecha Nacimiento:";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Enabled = false;
            this.dtpFechaNacimiento.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(140, 167);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(195, 23);
            this.dtpFechaNacimiento.TabIndex = 9;
            // 
            // lblTipoSangre
            // 
            this.lblTipoSangre.AutoSize = true;
            this.lblTipoSangre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTipoSangre.Location = new System.Drawing.Point(10, 196);
            this.lblTipoSangre.Name = "lblTipoSangre";
            this.lblTipoSangre.Size = new System.Drawing.Size(76, 15);
            this.lblTipoSangre.TabIndex = 10;
            this.lblTipoSangre.Text = "Tipo Sangre:";
            // 
            // cmbTipoSangre
            // 
            this.cmbTipoSangre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoSangre.Enabled = false;
            this.cmbTipoSangre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbTipoSangre.Location = new System.Drawing.Point(10, 214);
            this.cmbTipoSangre.Name = "cmbTipoSangre";
            this.cmbTipoSangre.Size = new System.Drawing.Size(120, 23);
            this.cmbTipoSangre.TabIndex = 11;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCelular.Location = new System.Drawing.Point(140, 196);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(48, 15);
            this.lblCelular.TabIndex = 12;
            this.lblCelular.Text = "Celular:";
            // 
            // txtCelular
            // 
            this.txtCelular.Enabled = false;
            this.txtCelular.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCelular.Location = new System.Drawing.Point(140, 214);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(195, 23);
            this.txtCelular.TabIndex = 13;
            // 
            // lblTelefonoExtra
            // 
            this.lblTelefonoExtra.AutoSize = true;
            this.lblTelefonoExtra.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTelefonoExtra.Location = new System.Drawing.Point(10, 243);
            this.lblTelefonoExtra.Name = "lblTelefonoExtra";
            this.lblTelefonoExtra.Size = new System.Drawing.Size(91, 15);
            this.lblTelefonoExtra.TabIndex = 14;
            this.lblTelefonoExtra.Text = "Teléfono Extra:";
            // 
            // txtTelefonoExtra
            // 
            this.txtTelefonoExtra.Enabled = false;
            this.txtTelefonoExtra.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTelefonoExtra.Location = new System.Drawing.Point(10, 261);
            this.txtTelefonoExtra.Name = "txtTelefonoExtra";
            this.txtTelefonoExtra.Size = new System.Drawing.Size(120, 23);
            this.txtTelefonoExtra.TabIndex = 15;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCorreo.Location = new System.Drawing.Point(140, 243);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(48, 15);
            this.lblCorreo.TabIndex = 16;
            this.lblCorreo.Text = "Correo:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Enabled = false;
            this.txtCorreo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCorreo.Location = new System.Drawing.Point(140, 261);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(195, 23);
            this.txtCorreo.TabIndex = 17;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDireccion.Location = new System.Drawing.Point(10, 290);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(63, 15);
            this.lblDireccion.TabIndex = 18;
            this.lblDireccion.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDireccion.Location = new System.Drawing.Point(10, 308);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(325, 23);
            this.txtDireccion.TabIndex = 19;
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Enabled = false;
            this.chkActivo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.chkActivo.Location = new System.Drawing.Point(10, 340);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(119, 19);
            this.chkActivo.TabIndex = 20;
            this.chkActivo.Text = "Empleado Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // panelUsuario
            // 
            this.panelUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panelUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelUsuario.Controls.Add(this.chkCrearUsuario);
            this.panelUsuario.Controls.Add(this.lblUsuario);
            this.panelUsuario.Controls.Add(this.txtUsuario);
            this.panelUsuario.Controls.Add(this.lblRol);
            this.panelUsuario.Controls.Add(this.cmbRol);
            this.panelUsuario.Controls.Add(this.lblClave);
            this.panelUsuario.Controls.Add(this.txtClave);
            this.panelUsuario.Controls.Add(this.chkUsuarioActivo);
            this.panelUsuario.Location = new System.Drawing.Point(730, 445);
            this.panelUsuario.Name = "panelUsuario";
            this.panelUsuario.Size = new System.Drawing.Size(350, 215);
            this.panelUsuario.TabIndex = 5;
            // 
            // chkCrearUsuario
            // 
            this.chkCrearUsuario.AutoSize = true;
            this.chkCrearUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.chkCrearUsuario.Location = new System.Drawing.Point(10, 8);
            this.chkCrearUsuario.Name = "chkCrearUsuario";
            this.chkCrearUsuario.Size = new System.Drawing.Size(117, 19);
            this.chkCrearUsuario.TabIndex = 0;
            this.chkCrearUsuario.Text = "🔑 Crear Usuario";
            this.chkCrearUsuario.UseVisualStyleBackColor = true;
            this.chkCrearUsuario.CheckedChanged += new System.EventHandler(this.chkCrearUsuario_CheckedChanged);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.Location = new System.Drawing.Point(10, 35);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(52, 15);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUsuario.Location = new System.Drawing.Point(10, 53);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(325, 23);
            this.txtUsuario.TabIndex = 2;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblRol.Location = new System.Drawing.Point(10, 82);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(28, 15);
            this.lblRol.TabIndex = 3;
            this.lblRol.Text = "Rol:";
            // 
            // cmbRol
            // 
            this.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRol.Enabled = false;
            this.cmbRol.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbRol.Location = new System.Drawing.Point(10, 100);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(325, 23);
            this.cmbRol.TabIndex = 4;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblClave.Location = new System.Drawing.Point(10, 129);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(72, 15);
            this.lblClave.TabIndex = 5;
            this.lblClave.Text = "Contraseña:";
            // 
            // txtClave
            // 
            this.txtClave.Enabled = false;
            this.txtClave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtClave.Location = new System.Drawing.Point(10, 147);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(325, 23);
            this.txtClave.TabIndex = 6;
            // 
            // chkUsuarioActivo
            // 
            this.chkUsuarioActivo.AutoSize = true;
            this.chkUsuarioActivo.Enabled = false;
            this.chkUsuarioActivo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.chkUsuarioActivo.Location = new System.Drawing.Point(10, 176);
            this.chkUsuarioActivo.Name = "chkUsuarioActivo";
            this.chkUsuarioActivo.Size = new System.Drawing.Size(107, 19);
            this.chkUsuarioActivo.TabIndex = 7;
            this.chkUsuarioActivo.Text = "Usuario Activo";
            this.chkUsuarioActivo.UseVisualStyleBackColor = true;
            // 
            // panelAcciones
            // 
            this.panelAcciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panelAcciones.Controls.Add(this.btnGuardar);
            this.panelAcciones.Controls.Add(this.btnCancelar);
            this.panelAcciones.Location = new System.Drawing.Point(730, 670);
            this.panelAcciones.Name = "panelAcciones";
            this.panelAcciones.Size = new System.Drawing.Size(350, 60);
            this.panelAcciones.TabIndex = 6;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnGuardar.Enabled = false;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(10, 10);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(150, 40);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "💾 Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnCancelar.Enabled = false;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(170, 10);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(150, 40);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "❌ Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1100, 749);
            this.Controls.Add(this.panelAcciones);
            this.Controls.Add(this.panelUsuario);
            this.Controls.Add(this.panelDatos);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.panelBusqueda);
            this.Controls.Add(this.panelSuperior);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "frmEmpleados";
            this.Text = "Gestión de Empleados";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmEmpleados_Load);
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.panelBusqueda.ResumeLayout(false);
            this.panelBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.panelBotones.ResumeLayout(false);
            this.panelDatos.ResumeLayout(false);
            this.panelDatos.PerformLayout();
            this.panelUsuario.ResumeLayout(false);
            this.panelUsuario.PerformLayout();
            this.panelAcciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}