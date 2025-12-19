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
    public partial class titleAuthor : Form
    {
        SQLControl control = new SQLControl();
        public titleAuthor()
        {
            InitializeComponent();
        }

        private void btnCANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            ADD_TitleAuthor add = new ADD_TitleAuthor();
            add.Show();
        }

        private void titleAuthor_Load(object sender, EventArgs e)
        {
            TAtable.DataSource = control.RefreshTA();
        }

        private void btnREFRESH_Click(object sender, EventArgs e)
        {
            TAtable.DataSource = null;
            TAtable.DataSource = control.RefreshTA();
        }

        private void TAtable_SelectionChanged(object sender, EventArgs e)
        {
            if (TAtable.SelectedRows.Count > 0)
            {

                DataGridViewRow selec = TAtable.SelectedRows[0];

                if (selec != null && !string.IsNullOrEmpty(selec.Cells[0].Value.ToString()))
                {
                    txtAuthorID.Text = selec.Cells[0].Value.ToString();
                    txtAuthorID.Enabled = false;
                    txtTitleID.Text = selec.Cells[1].Value.ToString();
                    txtAuthorORDER.Text = selec.Cells[2].Value.ToString();
                    txtRoyal.Text = selec.Cells[3].Value.ToString();
                }
            }
        }

        private void btnMODIFY_Click(object sender, EventArgs e)
        {
            string _auID, _TitleID, _auOR, _Royalp;
            try
            {
                if (TAtable.SelectedRows.Count == 1)
                {

                    DataGridViewRow selec = TAtable.SelectedRows[0];

                    if (selec != null && selec.Cells[0].Value != null && !string.IsNullOrEmpty(selec.Cells[0].Value.ToString()))
                    {
                        _auID = selec.Cells[0].Value.ToString();
                        _TitleID = selec.Cells[1].Value.ToString();
                        _auOR = selec.Cells[2].Value.ToString();
                        _Royalp = selec.Cells[3].Value.ToString();
                        modify_titleAuthor mod = new modify_titleAuthor(_auID,_TitleID,_auOR,_Royalp);
                        mod.Show();
                    }
                    else
                        MessageBox.Show("Select a valid record", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (TAtable.SelectedRows.Count == 0)
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
                string error = " ";
                error = control.DeleteTitleAuthor(txtTitleID.Text);
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = control.FilterTitleAuthor(txtSearch.Text);
                TAtable.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.ToString());
            }
        }
    }
}
