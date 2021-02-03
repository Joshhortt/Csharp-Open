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

				// Testar aqui com um if else erros que criamos prositadamente afim aprender mais sobre debugging do Try catch
				if(numero == 2)
				{																												
				throw new ErroDeProposito("Erro de proposito");
				}
				else if(numero == 4)
				{
					throw new ErroDeProposito("Erro de proposito generico");
				}

				numero += 100;  // colocado aqui depois do if else

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

			catch (Exception err)  // Esse catch tem de ficar no fim porque é o Exception Pai dos outros Exceptions 'ErroDeProosito' e 'FormatException'
			{
				MessageBox.Show("Olá cliente, voce por acaso não digitou letras em vez de numeros?" + err.Message);
			}
		}
	}
	public class ErroDeProposito : Exception  // Classe que herda da classe pai 'Exception'.
	{
		public ErroDeProposito(string erro) : base(erro)  // Construtor publico de erro string passando por construtor base que herdei.
		{
        }
    }
}
 

