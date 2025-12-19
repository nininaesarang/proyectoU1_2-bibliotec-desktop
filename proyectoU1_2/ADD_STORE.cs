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
    public partial class ADD_STORE : Form
    {
        SQLControl control = new SQLControl();
        public ADD_STORE()
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

                Error = control.AddStore(txtStoreID.Text, txtName.Text, txtAddress.Text, txtCity.Text, txtState.Text, txtCP.Text);

                if (string.IsNullOrEmpty(Error))
                {
                    MessageBox.Show("Store added successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void ADD_STORE_Load(object sender, EventArgs e)
        {

        }
    }
}
