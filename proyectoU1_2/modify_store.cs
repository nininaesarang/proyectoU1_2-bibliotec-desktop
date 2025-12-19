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
    public partial class modify_store : Form
    {
        string _storeID, _storeName, _address, _city, _state, _cp;

        private void modify_store_Load(object sender, EventArgs e)
        {
            txtStoreID.Text = _storeID;
            txtName.Text = _storeName;
            txtAddress.Text = _address;
            txtCity.Text = _city;
            txtState.Text = _state;
            txtCP.Text = _cp;
        }

        SQLControl control = new SQLControl();
        public modify_store(string storeID, string storeName, string address, string city, string state, string cp)
        {
            InitializeComponent();
            _storeID = storeID;
            _storeName = storeName;
            _address = address;
            _city = city;
            _state = state;
            _cp = cp;
        }

        private void btnCANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMODIFY_Click(object sender, EventArgs e)
        {
            string Error = "";
            try
            {

                Error = control.ModifyStore(txtStoreID.Text, txtName.Text, txtAddress.Text, txtCity.Text, txtState.Text, txtCP.Text);
                if (string.IsNullOrEmpty(Error))
                {
                    MessageBox.Show("Store modified correctly", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show(Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
