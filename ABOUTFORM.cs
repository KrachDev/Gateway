using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gateway
{
    public partial class ABOUTFORM : Form
    {
        public ABOUTFORM()
        {
            InitializeComponent();
        }

        private void ExitBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void ABOUTFORM_Load(object sender, EventArgs e)
        {
            verlvl.Text = Application.ProductVersion;

        }

        private void VersionLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
