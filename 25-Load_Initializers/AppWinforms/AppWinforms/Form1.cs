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
	public partial class Form1 : Form  // Form1 é a classe
	{
		public Form1()  // Form1() é o Construtor
		{
			InitializeComponent();
			MessageBox.Show("Inicializando o formulario pelo construtor");  // Depois de compilar app, dar play na aplicação que vai abrir uma pequena text box c/ esta mensagem
																			// Ok e vai para o  'Load'.
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			txtResultado.Text = "Benvindos a nossa primeira aula de Winforms!";
		}

		private void btnAbre_Click(object sender, EventArgs e)
		{
			var form = new FrmShow();
			form.lblMensagem.Text = txtResultado.Text;
			form.Show();
		
		}

		private void Form1_Load(object sender, EventArgs e)  //  dois clicks no formulario abre esta instancia privada -- > o Load
		{
			MessageBox.Show("Inicializando o formulario");  // Depois de compilar app, dar play na aplicação que vai abrir uma pequena text box c/ esta mensagem
			                                                // Ok e vai para o formulario
		}
	}
}
