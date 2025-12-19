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
    public partial class admin_interface : Form
    {
        public admin_interface()
        {
            InitializeComponent();
        }

        private void admin_interface_Load(object sender, EventArgs e)
        {

        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            Sign_up sign_Up = new Sign_up();
            sign_Up.Show();
        }

        private void btn_sales_Click(object sender, EventArgs e)
        {
            sales sales = new sales();
            sales.Show();
        }

        private void btn_stock_Click(object sender, EventArgs e)
        {
            stock stock = new stock();
            stock.Show();
        }

        private void admin_interface_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void admin_interface_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
