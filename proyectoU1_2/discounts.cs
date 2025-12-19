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
    public partial class discounts : Form
    {
        SQLControl control = new SQLControl();
        public discounts()
        {
            InitializeComponent();
        }

        private void discounts_Load(object sender, EventArgs e)
        {
            dataGridDiscounts.DataSource = control.RefreshDiscount();
        }

        private void btnCANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            add_discount add = new add_discount();
            add.Show();
        }

        private void btnMODIFY_Click(object sender, EventArgs e)
        {
            string _DType, _store_id, _low, _high, _discount;
            try
            {
                if (dataGridDiscounts.SelectedRows.Count == 1)
                {

                    DataGridViewRow selec = dataGridDiscounts.SelectedRows[0];

                    if (selec != null && selec.Cells[0].Value != null && !string.IsNullOrEmpty(selec.Cells[0].Value.ToString()))
                    {
                        _DType = selec.Cells[0].Value.ToString();
                        _store_id = selec.Cells[1].Value.ToString();
                        _low = selec.Cells[2].Value.ToString();
                        _high = selec.Cells[3].Value.ToString();
                        _discount = selec.Cells[4].Value.ToString();

                        modify_discount modify = new modify_discount(_DType,_store_id, _low, _high, _discount);
                        modify.Show();
                    }
                    else
                        MessageBox.Show("Select a valid record", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (dataGridDiscounts.SelectedRows.Count == 0)
                    MessageBox.Show("Select a valid record", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("Select 1 valid record", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
                if (dataGridDiscounts.SelectedRows.Count == 1)
                {
                    DataGridViewRow selec = dataGridDiscounts.SelectedRows[0];

                    if (selec != null && selec.Cells[0].Value != null && !string.IsNullOrEmpty(selec.Cells[0].Value.ToString()))
                    {
                        DialogResult result = MessageBox.Show("Delete discount?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            Error = control.DeleteDiscount(selec.Cells[0].Value.ToString());

                            if (string.IsNullOrEmpty(Error))
                            {
                                MessageBox.Show("Discount deleted correctly", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                control.RefreshAuthor();
                            }
                            else
                            {
                                MessageBox.Show(Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                        MessageBox.Show("Select a valid record", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (dataGridDiscounts.SelectedRows.Count == 0)
                    MessageBox.Show("Select a valid record", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("Select 1 valid record", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnREFRESH_Click(object sender, EventArgs e)
        {
            dataGridDiscounts.DataSource = null;
            dataGridDiscounts.DataSource = control.RefreshDiscount();
        }

        private void dataGridDiscounts_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridDiscounts.SelectedRows.Count > 0)
            {

                DataGridViewRow selec = dataGridDiscounts.SelectedRows[0];

                if (selec != null && !string.IsNullOrEmpty(selec.Cells[0].Value.ToString()))
                {
                    txtType.Text = selec.Cells[0].Value.ToString();
                    txtStore.Enabled = false;
                    txtStore.Text = selec.Cells[1].Value.ToString();
                    txtLow.Text = selec.Cells[2].Value.ToString();
                    txtHigh.Text = selec.Cells[3].Value.ToString();
                    txtDisc.Text = selec.Cells[4].Value.ToString();
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = control.discountFilter(txtSearch.Text);
                dataGridDiscounts.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.ToString());
            }
        }
    }
}
