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
	public partial class FrmPanel : Form
	{
		public FrmPanel()
		{
			InitializeComponent();
		}

		private void btnAlerta_Click(object sender, EventArgs e)
		{
			MessageBox.Show("O nome digitado é: " + txtNome.Text);  // Mostra uma mensagem de Alerta
		}

		private void btnShowCadastro_Click(object sender, EventArgs e)
		{
			// Mostrar tudo referente a Cadastro e esconde tudo referente a Lista
			pnlCadastro.Visible = true; 
			pnlLista.Visible = false;
			//btnShowLista.Visible = false;
			//btnShowCadastro.Visible = true;
		}

		private void FrmPanel_Load(object sender, EventArgs e)
		{

			dataGridView1.DataSource = Estado.Lista();
		}

		private void btnShowLista_Click(object sender, EventArgs e)
		{
			// Mostrar tudo referente a Lista e esconde tudo referente a Cadastro
			pnlLista.Visible = true; 
			pnlCadastro.Visible = false;
			//btnShowLista.Visible = true;
			//btnShowCadastro.Visible = false;
		}
	}
}
