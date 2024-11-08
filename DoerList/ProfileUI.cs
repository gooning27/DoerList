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
    public partial class ProfileUI : Form
    {
        public ProfileUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //change profile
        }

        private void BtnChangePass_Click(object sender, EventArgs e)
        {
            PassForm passForm = new PassForm();
            passForm.ShowDialog();
            this.Hide();
            
        }
    }
}
