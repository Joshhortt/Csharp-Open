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
	public partial class FrmPanel : Form
	{
		public FrmPanel()
		{
			InitializeComponent();
		}

		private void btnAlerta_Click(object sender, EventArgs e)
		{
			MessageBox.Show("O nome digitado é: " + txtNome.Text);
		}

		private void btnShowCadastro_Click(object sender, EventArgs e)
		{
			pnlCadastro.Visible = true;
		}
	}
}
