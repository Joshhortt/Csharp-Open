using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;  // adicionado quando intrduzimos o File.WriteAllText ...
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppWinforms
{
	public partial class FrmTexto : Form  
	{
		public FrmTexto()
		{
			InitializeComponent();
		}

		private void btnSalvar_Click(object sender, EventArgs e)
		{
			SalvarArquivo(); 
		}

		private void SalvarArquivo() 
		{
			File.WriteAllText(@"c:\arquivos\texto_" + DateTime.Now.ToString("dd_MM_yyy_HH_mm_ss") + "Txt", txtTexto.Text);    
																												  

			MessageBox.Show("Arquivo salvo");
			txtTexto.Text = string.Empty; 
		}

		private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SalvarArquivo(); 
		}

		private void FrmTexto_Load(object sender, EventArgs e)
		{

		}
	}
}
