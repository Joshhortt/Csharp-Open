﻿
namespace AppWinforms
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.btnOk = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtResultado = new System.Windows.Forms.TextBox();
			this.btnAbre = new System.Windows.Forms.Button();
			this.cboEstados = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.lblNomeGrid = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.novoTextoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.licençaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.doaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lblHoraAtual = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.btnNotificacao = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnOk
			// 
			this.btnOk.Location = new System.Drawing.Point(34, 190);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(326, 59);
			this.btnOk.TabIndex = 0;
			this.btnOk.Text = "OK";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(31, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(329, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Pressione Ok para preencher a caixa de texto";
			// 
			// txtResultado
			// 
			this.txtResultado.Location = new System.Drawing.Point(34, 65);
			this.txtResultado.Name = "txtResultado";
			this.txtResultado.Size = new System.Drawing.Size(325, 20);
			this.txtResultado.TabIndex = 2;
			// 
			// btnAbre
			// 
			this.btnAbre.Location = new System.Drawing.Point(35, 337);
			this.btnAbre.Name = "btnAbre";
			this.btnAbre.Size = new System.Drawing.Size(202, 39);
			this.btnAbre.TabIndex = 3;
			this.btnAbre.Text = "Abrir nova Janela";
			this.btnAbre.UseVisualStyleBackColor = true;
			this.btnAbre.Click += new System.EventHandler(this.btnAbre_Click);
			// 
			// cboEstados
			// 
			this.cboEstados.FormattingEnabled = true;
			this.cboEstados.Items.AddRange(new object[] {
            "SP",
            "RJ",
            "MG",
            "GO"});
			this.cboEstados.Location = new System.Drawing.Point(35, 135);
			this.cboEstados.Name = "cboEstados";
			this.cboEstados.Size = new System.Drawing.Size(325, 21);
			this.cboEstados.TabIndex = 4;
			this.cboEstados.Text = "[Selecione]";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(30, 112);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 20);
			this.label2.TabIndex = 5;
			this.label2.Text = "Estados";
			// 
			// dataGridView
			// 
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Location = new System.Drawing.Point(410, 226);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.Size = new System.Drawing.Size(444, 135);
			this.dataGridView.TabIndex = 6;
			// 
			// lblNomeGrid
			// 
			this.lblNomeGrid.AutoSize = true;
			this.lblNomeGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNomeGrid.Location = new System.Drawing.Point(539, 190);
			this.lblNomeGrid.Name = "lblNomeGrid";
			this.lblNomeGrid.Size = new System.Drawing.Size(225, 20);
			this.lblNomeGrid.TabIndex = 7;
			this.lblNomeGrid.Text = "Dados da Coleção de Estados";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.infoToolStripMenuItem,
            this.cadastroToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(875, 24);
			this.menuStrip1.TabIndex = 8;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// arquivoToolStripMenuItem
			// 
			this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoTextoToolStripMenuItem,
            this.sairToolStripMenuItem});
			this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
			this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.arquivoToolStripMenuItem.Text = "Arquivo";
			// 
			// novoTextoToolStripMenuItem
			// 
			this.novoTextoToolStripMenuItem.Name = "novoTextoToolStripMenuItem";
			this.novoTextoToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
			this.novoTextoToolStripMenuItem.Text = "Novo texto";
			this.novoTextoToolStripMenuItem.Click += new System.EventHandler(this.novoTextoToolStripMenuItem_Click);
			// 
			// sairToolStripMenuItem
			// 
			this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
			this.sairToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
			this.sairToolStripMenuItem.Text = "Sair";
			this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
			// 
			// infoToolStripMenuItem
			// 
			this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem,
            this.licençaToolStripMenuItem,
            this.doaçãoToolStripMenuItem});
			this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
			this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
			this.infoToolStripMenuItem.Text = "Info";
			// 
			// sobreToolStripMenuItem
			// 
			this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
			this.sobreToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
			this.sobreToolStripMenuItem.Text = "Sobre";
			this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
			// 
			// licençaToolStripMenuItem
			// 
			this.licençaToolStripMenuItem.Name = "licençaToolStripMenuItem";
			this.licençaToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
			this.licençaToolStripMenuItem.Text = "Licença";
			this.licençaToolStripMenuItem.Click += new System.EventHandler(this.licençaToolStripMenuItem_Click);
			// 
			// doaçãoToolStripMenuItem
			// 
			this.doaçãoToolStripMenuItem.Name = "doaçãoToolStripMenuItem";
			this.doaçãoToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
			this.doaçãoToolStripMenuItem.Text = "Doação";
			this.doaçãoToolStripMenuItem.Click += new System.EventHandler(this.doaçãoToolStripMenuItem_Click);
			// 
			// cadastroToolStripMenuItem
			// 
			this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
			this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(195, 20);
			this.cadastroToolStripMenuItem.Text = "Cadastro com tratamento de Erro";
			this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
			// 
			// lblHoraAtual
			// 
			this.lblHoraAtual.AutoSize = true;
			this.lblHoraAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHoraAtual.Location = new System.Drawing.Point(524, 42);
			this.lblHoraAtual.Name = "lblHoraAtual";
			this.lblHoraAtual.Size = new System.Drawing.Size(312, 24);
			this.lblHoraAtual.TabIndex = 9;
			this.lblHoraAtual.Text = "Dia / Hora atual: 01/01/2021 00:00:00";
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// notifyIcon
			// 
			this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
			this.notifyIcon.Text = "Meu Programa \r\nLaboratorio";
			this.notifyIcon.Visible = true;
			this.notifyIcon.Click += new System.EventHandler(this.notifyIcon_Click);
			this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
			// 
			// btnNotificacao
			// 
			this.btnNotificacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNotificacao.Location = new System.Drawing.Point(543, 112);
			this.btnNotificacao.Name = "btnNotificacao";
			this.btnNotificacao.Size = new System.Drawing.Size(221, 48);
			this.btnNotificacao.TabIndex = 10;
			this.btnNotificacao.Text = "Dar Notificação";
			this.btnNotificacao.UseVisualStyleBackColor = true;
			this.btnNotificacao.Click += new System.EventHandler(this.btnNotificacao_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(410, 385);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(168, 23);
			this.button1.TabIndex = 11;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(875, 474);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnNotificacao);
			this.Controls.Add(this.lblHoraAtual);
			this.Controls.Add(this.lblNomeGrid);
			this.Controls.Add(this.dataGridView);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cboEstados);
			this.Controls.Add(this.btnAbre);
			this.Controls.Add(this.txtResultado);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Aplicação 1";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtResultado;
		private System.Windows.Forms.Button btnAbre;
		private System.Windows.Forms.ComboBox cboEstados;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.Label lblNomeGrid;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem novoTextoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem licençaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem doaçãoToolStripMenuItem;
		private System.Windows.Forms.Label lblHoraAtual;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
		private System.Windows.Forms.NotifyIcon notifyIcon;
		private System.Windows.Forms.Button btnNotificacao;
		private System.Windows.Forms.Button button1;
	}
}

