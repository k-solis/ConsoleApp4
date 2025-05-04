using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp4.EmpaquetarProductos
{
    public partial class EmpaquetarProductosForm : Form
    {
        public EmpaquetarProductosForm()
        {
            InitializeComponent();
            ordenEmpaquetadaBTN.Click += ordenEmpaquetadaBTN_Click;
            cancelarBTN.Click += cancelarBTN_Click;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void ordenEmpaquetadaBTN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La orden fue marcada como empacada.");
            this.Close();
        }

        private void cancelarBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
