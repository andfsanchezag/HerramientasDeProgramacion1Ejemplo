using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectoEjemplo
{
    public partial class Form1 : Form
    {
        private tienda tienda;
        private Controller controller;
        public Form1()
        {
            InitializeComponent();
            this.tienda = new tienda(1000000.0, new libro[3], new List<transaccion>());
            this.controller = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
                int iSBN = int.Parse(ISBN.Text);
                string titulo = Titulo.Text;
                int cantidad_actual = int.Parse(CantidadActual.Text);
                double precio_de_compra = double.Parse(PrecioCompra.Text);
                double precio_de_venta = double.Parse(PrecioVenta.Text);
                libro lib = new libro(iSBN, titulo, cantidad_actual, precio_de_venta, precio_de_compra);
                bool response = this.controller.RegistrarLibro(this.tienda, lib);
                if (response)
                {
                    MessageBox.Show("se ha registrado el libro en el catalogo");
                }
                else {
                    MessageBox.Show("el catalogo esta lleno");
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CantidadActual_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int iSBN = int.Parse(ISBN.Text);
                libro lib =this.controller.BuscarPorIsbn(this.tienda, iSBN);
                if (lib != null)
                {
                    MessageBox.Show(lib.ToString());
                }
                else {
                    MessageBox.Show("no existe un libro con ese ISBN");
                }
            }
            catch (Exception ex) { 
                MessageBox.Show(ex.Message );
            }
        }
    }
}
