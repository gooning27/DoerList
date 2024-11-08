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
    public partial class PassForm : Form
    {
        public PassForm()
        {
            InitializeComponent();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string currentPassword = txtBoxCurrentPassword.Text;
            string newPassword = txtBoxNewPassword.Text;
            string confirmPassword = txtBoxConfirmPassword.Text;

            
            if (currentPassword == null || newPassword == null || confirmPassword == null)
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            string actualCurrentPassword = "oldpassword";

            if (currentPassword != actualCurrentPassword)
            {
                MessageBox.Show("Current password is incorrect.");
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("New passwords do not match. Please try again.");
                return;
            }

            
            MessageBox.Show("Password changed successfully!");


            txtBoxCurrentPassword.Text = null;
            txtBoxNewPassword.Text = null;
            txtBoxConfirmPassword.Text = null;
        
    }
    }
}
