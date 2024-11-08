using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoerList
{
    public partial class RegistrationUI : Form
    {
        public RegistrationUI()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtBoxUsername.Text;
            string password = txtBoxPassword.Text;
            string confirmPassword = txtBoxCfmPassword.Text;


            if (username == null || password = null || confirmPassword == null)
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match. Please try again.");
                return;
            }
            MessageBox.Show("Registration successful!");

            
            txtBoxUsername.Text = null;
            txtBoxPassword.Text = null;
            txtBoxCfmPassword.Text = null;
        }
    }
}
