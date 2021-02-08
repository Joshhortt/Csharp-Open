using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppWinforms
{
	public partial class FrmTabControl : Form
	{
		public FrmTabControl()
		{
			InitializeComponent();
		}

		private void FrmTabControl_Load(object sender, EventArgs e)
		{
			tabControl.SelectTab("tabPage3"); 
		}

		private void btnTab1_Click(object sender, EventArgs e)
		{
			tabControl.SelectTab("tabPage1"); 
		}

		private void btnTab2_Click(object sender, EventArgs e)
		{
			tabControl.SelectTab("tabPage2"); 
		}

		private void btnTab3_Click(object sender, EventArgs e)
		{
			tabControl.SelectTab("tabPage3");  
		}
	}
}
