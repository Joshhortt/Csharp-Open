﻿using System;
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
 
		private void AbrirLerArquivo_Click(object sender, EventArgs e)
		{
			new FrmTexto().Show(); 
		}

		private void AbrirCadastro_Click(object sender, EventArgs e)
		{
			new FrmCadastro().Show();  
		}

		private void Fechar_Click(object sender, EventArgs e)
		{
			Application.Exit();  
		}

		private void btnAbre_Click(object sender, EventArgs e)
		{
			var form = new FrmShow();
			form.lblMensagem.Text = txtResultado.Text;
			form.Show();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			var contextMenu = new ContextMenu();
			contextMenu.MenuItems.Add(new MenuItem("Abrir Ler Arquivo", AbrirLerArquivo_Click));
			contextMenu.MenuItems.Add(new MenuItem("Abrir Cadastro", AbrirCadastro_Click));
			contextMenu.MenuItems.Add(new MenuItem("Fechar", Fechar_Click));
			notifyIcon.ContextMenu = ContextMenu;

			atualizarHora();


																		      
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

		private void atualizarHora()  
		{
			lblHoraAtual.Text = "Dia e Hora atual: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
		}

		private void novoTextoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var frmTexto = new FrmTexto();
			frmTexto.MdiParent = MDISingleton.InstanciaMDI(); 
			frmTexto.Show();    // aqui estou a dizer que o meu formulario novo texto vai abrir dentro do MDI
		}

		private void sairToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();   
		}

		private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new FrmSobre().Show();  
		}

		private void licençaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new FrmLicenca().Show();  
		}

		private void doaçãoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new FrmDoacao().Show(); 
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			atualizarHora();
		}

		private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new FrmCadastro().Show(); 
		}

		private void notifyIcon_Click(object sender, EventArgs e)
		{
			//MessageBox.Show("Cliquei no Icon");  
		}

		private void notifyIcon_DoubleClick(object sender, EventArgs e)
		{
			//MessageBox.Show("Cliquei no Icon duas vezes");  
		}

		private void btnNotificacao_Click(object sender, EventArgs e)
		{ 
		   // notifyIcon.ShowBalloonTip(10, "Notificação", txtResultado.Text, ToolTipIcon.Info); 
		   // notifyIcon.ShowBalloonTip(10, "Notificação", "Erro na aplicação", ToolTipIcon.Error);
		   // notifyIcon.ShowBalloonTip(10, "Notificação", "Valide os campo\nNome, Telefone", ToolTipIcon.Warning);
			notifyIcon.ShowBalloonTip(10, "Notificação", "Valide os campo\nNome, Telefone", ToolTipIcon.None);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			new MDIParentPrincipal().Show(); // vai permitir abrir o MDI do botao do form principal
		}
	}
}
