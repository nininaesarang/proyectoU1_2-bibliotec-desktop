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
    public partial class title : Form
    {
        SQLControl control = new SQLControl();
        public title()
        {
            InitializeComponent();
        }

        private void title_Load(object sender, EventArgs e)
        {
            dataTitle.DataSource = control.RefreshTitles();
        }

        private void btnTA_Click(object sender, EventArgs e)
        {
            titleAuthor TA = new titleAuthor();
            TA.Show();
        }

        private void btnREFRESH_Click(object sender, EventArgs e)
        {
            dataTitle.DataSource = null;
            dataTitle.DataSource = control.RefreshTitles();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = control.TitleFilter(txtSearch.Text);
                dataTitle.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.ToString());
            }
        }

        private void dataTitle_SelectionChanged(object sender, EventArgs e)
        {
            if (dataTitle.SelectedRows.Count > 0)
            {

                DataGridViewRow selec = dataTitle.SelectedRows[0];

                if (selec != null && !string.IsNullOrEmpty(selec.Cells[0].Value.ToString()))
                {
                    txtTitleID.Text = selec.Cells[0].Value.ToString();
                    txtTitleID.Enabled = false;
                    txtTitle.Text = selec.Cells[1].Value.ToString();
                    txtType.Text = selec.Cells[2].Value.ToString();
                    txtPubID.Text = selec.Cells[3].Value.ToString();
                    txtPrice.Text = selec.Cells[4].Value.ToString();
                    txtAdvance.Text = selec.Cells[5].Value.ToString();
                    txtRoyal.Text = selec.Cells[6].Value.ToString();
                    txtYTDS.Text = selec.Cells[7].Value.ToString();
                    txtNotes.Text = selec.Cells[8].Value.ToString();
                    dtpPubDate.Value = Convert.ToDateTime(selec.Cells[9].Value);
                }
            }
        }

        private void btnCANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMODIFY_Click(object sender, EventArgs e)
        {
            string _titleID, _TitleName, _type, _pID, _notes, _price, _advance, _royal, _ytdSales;
            DateTime _pubDate;
            try
            {
                if (dataTitle.SelectedRows.Count == 1)
                {

                    DataGridViewRow selec = dataTitle.SelectedRows[0];

                    if (selec != null && selec.Cells[0].Value != null && !string.IsNullOrEmpty(selec.Cells[0].Value.ToString()))
                    {
                        _titleID = selec.Cells[0].Value.ToString();
                        _TitleName = selec.Cells[1].Value.ToString();
                        _type = selec.Cells[2].Value.ToString();
                        _pID = selec.Cells[3].Value.ToString();
                        _price = selec.Cells[4].Value.ToString();
                        _advance = selec.Cells[5].Value.ToString();
                        _royal = selec.Cells[6].Value.ToString();
                        _ytdSales = selec.Cells[7].Value.ToString();
                        _notes = selec.Cells[8].ToString();
                        _pubDate = Convert.ToDateTime(selec.Cells[9].Value);
                        Modify_title mod = new Modify_title(_titleID,_TitleName,_type,_pID,_price,_advance,_royal,_ytdSales,_notes,_pubDate);
                        mod.Show();
                    }
                    else
                        MessageBox.Show("Select a valid record", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (dataTitle.SelectedRows.Count == 0)
                    MessageBox.Show("Select a valid record", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("Select 1 valid record", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            add_title add = new add_title();
            add.Show();
        }

        private void btnDELETE_Click(object sender, EventArgs e)
        {
            try
            {
                string Error = "";
                if (dataTitle.SelectedRows.Count == 1)
                {
                    DataGridViewRow selec = dataTitle.SelectedRows[0];

                    if (selec != null && selec.Cells[0].Value != null && !string.IsNullOrEmpty(selec.Cells[0].Value.ToString()))
                    {
                        DialogResult result = MessageBox.Show("Delete title?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            Error = control.DeleteTitle(selec.Cells[0].Value.ToString());

                            if (string.IsNullOrEmpty(Error))
                            {
                                MessageBox.Show("Title deleted correctly", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                else if (dataTitle.SelectedRows.Count == 0)
                    MessageBox.Show("Select a valid record", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("Select 1 valid record", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
