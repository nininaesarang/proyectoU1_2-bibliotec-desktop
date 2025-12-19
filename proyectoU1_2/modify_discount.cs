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
    public partial class modify_discount : Form
    {
        string _DType, _store_id, _low, _high, _discount;
        SQLControl control = new SQLControl();

        private void btnCANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string Error = "";
            try
            {

                Error = control.ModifyDiscount(txtType.Text, txtStore.Text, Convert.ToInt32(txtLow.Text), Convert.ToInt32(txtHigh.Text), Convert.ToDouble(txtDisc.Text));
                if (string.IsNullOrEmpty(Error))
                {
                    MessageBox.Show("Discount modified correctly", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        public modify_discount(string dtype, string s_id, string low, string high, string disc)
        {
            InitializeComponent();
            _DType = dtype;
            _store_id = s_id;
            _low = low;
            _high = high;
            _discount = disc;
        }

        private void modify_discount_Load(object sender, EventArgs e)
        {
            txtType.Text = _DType;
            txtStore.Text = _store_id;
            txtLow.Text = _low;
            txtHigh.Text = _high;
            txtDisc.Text = _discount;
        }
    }
}
