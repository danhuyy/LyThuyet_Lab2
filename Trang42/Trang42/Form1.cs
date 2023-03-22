using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trang42
{
    public partial class Error : Form
    {
        public Error()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Lỗi chương trình, bạn muốn thoát?", "Error",
MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
