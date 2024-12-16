using ludogame_v4.login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ludogame_v4.TheHien
{
	public partial class Menu : Form
	{
		private Form activeForm;
		public static int Lui;
		/*lui 1 = tro ve cua form tuy chon 
		 2 = mo form rule
		3 = champion
		*/
		public Menu()
		{
			Lui = 0;
			InitializeComponent();
		}

		private void OpenChildForm(Form childForm)
		{
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			this.panelDesktop.Controls.Add(childForm);
			this.panelDesktop.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();

		}
		private void Menu_Load(object sender, EventArgs e)
		{
			login.PageHome pageHome = new login.PageHome();
			OpenChildForm(pageHome);
			pageHome.FormClosed += new FormClosedEventHandler(PageFormClosed);
		}
		void PageFormClosed(object sender, EventArgs e)
		{
			switch(Lui)
			{
				case 0:
					TheHien.TuyChon tuyChon = new TheHien.TuyChon();
					OpenChildForm(tuyChon);
					tuyChon.FormClosed += new FormClosedEventHandler(FormTuyChonClored);
					break;
					case 3:
					TheHien.BangXepHang bangXepHang=new BangXepHang();
					OpenChildForm(bangXepHang);
					bangXepHang.FormClosed += new FormClosedEventHandler(FormTuyChonClored);
					break;
			}	
		}
		void FormTuyChonClored(object sender, EventArgs e)
		{
			if (Lui == 1)
			{
				login.PageHome pageHome = new login.PageHome();
				OpenChildForm(pageHome);
				pageHome.FormClosed += new FormClosedEventHandler(PageFormClosed);
				return;
			}
			TheHien.FormXuLyChinh formXuLyChinh = new TheHien.FormXuLyChinh();
			OpenChildForm(formXuLyChinh);
			formXuLyChinh.FormClosed += new FormClosedEventHandler(FormXuLyClosed);
		}
		void FormXuLyClosed(object sender, FormClosedEventArgs e)
		{
			login.PageHome pageHome = new login.PageHome();
			OpenChildForm(pageHome);
			pageHome.FormClosed += new FormClosedEventHandler(PageFormClosed);
		}


	}
}
