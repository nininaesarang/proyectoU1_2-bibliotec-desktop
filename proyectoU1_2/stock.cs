using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoU1_2
{
    public partial class stock : Form
    {
        public stock()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            store store = new store();
            store.Show();
        }

        private void btnAuthor_Click(object sender, EventArgs e)
        {
            Authors authors = new Authors();
            authors.Show();
        }

        private void btnDiscounts_Click(object sender, EventArgs e)
        {
            discounts disc = new discounts();
            disc.Show();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            Sales__Administrator_ salesADMIN = new Sales__Administrator_();
            salesADMIN.Show();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            employee emp = new employee();
            emp.Show();
        }

        private void btnTITLES_Click(object sender, EventArgs e)
        {
            title t = new title();
            t.Show();
        }
    }
}
