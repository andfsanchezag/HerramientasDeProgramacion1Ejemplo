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
        public Form1()
        {
            InitializeComponent();
            this.tienda = new tienda(1000000.0, new libro[20], new List<transaccion>());
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
