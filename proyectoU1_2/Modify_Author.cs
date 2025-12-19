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
    public partial class Modify_Author : Form
    {
        string _id, _name, _LName, _phone, _address, _city, _state, _cp;

        private void btnDELETE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool _contract;
        SQLControl control = new SQLControl();

        public Modify_Author(string id, string name, string LName, string phone, string address, string city, string state, string cp, bool contract)
        {
            InitializeComponent();
            _id = id;
            _name = name;
            _LName = LName;
            _phone = phone;
            _address = address;
            _city = city;
            _state = state;
            _cp = cp;
            _contract = contract;
        }

        private void Modify_Author_Load(object sender, EventArgs e)
        {
            mkd_id.Text = _id;
            mkd_id.Enabled = false;
            txtName.Text = _name;
            txtLName.Text = _LName;
            mkdPhone.Text = _phone;
            txtAddress.Text = _address;
            txtCity.Text = _city;
            txtState.Text = _state;
            txtCP.Text = _cp;
            chkContract.Checked = _contract;
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            string Error = "";
            try
            {

                Error = control.ModifyAuthor(mkd_id.Text, txtName.Text, txtLName.Text, mkdPhone.Text, txtAddress.Text, txtCity.Text, txtState.Text, Convert.ToInt32(txtCP.Text), chkContract.Checked);
                if (string.IsNullOrEmpty(Error))
                {
                    MessageBox.Show("Author modified correctly", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
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
