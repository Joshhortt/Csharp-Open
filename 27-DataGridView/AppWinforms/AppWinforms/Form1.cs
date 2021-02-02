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
	public partial class Form1 : Form  
	{
		public Form1()  
		{
			InitializeComponent(); 
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			txtResultado.Text = "Benvindos ao Estado do Brasil: " + ((Estado)cboEstados.SelectedItem).Id;
		}

		private void btnAbre_Click(object sender, EventArgs e)
		{
			var form = new FrmShow();
			form.lblMensagem.Text = txtResultado.Text;
			form.Show();
		}

		private void Form1_Load(object sender, EventArgs e) 
		{
			//cboEstados.Items.Clear();                Tambem o Clear aqui ja nao é necessario ja que o DataSource limpa tudo

			cboEstados.DataSource = Estado.Lista(); // DataSource é a propriedade onde estao os dados do meu 'estado'. 
													// Faz o mesmo que o foreach contudo tudo numa linha de codigo.
													// A diferença aqui é que carrega logo inicialmente o primeiro estado em vez de [Seleccione] 

			cboEstados.Text = "[Selecione]";        // para que o DataSource inclua o que consta na Lista, devemos colocar esta linha de codigo.
			
			//foreach (Estado estado in Estado.Lista())
			//{
			//	cboEstados.Items.Add(estado);
			//}
		}
	}
}
