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
    public partial class Form1 : Form
    {
        SQLControl control = new SQLControl();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        public void button4_Click(object sender, EventArgs e)
        {
            int result = control.Login(txtUser.Text, txtPass.Text);
            if(txtUser.Text != "" || txtPass.Text != "")
            {
                if (result == 1)
                {
                    this.Close();
                    admin_interface admin = new admin_interface();
                    admin.Show();
                }
                else if (result == 0)
                {
                    this.Close();
                    operator_interface operador = new operator_interface();
                    operador.Show();
                }
                else if (result != 1 && result != 0)
                {
                    MessageBox.Show("Incorrect user and password", "Atention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Fill all fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
