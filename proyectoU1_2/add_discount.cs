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
    public partial class add_discount : Form
    {
        SQLControl control = new SQLControl();
        public add_discount()
        {
            InitializeComponent();
        }

        private void btnCANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            try
            {
                string Error = "";

                Error = control.AddDiscount(txtType.Text, txtStore.Text, Convert.ToInt32(txtLow.Text), Convert.ToInt32(txtHigh.Text),Convert.ToDouble(txtDisc.Text));

                if (string.IsNullOrEmpty(Error))
                {
                    MessageBox.Show("Discount added successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else
                {
                    MessageBox.Show(Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}