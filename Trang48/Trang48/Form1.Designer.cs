namespace Trang48
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.treeViewThucVat = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // treeViewThucVat
            // 
            this.treeViewThucVat.ImageIndex = 0;
            this.treeViewThucVat.ImageList = this.imageList1;
            this.treeViewThucVat.Location = new System.Drawing.Point(39, 27);
            this.treeViewThucVat.Name = "treeViewThucVat";
            this.treeViewThucVat.SelectedImageIndex = 0;
            this.treeViewThucVat.Size = new System.Drawing.Size(111, 141);
            this.treeViewThucVat.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "hoa.png");
            this.imageList1.Images.SetKeyName(1, "hoahong.jpg");
            this.imageList1.Images.SetKeyName(2, "hoalan.jpg");
            this.imageList1.Images.SetKeyName(3, "traicay.jpg");
            this.imageList1.Images.SetKeyName(4, "xoai.jpg");
            this.imageList1.Images.SetKeyName(5, "traimit.jpg");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.treeViewThucVat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewThucVat;
        private System.Windows.Forms.ImageList imageList1;
    }
}

