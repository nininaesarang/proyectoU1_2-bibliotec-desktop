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
    public partial class sales : Form
    {
        SQLControl control = new SQLControl();
        public sales()
        {
            InitializeComponent();
        }

        private void btnCANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sales_Load(object sender, EventArgs e)
        {
            dataGridSALES.DataSource = control.RefreshSaleManage();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridSALES_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            try
            {
                string error = control.sales(Convert.ToInt32(txtSELL.Text), txtTitle.Text, txtQTY.Text,txtStore.Text);
                if (string.IsNullOrEmpty(error))
                {
                    MessageBox.Show("Sale made successfully", "Information", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void btnDELETE_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = control.salesManageFilter(txtSearch.Text);
                dataGridSALES.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.ToString());
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {

        }

        private void btnREFRESH_Click(object sender, EventArgs e)
        {
            dataGridSALES.DataSource = null;
            dataGridSALES.DataSource = control.RefreshSaleManage();
        }

        private void dataGridSALES_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridSALES.SelectedRows.Count > 0)
            {

                DataGridViewRow selec = dataGridSALES.SelectedRows[0];

                if (selec != null && !string.IsNullOrEmpty(selec.Cells[0].Value.ToString()))
                {
                    txtTitle.Text = selec.Cells[0].Value.ToString();
                    txtAuthor.Text = selec.Cells[1].Value.ToString();
                    txtType.Text = selec.Cells[2].Value.ToString();
                    txtNotes.Text = selec.Cells[3].Value.ToString();
                    txtPDate.Text = selec.Cells[4].Value.ToString();
                    txtPrice.Text = selec.Cells[5].Value.ToString();
                    cmbDiscounts.Text = selec.Cells[6].Value.ToString();
                    txtQTY.Text = selec.Cells[7].Value.ToString();
                    txtStore.Text = selec.Cells[8].Value.ToString();

                }
            }
        }
    }
}
