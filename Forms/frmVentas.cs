using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using WalkiriaPapeleria.DAO;
using WalkiriaPapeleria.Helpers;
using WalkiriaPapeleria.Models;

namespace WalkiriaPapeleria.Forms
{
    public partial class frmVentas : Form
    {
        private FacturaDAO facturaDAO;
        private ProductoDAO productoDAO;
        private ServicioDAO servicioDAO;
        private ClienteDAO clienteDAO;
        private List<DetalleFactura> detalles;
        private int idClienteSeleccionado = 0;
        private bool esClienteSeleccionado = false;
        private int ultimaFacturaGuardada = 0;
        private int indiceDetalleSeleccionado = -1;
        private bool esModificacion = false;

        public frmVentas()
        {
            InitializeComponent();
            facturaDAO = new FacturaDAO();
            productoDAO = new ProductoDAO();
            servicioDAO = new ServicioDAO();
            clienteDAO = new ClienteDAO();
            detalles = new List<DetalleFactura>();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            // Configurar métodos de pago
            cmbMetodoPago.Items.Clear();
            cmbMetodoPago.Items.Add("EFECTIVO");
            cmbMetodoPago.Items.Add("TRANSFERENCIA");
            cmbMetodoPago.Items.Add("TARJETA");
            cmbMetodoPago.SelectedIndex = 0;

            // Configurar categorías
            cmbCategoria.Items.Clear();
            cmbCategoria.Items.Add("PRODUCTO");
            cmbCategoria.Items.Add("SERVICIO");
            cmbCategoria.SelectedIndex = 0;

            // Generar número de factura
            txtNumeroFactura.Text = facturaDAO.ObtenerNumeroFactura();

            // Cargar listas para combos de búsqueda
            CargarProductos();
            CargarServicios();

            // Mostrar información del usuario, rol y turno
            if (SessionManager.IsLoggedIn)
            {
                lblUsuario.Text = "👤 Usuario: " + SessionManager.UsuarioActual.NombreCompleto;
                lblRol.Text = "🎭 Rol: " + SessionManager.UsuarioActual.RolNombre;
                string turno = SessionManager.TurnoActual ?? "No asignado";
                lblTurno.Text = "🕐 Turno: " + turno;

                if (turno.Contains("Matutino"))
                    lblTurno.ForeColor = System.Drawing.Color.FromArgb(243, 156, 18);
                else if (turno.Contains("Vespertino"))
                    lblTurno.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
                else
                    lblTurno.ForeColor = System.Drawing.Color.FromArgb(192, 57, 43);
            }
            else
            {
                lblUsuario.Text = "👤 Usuario: No autenticado";
                lblRol.Text = "🎭 Rol: No autenticado";
                lblTurno.Text = "🕐 Turno: No asignado";
            }

            CalcularTotales();
            btnAgregarDetalle.Enabled = false;
            btnEliminarDetalle.Enabled = false;
            btnModificarDetalle.Enabled = false;
            btnImprimirUltima.Enabled = false;
        }

        private void CargarProductos()
        {
            try
            {
                DataTable dt = productoDAO.ObtenerActivos();
                cmbProductos.DataSource = dt;
                cmbProductos.DisplayMember = "Nombre_Producto";
                cmbProductos.ValueMember = "ID_Producto";
                cmbProductos.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message);
            }
        }

        private void CargarServicios()
        {
            try
            {
                DataTable dt = servicioDAO.ObtenerActivos();
                cmbServicios.DataSource = dt;
                cmbServicios.DisplayMember = "Nombre_Servicio";
                cmbServicios.ValueMember = "ID_Servicio";
                cmbServicios.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar servicios: " + ex.Message);
            }
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            string categoria = cmbCategoria.SelectedItem.ToString();

            if (categoria == "PRODUCTO")
            {
                cmbProductos.Visible = true;
                cmbServicios.Visible = false;
                lblItem.Text = "Producto:";
                cmbProductos.SelectedIndex = -1;
            }
            else
            {
                cmbProductos.Visible = false;
                cmbServicios.Visible = true;
                lblItem.Text = "Servicio:";
                cmbServicios.SelectedIndex = -1;
            }

            txtPrecio.Clear();
            txtCantidad.Text = "1";
            txtStock.Text = "";
            esModificacion = false;
            indiceDetalleSeleccionado = -1;
            btnModificarDetalle.Enabled = false;
            btnAgregarDetalle.Text = "Añadir";
        }

        private void cmbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProductos.SelectedIndex >= 0)
            {
                DataRowView row = (DataRowView)cmbProductos.SelectedItem;
                txtPrecio.Text = row["Precio_Venta"].ToString();
                txtStock.Text = "Stock: " + row["Cantidad_Disponible"].ToString();
            }
            else
            {
                txtPrecio.Clear();
                txtStock.Text = "";
            }
            btnAgregarDetalle.Enabled = cmbProductos.SelectedIndex >= 0;
        }

        private void cmbServicios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbServicios.SelectedIndex >= 0)
            {
                DataRowView row = (DataRowView)cmbServicios.SelectedItem;
                txtPrecio.Text = row["Precio_Servicio"].ToString();
                txtStock.Text = "Disponible";
            }
            else
            {
                txtPrecio.Clear();
                txtStock.Text = "";
            }
            btnAgregarDetalle.Enabled = cmbServicios.SelectedIndex >= 0;
        }

        // ==================== SELECCIÓN DE DETALLE ====================
        private void dgvDetalle_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDetalle.SelectedRows.Count > 0)
            {
                indiceDetalleSeleccionado = dgvDetalle.SelectedRows[0].Index;
                btnEliminarDetalle.Enabled = true;
                btnModificarDetalle.Enabled = true;
            }
            else
            {
                indiceDetalleSeleccionado = -1;
                btnEliminarDetalle.Enabled = false;
                btnModificarDetalle.Enabled = false;
            }
        }

        // ==================== AGREGAR DETALLE ====================
        private void btnAgregarDetalle_Click(object sender, EventArgs e)
        {
            try
            {
                if (esModificacion)
                {
                    // Estamos en modo modificación, actualizar el detalle existente
                    ActualizarDetalleExistente();
                    return;
                }

                string categoria = cmbCategoria.SelectedItem.ToString();
                int? idProducto = null;
                int? idServicio = null;
                string nombreItem = "";
                decimal precio = 0;
                int cantidad = 1;

                if (!int.TryParse(txtCantidad.Text, out cantidad) || cantidad <= 0)
                {
                    MessageBox.Show("Ingrese una cantidad válida (mayor a 0).");
                    txtCantidad.Focus();
                    return;
                }

                if (categoria == "PRODUCTO")
                {
                    if (cmbProductos.SelectedIndex < 0)
                    {
                        MessageBox.Show("Seleccione un producto.");
                        return;
                    }

                    DataRowView row = (DataRowView)cmbProductos.SelectedItem;
                    idProducto = Convert.ToInt32(row["ID_Producto"]);
                    nombreItem = row["Nombre_Producto"].ToString();
                    precio = Convert.ToDecimal(row["Precio_Venta"]);

                    int stock = Convert.ToInt32(row["Cantidad_Disponible"]);
                    if (cantidad > stock)
                    {
                        MessageBox.Show("No hay suficiente stock disponible. Stock actual: " + stock);
                        return;
                    }
                }
                else
                {
                    if (cmbServicios.SelectedIndex < 0)
                    {
                        MessageBox.Show("Seleccione un servicio.");
                        return;
                    }

                    DataRowView row = (DataRowView)cmbServicios.SelectedItem;
                    idServicio = Convert.ToInt32(row["ID_Servicio"]);
                    nombreItem = row["Nombre_Servicio"].ToString();
                    precio = Convert.ToDecimal(row["Precio_Servicio"]);
                }

                DetalleFactura detalle = new DetalleFactura();
                detalle.Categoria = categoria;
                detalle.ID_Producto = idProducto;
                detalle.ID_Servicio = idServicio;
                detalle.NombreItem = nombreItem;
                detalle.Cantidad = cantidad;
                detalle.Precio_Unitario = precio;
                detalle.Descuento_Detalle = 0;
                detalle.Total_Detalle = cantidad * precio;

                detalles.Add(detalle);
                ActualizarGridDetalle();
                CalcularTotales();

                LimpiarCamposDetalle();
                txtCantidad.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar detalle: " + ex.Message);
            }
        }

        // ==================== MODIFICAR DETALLE ====================
        private void btnModificarDetalle_Click(object sender, EventArgs e)
        {
            if (indiceDetalleSeleccionado < 0 || indiceDetalleSeleccionado >= detalles.Count)
            {
                MessageBox.Show("Seleccione un detalle para modificar.");
                return;
            }

            // Cargar el detalle seleccionado en los campos
            DetalleFactura detalle = detalles[indiceDetalleSeleccionado];

            // Seleccionar categoría
            if (detalle.Categoria == "PRODUCTO")
            {
                cmbCategoria.SelectedIndex = 0;
                cmbProductos.SelectedValue = detalle.ID_Producto;
            }
            else
            {
                cmbCategoria.SelectedIndex = 1;
                cmbServicios.SelectedValue = detalle.ID_Servicio;
            }

            txtCantidad.Text = detalle.Cantidad.ToString();
            txtPrecio.Text = detalle.Precio_Unitario.ToString("F2");

            // Cambiar modo
            esModificacion = true;
            btnAgregarDetalle.Text = "Actualizar";
            btnModificarDetalle.Enabled = false;
            btnEliminarDetalle.Enabled = false;
            txtCantidad.Focus();
        }

        // ==================== ACTUALIZAR DETALLE EXISTENTE ====================
        private void ActualizarDetalleExistente()
        {
            try
            {
                if (indiceDetalleSeleccionado < 0 || indiceDetalleSeleccionado >= detalles.Count)
                {
                    MessageBox.Show("Error: No se encontró el detalle a modificar.");
                    return;
                }

                string categoria = cmbCategoria.SelectedItem.ToString();
                int? idProducto = null;
                int? idServicio = null;
                string nombreItem = "";
                decimal precio = 0;
                int cantidad = 1;

                if (!int.TryParse(txtCantidad.Text, out cantidad) || cantidad <= 0)
                {
                    MessageBox.Show("Ingrese una cantidad válida (mayor a 0).");
                    txtCantidad.Focus();
                    return;
                }

                if (categoria == "PRODUCTO")
                {
                    if (cmbProductos.SelectedIndex < 0)
                    {
                        MessageBox.Show("Seleccione un producto.");
                        return;
                    }

                    DataRowView row = (DataRowView)cmbProductos.SelectedItem;
                    idProducto = Convert.ToInt32(row["ID_Producto"]);
                    nombreItem = row["Nombre_Producto"].ToString();
                    precio = Convert.ToDecimal(row["Precio_Venta"]);

                    int stock = Convert.ToInt32(row["Cantidad_Disponible"]);
                    if (cantidad > stock)
                    {
                        MessageBox.Show("No hay suficiente stock disponible. Stock actual: " + stock);
                        return;
                    }
                }
                else
                {
                    if (cmbServicios.SelectedIndex < 0)
                    {
                        MessageBox.Show("Seleccione un servicio.");
                        return;
                    }

                    DataRowView row = (DataRowView)cmbServicios.SelectedItem;
                    idServicio = Convert.ToInt32(row["ID_Servicio"]);
                    nombreItem = row["Nombre_Servicio"].ToString();
                    precio = Convert.ToDecimal(row["Precio_Servicio"]);
                }

                // Actualizar el detalle existente
                DetalleFactura detalle = detalles[indiceDetalleSeleccionado];
                detalle.Categoria = categoria;
                detalle.ID_Producto = idProducto;
                detalle.ID_Servicio = idServicio;
                detalle.NombreItem = nombreItem;
                detalle.Cantidad = cantidad;
                detalle.Precio_Unitario = precio;
                detalle.Descuento_Detalle = 0;
                detalle.Total_Detalle = cantidad * precio;

                ActualizarGridDetalle();
                CalcularTotales();
                LimpiarCamposDetalle();

                // Resetear modo
                esModificacion = false;
                btnAgregarDetalle.Text = "Añadir";
                btnModificarDetalle.Enabled = true;
                btnEliminarDetalle.Enabled = true;
                indiceDetalleSeleccionado = -1;

                MessageBox.Show("✅ Detalle modificado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar detalle: " + ex.Message);
            }
        }

        // ==================== ELIMINAR DETALLE ====================
        private void btnEliminarDetalle_Click(object sender, EventArgs e)
        {
            if (indiceDetalleSeleccionado < 0 || indiceDetalleSeleccionado >= detalles.Count)
            {
                MessageBox.Show("Seleccione un detalle para eliminar.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "¿Está seguro que desea eliminar este detalle?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                detalles.RemoveAt(indiceDetalleSeleccionado);
                ActualizarGridDetalle();
                CalcularTotales();
                indiceDetalleSeleccionado = -1;
                btnEliminarDetalle.Enabled = false;
                btnModificarDetalle.Enabled = false;

                // Si estábamos en modo modificación, cancelarlo
                if (esModificacion)
                {
                    esModificacion = false;
                    btnAgregarDetalle.Text = "Añadir";
                    LimpiarCamposDetalle();
                }
            }
        }

        // ==================== ACTUALIZAR GRID ====================
        private void ActualizarGridDetalle()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Item");
            dt.Columns.Add("Cantidad");
            dt.Columns.Add("Precio");
            dt.Columns.Add("Total");

            foreach (var detalle in detalles)
            {
                DataRow row = dt.NewRow();
                row["Item"] = detalle.NombreItem;
                row["Cantidad"] = detalle.Cantidad;
                row["Precio"] = detalle.Precio_Unitario.ToString("C2");
                row["Total"] = detalle.Total_Detalle.ToString("C2");
                dt.Rows.Add(row);
            }

            dgvDetalle.DataSource = dt;
            ConfigurarGridDetalle();

            bool hayDetalles = detalles.Count > 0;
            btnEliminarDetalle.Enabled = hayDetalles;
            btnModificarDetalle.Enabled = hayDetalles;
        }

        private void ConfigurarGridDetalle()
        {
            if (dgvDetalle.Columns.Count > 0)
            {
                dgvDetalle.Columns[0].HeaderText = "Item";
                dgvDetalle.Columns[1].HeaderText = "Cantidad";
                dgvDetalle.Columns[2].HeaderText = "Precio";
                dgvDetalle.Columns[3].HeaderText = "Total";
                dgvDetalle.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
        }

        // ==================== CALCULAR TOTALES ====================
        private void CalcularTotales()
        {
            decimal subtotal = 0;
            foreach (var detalle in detalles)
            {
                subtotal += detalle.Total_Detalle;
            }

            decimal itbis = subtotal * 0.18m;
            decimal total = subtotal + itbis;

            lblSubtotal.Text = subtotal.ToString("C2");
            lblITBIS.Text = itbis.ToString("C2");
            lblTotal.Text = total.ToString("C2");
        }

        // ==================== LIMPIAR CAMPOS DE DETALLE ====================
        private void LimpiarCamposDetalle()
        {
            cmbProductos.SelectedIndex = -1;
            cmbServicios.SelectedIndex = -1;
            txtPrecio.Clear();
            txtCantidad.Text = "1";
            txtStock.Text = "";
            cmbCategoria.SelectedIndex = 0;
            esModificacion = false;
            btnAgregarDetalle.Text = "Añadir";
            btnModificarDetalle.Enabled = false;
        }

        // ==================== BUSCAR CLIENTE ====================
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            string cedula = txtBuscarCliente.Text.Trim();

            if (string.IsNullOrEmpty(cedula))
            {
                MessageBox.Show("Ingrese la cédula del cliente.");
                return;
            }

            try
            {
                DataTable dt = clienteDAO.BuscarPorCedula(cedula);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    idClienteSeleccionado = Convert.ToInt32(row["ID_Cliente"]);
                    esClienteSeleccionado = true;

                    string nombreCompleto = row["Nombre_Cliente"].ToString() + " " + row["Apellido_Cliente"].ToString();
                    lblClienteSeleccionado.Text = "Cliente: " + nombreCompleto;
                    lblClienteSeleccionado.ForeColor = System.Drawing.Color.FromArgb(46, 204, 113);
                    txtBuscarCliente.Clear();
                }
                else
                {
                    MessageBox.Show("Cliente no encontrado. La venta será sin cliente registrado.");
                    idClienteSeleccionado = 0;
                    esClienteSeleccionado = false;
                    lblClienteSeleccionado.Text = "Cliente: No registrado";
                    lblClienteSeleccionado.ForeColor = System.Drawing.Color.FromArgb(243, 156, 18);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar cliente: " + ex.Message);
            }
        }

        private void btnLimpiarCliente_Click(object sender, EventArgs e)
        {
            idClienteSeleccionado = 0;
            esClienteSeleccionado = false;
            lblClienteSeleccionado.Text = "Cliente: No registrado";
            lblClienteSeleccionado.ForeColor = System.Drawing.Color.FromArgb(243, 156, 18);
            txtBuscarCliente.Clear();
        }

        // ==================== GUARDAR VENTA ====================
        private void btnGuardarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                if (detalles.Count == 0)
                {
                    MessageBox.Show("Agregue al menos un producto o servicio a la venta.");
                    return;
                }

                if (cmbMetodoPago.SelectedIndex < 0)
                {
                    MessageBox.Show("Seleccione un método de pago.");
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "¿Está seguro que desea guardar esta factura?\n" +
                    "Total: " + lblTotal.Text,
                    "Confirmar venta",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                    return;

                Factura factura = new Factura();
                factura.Numero_Factura = txtNumeroFactura.Text;
                factura.ID_Cliente = esClienteSeleccionado ? (int?)idClienteSeleccionado : null;
                factura.ID_Usuario = SessionManager.UsuarioActual.ID_Usuario;
                factura.ID_Metodo_Pago = cmbMetodoPago.SelectedIndex + 1;

                decimal subtotal = 0;
                foreach (var detalle in detalles)
                {
                    subtotal += detalle.Total_Detalle;
                }
                decimal itbis = subtotal * 0.18m;

                factura.Subtotal = subtotal;
                factura.Descuento = 0;
                factura.ITBIS = itbis;
                factura.Total_Factura = subtotal + itbis;
                factura.Estado_Factura = true;

                int idFactura = facturaDAO.GuardarFactura(factura, detalles);

                if (idFactura > 0)
                {
                    ultimaFacturaGuardada = idFactura;

                    MessageBox.Show(
                        "✅ Factura guardada correctamente.\n" +
                        "Número: " + txtNumeroFactura.Text + "\n" +
                        "Total: " + factura.Total_Factura.ToString("C2"),
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    DialogResult imprimirResult = MessageBox.Show(
                        "¿Desea imprimir la factura?",
                        "Imprimir factura",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (imprimirResult == DialogResult.Yes)
                    {
                        frmImpresionFactura impresion = new frmImpresionFactura(idFactura);
                        impresion.ShowDialog();
                    }

                    LimpiarVenta();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la venta: " + ex.Message);
            }
        }

        // ==================== LIMPIAR VENTA ====================
        private void LimpiarVenta()
        {
            detalles.Clear();
            ActualizarGridDetalle();
            CalcularTotales();
            txtNumeroFactura.Text = facturaDAO.ObtenerNumeroFactura();
            LimpiarCamposDetalle();
            btnLimpiarCliente_Click(null, null);
            btnImprimirUltima.Enabled = true;
            btnEliminarDetalle.Enabled = false;
            btnModificarDetalle.Enabled = false;
            esModificacion = false;
            btnAgregarDetalle.Text = "Añadir";
        }

        private void btnImprimirUltima_Click(object sender, EventArgs e)
        {
            if (ultimaFacturaGuardada > 0)
            {
                frmImpresionFactura impresion = new frmImpresionFactura(ultimaFacturaGuardada);
                impresion.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay factura guardada para imprimir.",
                    "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancelarVenta_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "¿Está seguro que desea cancelar esta venta?\n" +
                "Se perderán todos los datos ingresados.",
                "Cancelar venta",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                LimpiarVenta();
                btnImprimirUltima.Enabled = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ==================== VALIDACIÓN DE CANTIDAD (solo números) ====================
        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}