using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeVentas
{
    class Ventas
    {
		private string _Prodcuto;
		private int _cantidad;

        public string Producto
        {
            get { return _Prodcuto; }
            set { _Prodcuto = value; }
        }
        public int Cantidad
		{
			get { return _cantidad; }
			set { _cantidad = value; }
		}

        //Asignacion de precio de los productos
        public double AsignarPrecio()
        {
            switch (Producto)
            {
                case "Teclado": return 35;
                case "Impresora": return 350;
                case "Lavadora": return 550;
                case "Azucar": return 50;
            }
            return 0;
        }

        //Calculando el Subtotal
        public double CalcularSubTotal()
        {
            return AsignarPrecio() * Cantidad;
        }

        //Calculando el descuento
        public double CalcularDescuento()
        {
            double suboTotal = CalcularSubTotal();

            if (suboTotal <= 300) return 5.0 / 100 * suboTotal;
            else if (suboTotal > 300 && suboTotal <= 500) return 10.0 / 100 * suboTotal;
            else return 12.5 / 100 * suboTotal;
        }

        //Calculando el neto
        public double CalcularNeto()
        {
            return CalcularSubTotal() - CalcularDescuento();
        }

		

	}
}
