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
    public partial class modify_titleAuthor : Form
    {
        SQLControl control = new SQLControl();
        string _auID, _TitleID, _auOR, _Royalp;

        private void btnMODIFY_Click(object sender, EventArgs e)
        {
            string Error = "";
            try
            {

                Error = control.modifyTitleAuthor(txtAuthorID.Text, txtTitleID.Text, Convert.ToInt32(txtAuthorORDER.Text), Convert.ToInt32(txtRoyal.Text));
                if (string.IsNullOrEmpty(Error))
                {
                    MessageBox.Show("Record modified correctly", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void modify_titleAuthor_Load(object sender, EventArgs e)
        {
            txtAuthorID.Text = _auID;
            txtTitleID.Text = _TitleID;
            txtAuthorORDER.Text = _auOR;
            txtRoyal.Text = _Royalp;
        }

        public modify_titleAuthor(string auID, string TitleID, string auOR, string RoyalP)
        {
            InitializeComponent();
            _auID = auID;
            _TitleID = TitleID;
            _auOR = auOR;
            _Royalp = RoyalP;
        }

        private void btnCANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
