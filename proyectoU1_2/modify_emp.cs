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
    public partial class modify_emp : Form
    {
        string _EmpID, _EmpName, _EmpLName, _minit, _jobID, _jobLVL, _pubID;

        private void btnMODIFY_Click(object sender, EventArgs e)
        {
            string Error = "";
            try
            {

                Error = control.ModifyEmployee(txtID.Text, txtName.Text, txtLName.Text, txtMinit.Text, Convert.ToInt32(txtJobID.Text), Convert.ToInt32(txtJobM.Text), txtPubID.Text, dtpHD.Value);
                if (string.IsNullOrEmpty(Error))
                {
                    MessageBox.Show("Employee modified correctly", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void modify_emp_Load(object sender, EventArgs e)
        {
            txtID.Text = _EmpID;
            txtID.Enabled = false;
            txtName.Text = _EmpName;
            txtLName.Text = _EmpLName;
            txtMinit.Text = _minit;
            txtJobID.Text = _jobID;
            txtJobM.Text = _jobLVL;
            txtPubID.Text = _pubID;
            dtpHD.Value = _HDate;
        }

        DateTime _HDate;
        SQLControl control = new SQLControl();
        public modify_emp(string EmpID, string empName, string emoLName, string minit, string jobID, string jobLVL, string pubID, DateTime HDate)
        {
            InitializeComponent();
            _EmpID = EmpID;
            _EmpName = empName;
            _EmpLName = emoLName;
            _minit = minit;
            _jobID = jobID;
            _jobLVL = jobLVL;
            _pubID = pubID;
            _HDate = HDate;
        }

        private void btnCANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
