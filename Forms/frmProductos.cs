using System;
using System.Data;
using System.Windows.Forms;
using WalkiriaPapeleria.DAO;
using WalkiriaPapeleria.Models;

namespace WalkiriaPapeleria.Forms
{
    public partial class frmProductos : Form
    {
        private ProductoDAO productoDAO;
        private bool esEdicion = false;
        private int idProductoSeleccionado = 0;

        public frmProductos()
        {
            InitializeComponent();
            productoDAO = new ProductoDAO();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            // Configurar ComboBox de Estado ANTES de todo
            cmbEstado.Items.Clear();
            cmbEstado.Items.Add("Disponible");
            cmbEstado.Items.Add("Agotado");
            cmbEstado.SelectedIndex = 0;

            CargarProductos();
            LimpiarCampos();
            btnEliminar.Enabled = false;
            btnEditar.Enabled = false;
        }

        private void CargarProductos()
        {
            try
            {
                DataTable dt = productoDAO.ObtenerTodos();
                dgvProductos.DataSource = dt;
                ConfigurarDataGridView();
                lblTotal.Text = "Total: " + dt.Rows.Count + " productos";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message);
            }
        }

        private void ConfigurarDataGridView()
        {
            try
            {
                if (dgvProductos.Columns.Contains("ID_Producto"))
                    dgvProductos.Columns["ID_Producto"].Visible = false;

                if (dgvProductos.Columns.Contains("Nombre_Producto"))
                    dgvProductos.Columns["Nombre_Producto"].HeaderText = "Producto";

                if (dgvProductos.Columns.Contains("Descripcion_Producto"))
                    dgvProductos.Columns["Descripcion_Producto"].HeaderText = "Descripción";

                if (dgvProductos.Columns.Contains("Precio_Venta"))
                {
                    dgvProductos.Columns["Precio_Venta"].HeaderText = "Precio";
                    dgvProductos.Columns["Precio_Venta"].DefaultCellStyle.Format = "C2";
                }

                if (dgvProductos.Columns.Contains("Cantidad_Disponible"))
                    dgvProductos.Columns["Cantidad_Disponible"].HeaderText = "Cantidad";

                if (dgvProductos.Columns.Contains("Estado_Producto"))
                    dgvProductos.Columns["Estado_Producto"].HeaderText = "Estado";

                if (dgvProductos.Columns.Contains("Fecha_Registro"))
                {
                    dgvProductos.Columns["Fecha_Registro"].HeaderText = "Fecha Registro";
                    dgvProductos.Columns["Fecha_Registro"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                }

                dgvProductos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error configurando DataGridView: " + ex.Message);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string busqueda = txtBuscar.Text.Trim();

            if (string.IsNullOrEmpty(busqueda) || busqueda == "Buscar...")
            {
                CargarProductos();
                return;
            }

            try
            {
                DataTable dt = productoDAO.BuscarPorNombre(busqueda);
                dgvProductos.DataSource = dt;
                ConfigurarDataGridView();
                lblTotal.Text = "Total: " + dt.Rows.Count + " productos encontrados";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
        }

        private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvProductos.SelectedRows[0];
                idProductoSeleccionado = Convert.ToInt32(row.Cells["ID_Producto"].Value);
                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
            }
            else
            {
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            esEdicion = false;
            idProductoSeleccionado = 0;
            LimpiarCampos();
            HabilitarCampos(true);
            txtNombre.Focus();
            btnGuardar.Text = "Guardar";
            lblTituloFormulario.Text = "Nuevo Producto";

            if (cmbEstado.Items.Count > 0)
            {
                cmbEstado.SelectedIndex = 0;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (idProductoSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un producto para editar.");
                return;
            }

            try
            {
                esEdicion = true;
                Producto producto = productoDAO.ObtenerPorID(idProductoSeleccionado);

                if (producto != null)
                {
                    txtNombre.Text = producto.Nombre_Producto;
                    txtDescripcion.Text = producto.Descripcion_Producto;
                    txtPrecio.Text = producto.Precio_Venta.ToString("F2");
                    txtCantidad.Text = producto.Cantidad_Disponible.ToString();

                    if (cmbEstado.Items.Count > 0)
                    {
                        cmbEstado.SelectedIndex = producto.Estado_Producto ? 0 : 1;
                    }
                }

                HabilitarCampos(true);
                txtNombre.Focus();
                btnGuardar.Text = "Actualizar";
                lblTituloFormulario.Text = "Editar Producto";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos())
                    return;

                Producto producto = new Producto();
                producto.Nombre_Producto = txtNombre.Text.Trim();
                producto.Descripcion_Producto = string.IsNullOrEmpty(txtDescripcion.Text.Trim()) ? null : txtDescripcion.Text.Trim();
                producto.Precio_Venta = Convert.ToDecimal(txtPrecio.Text.Trim());
                producto.Cantidad_Disponible = Convert.ToInt32(txtCantidad.Text.Trim());

                if (cmbEstado.Items.Count > 0)
                {
                    producto.Estado_Producto = cmbEstado.SelectedIndex == 0;
                }
                else
                {
                    producto.Estado_Producto = true;
                }

                if (esEdicion)
                {
                    producto.ID_Producto = idProductoSeleccionado;

                    if (productoDAO.Actualizar(producto))
                        MessageBox.Show("Producto actualizado correctamente.");
                }
                else
                {
                    if (productoDAO.ExisteNombre(producto.Nombre_Producto))
                    {
                        MessageBox.Show("Ya existe un producto con este nombre.");
                        txtNombre.Focus();
                        return;
                    }

                    if (productoDAO.Insertar(producto))
                        MessageBox.Show("Producto registrado correctamente.");
                }

                CargarProductos();
                LimpiarCampos();
                HabilitarCampos(false);
                btnGuardar.Text = "Guardar";
                lblTituloFormulario.Text = "Gestión de Productos";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idProductoSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un producto para eliminar.");
                return;
            }

            DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar este producto?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    if (productoDAO.Eliminar(idProductoSeleccionado))
                    {
                        MessageBox.Show("Producto eliminado correctamente.");
                        CargarProductos();
                        LimpiarCampos();
                        HabilitarCampos(false);
                        btnGuardar.Text = "Guardar";
                        lblTituloFormulario.Text = "Gestión de Productos";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            HabilitarCampos(false);
            btnGuardar.Text = "Guardar";
            lblTituloFormulario.Text = "Gestión de Productos";
            esEdicion = false;
            idProductoSeleccionado = 0;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtCantidad.Text = "";

            if (cmbEstado.Items.Count > 0)
            {
                cmbEstado.SelectedIndex = 0;
            }
        }

        private void HabilitarCampos(bool habilitar)
        {
            txtNombre.Enabled = habilitar;
            txtDescripcion.Enabled = habilitar;
            txtPrecio.Enabled = habilitar;
            txtCantidad.Enabled = habilitar;
            cmbEstado.Enabled = habilitar;
            btnGuardar.Enabled = habilitar;
            btnCancelar.Enabled = habilitar;
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre del producto es obligatorio.");
                txtNombre.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                MessageBox.Show("El precio es obligatorio.");
                txtPrecio.Focus();
                return false;
            }

            decimal precio;
            if (!decimal.TryParse(txtPrecio.Text, out precio) || precio <= 0)
            {
                MessageBox.Show("Ingrese un precio válido mayor a 0.");
                txtPrecio.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                MessageBox.Show("La cantidad es obligatoria.");
                txtCantidad.Focus();
                return false;
            }

            int cantidad;
            if (!int.TryParse(txtCantidad.Text, out cantidad) || cantidad < 0)
            {
                MessageBox.Show("Ingrese una cantidad válida (0 o mayor).");
                txtCantidad.Focus();
                return false;
            }

            return true;
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && txtPrecio.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}