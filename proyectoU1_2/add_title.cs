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
    public partial class add_title : Form
    {
        SQLControl control = new SQLControl();
        public add_title()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            try
            {
                string Error = "";

                Error = control.addTitle(txtTitleID.Text, txtTitle.Text, txtType.Text, txtPubID.Text, Convert.ToDouble(txtPrice.Text), Convert.ToDouble(txtAdvance.Text), Convert.ToInt32(txtRoyal.Text), Convert.ToInt32(txtYTDS.Text), txtNotes.Text, dtpPubDate.Value);

                if (string.IsNullOrEmpty(Error))
                {
                    MessageBox.Show("Title added successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
