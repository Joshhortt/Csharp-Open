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
	public class Estado
	{
		public int Id;     // propriedade Id do tipo int
		public string Nome;   // propriedade Nome do tipo string

		public override string ToString()  // override de APPWinforms Estado (fazendo com que nao apareça na textBox
		{
			return this.Nome; // retorna o Nome do Estado 
		}

		public static List<Estado> Lista()  // Criar Lista de Estados com numero Id e Nome
		{
			// SP
			var lista = new List<Estado>();
			var est1 = new Estado();
			est1.Id = 1;
			est1.Nome = "SP";

			var s = est1.ToString();

			lista.Add(est1);

			// RJ
			est1 = new Estado();
			est1.Id = 2;
			est1.Nome = "RJ";
			lista.Add(est1);

			// MG
			est1 = new Estado();
			est1.Id = 3;
			est1.Nome = "MG";
			lista.Add(est1);

			//GO
			est1 = new Estado();
			est1.Id = 4;
			est1.Nome = "GO";
			lista.Add(est1);

			return lista;
		}
	}
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
