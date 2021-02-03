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
	public partial class FrmCadastro : Form
	{
		public FrmCadastro()
		{
			InitializeComponent();
		}

		private void BtnCalcular_Click(object sender, EventArgs e)
		{
			
			var nome = textBox1.Text;
			try
			{   // Try -> apanha o erro do usuario que digita em vez de numeros na textBox letras
				int numero = int.Parse(txtNumero.Text); // Conversão com int.Parse (so recebe string)
				numero += 100;
				MessageBox.Show("Olá " + nome + ", o valor do numero mais 100 é de: " + numero);
				//MessageBox.Show($"Olá { nome } , o valor do numero mais 100 é de:   {numero} "); Outra forma de mostrar na tela
			}
			catch
			{   // catch -> apanha o erro do usuario que digita em vez de numeros na textBox letras e mostra uma msg na MessageBox
				// avisar do seu erro. Ao dar Ok o usuario ve logo que o cursor pisca para que possa efetuar a devida coreção.
				MessageBox.Show("Olá cliente, voce por acaso não digitou letras em vez de numeros?");
				txtNumero.Focus();
			}
			
		}
	}
}
