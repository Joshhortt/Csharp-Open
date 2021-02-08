
namespace AppWinforms
{
	partial class FrmPanel
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
			this.pnlCadastro = new System.Windows.Forms.Panel();
			this.btnAlerta = new System.Windows.Forms.Button();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnShowCadastro = new System.Windows.Forms.Button();
			this.pnlLista = new System.Windows.Forms.Panel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.btnShowLista = new System.Windows.Forms.Button();
			this.pnlCadastro.SuspendLayout();
			this.pnlLista.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlCadastro
			// 
			this.pnlCadastro.Controls.Add(this.btnAlerta);
			this.pnlCadastro.Controls.Add(this.txtNome);
			this.pnlCadastro.Controls.Add(this.label1);
			this.pnlCadastro.Location = new System.Drawing.Point(12, 87);
			this.pnlCadastro.Name = "pnlCadastro";
			this.pnlCadastro.Size = new System.Drawing.Size(384, 282);
			this.pnlCadastro.TabIndex = 0;
			this.pnlCadastro.Visible = false;
			// 
			// btnAlerta
			// 
			this.btnAlerta.Location = new System.Drawing.Point(186, 23);
			this.btnAlerta.Name = "btnAlerta";
			this.btnAlerta.Size = new System.Drawing.Size(75, 23);
			this.btnAlerta.TabIndex = 2;
			this.btnAlerta.Text = "Ok";
			this.btnAlerta.UseVisualStyleBackColor = true;
			this.btnAlerta.Click += new System.EventHandler(this.btnAlerta_Click);
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(61, 23);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(100, 20);
			this.txtNome.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(20, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nome";
			// 
			// btnShowCadastro
			// 
			this.btnShowCadastro.Location = new System.Drawing.Point(12, 41);
			this.btnShowCadastro.Name = "btnShowCadastro";
			this.btnShowCadastro.Size = new System.Drawing.Size(144, 23);
			this.btnShowCadastro.TabIndex = 1;
			this.btnShowCadastro.Text = "Mostrar Cadastro";
			this.btnShowCadastro.UseVisualStyleBackColor = true;
			this.btnShowCadastro.Click += new System.EventHandler(this.btnShowCadastro_Click);
			// 
			// pnlLista
			// 
			this.pnlLista.Controls.Add(this.dataGridView1);
			this.pnlLista.Controls.Add(this.label2);
			this.pnlLista.Location = new System.Drawing.Point(413, 87);
			this.pnlLista.Name = "pnlLista";
			this.pnlLista.Size = new System.Drawing.Size(397, 282);
			this.pnlLista.TabIndex = 2;
			this.pnlLista.Visible = false;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(21, 64);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(356, 191);
			this.dataGridView1.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(27, 23);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Lista";
			// 
			// btnShowLista
			// 
			this.btnShowLista.Location = new System.Drawing.Point(434, 41);
			this.btnShowLista.Name = "btnShowLista";
			this.btnShowLista.Size = new System.Drawing.Size(104, 23);
			this.btnShowLista.TabIndex = 3;
			this.btnShowLista.Text = "Mostrar Lista";
			this.btnShowLista.UseVisualStyleBackColor = true;
			this.btnShowLista.Click += new System.EventHandler(this.btnShowLista_Click);
			// 
			// FrmPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.ClientSize = new System.Drawing.Size(822, 481);
			this.Controls.Add(this.btnShowLista);
			this.Controls.Add(this.pnlLista);
			this.Controls.Add(this.btnShowCadastro);
			this.Controls.Add(this.pnlCadastro);
			this.Name = "FrmPanel";
			this.Text = "FrmPanelTabControl";
			this.Load += new System.EventHandler(this.FrmPanel_Load);
			this.pnlCadastro.ResumeLayout(false);
			this.pnlCadastro.PerformLayout();
			this.pnlLista.ResumeLayout(false);
			this.pnlLista.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlCadastro;
		private System.Windows.Forms.Button btnAlerta;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnShowCadastro;
		private System.Windows.Forms.Panel pnlLista;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnShowLista;
	}
}