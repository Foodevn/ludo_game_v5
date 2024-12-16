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
        
        public PageHome()
        {
            InitializeComponent();
			
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
			TheHien.Menu.Lui = 4;
			this.Close();
		}
	}
}
