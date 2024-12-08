namespace ludogame_v4.TheHien
{
	partial class TheHienQuanCo
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
            this.picQC = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picQC)).BeginInit();
            this.SuspendLayout();
            // 
            // picQC
            // 
            this.picQC.BackColor = System.Drawing.Color.Transparent;
            this.picQC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picQC.Location = new System.Drawing.Point(8, 8);
            this.picQC.Name = "picQC";
            this.picQC.Size = new System.Drawing.Size(40, 40);
            this.picQC.TabIndex = 0;
            this.picQC.TabStop = false;
            this.picQC.Click += new System.EventHandler(this.picQC_Click);
            // 
            // TheHienQuanCo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.picQC);
            this.Name = "TheHienQuanCo";
            this.Size = new System.Drawing.Size(100, 100);
            ((System.ComponentModel.ISupportInitialize)(this.picQC)).EndInit();
            this.ResumeLayout(false);

		}

        #endregion

        public System.Windows.Forms.PictureBox picQC;
    }
}
