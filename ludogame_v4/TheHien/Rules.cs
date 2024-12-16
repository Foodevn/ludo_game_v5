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
	public partial class Rules : Form
	{
		public Rules()
		{
			InitializeComponent();
		}

		private void lbLui_Click(object sender, EventArgs e)
		{
			TheHien.Menu.Lui = 1;
			this.Close();
		}
	}
}
