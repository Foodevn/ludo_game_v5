namespace ludogame_v4.TheHien
{
    partial class BangXepHang
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BangXepHang));
			this.lvRank = new System.Windows.Forms.ListView();
			this.lbLui = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lvRank
			// 
			this.lvRank.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lvRank.BackgroundImage = global::ludogame_v4.Properties.Resources.BangXepHang;
			this.lvRank.BackgroundImageTiled = true;
			this.lvRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lvRank.HideSelection = false;
			this.lvRank.Location = new System.Drawing.Point(181, 98);
			this.lvRank.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.lvRank.Name = "lvRank";
			this.lvRank.Size = new System.Drawing.Size(892, 496);
			this.lvRank.TabIndex = 1;
			this.lvRank.UseCompatibleStateImageBehavior = false;
			this.lvRank.View = System.Windows.Forms.View.Details;
			// 
			// lbLui
			// 
			this.lbLui.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lbLui.AutoSize = true;
			this.lbLui.BackColor = System.Drawing.Color.Transparent;
			this.lbLui.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lbLui.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbLui.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lbLui.Location = new System.Drawing.Point(12, 27);
			this.lbLui.Name = "lbLui";
			this.lbLui.Size = new System.Drawing.Size(56, 46);
			this.lbLui.TabIndex = 64;
			this.lbLui.Text = "< ";
			this.lbLui.Click += new System.EventHandler(this.lbLui_Click);
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(120, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(173, 46);
			this.label1.TabIndex = 64;
			this.label1.Text = "Ranking";
			this.label1.Click += new System.EventHandler(this.lbLui_Click);
			// 
			// BangXepHang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(1298, 708);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lbLui);
			this.Controls.Add(this.lvRank);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "BangXepHang";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Bảng Xếp Hạng";
			this.Load += new System.EventHandler(this.BangXepHang_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lvRank;
		private System.Windows.Forms.Label lbLui;
		private System.Windows.Forms.Label label1;
	}
}