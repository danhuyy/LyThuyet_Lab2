using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Trang60
{ 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        protected override void OnMouseWheel(MouseEventArgs e)
        {
            if (e.Delta > 0) MessageBox.Show("Bạn vừa Scroll chuột lên");
            else MessageBox.Show("Bạn vừa Scroll chuột xuống");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
                   }

        private void button5_Click(object sender, EventArgs e)
        {
            this.ReSet();
        }
        private void ReSet()
        {
            this.lbThongTin.Text = "";
            this.txtMaNV.Text = "";
            this.txtHoTen.Text = "";
            this.txtDiaChi.Text = "";
            this.dtpNgay.Value = DateTime.Now;
            this.txtHinh.Text = "";
            this.cbPhong.Text = "";
            this.txtEmail.Text = "";
            this.rdNam.Checked = true;
            this.txtSoDT.Text = "";

        }
      

        private void textBox5txtEmai_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    private void txtDiaChi_TextChanged(object sender, EventArgs e)
    {

    }
}

}
