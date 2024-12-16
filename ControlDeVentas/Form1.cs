using System.Collections;
using System.Globalization;

namespace ControlDeVentas
{
    public partial class Form1 : Form
    {
        //Inicializar arreglo de producto
        static string[] productos = { "Teclado", "Impresora", "Lavadora", "Azucar" };
        //Objeto de la clase ArrayList
        ArrayList aProducto = new ArrayList(productos);
        //Objeto de la clase ventas
        Ventas objV = new Ventas();
        //Acumula totales
        double total;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarFecha();
            MostrarHora();
            LimpiarCampos();
            lblTotalNeto.Text = "0.00";
            LlenarProducto();

        }

        private void MostrarFecha()
        {
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void MostrarHora()
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void LimpiarCampos()
        {
            txtCliente.Clear();
            cobProducto.Text = "Seleccione un producto";
            txtCantidad.Clear();
            lblPrecio.Text = "0.00";
            txtCliente.Focus();
        }

        private void LlenarProducto()
        {
            foreach (var p in aProducto)
            {
                cobProducto.Items.Add(p);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Desea salir...?", "Ventas", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                LimpiarCampos();
            }

        }

        private void cobProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            CultureInfo culturaPeru = new CultureInfo("es-PE");
            objV.Producto = cobProducto.Text;
            lblPrecio.Text = objV.AsignarPrecio().ToString("C",culturaPeru);

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Establecer la cultura para Soles Peruanos (PEN)
            CultureInfo culturaPeru = new CultureInfo("es-PE");

            //Enviando los datos a la clase ventas
            objV.Producto = cobProducto.Text;
            objV.Cantidad = int.Parse(txtCantidad.Text);

            //Imprimiendo los resultados
            ListViewItem fila = new ListViewItem(objV.Producto);
            fila.SubItems.Add(objV.Cantidad.ToString());
            fila.SubItems.Add(objV.AsignarPrecio().ToString("C", culturaPeru));
            fila.SubItems.Add(objV.CalcularSubTotal().ToString("C", culturaPeru));
            fila.SubItems.Add(objV.CalcularDescuento().ToString("C", culturaPeru));
            fila.SubItems.Add(objV.CalcularNeto().ToString("C", culturaPeru));

            lvRegistro.Items.Add(fila);

            //Suma de producto
            total += objV.CalcularNeto();

            //Imprime el total
            lblTotalNeto.Text = total.ToString("C", culturaPeru);

            //Limpiando campos
            LimpiarCampos();

        }

        private void lblPrecio_Click(object sender, EventArgs e)
        {

        }
    }
}
