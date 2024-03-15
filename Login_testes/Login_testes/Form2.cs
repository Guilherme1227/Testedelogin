using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_testes
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void EteLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
                try
                {
                    VisitLinkEte();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to open link that was clicked.");
                }

        }
        private void VisitLinkEte()
        {
            // Change the color of the link text by setting LinkVisited
            // to true.
            EteLink.LinkVisited = true;
            //Call the Process.Start method to open the default browser
            //with a URL:
            System.Diagnostics.Process.Start("http://www.etefmc.com.br");
        }

        private void AvaLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLinkAva();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }
        private void VisitLinkAva()
        {
            // Change the color of the link text by setting LinkVisited
            // to true.
            AvaLink.LinkVisited = true;
            //Call the Process.Start method to open the default browser
            //with a URL:
            System.Diagnostics.Process.Start("https://avarje.jesuitasbrasil.org.br/etemg/");
        }

        private void GitLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLinkGit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }
        private void VisitLinkGit()
        {
            // Change the color of the link text by setting LinkVisited
            // to true.
            GitLink.LinkVisited = true;
            //Call the Process.Start method to open the default browser
            //with a URL:
            System.Diagnostics.Process.Start("https://github.com/login");
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
