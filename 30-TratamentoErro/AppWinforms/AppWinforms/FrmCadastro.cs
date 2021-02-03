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
			{
				int numero = int.Parse(txtNumero.Text);
				numero += 100;

				throw new Exception("Erro de proposito");  // tipo de erro excepção. Neste caso o erro cai sempre no catch, independentement se o usuario
														   // digita correctamente as letras e numeros pedidos no formulario.

				MessageBox.Show("Olá " + nome + ", o valor do numero mais 100 é de: " + numero);
			}

			catch (FormatException errFormat)
			{
				MessageBox.Show("Olá cliente, voce por acaso não digitou letras em vez de numeros?" + errFormat);
				txtNumero.Focus();
			}

			catch (Exception err)  // ao incluir o Exception err o catch vai tratar qualquer tipo de erro...
			{   // posso tambem concatenar a mensagem de erro com o erro em si
				MessageBox.Show("Olá cliente, voce por acaso não digitou letras em vez de numeros?" + err.Message);  
				//MessageBox.Show("Olá cliente, voce por acaso não digitou letras em vez de numeros?");
				//txtNumero.Focus();
			}
			
		}
	}
}
