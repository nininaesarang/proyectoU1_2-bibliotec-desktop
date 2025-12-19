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
    public partial class store : Form
    {
        SQLControl control = new SQLControl();
        public store()
        {
            InitializeComponent();
        }

        private void btnCANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = control.StoreFilter(txtSearch.Text);
                storesGrid.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.ToString());
            }
        }

        private void btnREFRESH_Click(object sender, EventArgs e)
        {
            storesGrid.DataSource = null;
            storesGrid.DataSource = control.RefreshStores();
        }

        private void store_Load(object sender, EventArgs e)
        {
            storesGrid.DataSource = control.RefreshStores();
        }

        private void btnDELETE_Click(object sender, EventArgs e)
        {
            try
            {
                string Error = "";
                if (storesGrid.SelectedRows.Count == 1)
                {
                    DataGridViewRow selec = storesGrid.SelectedRows[0];

                    if (selec != null && selec.Cells[0].Value != null && !string.IsNullOrEmpty(selec.Cells[0].Value.ToString()))
                    {
                        DialogResult result = MessageBox.Show("Delete store?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            Error = control.DeleteStore(selec.Cells[0].Value.ToString());

                            if (string.IsNullOrEmpty(Error))
                            {
                                MessageBox.Show("Store deleted correctly", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                else if (storesGrid.SelectedRows.Count == 0)
                    MessageBox.Show("Select a valid record", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("Select 1 valid record", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void storesGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (storesGrid.SelectedRows.Count > 0)
            {

                DataGridViewRow selec = storesGrid.SelectedRows[0];

                if (selec != null && !string.IsNullOrEmpty(selec.Cells[0].Value.ToString()))
                {
                    txtStoreID.Text = selec.Cells[0].Value.ToString();
                    txtStoreID.Enabled = false;
                    txtName.Text = selec.Cells[1].Value.ToString();
                    txtAddress.Text = selec.Cells[2].Value.ToString();
                    txtCity.Text = selec.Cells[3].Value.ToString();
                    txtState.Text = selec.Cells[4].Value.ToString();
                    txtCP.Text = selec.Cells[5].Value.ToString();
                }
            }
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            ADD_STORE add = new ADD_STORE();
            add.Show();
        }

        private void btnMODIFY_Click(object sender, EventArgs e)
        {
            string _storeID, _storeName, _address, _city, _state, _cp;
            try
            {
                if (storesGrid.SelectedRows.Count == 1)
                {

                    DataGridViewRow selec = storesGrid.SelectedRows[0];

                    if (selec != null && selec.Cells[0].Value != null && !string.IsNullOrEmpty(selec.Cells[0].Value.ToString()))
                    {
                        _storeID = selec.Cells[0].Value.ToString();
                        _storeName = selec.Cells[1].Value.ToString();
                        _address = selec.Cells[2].Value.ToString();
                        _city = selec.Cells[3].Value.ToString();
                        _state = selec.Cells[4].Value.ToString();
                        _cp = selec.Cells[5].Value.ToString();
                        modify_store modify = new modify_store(_storeID, _storeName, _address, _city, _state, _cp);
                        modify.Show();
                    }
                    else
                        MessageBox.Show("Select a valid record", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (storesGrid.SelectedRows.Count == 0)
                    MessageBox.Show("Select a valid record", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("Select 1 valid record", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
