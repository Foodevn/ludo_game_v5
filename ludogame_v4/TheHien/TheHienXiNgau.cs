using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ludogame_v4.TheHien
{
	public partial class TheHienXiNgau : UserControl
	{
		private PictureBox picXN1;

		private PictureBox picXN2;

		private int soXNTH;

		

		public int SoXiNgauTheHien
		{
			get
			{return soXNTH;}
			set
			{soXNTH = value;}
		}

		public TheHienXiNgau()
		{
			InitializeComponent();
			SoXiNgauTheHien = 1;
			LoadImageXN(1, 6);
			DinhViXiNgau();
		}

		public TheHienXiNgau(int So)
		{
			InitializeComponent();
			LoadImageXN(1, 6);
			SoXiNgauTheHien = So;
			DinhViXiNgau();
		}

		public void DinhViXiNgau()
		{
			if (SoXiNgauTheHien == 1)
			{
				picXN1.Location = new Point(32, 8);

                if (picXN2.Visible)
				{
					picXN2.Visible = false;
				}
			}
			else
			{
				picXN1.Location = new Point(8, 8);
				if (!picXN2.Visible)
				{
					picXN2.Visible = true;
				}
			}
		}

		public void LoadImageXiNgau1(string strFileName)
		{
			picXN1.Image = new Bitmap(strFileName);

		}

		public void LoadImageXiNgau2(string strFileName)
		{
			picXN2.Image = new Bitmap(strFileName);
		}

		public void LoadImageXN(int gt1, int gt2)
		{
			picXN1.Image = new Bitmap(Application.StartupPath + "/HinhXiNgau/" + gt1 + ".jpg");
			picXN2.Image = new Bitmap(Application.StartupPath + "/HinhXiNgau/" + gt2 + ".jpg");
		}

	

		
	}
}
