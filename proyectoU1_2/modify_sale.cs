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
    public partial class modify_sale : Form
    {
        string _store_id, _orderNo, _qty, _payterm, _titleID;
        DateTime _OrderDate;

        private void modify_sale_Load(object sender, EventArgs e)
        {
            txtStoreID.Text = _store_id;
            txtOrderNO.Text = _orderNo;
            dtpOD.Value = _OrderDate;
            txtQTY.Text = _qty;
            txtPay.Text = _payterm;
            txtTitleID.Text = _titleID;
        }

        SQLControl control = new SQLControl();
        public modify_sale(string store_id, string orderNo, DateTime orderDate, string qty, string pay, string titleID)
        {
            InitializeComponent();
            _store_id = store_id;
            _orderNo = orderNo;
            _OrderDate = orderDate;
            _qty = qty;
            _payterm = pay;
            _titleID = titleID;
        }

        private void btnCANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            string Error = "";
            try
            {

                Error = control.ModifySale(txtStoreID.Text, txtOrderNO.Text, dtpOD.Value, Convert.ToInt32(txtQTY.Text), txtPay.Text, txtTitleID.Text);
                if (string.IsNullOrEmpty(Error))
                {
                    MessageBox.Show("Sale modified correctly", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
