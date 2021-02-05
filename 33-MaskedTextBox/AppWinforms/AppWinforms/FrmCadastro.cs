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
				//numero += 100;

				if(numero == 2)
				{																												
				throw new ErroDeProposito("Erro de proposito");
				}
				else if(numero == 4)
				{
					throw new ErroDeProposito("Erro de proposito generico");
				}

				numero += 100;  

				MessageBox.Show("Olá " + nome + ", o valor do numero mais 100 é de: " + numero);
			}

			catch (FormatException errFormat)
			{
				MessageBox.Show("Olá cliente, voce por acaso não digitou letras em vez de numeros?" + errFormat);
				txtNumero.Focus();
			}

			catch (ErroDeProposito errProposito)
			{
				MessageBox.Show("Erro de Proposito" + errProposito.StackTrace);
			}

			catch (Exception err)  
			{
				MessageBox.Show("Olá cliente, voce por acaso não digitou letras em vez de numeros?" + err.Message);
			}
			finally
			{
				MessageBox.Show("todas as Excepções tratadas");  			                                                
			}
		}

		private void maskedTextBox1_Leave(object sender, EventArgs e)
		{   // Mostrando as duas validações
			if (maskedTextBox1.MaskCompleted)
			{
				MessageBox.Show("Mascara completa!");
			}
			else
			{
				MessageBox.Show("Mascara incompleta!");
			}

			// Mostrando só a validação de mascara incompleta.
			//if (!maskedTextBox1.MaskCompleted)
			//{
			//	MessageBox.Show("Mascara incompleta!");
			//}
		}
	}
	public class ErroDeProposito : Exception  
	{
		public ErroDeProposito(string erro) : base(erro)  
		{
        }
    }
}
 

