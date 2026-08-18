using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using WalkiriaPapeleria.DAO;

namespace WalkiriaPapeleria.Forms
{
    public partial class frmImpresionFactura : Form
    {
        private int idFactura;
        private FacturaDAO facturaDAO;
        private string contenidoFactura = "";

        public frmImpresionFactura(int idFactura)
        {
            InitializeComponent();
            this.idFactura = idFactura;
            facturaDAO = new FacturaDAO();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void frmImpresionFactura_Load(object sender, EventArgs e)
        {
            CargarFactura();
        }

        private void CargarFactura()
        {
            try
            {
                var dtFactura = facturaDAO.ObtenerPorID(idFactura);
                var dtDetalle = facturaDAO.ObtenerDetalle(idFactura);

                if (dtFactura.Rows.Count > 0)
                {
                    var row = dtFactura.Rows[0];
                    string numero = row["Numero_Factura"].ToString();
                    string fecha = Convert.ToDateTime(row["Fecha_Factura"]).ToString("dd/MM/yyyy HH:mm");
                    string cliente = row["Cliente"].ToString();
                    string usuario = row["Usuario"].ToString();
                    string metodoPago = row["Metodo_Pago"].ToString();
                    string subtotal = Convert.ToDecimal(row["Subtotal"]).ToString("C2");
                    string descuento = Convert.ToDecimal(row["Descuento"]).ToString("C2");
                    string itbis = Convert.ToDecimal(row["ITBIS"]).ToString("C2");
                    string total = Convert.ToDecimal(row["Total_Factura"]).ToString("C2");

                    // Obtener datos del negocio
                    string nombreNegocio = "WALKIRIA PAPELERÍA";
                    string rnc = "130987654";
                    string direccion = "Nagua, República Dominicana";
                    string telefono = "809-507-0000";

                    // Construir contenido de la factura
                    contenidoFactura = "";
                    contenidoFactura += "========================================\n";
                    contenidoFactura += "          " + nombreNegocio + "\n";
                    contenidoFactura += "          RNC: " + rnc + "\n";
                    contenidoFactura += "          " + direccion + "\n";
                    contenidoFactura += "          Tel: " + telefono + "\n";
                    contenidoFactura += "========================================\n";
                    contenidoFactura += "\n";
                    contenidoFactura += "FACTURA: " + numero + "\n";
                    contenidoFactura += "FECHA: " + fecha + "\n";
                    contenidoFactura += "CLIENTE: " + cliente + "\n";
                    contenidoFactura += "USUARIO: " + usuario + "\n";
                    contenidoFactura += "METODO PAGO: " + metodoPago + "\n";
                    contenidoFactura += "\n";
                    contenidoFactura += "----------------------------------------\n";
                    contenidoFactura += "ITEM                CANT   PRECIO   TOTAL\n";
                    contenidoFactura += "----------------------------------------\n";

                    // Agregar detalles
                    foreach (DataRow detalle in dtDetalle.Rows)
                    {
                        string item = detalle["NombreItem"].ToString();
                        int cantidad = Convert.ToInt32(detalle["Cantidad"]);
                        decimal precio = Convert.ToDecimal(detalle["Precio_Unitario"]);
                        decimal totalDetalle = Convert.ToDecimal(detalle["Total_Detalle"]);

                        // Truncar nombre si es muy largo
                        if (item.Length > 20)
                            item = item.Substring(0, 20);

                        contenidoFactura += item.PadRight(20);
                        contenidoFactura += cantidad.ToString().PadLeft(5);
                        contenidoFactura += precio.ToString("C2").PadLeft(10);
                        contenidoFactura += totalDetalle.ToString("C2").PadLeft(10);
                        contenidoFactura += "\n";
                    }

                    contenidoFactura += "----------------------------------------\n";
                    contenidoFactura += "SUBTOTAL:".PadRight(35) + subtotal.PadLeft(10) + "\n";
                    contenidoFactura += "ITBIS (18%):".PadRight(35) + itbis.PadLeft(10) + "\n";
                    contenidoFactura += "TOTAL:".PadRight(35) + total.PadLeft(10) + "\n";
                    contenidoFactura += "========================================\n";
                    contenidoFactura += "       ¡GRACIAS POR SU COMPRA!\n";
                    contenidoFactura += "========================================\n";

                    // Mostrar en el TextBox
                    txtFactura.Text = contenidoFactura;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar factura: " + ex.Message);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                PrintDocument printDoc = new PrintDocument();
                printDoc.PrintPage += new PrintPageEventHandler(printDoc_PrintPage);

                PrintDialog printDialog = new PrintDialog();
                printDialog.Document = printDoc;

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDoc.Print();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al imprimir: " + ex.Message);
            }
        }

        private void printDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                // Configurar fuente para impresión (tamaño pequeño para tickets)
                Font font = new Font("Courier New", 10);
                float lineHeight = font.GetHeight(e.Graphics) + 2;
                float y = 50;
                float x = 50;

                // Imprimir línea por línea
                string[] lineas = contenidoFactura.Split('\n');
                foreach (string linea in lineas)
                {
                    e.Graphics.DrawString(linea, font, Brushes.Black, x, y);
                    y += lineHeight;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al imprimir: " + ex.Message);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}