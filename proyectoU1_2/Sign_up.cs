using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;

namespace proyectoU1_2
{
    public partial class Sign_up : Form
    {
        SQLControl control = new SQLControl();
        public Sign_up()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string Error = "";

                Error =control.AddUser(txtUsser.Text,txtPass.Text, chkAdmin.Checked);
                if (txtConf.Text == txtPass.Text)
                {
                    if (string.IsNullOrEmpty(Error))
                    {
                        if (string.IsNullOrEmpty(Error))
                        {
                            MessageBox.Show("User added sucessfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show(Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (txtConf.Text != txtPass.Text)
                {
                    MessageBox.Show("Password does not match", "Atention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Sign_up_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
