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
    public partial class operator_interface : Form
    {
        public operator_interface()
        {
            InitializeComponent();
        }

        private void btn_sales_Click(object sender, EventArgs e)
        {
            sales sales = new sales();
            sales.Show();
        }

        private void operator_interface_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void operator_interface_Load(object sender, EventArgs e)
        {

        }
    }
}
