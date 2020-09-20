namespace GUI
{
    partial class DoUong_Item
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox_DoUong = new System.Windows.Forms.PictureBox();
            this.lblTenMon = new System.Windows.Forms.Label();
            this.lblGiaBan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_DoUong)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_DoUong
            // 
            this.pictureBox_DoUong.Location = new System.Drawing.Point(20, 20);
            this.pictureBox_DoUong.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_DoUong.Name = "pictureBox_DoUong";
            this.pictureBox_DoUong.Size = new System.Drawing.Size(225, 219);
            this.pictureBox_DoUong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_DoUong.TabIndex = 0;
            this.pictureBox_DoUong.TabStop = false;
            this.pictureBox_DoUong.Click += new System.EventHandler(this.pictureBox_DoUong_Click);
            // 
            // lblTenMon
            // 
            this.lblTenMon.AutoSize = true;
            this.lblTenMon.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblTenMon.Location = new System.Drawing.Point(14, 244);
            this.lblTenMon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenMon.MaximumSize = new System.Drawing.Size(0, 219);
            this.lblTenMon.Name = "lblTenMon";
            this.lblTenMon.Size = new System.Drawing.Size(141, 29);
            this.lblTenMon.TabIndex = 1;
            this.lblTenMon.Text = "Tên món ăn";
            // 
            // lblGiaBan
            // 
            this.lblGiaBan.AutoSize = true;
            this.lblGiaBan.Font = new System.Drawing.Font("Tahoma", 15F);
            this.lblGiaBan.Location = new System.Drawing.Point(150, 20);
            this.lblGiaBan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGiaBan.Name = "lblGiaBan";
            this.lblGiaBan.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lblGiaBan.Size = new System.Drawing.Size(94, 50);
            this.lblGiaBan.TabIndex = 2;
            this.lblGiaBan.Text = "100k";
            // 
            // DoUong_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblGiaBan);
            this.Controls.Add(this.lblTenMon);
            this.Controls.Add(this.pictureBox_DoUong);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DoUong_Item";
            this.Size = new System.Drawing.Size(264, 319);
            this.Load += new System.EventHandler(this.DoUong_Item_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_DoUong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_DoUong;
        private System.Windows.Forms.Label lblTenMon;
        private System.Windows.Forms.Label lblGiaBan;

    }
}
