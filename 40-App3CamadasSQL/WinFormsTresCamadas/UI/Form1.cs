﻿using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsTresCamadas
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnGravar_Click(object sender, EventArgs e)  // METODO Gravar
		{
			var usuario = new Usuario();
			usuario.Nome = txtNome.Text;
			usuario.Telefone = txtTelefone.Text;
			usuario.CC = txtCC.Text;
			usuario.Gravar();

			MessageBox.Show("Usuario salvo com sucesso"); 
		}
	}
}
