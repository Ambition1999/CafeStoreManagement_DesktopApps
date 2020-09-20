namespace GUI
{
    partial class Ban_Item
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
            this.components = new System.ComponentModel.Container();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.lbl_TrangThai = new System.Windows.Forms.Label();
            this.lbl_TenBan = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.chuyểnBànToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gộpBànToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hủyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_TenKhuVuc = new System.Windows.Forms.Label();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.lbl_TrangThai);
            this.layoutControl1.Controls.Add(this.lbl_TenBan);
            this.layoutControl1.Controls.Add(this.lbl_TenKhuVuc);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(145, 121);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // lbl_TrangThai
            // 
            this.lbl_TrangThai.BackColor = System.Drawing.Color.LimeGreen;
            this.lbl_TrangThai.ForeColor = System.Drawing.Color.White;
            this.lbl_TrangThai.Location = new System.Drawing.Point(12, 88);
            this.lbl_TrangThai.Name = "lbl_TrangThai";
            this.lbl_TrangThai.Size = new System.Drawing.Size(121, 21);
            this.lbl_TrangThai.TabIndex = 6;
            this.lbl_TrangThai.Text = "Trạng thái";
            this.lbl_TrangThai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_TrangThai.Click += new System.EventHandler(this.lbl_TrangThai_Click);
            // 
            // lbl_TenBan
            // 
            this.lbl_TenBan.BackColor = System.Drawing.Color.White;
            this.lbl_TenBan.ContextMenuStrip = this.contextMenuStrip1;
            this.lbl_TenBan.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenBan.Location = new System.Drawing.Point(12, 37);
            this.lbl_TenBan.Name = "lbl_TenBan";
            this.lbl_TenBan.Size = new System.Drawing.Size(121, 47);
            this.lbl_TenBan.TabIndex = 5;
            this.lbl_TenBan.Text = "Bàn số 003";
            this.lbl_TenBan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_TenBan.Click += new System.EventHandler(this.lbl_TenBan_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chuyểnBànToolStripMenuItem,
            this.gộpBànToolStripMenuItem,
            this.hủyToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(139, 70);
            // 
            // chuyểnBànToolStripMenuItem
            // 
            this.chuyểnBànToolStripMenuItem.Name = "chuyểnBànToolStripMenuItem";
            this.chuyểnBànToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.chuyểnBànToolStripMenuItem.Text = "Chuyển bàn";
            this.chuyểnBànToolStripMenuItem.Click += new System.EventHandler(this.chuyểnBànToolStripMenuItem_Click);
            // 
            // gộpBànToolStripMenuItem
            // 
            this.gộpBànToolStripMenuItem.Name = "gộpBànToolStripMenuItem";
            this.gộpBànToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.gộpBànToolStripMenuItem.Text = "Gộp bàn";
            this.gộpBànToolStripMenuItem.Click += new System.EventHandler(this.gộpBànToolStripMenuItem_Click);
            // 
            // hủyToolStripMenuItem
            // 
            this.hủyToolStripMenuItem.Name = "hủyToolStripMenuItem";
            this.hủyToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.hủyToolStripMenuItem.Text = "Hủy";
            this.hủyToolStripMenuItem.Click += new System.EventHandler(this.hủyToolStripMenuItem_Click);
            // 
            // lbl_TenKhuVuc
            // 
            this.lbl_TenKhuVuc.BackColor = System.Drawing.Color.LimeGreen;
            this.lbl_TenKhuVuc.ForeColor = System.Drawing.Color.White;
            this.lbl_TenKhuVuc.Location = new System.Drawing.Point(12, 12);
            this.lbl_TenKhuVuc.Name = "lbl_TenKhuVuc";
            this.lbl_TenKhuVuc.Size = new System.Drawing.Size(121, 21);
            this.lbl_TenKhuVuc.TabIndex = 4;
            this.lbl_TenKhuVuc.Text = "Tầng trệt";
            this.lbl_TenKhuVuc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_TenKhuVuc.Click += new System.EventHandler(this.lbl_TenKhuVuc_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(145, 121);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.lbl_TenKhuVuc;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(125, 25);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.lbl_TenBan;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 25);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(125, 51);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.lbl_TrangThai;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 76);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(125, 25);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // Ban_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "Ban_Item";
            this.Size = new System.Drawing.Size(145, 121);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private System.Windows.Forms.Label lbl_TrangThai;
        private System.Windows.Forms.Label lbl_TenBan;
        private System.Windows.Forms.Label lbl_TenKhuVuc;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chuyểnBànToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gộpBànToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hủyToolStripMenuItem;

    }
}
