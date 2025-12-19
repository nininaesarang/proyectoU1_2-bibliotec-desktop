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
    public partial class Modify_title : Form
    {
        SQLControl control = new SQLControl();
        string _titleID, _TitleName, _type, _pID, _notes, _price, _advance, _royal, _ytdSales;

        private void btnMODIFY_Click(object sender, EventArgs e)
        {
            string Error = "";
            try
            {

                Error = control.ModifyTitle(txtTitleID.Text, txtTitle.Text, txtType.Text, txtPubID.Text, Convert.ToDouble(txtPrice.Text),Convert.ToDouble(txtAdvance.Text),Convert.ToInt32(txtRoyal.Text),Convert.ToInt32(txtYTDS.Text), txtNotes.Text, dtpPubDate.Value);
                if (string.IsNullOrEmpty(Error))
                {
                    MessageBox.Show("Title modified correctly", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void Modify_title_Load(object sender, EventArgs e)
        {
            txtTitleID.Text = _titleID;
            txtTitle.Text = _TitleName;
            txtType.Text = _type;
            txtPubID.Text = _pID;
            txtPrice.Text = _price;
            txtAdvance.Text = _advance;
            txtRoyal.Text = _royal;
            txtYTDS.Text = _ytdSales;
            txtNotes.Text = _notes;
            dtpPubDate.Value = _pubDate;
        }
        DateTime _pubDate;
        public Modify_title(string titleId, string titleName, string type, string pID, string price, string advance, string royal, string ytdSales, string notes, DateTime pDate)
        {
            InitializeComponent();
            _titleID = titleId;
            _TitleName = titleName;
            _type = type;
            _pID = pID;
            _price = price;
            _advance = advance;
            _royal = royal;
            _ytdSales = ytdSales;
            _notes = notes;
            _pubDate = pDate;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
