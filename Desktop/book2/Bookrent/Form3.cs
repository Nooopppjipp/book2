using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookrent
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            lblMessage.Left = (this.ClientSize.Width - lblMessage.Width) / 2;
            lblMessage.Top = (this.ClientSize.Height - lblMessage.Height) / 3;
            btnOK.Left = (this.ClientSize.Width - btnOK.Width) / 2;
        }
        public Form3(string message)
        {
            InitializeComponent();
            lblMessage.Text = message;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
