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

		}

		private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SalvarArquivo();  // Colocar tambem o metodo no clique do botao salvar do Arquivo no Menu Strip
		}
	}
}
