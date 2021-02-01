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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			txtResultado.Text = "Benvindos a nossa primeira aula de Winforms!";
		}

		private void btnAbre_Click(object sender, EventArgs e)
		{
			var form = new FrmShow();
			form.Show();
		}
	}
}
