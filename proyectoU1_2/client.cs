using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;

namespace proyectoU1_2
{
    public partial class client : Form
    {
        SQLControl control = new SQLControl();
        public client()
        {
            InitializeComponent();
        }

        private void client_Load(object sender, EventArgs e)
        {
            dataStock.DataSource = control.RefreshClient();
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
                dt = control.SearchStock(txtSearch.Text);
                dataStock.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.ToString());
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataStock_SelectionChanged(object sender, EventArgs e)
        {
            if (dataStock.SelectedRows.Count > 0)
            {

                DataGridViewRow selec = dataStock.SelectedRows[0];

                if (selec != null && !string.IsNullOrEmpty(selec.Cells[0].Value.ToString()))
                {
                    txtStore.Text = selec.Cells[0].Value.ToString();
                    txtTitle.Text = selec.Cells[1].Value.ToString();
                    txtAName.Text = selec.Cells[2].Value.ToString();
                    txtAuthorLN.Text = selec.Cells[3].Value.ToString();
                    txtQTY.Text = selec.Cells[4].Value.ToString();
                }
            }
        }

        private void btnAuthor_Click(object sender, EventArgs e)
        {
            try
            {

                string Error = control.author();

                if (Error != null)
                {
                    using (SaveFileDialog save = new SaveFileDialog())
                    {
                        save.Filter = "XML files (*.xml)|*.xml";
                        save.Title = "Save XML archive";
                        if (save.ShowDialog() == DialogResult.OK)
                        {
                            File.WriteAllText(save.FileName, Error);
                            MessageBox.Show("File saved correctly", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("File was not saved","Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show(Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            try
            {
                string Error = control.store();

                if (Error != null)
                {
                    using (SaveFileDialog save = new SaveFileDialog())
                    {
                        save.Filter = "XML files (*.xml)|*.xml";
                        save.Title = "Save XML archive";
                        if (save.ShowDialog() == DialogResult.OK)
                        {
                            File.WriteAllText(save.FileName, Error);
                            MessageBox.Show("File saved correctly", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("File was not saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show(Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTitle_Click(object sender, EventArgs e)
        {
            try
            {
                string Error = control.title();

                if (Error != null)
                {
                    using (SaveFileDialog save = new SaveFileDialog())
                    {
                        save.Filter = "XML files (*.xml)|*.xml";
                        save.Title = "Save XML archive";
                        if (save.ShowDialog() == DialogResult.OK)
                        {
                            File.WriteAllText(save.FileName, Error);
                            MessageBox.Show("File saved correctly", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("File was not saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show(Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
