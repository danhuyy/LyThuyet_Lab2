using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trang48
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TreeNode rNode, cNode;
            rNode = this.treeViewThucVat.Nodes.Add("Các loại hoa");
            rNode.ImageIndex = 0;
            cNode = new TreeNode("Hoa Lan");
            cNode.ImageIndex = 1;
            rNode.Nodes.Add(cNode);
            cNode = new TreeNode("Hoa Hồng", 2, 2);
            rNode.Nodes.Add(cNode);
            rNode = this.treeViewThucVat.Nodes.Add("Trái Cây");
            rNode.ImageIndex = 3;
            cNode = new TreeNode("Trái Xoài");
            cNode.ImageIndex = 4;
            rNode.Nodes.Add(cNode);
            cNode = new TreeNode("Trái Mít");
            cNode.ImageIndex = 5;
            rNode.Nodes.Add(cNode);
        }
    }
}
