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
			//*********************** Estado ****************************

			cboEstados.DataSource = Estado.Lista();
			cboEstados.Text = "[Selecione]";

			/*
			 // Load dos Estados na Lista
			cboEstados.Items.Clear();
			foreach (Estado estado in Estado.Lista())
			{
				cboEstados.Items.Add(estado);
			}
			 */

			//***********************************************************



			//******************* GridView simples***********************

			// forma mais simples de utilizar
			// dataGridView.DataSource = Estado.Lista();

			//***********************************************************



			//***************** GridView + complexo**********************
			/*
			 * dataGridView.ColumnCount = 2; // o grid view vai ter duas colunas
			dataGridView.Columns[0].Name = "Id";  // consta numa coluna o Id
			dataGridView.Columns[1].Name = "Nome";  // consta noutra coluna o Nome

			var rows = new List<string[]>();  //  Lista de array coleção na memoria 
			foreach (Estado estado in Estado.Lista())
			{
				string[] row1 = new string[] { estado.Id.ToString(), estado.Nome }; 
				rows.Add(row1);  // Adicona as linhas
			}
			foreach (string[] rowArray in rows) // Faz esta operação 4 vezes.
			{
				dataGridView.Rows.Add(rowArray);
			}
			*/
			//***********************************************************




			//************** GridView forma intermediaria ***************
			// utilizando Link
			var data = from estado in Estado.Lista()
					// where estado.Id == 1 || estado.Id == 2  // só mostra o estado com Id 1 e com Id 2, neste caso o SP e RJ
					// orderby estado.Nome  // ordena pelo Nome
					// orderby estado.Id  // ordena pelo Id
					   select new
					   {
						   Id = estado.Id,
						   Nome = estado.Nome
					   };
			dataGridView.DataSource = data.ToList();

			//***********************************************************
		}

		private void novoTextoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new FrmTexto().Show();   // Ja mostra o novo formulario criado FrmTexto, oden ja podemos digitar texto e salvar.
		}

		private void sairToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();    // Com este metodo Sai da Aplicação ou fecha a, após clicar no botao sair no Menu Strip
		}

		private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new FrmSobre().Show();  // mostra o formulario Sobre
		}

		private void licençaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new FrmLicenca().Show();  // mostra o formulario Licença
		}

		private void doaçãoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new FrmDoacao().Show();  // mostra o formulario Doação
		}
	}
}
