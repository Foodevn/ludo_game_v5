using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ludogame_v4.login
{
    public partial class PageHome : Form
    {

        private Image backgroundImage;
        public PageHome()
        {
            InitializeComponent();
            backgroundImage = new Bitmap(Application.StartupPath + "\\image\\14f9f7087b83339250e511a0f3c9a7b0.jpg");
            this.DoubleBuffered = true; // Kích hoạt DoubleBuffering để giảm nhấp nháy


        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (backgroundImage != null)
            {
                e.Graphics.DrawImage(backgroundImage, this.ClientRectangle);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
		{
			TheHien.Menu.Lui = 0;
			this.Close();
		}

		private void btnChampion_Click(object sender, EventArgs e)
		{
			TheHien.Menu.Lui = 3;
			this.Close();
		}

		private void btnRules_Click(object sender, EventArgs e)
		{

			TheHien.Menu.Lui = 2;
			this.Close();
		}

        private void btnExit_Click(object sender, EventArgs e)
        {
			this.Close();
        }
    }
}
