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
	public partial class FrmTexto : Form  // Criado novo Winform
	{
		public FrmTexto()
		{
			InitializeComponent();
		}

		private void btnSalvar_Click(object sender, EventArgs e)
		{
			SalvarArquivo();  // Colocar tambem o metodo dentro do click do botao
		}

		private void SalvarArquivo() // Criar um metodo privado sem retorno
		{
			File.WriteAllText(@"c:\arquivos\texto_" + DateTime.Now.ToString("dd_MM_yyy_HH_mm_ss") + "Txt", txtTexto.Text);   // O path onde se vai salvar este arquivo. Coloque o @ a 
																												   // frente do path por causa da barra ou colque \\ sem o @.

			MessageBox.Show("Arquivo salvo");
			txtTexto.Text = string.Empty;  // faz a limpeza do textBox
		}

		private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SalvarArquivo();  // Colocar tambem o metodo no clique do botao salvar do Arquivo no Menu Strip
		}
	}
}
