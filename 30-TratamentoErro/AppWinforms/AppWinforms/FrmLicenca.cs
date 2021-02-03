using System.Diagnostics;   // adicionar o System.Diagnostics para que o Process.Start execute.
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
	public partial class FrmLicenca : Form
	{
		public FrmLicenca()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Process.Start("https://github.com/Joshhortt/Csharp-Open"); 
		}

		private void btnRegistrar_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Programa registrado"); 
		}                                           

		private void FrmLicenca_Load(object sender, EventArgs e)
		{

		}
	}
}
