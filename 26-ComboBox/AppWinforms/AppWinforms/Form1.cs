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
			// MessageBox.Show("Inicializando o formulario pelo construtor");  
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			// seleciona o Item escolhido no comboBox pelo Id. Aparece na caixa de texto o numero do Id apos a string
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
			// MessageBox.Show("Inicializando o formulario"); 


			// Load dos Estados na Lista
			cboEstados.Items.Clear();
			foreach (Estado estado in Estado.Lista())
			{
				cboEstados.Items.Add(estado);
			}
		}
	}
}
