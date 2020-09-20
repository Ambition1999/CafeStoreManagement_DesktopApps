namespace GUI
{
    partial class DoUongGioHang_Item_Temp
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_TenDoUong = new System.Windows.Forms.Label();
            this.lbl_SoLuong = new System.Windows.Forms.Label();
            this.lbl_ThanhTien = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.27676F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.72325F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 198F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_TenDoUong, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_SoLuong, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_ThanhTien, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(634, 73);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lbl_TenDoUong
            // 
            this.lbl_TenDoUong.AutoSize = true;
            this.lbl_TenDoUong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_TenDoUong.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbl_TenDoUong.Location = new System.Drawing.Point(4, 0);
            this.lbl_TenDoUong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TenDoUong.Name = "lbl_TenDoUong";
            this.lbl_TenDoUong.Size = new System.Drawing.Size(272, 73);
            this.lbl_TenDoUong.TabIndex = 0;
            this.lbl_TenDoUong.Text = "Tên đồ uống";
            this.lbl_TenDoUong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_SoLuong
            // 
            this.lbl_SoLuong.AutoSize = true;
            this.lbl_SoLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_SoLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_SoLuong.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbl_SoLuong.Location = new System.Drawing.Point(290, 10);
            this.lbl_SoLuong.Margin = new System.Windows.Forms.Padding(10);
            this.lbl_SoLuong.Name = "lbl_SoLuong";
            this.lbl_SoLuong.Size = new System.Drawing.Size(71, 53);
            this.lbl_SoLuong.TabIndex = 1;
            this.lbl_SoLuong.Text = "1";
            this.lbl_SoLuong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_SoLuong.Click += new System.EventHandler(this.lbl_SoLuong_Click);
            // 
            // lbl_ThanhTien
            // 
            this.lbl_ThanhTien.AutoSize = true;
            this.lbl_ThanhTien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_ThanhTien.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbl_ThanhTien.Location = new System.Drawing.Point(375, 0);
            this.lbl_ThanhTien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ThanhTien.Name = "lbl_ThanhTien";
            this.lbl_ThanhTien.Size = new System.Drawing.Size(190, 73);
            this.lbl_ThanhTien.TabIndex = 2;
            this.lbl_ThanhTien.Text = "Thành tiền";
            this.lbl_ThanhTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DoUongGioHang_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DoUongGioHang_Item";
            this.Size = new System.Drawing.Size(634, 73);
            this.Click += new System.EventHandler(this.DoUongGioHang_Item_Click);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_TenDoUong;
        private System.Windows.Forms.Label lbl_SoLuong;
        private System.Windows.Forms.Label lbl_ThanhTien;
    }
}
