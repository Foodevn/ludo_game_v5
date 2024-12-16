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
            this.Close();
		}

		private void btnChampion_Click(object sender, EventArgs e)
		{
			TheHien.Menu.Lui = 3;
			this.Close();
		}
	}
}
