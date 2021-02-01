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
	public partial class FrmShow : Form
	{
		public FrmShow()
		{
			InitializeComponent();
		}

		private void FrmShow_Load(object sender, EventArgs e)    // dois clicks no formulario abre esta instancia privada -- > o Load do segundo formulario
		{
			MessageBox.Show("Inicializando o formulario Show");  // Depois de compilar app, dar play na aplicação que vai abrir uma pequena text box c/ esta mensagem
															     // Ok e vai para o formulario principal. 
																 // Clicar no Abrir janela e abre a pequena TextBox com esta mensagem.
		}
	}
}
