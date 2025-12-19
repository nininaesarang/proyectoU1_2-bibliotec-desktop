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
    public partial class Authors : Form
    {
        SQLControl control = new SQLControl();
        public Authors()
        {
            InitializeComponent();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            Add_Author add = new Add_Author();
            add.Show();
        }

        private void btnCANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridSALES_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Authors_Load(object sender, EventArgs e)
        {
            dataGridAuthor.DataSource = control.RefreshAuthor();
        }

        private void btnMODIFY_Click(object sender, EventArgs e)
        {
            string _id, _name, _LName, _phone, _address, _city, _state, _cp;
            bool _contract;

            try
            {
                if (dataGridAuthor.SelectedRows.Count == 1)
                {

                    DataGridViewRow selec = dataGridAuthor.SelectedRows[0];

                    if (selec != null && selec.Cells[0].Value != null && !string.IsNullOrEmpty(selec.Cells[0].Value.ToString()))
                    {
                        _id = selec.Cells[0].Value.ToString();
                        _name = selec.Cells[1].Value.ToString();
                        _LName = selec.Cells[2].Value.ToString();
                        _phone = selec.Cells[3].Value.ToString();
                        _address = selec.Cells[4].Value.ToString();
                        _city = selec.Cells[5].Value.ToString();
                        _state = selec.Cells[6].Value.ToString();
                        _cp = selec.Cells[7].Value.ToString();
                        _contract = Convert.ToBoolean(selec.Cells[8].Value);
                        Modify_Author modify = new Modify_Author(_id, _name, _LName, _phone, _address, _city, _state, _cp,_contract) ;
                        modify.Show();
                    }
                    else
                        MessageBox.Show("Select a valid author", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (dataGridAuthor.SelectedRows.Count == 0)
                    MessageBox.Show("Select a valid author", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("Select 1 valid author", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnDELETE_Click(object sender, EventArgs e)
        {
            try
            {
                string Error = "";
                if (dataGridAuthor.SelectedRows.Count == 1)
                {
                    DataGridViewRow selec = dataGridAuthor.SelectedRows[0];

                    if (selec != null && selec.Cells[0].Value != null && !string.IsNullOrEmpty(selec.Cells[0].Value.ToString()))
                    {
                        DialogResult result = MessageBox.Show("Delete author?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            Error = control.DeleteAuthor(selec.Cells[0].Value.ToString());

                            if (string.IsNullOrEmpty(Error))
                            {
                                MessageBox.Show("Author deleted correctly", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                control.RefreshAuthor();
                            }
                            else
                            {
                                MessageBox.Show(Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                        MessageBox.Show("Select a valid author", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (dataGridAuthor.SelectedRows.Count == 0)
                    MessageBox.Show("Select a valid author", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("Select 1 valid author", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnREFRESH_Click(object sender, EventArgs e)
        {
            dataGridAuthor.DataSource = null;
            dataGridAuthor.DataSource = control.RefreshAuthor();
        }

        private void dataGridAuthor_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridAuthor.SelectedRows.Count > 0)
            {

                DataGridViewRow selec = dataGridAuthor.SelectedRows[0];

                if (selec != null && !string.IsNullOrEmpty(selec.Cells[0].Value.ToString()))
                {
                    mkd_id.Text = selec.Cells[0].Value.ToString();
                    mkd_id.Enabled = false;
                    txtLName.Text = selec.Cells[1].Value.ToString();
                    txtName.Text = selec.Cells[2].Value.ToString();
                    mkdPhone.Text = selec.Cells[3].Value.ToString();
                    txtAddress.Text = selec.Cells[4].Value.ToString();
                    txtCity.Text = selec.Cells[5].Value.ToString();
                    txtState.Text = selec.Cells[6].Value.ToString();
                    txtCP.Text = selec.Cells[7].Value.ToString();
                    chkContract.Checked = Convert.ToBoolean(selec.Cells[8].Value);

                }
            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = control.Filter(txtSearch.Text);
                dataGridAuthor.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.ToString());
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtLName_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void mkdPhone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void mkd_id_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtState_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCP_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void chkContract_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
