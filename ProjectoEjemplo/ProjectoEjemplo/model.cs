using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectoEjemplo
{
    public class tienda
    {
        private double caja;
        private libro []catalogo;
        private List<transaccion> transaccionList;

        public tienda(double caja, libro[] catalogo, List<transaccion> transaccionList)
        {
            this.Caja = caja;
            this.Catalogo = catalogo;
            this.TransaccionList = transaccionList;
            MessageBox.Show("se ha creado la tienda con " + caja + " en la caja");
            
            
        }

        public double Caja { get => caja; set => caja = value; }
        public libro[] Catalogo { get => catalogo; set => catalogo = value; }
        public List<transaccion> TransaccionList { get => transaccionList; set => transaccionList = value; }
    }
   public class libro
    {
        private int iSBN;
        private string titulo;
        private int cantidad_actual;
        private double precio_de_venta;
        private double precio_de_compra;

        public libro(int iSBN, string titulo, int cantidad_actual, double precio_de_venta, double precio_de_compra)
        {
            this.ISBN = iSBN;
            this.Titulo = titulo;
            this.Cantidad_actual = cantidad_actual;
            this.Precio_de_venta = precio_de_venta;
            this.Precio_de_compra = precio_de_compra;
        }

        public int ISBN { get => iSBN; set => iSBN = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public int Cantidad_actual { get => cantidad_actual; set => cantidad_actual = value; }
        public double Precio_de_venta { get => precio_de_venta; set => precio_de_venta = value; }
        public double Precio_de_compra { get => precio_de_compra; set => precio_de_compra = value; }

        public String ToString() { 
        return "ISBN: " + ISBN +
                "\nTitulo: " + Titulo +
                "\nCantidad actual :" + Cantidad_actual;
        }


    }
    public class transaccion
    {
        private libro libro;
        private DateTime date;
        private string tipo;

        public transaccion(libro libro, DateTime date, string tipo)
        {
            this.Libro = libro;
            this.Date = date;
            this.Tipo = tipo;
        }

        public libro Libro { get => libro; set => libro = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Tipo { get => tipo; set => tipo = value; }
    }
}
