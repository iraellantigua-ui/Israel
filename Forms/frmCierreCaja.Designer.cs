using System.Drawing;
using System.Windows.Forms;

namespace WalkiriaPapeleria.Forms
{
    partial class frmCierreCaja
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panelSuperior;
        private Label lblTitulo;
        private Label lblTurnoActual;
        private Panel panelDatos;
        private Label lblCajero;
        private ComboBox cmbCajero;
        private Label lblFechaCierre;
        private DateTimePicker dtpFechaCierre;
        private Label lblTurnoCierre;
        private ComboBox cmbTurnoCierre;
        private Button btnBuscar;
        private Label lblSupervisor;
        private ComboBox cmbSupervisor;
        private Panel panelTotales;
        private Label lblTotalVentasTexto;
        private Label lblTotalVentas;
        private Label lblTotalEfectivoTexto;
        private Label lblTotalEfectivo;
        private Label lblTotalTarjetaTexto;
        private Label lblTotalTarjeta;
        private Label lblTotalTransferenciaTexto;
        private Label lblTotalTransferencia;
        private Label lblCantidadFacturasTexto;
        private Label lblCantidadFacturas;
        private DataGridView dgvVentasTurno;
        private Panel panelCierre;
        private Label lblFondoInicial;
        private TextBox txtFondoInicial;
        private Label lblMontoContado;
        private TextBox txtMontoContado;
        private Label lblDiferenciaTexto;
        private Label lblDiferencia;
        private Label lblObservacion;
        private TextBox txtObservacion;
        private CheckBox chkCierreConfirmado;
        private Panel panelBotones;
        private Button btnCalcular;
        private Button btnGuardarCierre;
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
            this.lblTurnoActual = new System.Windows.Forms.Label();
            this.panelDatos = new System.Windows.Forms.Panel();
            this.lblCajero = new System.Windows.Forms.Label();
            this.cmbCajero = new System.Windows.Forms.ComboBox();
            this.lblFechaCierre = new System.Windows.Forms.Label();
            this.dtpFechaCierre = new System.Windows.Forms.DateTimePicker();
            this.lblTurnoCierre = new System.Windows.Forms.Label();
            this.cmbTurnoCierre = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblSupervisor = new System.Windows.Forms.Label();
            this.cmbSupervisor = new System.Windows.Forms.ComboBox();
            this.panelTotales = new System.Windows.Forms.Panel();
            this.lblTotalVentasTexto = new System.Windows.Forms.Label();
            this.lblTotalVentas = new System.Windows.Forms.Label();
            this.lblTotalEfectivoTexto = new System.Windows.Forms.Label();
            this.lblTotalEfectivo = new System.Windows.Forms.Label();
            this.lblTotalTarjetaTexto = new System.Windows.Forms.Label();
            this.lblTotalTarjeta = new System.Windows.Forms.Label();
            this.lblTotalTransferenciaTexto = new System.Windows.Forms.Label();
            this.lblTotalTransferencia = new System.Windows.Forms.Label();
            this.lblCantidadFacturasTexto = new System.Windows.Forms.Label();
            this.lblCantidadFacturas = new System.Windows.Forms.Label();
            this.dgvVentasTurno = new System.Windows.Forms.DataGridView();
            this.panelCierre = new System.Windows.Forms.Panel();
            this.lblFondoInicial = new System.Windows.Forms.Label();
            this.txtFondoInicial = new System.Windows.Forms.TextBox();
            this.lblMontoContado = new System.Windows.Forms.Label();
            this.txtMontoContado = new System.Windows.Forms.TextBox();
            this.lblDiferenciaTexto = new System.Windows.Forms.Label();
            this.lblDiferencia = new System.Windows.Forms.Label();
            this.lblObservacion = new System.Windows.Forms.Label();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.chkCierreConfirmado = new System.Windows.Forms.CheckBox();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnGuardarCierre = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panelSuperior.SuspendLayout();
            this.panelDatos.SuspendLayout();
            this.panelTotales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasTurno)).BeginInit();
            this.panelCierre.SuspendLayout();
            this.panelBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panelSuperior.Controls.Add(this.lblTitulo);
            this.panelSuperior.Controls.Add(this.lblTurnoActual);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1100, 70);
            this.panelSuperior.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(20, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(213, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "💵 Cierre de Caja";
            // 
            // lblTurnoActual
            // 
            this.lblTurnoActual.AutoSize = true;
            this.lblTurnoActual.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTurnoActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.lblTurnoActual.Location = new System.Drawing.Point(850, 22);
            this.lblTurnoActual.Name = "lblTurnoActual";
            this.lblTurnoActual.Size = new System.Drawing.Size(160, 21);
            this.lblTurnoActual.TabIndex = 1;
            this.lblTurnoActual.Text = "🕐 Turno: Matutino";
            this.lblTurnoActual.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelDatos
            // 
            this.panelDatos.BackColor = System.Drawing.Color.White;
            this.panelDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDatos.Controls.Add(this.lblCajero);
            this.panelDatos.Controls.Add(this.cmbCajero);
            this.panelDatos.Controls.Add(this.lblFechaCierre);
            this.panelDatos.Controls.Add(this.dtpFechaCierre);
            this.panelDatos.Controls.Add(this.lblTurnoCierre);
            this.panelDatos.Controls.Add(this.cmbTurnoCierre);
            this.panelDatos.Controls.Add(this.btnBuscar);
            this.panelDatos.Controls.Add(this.lblSupervisor);
            this.panelDatos.Controls.Add(this.cmbSupervisor);
            this.panelDatos.Location = new System.Drawing.Point(10, 80);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(1080, 120);
            this.panelDatos.TabIndex = 1;
            // 
            // lblCajero
            // 
            this.lblCajero.AutoSize = true;
            this.lblCajero.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCajero.Location = new System.Drawing.Point(15, 15);
            this.lblCajero.Name = "lblCajero";
            this.lblCajero.Size = new System.Drawing.Size(57, 19);
            this.lblCajero.TabIndex = 0;
            this.lblCajero.Text = "Cajero:";
            // 
            // cmbCajero
            // 
            this.cmbCajero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCajero.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCajero.Location = new System.Drawing.Point(15, 37);
            this.cmbCajero.Name = "cmbCajero";
            this.cmbCajero.Size = new System.Drawing.Size(200, 25);
            this.cmbCajero.TabIndex = 1;
            // 
            // lblFechaCierre
            // 
            this.lblFechaCierre.AutoSize = true;
            this.lblFechaCierre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFechaCierre.Location = new System.Drawing.Point(240, 15);
            this.lblFechaCierre.Name = "lblFechaCierre";
            this.lblFechaCierre.Size = new System.Drawing.Size(51, 19);
            this.lblFechaCierre.TabIndex = 2;
            this.lblFechaCierre.Text = "Fecha:";
            // 
            // dtpFechaCierre
            // 
            this.dtpFechaCierre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpFechaCierre.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCierre.Location = new System.Drawing.Point(240, 37);
            this.dtpFechaCierre.Name = "dtpFechaCierre";
            this.dtpFechaCierre.Size = new System.Drawing.Size(150, 25);
            this.dtpFechaCierre.TabIndex = 3;
            // 
            // lblTurnoCierre
            // 
            this.lblTurnoCierre.AutoSize = true;
            this.lblTurnoCierre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTurnoCierre.Location = new System.Drawing.Point(420, 15);
            this.lblTurnoCierre.Name = "lblTurnoCierre";
            this.lblTurnoCierre.Size = new System.Drawing.Size(51, 19);
            this.lblTurnoCierre.TabIndex = 4;
            this.lblTurnoCierre.Text = "Turno:";
            // 
            // cmbTurnoCierre
            // 
            this.cmbTurnoCierre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTurnoCierre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTurnoCierre.Location = new System.Drawing.Point(420, 37);
            this.cmbTurnoCierre.Name = "cmbTurnoCierre";
            this.cmbTurnoCierre.Size = new System.Drawing.Size(150, 25);
            this.cmbTurnoCierre.TabIndex = 5;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(600, 35);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(120, 30);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "🔍 Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblSupervisor
            // 
            this.lblSupervisor.AutoSize = true;
            this.lblSupervisor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSupervisor.Location = new System.Drawing.Point(15, 75);
            this.lblSupervisor.Name = "lblSupervisor";
            this.lblSupervisor.Size = new System.Drawing.Size(87, 19);
            this.lblSupervisor.TabIndex = 7;
            this.lblSupervisor.Text = "Supervisor:";
            // 
            // cmbSupervisor
            // 
            this.cmbSupervisor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSupervisor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSupervisor.Location = new System.Drawing.Point(108, 75);
            this.cmbSupervisor.Name = "cmbSupervisor";
            this.cmbSupervisor.Size = new System.Drawing.Size(300, 25);
            this.cmbSupervisor.TabIndex = 8;
            // 
            // panelTotales
            // 
            this.panelTotales.BackColor = System.Drawing.Color.White;
            this.panelTotales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTotales.Controls.Add(this.lblTotalVentasTexto);
            this.panelTotales.Controls.Add(this.lblTotalVentas);
            this.panelTotales.Controls.Add(this.lblTotalEfectivoTexto);
            this.panelTotales.Controls.Add(this.lblTotalEfectivo);
            this.panelTotales.Controls.Add(this.lblTotalTarjetaTexto);
            this.panelTotales.Controls.Add(this.lblTotalTarjeta);
            this.panelTotales.Controls.Add(this.lblTotalTransferenciaTexto);
            this.panelTotales.Controls.Add(this.lblTotalTransferencia);
            this.panelTotales.Controls.Add(this.lblCantidadFacturasTexto);
            this.panelTotales.Controls.Add(this.lblCantidadFacturas);
            this.panelTotales.Location = new System.Drawing.Point(10, 210);
            this.panelTotales.Name = "panelTotales";
            this.panelTotales.Size = new System.Drawing.Size(438, 176);
            this.panelTotales.TabIndex = 2;
            // 
            // lblTotalVentasTexto
            // 
            this.lblTotalVentasTexto.AutoSize = true;
            this.lblTotalVentasTexto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalVentasTexto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblTotalVentasTexto.Location = new System.Drawing.Point(15, 15);
            this.lblTotalVentasTexto.Name = "lblTotalVentasTexto";
            this.lblTotalVentasTexto.Size = new System.Drawing.Size(107, 21);
            this.lblTotalVentasTexto.TabIndex = 0;
            this.lblTotalVentasTexto.Text = "Total Ventas:";
            // 
            // lblTotalVentas
            // 
            this.lblTotalVentas.AutoSize = true;
            this.lblTotalVentas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.lblTotalVentas.Location = new System.Drawing.Point(200, 15);
            this.lblTotalVentas.Name = "lblTotalVentas";
            this.lblTotalVentas.Size = new System.Drawing.Size(76, 21);
            this.lblTotalVentas.TabIndex = 1;
            this.lblTotalVentas.Text = "RD$ 0.00";
            // 
            // lblTotalEfectivoTexto
            // 
            this.lblTotalEfectivoTexto.AutoSize = true;
            this.lblTotalEfectivoTexto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTotalEfectivoTexto.Location = new System.Drawing.Point(15, 45);
            this.lblTotalEfectivoTexto.Name = "lblTotalEfectivoTexto";
            this.lblTotalEfectivoTexto.Size = new System.Drawing.Size(59, 19);
            this.lblTotalEfectivoTexto.TabIndex = 2;
            this.lblTotalEfectivoTexto.Text = "Efectivo:";
            // 
            // lblTotalEfectivo
            // 
            this.lblTotalEfectivo.AutoSize = true;
            this.lblTotalEfectivo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTotalEfectivo.Location = new System.Drawing.Point(200, 45);
            this.lblTotalEfectivo.Name = "lblTotalEfectivo";
            this.lblTotalEfectivo.Size = new System.Drawing.Size(66, 19);
            this.lblTotalEfectivo.TabIndex = 3;
            this.lblTotalEfectivo.Text = "RD$ 0.00";
            // 
            // lblTotalTarjetaTexto
            // 
            this.lblTotalTarjetaTexto.AutoSize = true;
            this.lblTotalTarjetaTexto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTotalTarjetaTexto.Location = new System.Drawing.Point(15, 70);
            this.lblTotalTarjetaTexto.Name = "lblTotalTarjetaTexto";
            this.lblTotalTarjetaTexto.Size = new System.Drawing.Size(51, 19);
            this.lblTotalTarjetaTexto.TabIndex = 4;
            this.lblTotalTarjetaTexto.Text = "Tarjeta:";
            // 
            // lblTotalTarjeta
            // 
            this.lblTotalTarjeta.AutoSize = true;
            this.lblTotalTarjeta.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTotalTarjeta.Location = new System.Drawing.Point(200, 70);
            this.lblTotalTarjeta.Name = "lblTotalTarjeta";
            this.lblTotalTarjeta.Size = new System.Drawing.Size(66, 19);
            this.lblTotalTarjeta.TabIndex = 5;
            this.lblTotalTarjeta.Text = "RD$ 0.00";
            // 
            // lblTotalTransferenciaTexto
            // 
            this.lblTotalTransferenciaTexto.AutoSize = true;
            this.lblTotalTransferenciaTexto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTotalTransferenciaTexto.Location = new System.Drawing.Point(15, 95);
            this.lblTotalTransferenciaTexto.Name = "lblTotalTransferenciaTexto";
            this.lblTotalTransferenciaTexto.Size = new System.Drawing.Size(91, 19);
            this.lblTotalTransferenciaTexto.TabIndex = 6;
            this.lblTotalTransferenciaTexto.Text = "Transferencia:";
            // 
            // lblTotalTransferencia
            // 
            this.lblTotalTransferencia.AutoSize = true;
            this.lblTotalTransferencia.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTotalTransferencia.Location = new System.Drawing.Point(200, 95);
            this.lblTotalTransferencia.Name = "lblTotalTransferencia";
            this.lblTotalTransferencia.Size = new System.Drawing.Size(66, 19);
            this.lblTotalTransferencia.TabIndex = 7;
            this.lblTotalTransferencia.Text = "RD$ 0.00";
            // 
            // lblCantidadFacturasTexto
            // 
            this.lblCantidadFacturasTexto.AutoSize = true;
            this.lblCantidadFacturasTexto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCantidadFacturasTexto.Location = new System.Drawing.Point(15, 120);
            this.lblCantidadFacturasTexto.Name = "lblCantidadFacturasTexto";
            this.lblCantidadFacturasTexto.Size = new System.Drawing.Size(153, 19);
            this.lblCantidadFacturasTexto.TabIndex = 8;
            this.lblCantidadFacturasTexto.Text = "Cantidad de Facturas:";
            // 
            // lblCantidadFacturas
            // 
            this.lblCantidadFacturas.AutoSize = true;
            this.lblCantidadFacturas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCantidadFacturas.Location = new System.Drawing.Point(200, 120);
            this.lblCantidadFacturas.Name = "lblCantidadFacturas";
            this.lblCantidadFacturas.Size = new System.Drawing.Size(17, 19);
            this.lblCantidadFacturas.TabIndex = 9;
            this.lblCantidadFacturas.Text = "0";
            // 
            // dgvVentasTurno
            // 
            this.dgvVentasTurno.AllowUserToAddRows = false;
            this.dgvVentasTurno.AllowUserToDeleteRows = false;
            this.dgvVentasTurno.BackgroundColor = System.Drawing.Color.White;
            this.dgvVentasTurno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVentasTurno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentasTurno.Location = new System.Drawing.Point(470, 210);
            this.dgvVentasTurno.Name = "dgvVentasTurno";
            this.dgvVentasTurno.ReadOnly = true;
            this.dgvVentasTurno.RowHeadersVisible = false;
            this.dgvVentasTurno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVentasTurno.Size = new System.Drawing.Size(620, 350);
            this.dgvVentasTurno.TabIndex = 3;
            // 
            // panelCierre
            // 
            this.panelCierre.BackColor = System.Drawing.Color.White;
            this.panelCierre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCierre.Controls.Add(this.lblFondoInicial);
            this.panelCierre.Controls.Add(this.txtFondoInicial);
            this.panelCierre.Controls.Add(this.lblMontoContado);
            this.panelCierre.Controls.Add(this.txtMontoContado);
            this.panelCierre.Controls.Add(this.lblDiferenciaTexto);
            this.panelCierre.Controls.Add(this.lblDiferencia);
            this.panelCierre.Controls.Add(this.lblObservacion);
            this.panelCierre.Controls.Add(this.txtObservacion);
            this.panelCierre.Controls.Add(this.chkCierreConfirmado);
            this.panelCierre.Location = new System.Drawing.Point(10, 392);
            this.panelCierre.Name = "panelCierre";
            this.panelCierre.Size = new System.Drawing.Size(438, 248);
            this.panelCierre.TabIndex = 4;
            // 
            // lblFondoInicial
            // 
            this.lblFondoInicial.AutoSize = true;
            this.lblFondoInicial.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFondoInicial.Location = new System.Drawing.Point(15, 15);
            this.lblFondoInicial.Name = "lblFondoInicial";
            this.lblFondoInicial.Size = new System.Drawing.Size(98, 19);
            this.lblFondoInicial.TabIndex = 0;
            this.lblFondoInicial.Text = "Fondo Inicial:";
            // 
            // txtFondoInicial
            // 
            this.txtFondoInicial.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFondoInicial.Location = new System.Drawing.Point(15, 37);
            this.txtFondoInicial.Name = "txtFondoInicial";
            this.txtFondoInicial.ReadOnly = true;
            this.txtFondoInicial.Size = new System.Drawing.Size(150, 25);
            this.txtFondoInicial.TabIndex = 1;
            this.txtFondoInicial.Text = "1000.00";
            this.txtFondoInicial.TextChanged += new System.EventHandler(this.txtFondoInicial_TextChanged);
            // 
            // lblMontoContado
            // 
            this.lblMontoContado.AutoSize = true;
            this.lblMontoContado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMontoContado.Location = new System.Drawing.Point(15, 68);
            this.lblMontoContado.Name = "lblMontoContado";
            this.lblMontoContado.Size = new System.Drawing.Size(118, 19);
            this.lblMontoContado.TabIndex = 2;
            this.lblMontoContado.Text = "Monto Contado:";
            // 
            // txtMontoContado
            // 
            this.txtMontoContado.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMontoContado.Location = new System.Drawing.Point(15, 90);
            this.txtMontoContado.Name = "txtMontoContado";
            this.txtMontoContado.ReadOnly = true;
            this.txtMontoContado.Size = new System.Drawing.Size(150, 25);
            this.txtMontoContado.TabIndex = 3;
            this.txtMontoContado.Text = "0.00";
            this.txtMontoContado.TextChanged += new System.EventHandler(this.txtMontoContado_TextChanged);
            // 
            // lblDiferenciaTexto
            // 
            this.lblDiferenciaTexto.AutoSize = true;
            this.lblDiferenciaTexto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblDiferenciaTexto.Location = new System.Drawing.Point(15, 121);
            this.lblDiferenciaTexto.Name = "lblDiferenciaTexto";
            this.lblDiferenciaTexto.Size = new System.Drawing.Size(93, 21);
            this.lblDiferenciaTexto.TabIndex = 4;
            this.lblDiferenciaTexto.Text = "Diferencia:";
            // 
            // lblDiferencia
            // 
            this.lblDiferencia.AutoSize = true;
            this.lblDiferencia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblDiferencia.Location = new System.Drawing.Point(200, 121);
            this.lblDiferencia.Name = "lblDiferencia";
            this.lblDiferencia.Size = new System.Drawing.Size(76, 21);
            this.lblDiferencia.TabIndex = 5;
            this.lblDiferencia.Text = "RD$ 0.00";
            // 
            // lblObservacion
            // 
            this.lblObservacion.AutoSize = true;
            this.lblObservacion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblObservacion.Location = new System.Drawing.Point(15, 148);
            this.lblObservacion.Name = "lblObservacion";
            this.lblObservacion.Size = new System.Drawing.Size(98, 19);
            this.lblObservacion.TabIndex = 6;
            this.lblObservacion.Text = "Observación:";
            // 
            // txtObservacion
            // 
            this.txtObservacion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtObservacion.Location = new System.Drawing.Point(15, 170);
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.ReadOnly = true;
            this.txtObservacion.Size = new System.Drawing.Size(315, 25);
            this.txtObservacion.TabIndex = 7;
            // 
            // chkCierreConfirmado
            // 
            this.chkCierreConfirmado.AutoSize = true;
            this.chkCierreConfirmado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.chkCierreConfirmado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.chkCierreConfirmado.Location = new System.Drawing.Point(200, 15);
            this.chkCierreConfirmado.Name = "chkCierreConfirmado";
            this.chkCierreConfirmado.Size = new System.Drawing.Size(232, 23);
            this.chkCierreConfirmado.TabIndex = 0;
            this.chkCierreConfirmado.Text = "✅ Confirmar Datos del Cierre";
            this.chkCierreConfirmado.UseVisualStyleBackColor = true;
            this.chkCierreConfirmado.CheckedChanged += new System.EventHandler(this.chkCierreConfirmado_CheckedChanged);
            // 
            // panelBotones
            // 
            this.panelBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panelBotones.Controls.Add(this.btnCalcular);
            this.panelBotones.Controls.Add(this.btnGuardarCierre);
            this.panelBotones.Controls.Add(this.btnCerrar);
            this.panelBotones.Location = new System.Drawing.Point(470, 580);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(620, 60);
            this.panelBotones.TabIndex = 5;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(14, 10);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(140, 40);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "🧮 Calcular Cierre";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnGuardarCierre
            // 
            this.btnGuardarCierre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnGuardarCierre.Enabled = false;
            this.btnGuardarCierre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCierre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGuardarCierre.ForeColor = System.Drawing.Color.White;
            this.btnGuardarCierre.Location = new System.Drawing.Point(160, 10);
            this.btnGuardarCierre.Name = "btnGuardarCierre";
            this.btnGuardarCierre.Size = new System.Drawing.Size(140, 40);
            this.btnGuardarCierre.TabIndex = 1;
            this.btnGuardarCierre.Text = "💾 Guardar Cierre";
            this.btnGuardarCierre.UseVisualStyleBackColor = false;
            this.btnGuardarCierre.Click += new System.EventHandler(this.btnGuardarCierre_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(423, 10);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(160, 40);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "✖ Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmCierreCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1100, 660);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.panelCierre);
            this.Controls.Add(this.dgvVentasTurno);
            this.Controls.Add(this.panelTotales);
            this.Controls.Add(this.panelDatos);
            this.Controls.Add(this.panelSuperior);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "frmCierreCaja";
            this.Text = "Cierre de Caja - Walkiria Papelería";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCierreCaja_Load);
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.panelDatos.ResumeLayout(false);
            this.panelDatos.PerformLayout();
            this.panelTotales.ResumeLayout(false);
            this.panelTotales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasTurno)).EndInit();
            this.panelCierre.ResumeLayout(false);
            this.panelCierre.PerformLayout();
            this.panelBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}