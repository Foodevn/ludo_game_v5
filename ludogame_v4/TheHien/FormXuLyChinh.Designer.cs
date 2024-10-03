namespace ludogame_v4.TheHien
{
	partial class FormXuLyChinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormXuLyChinh));
            this.panelBC = new System.Windows.Forms.Panel();
            this.btnDoXiNgau = new System.Windows.Forms.Button();
            this.btnSapBanCo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.picLuotQC = new System.Windows.Forms.PictureBox();
            this.btnTuyChon = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.panelXN = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelXN_Red = new System.Windows.Forms.Panel();
            this.panelXN_Blue = new System.Windows.Forms.Panel();
            this.panelBC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLuotQC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBC
            // 
            this.panelBC.Controls.Add(this.panelXN_Blue);
            this.panelBC.Controls.Add(this.panelXN_Red);
            this.panelBC.Controls.Add(this.pictureBox1);
            this.panelBC.Location = new System.Drawing.Point(4, 4);
            this.panelBC.Margin = new System.Windows.Forms.Padding(2);
            this.panelBC.Name = "panelBC";
            this.panelBC.Size = new System.Drawing.Size(477, 465);
            this.panelBC.TabIndex = 0;
            // 
            // btnDoXiNgau
            // 
            this.btnDoXiNgau.Location = new System.Drawing.Point(548, 102);
            this.btnDoXiNgau.Margin = new System.Windows.Forms.Padding(2);
            this.btnDoXiNgau.Name = "btnDoXiNgau";
            this.btnDoXiNgau.Size = new System.Drawing.Size(68, 21);
            this.btnDoXiNgau.TabIndex = 1;
            this.btnDoXiNgau.Text = "Do xi ngau";
            this.btnDoXiNgau.Click += new System.EventHandler(this.btnDoXiNgau_Click);
            // 
            // btnSapBanCo
            // 
            this.btnSapBanCo.Location = new System.Drawing.Point(548, 146);
            this.btnSapBanCo.Margin = new System.Windows.Forms.Padding(2);
            this.btnSapBanCo.Name = "btnSapBanCo";
            this.btnSapBanCo.Size = new System.Drawing.Size(68, 21);
            this.btnSapBanCo.TabIndex = 4;
            this.btnSapBanCo.Text = "Sap Ban Co";
            this.btnSapBanCo.Click += new System.EventHandler(this.btnSapBanCo_Click);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(555, 326);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Luot di";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picLuotQC
            // 
            this.picLuotQC.BackColor = System.Drawing.Color.Transparent;
            this.picLuotQC.Location = new System.Drawing.Point(569, 364);
            this.picLuotQC.Margin = new System.Windows.Forms.Padding(2);
            this.picLuotQC.Name = "picLuotQC";
            this.picLuotQC.Size = new System.Drawing.Size(22, 22);
            this.picLuotQC.TabIndex = 7;
            this.picLuotQC.TabStop = false;
            // 
            // btnTuyChon
            // 
            this.btnTuyChon.Location = new System.Drawing.Point(548, 169);
            this.btnTuyChon.Margin = new System.Windows.Forms.Padding(2);
            this.btnTuyChon.Name = "btnTuyChon";
            this.btnTuyChon.Size = new System.Drawing.Size(68, 21);
            this.btnTuyChon.TabIndex = 9;
            this.btnTuyChon.Text = "Tuy Chon";
            this.btnTuyChon.Click += new System.EventHandler(this.btnTuyChon_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(548, 191);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(68, 22);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoat";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // panelXN
            // 
            this.panelXN.BackColor = System.Drawing.Color.Transparent;
            this.panelXN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelXN.Location = new System.Drawing.Point(523, 29);
            this.panelXN.Margin = new System.Windows.Forms.Padding(2);
            this.panelXN.Name = "panelXN";
            this.panelXN.Size = new System.Drawing.Size(120, 60);
            this.panelXN.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::ludogame_v4.Properties.Resources.BANCO1;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(477, 465);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelXN_Red
            // 
            this.panelXN_Red.BackColor = System.Drawing.Color.Transparent;
            this.panelXN_Red.Location = new System.Drawing.Point(311, 80);
            this.panelXN_Red.Name = "panelXN_Red";
            this.panelXN_Red.Size = new System.Drawing.Size(135, 83);
            this.panelXN_Red.TabIndex = 1;
            // 
            // panelXN_Blue
            // 
            this.panelXN_Blue.BackColor = System.Drawing.Color.Transparent;
            this.panelXN_Blue.Location = new System.Drawing.Point(311, 346);
            this.panelXN_Blue.Name = "panelXN_Blue";
            this.panelXN_Blue.Size = new System.Drawing.Size(135, 87);
            this.panelXN_Blue.TabIndex = 2;
            // 
            // FormXuLyChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(749, 487);
            this.Controls.Add(this.panelXN);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTuyChon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSapBanCo);
            this.Controls.Add(this.btnDoXiNgau);
            this.Controls.Add(this.panelBC);
            this.Controls.Add(this.picLuotQC);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormXuLyChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Co Ca Ngua";
            this.Load += new System.EventHandler(this.XuLyChinh_Load);
            this.panelBC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLuotQC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.Panel panelXN;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelXN_Red;
        private System.Windows.Forms.Panel panelXN_Blue;
    }
}