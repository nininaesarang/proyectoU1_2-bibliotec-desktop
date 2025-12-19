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
    public partial class employee : Form
    {
        SQLControl control = new SQLControl();
        public employee()
        {
            InitializeComponent();
        }

        private void btnREFRESH_Click(object sender, EventArgs e)
        {
            dataEmp.DataSource = null;
            dataEmp.DataSource = control.RefreshEmployee();
        }

        private void employee_Load(object sender, EventArgs e)
        {
            dataEmp.DataSource = control.RefreshEmployee();
        }

        private void btnCANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            add_employee add = new add_employee();
            add.Show();
        }

        private void dataEmp_SelectionChanged(object sender, EventArgs e)
        {
            if (dataEmp.SelectedRows.Count > 0)
            {
                DataGridViewRow selec = dataEmp.SelectedRows[0];

                if (selec != null && !string.IsNullOrEmpty(selec.Cells[0].Value.ToString()))
                {
                    txtID.Text = selec.Cells[0].Value.ToString();
                    txtID.Enabled = false;
                    txtName.Text = selec.Cells[1].Value.ToString();
                    txtLName.Text = selec.Cells[2].Value.ToString();
                    txtMinit.Text = selec.Cells[3].Value.ToString();
                    txtJobID.Text = selec.Cells[4].Value.ToString();
                    txtJobM.Text = selec.Cells[5].Value.ToString();
                    txtPubID.Text = selec.Cells[6].Value.ToString();
                    dtpHD.Text = selec.Cells[7].Value.ToString();
                }
            }
        }

        private void btnDELETE_Click(object sender, EventArgs e)
        {
            try
            {
                string error = " ";
                error = control.DeleteEmployee(txtID.Text);
                if (string.IsNullOrEmpty(error))
                {
                    MessageBox.Show("Employee deleted successfully", "Information", MessageBoxButtons.OK,
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
            string _EmpID, _EmpName, _EmpLName, _minit, _jobID, _jobLVL, _pubID;
            DateTime _HDate;
            try
            {
                if (dataEmp.SelectedRows.Count == 1)
                {

                    DataGridViewRow selec = dataEmp.SelectedRows[0];

                    if (selec != null && selec.Cells[0].Value != null && !string.IsNullOrEmpty(selec.Cells[0].Value.ToString()))
                    {
                        _EmpID = selec.Cells[0].Value.ToString();
                        _EmpName = selec.Cells[1].Value.ToString();
                        _EmpLName = selec.Cells[2].Value.ToString();
                        _minit = selec.Cells[3].Value.ToString();
                        _jobID = selec.Cells[4].Value.ToString();
                        _jobLVL = selec.Cells[5].Value.ToString();
                        _pubID = selec.Cells[6].Value.ToString();
                        _HDate = Convert.ToDateTime(selec.Cells[7].Value.ToString());
                        modify_emp modify_ = new modify_emp(_EmpID, _EmpName, _EmpLName, _minit, _jobID, _jobLVL, _pubID, _HDate);
                        modify_.Show();
                    }
                    else
                        MessageBox.Show("Select a valid record", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (dataEmp.SelectedRows.Count == 0)
                    MessageBox.Show("Select a valid record", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("Select 1 valid record", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnCANCEL_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearchEmp_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = control.EmployeeFilter(txtSearchEmp.Text);
                dataEmp.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.ToString());
            }
        }
    }
}
