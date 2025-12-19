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
    public partial class Sales__Administrator_ : Form
    {
        SQLControl control = new SQLControl();
        public Sales__Administrator_()
        {
            InitializeComponent();
        }

        private void btnCANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Sales__Administrator__Load(object sender, EventArgs e)
        {
            salesGrid.DataSource = control.RefreshSales_ADMIN();
        }

        private void salesGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (salesGrid.SelectedRows.Count > 0)
            {

                DataGridViewRow selec = salesGrid.SelectedRows[0];

                if (selec != null && !string.IsNullOrEmpty(selec.Cells[0].Value.ToString()))
                {
                    txtStoreID.Text = selec.Cells[0].Value.ToString();
                    txtOrderNO.Text = selec.Cells[1].Value.ToString();
                    dtpOD.Value = Convert.ToDateTime(selec.Cells[2].Value);
                    txtQTY.Text = selec.Cells[3].Value.ToString();
                    txtPay.Text = selec.Cells[4].Value.ToString();
                    txtTitleID.Text = selec.Cells[5].Value.ToString();
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = control.SaleFilter(txtSearch.Text);
                salesGrid.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.ToString());
            }
        }

        private void btnREFRESH_Click(object sender, EventArgs e)
        {
            salesGrid.DataSource = null;
            salesGrid.DataSource = control.RefreshSales_ADMIN();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            ADD_SALE add = new ADD_SALE();
            add.Show();
        }

        private void btnDELETE_Click(object sender, EventArgs e)
        {
            try
            {
                string error = " ";
                error = control.DeleteSale(txtOrderNO.Text);
                if (string.IsNullOrEmpty(error))
                {
                    MessageBox.Show("Record deleted successfully", "Information", MessageBoxButtons.OK,
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

        private void btnMODIFY_Click(object sender, EventArgs e)
        {
            string _store_id, _orderNo, _qty, _payterm, _titleID;
            DateTime _OrderDate;
            try
            {
                if (salesGrid.SelectedRows.Count == 1)
                {

                    DataGridViewRow selec = salesGrid.SelectedRows[0];

                    if (selec != null && selec.Cells[0].Value != null && !string.IsNullOrEmpty(selec.Cells[0].Value.ToString()))
                    {
                        _store_id = selec.Cells[0].Value.ToString();
                        _orderNo = selec.Cells[1].Value.ToString();
                        _OrderDate =Convert.ToDateTime(selec.Cells[2].Value);
                        _qty = selec.Cells[3].Value.ToString();
                        _payterm = selec.Cells[4].Value.ToString();
                        _titleID = selec.Cells[5].Value.ToString();
                        modify_sale modify = new modify_sale(_store_id, _orderNo, _OrderDate, _qty, _payterm, _titleID);
                        modify.Show();
                    }
                    else
                        MessageBox.Show("Select a valid record", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (salesGrid.SelectedRows.Count == 0)
                    MessageBox.Show("Select a valid record", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("Select 1 valid record", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtTitleID_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
