namespace ludogame_v4.TheHien
{
	partial class TheHienXiNgau
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
			this.picXN1 = new System.Windows.Forms.PictureBox();
			this.picXN2 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.picXN1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picXN2)).BeginInit();
			this.SuspendLayout();
			// 
			// picXN1
			// 
			this.picXN1.Location = new System.Drawing.Point(8, 8);
			this.picXN1.Name = "picXN1";
			this.picXN1.Size = new System.Drawing.Size(40, 40);
			this.picXN1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picXN1.TabIndex = 0;
			this.picXN1.TabStop = false;
			// 
			// picXN2
			// 
			this.picXN2.Location = new System.Drawing.Point(56, 8);
			this.picXN2.Name = "picXN2";
			this.picXN2.Size = new System.Drawing.Size(40, 40);
			this.picXN2.TabIndex = 1;
			this.picXN2.TabStop = false;
			// 
			// TheHienXiNgau
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.Controls.Add(this.picXN2);
			this.Controls.Add(this.picXN1);
			this.Name = "TheHienXiNgau";
			this.Size = new System.Drawing.Size(104, 56);
			this.Click += new System.EventHandler(this.TheHienXiNgau_Click);
			((System.ComponentModel.ISupportInitialize)(this.picXN1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picXN2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
	}
}
