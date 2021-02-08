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

		private void btnTab1_Click(object sender, EventArgs e)
		{
			tabControl.SelectTab("tabPage1"); // Ao clicar no botao vai para a pagina Tab1
		}

		private void btnTab2_Click(object sender, EventArgs e)
		{
			tabControl.SelectTab("tabPage2"); // Ao clicar no botao vai para a pagina Tab2
		}

		private void btnTab3_Click(object sender, EventArgs e)
		{
			tabControl.SelectTab("tabPage3");  // Ao clicar no botao vai para a pagina Tab3
		}
	}
}
