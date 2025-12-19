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
    public partial class add_employee : Form
    {
        SQLControl control = new SQLControl();
        public add_employee()
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

                Error = control.AddEmployee(txtID.Text, txtName.Text, txtLName.Text, txtMinit.Text,Convert.ToInt32(txtJobID.Text),Convert.ToInt32(txtJobM.Text), txtPubID.Text, dtpHD.Value);

                if (string.IsNullOrEmpty(Error))
                {
                    MessageBox.Show("Employee added successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void add_employee_Load(object sender, EventArgs e)
        {

        }
    }
    
}
