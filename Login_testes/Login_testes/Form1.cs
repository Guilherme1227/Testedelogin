using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Login_testes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tipText.Text = "Username = admin \nPassword = ds@etefmc";
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            string user = userBox.Text;
            string password = passwordBox.Text;

            if (user == "admin" && password == "ds@etefmc")
            {
                tipText.Text = "Login completed with success.";
                Thread.Sleep(2000);
                Form2 f2 = new Form2();
                f2.ShowDialog();
                this.Close();

            }
            else
            {
                tipText.Text = "Wrong username or password.";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
            passwordBox.PasswordChar = '●';
        }
    }
}
