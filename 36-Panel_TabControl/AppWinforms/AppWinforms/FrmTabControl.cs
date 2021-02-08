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
			tabControl.SelectTab("tabPage3");  // Vai abrir a Tab Dados Pagamentos por default
		}
	}
}
