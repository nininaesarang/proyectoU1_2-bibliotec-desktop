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
    public partial class Add_Author : Form
    {
        SQLControl control = new SQLControl();
        public Add_Author()
        {
            InitializeComponent();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            try
            {
                string Error = "";

                Error = control.AddAuthor(mkd_id.Text, txtName.Text, txtLName.Text, mkdPhone.Text, txtAddress.Text, txtCity.Text, txtState.Text, Convert.ToInt32(txtCP.Text), chkContract.Checked);

                if (string.IsNullOrEmpty(Error))
                {
                    MessageBox.Show("Author added successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
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

        private void btnDELETE_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
