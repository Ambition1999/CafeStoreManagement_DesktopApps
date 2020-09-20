namespace GUI
{
    partial class FormOrder
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
            this.flowLayoutPanel_TrangOrder = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutPanel_TrangOrder
            // 
            this.flowLayoutPanel_TrangOrder.AutoScroll = true;
            this.flowLayoutPanel_TrangOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_TrangOrder.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel_TrangOrder.Name = "flowLayoutPanel_TrangOrder";
            this.flowLayoutPanel_TrangOrder.Size = new System.Drawing.Size(507, 254);
            this.flowLayoutPanel_TrangOrder.TabIndex = 0;
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel_TrangOrder);
            this.Name = "FormOrder";
            this.Size = new System.Drawing.Size(507, 254);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_TrangOrder;

    }
}
