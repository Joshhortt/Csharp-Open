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
			this.btnOk = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtResultado = new System.Windows.Forms.TextBox();
			this.btnAbre = new System.Windows.Forms.Button();
			this.cboEstados = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.lblNomeGrid = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// btnOk
			// 
			this.btnOk.Location = new System.Drawing.Point(33, 208);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(326, 23);
			this.btnOk.TabIndex = 0;
			this.btnOk.Text = "OK";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(30, 51);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(329, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Pressione Ok para preencher a caixa de texto";
			// 
			// txtResultado
			// 
			this.txtResultado.Location = new System.Drawing.Point(33, 74);
			this.txtResultado.Name = "txtResultado";
			this.txtResultado.Size = new System.Drawing.Size(325, 20);
			this.txtResultado.TabIndex = 2;
			// 
			// btnAbre
			// 
			this.btnAbre.Location = new System.Drawing.Point(101, 408);
			this.btnAbre.Name = "btnAbre";
			this.btnAbre.Size = new System.Drawing.Size(202, 23);
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
			this.cboEstados.Location = new System.Drawing.Point(34, 139);
			this.cboEstados.Name = "cboEstados";
			this.cboEstados.Size = new System.Drawing.Size(325, 21);
			this.cboEstados.TabIndex = 4;
			this.cboEstados.Text = "[Selecione]";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(30, 116);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 20);
			this.label2.TabIndex = 5;
			this.label2.Text = "Estados";
			// 
			// dataGridView
			// 
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Location = new System.Drawing.Point(401, 163);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.Size = new System.Drawing.Size(456, 150);
			this.dataGridView.TabIndex = 6;
			// 
			// lblNomeGrid
			// 
			this.lblNomeGrid.AutoSize = true;
			this.lblNomeGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNomeGrid.Location = new System.Drawing.Point(502, 140);
			this.lblNomeGrid.Name = "lblNomeGrid";
			this.lblNomeGrid.Size = new System.Drawing.Size(225, 20);
			this.lblNomeGrid.TabIndex = 7;
			this.lblNomeGrid.Text = "Dados da Coleção de Estados";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(896, 474);
			this.Controls.Add(this.lblNomeGrid);
			this.Controls.Add(this.dataGridView);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cboEstados);
			this.Controls.Add(this.btnAbre);
			this.Controls.Add(this.txtResultado);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnOk);
			this.Name = "Form1";
			this.Text = "Aplicação 1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
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
	}
}

