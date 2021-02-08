
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.btnAlerta = new System.Windows.Forms.Button();
			this.btnShowCadastro = new System.Windows.Forms.Button();
			this.pnlCadastro.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlCadastro
			// 
			this.pnlCadastro.Controls.Add(this.btnAlerta);
			this.pnlCadastro.Controls.Add(this.txtNome);
			this.pnlCadastro.Controls.Add(this.label1);
			this.pnlCadastro.Location = new System.Drawing.Point(12, 87);
			this.pnlCadastro.Name = "pnlCadastro";
			this.pnlCadastro.Size = new System.Drawing.Size(349, 282);
			this.pnlCadastro.TabIndex = 0;
			this.pnlCadastro.Visible = false;
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
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(61, 23);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(100, 20);
			this.txtNome.TabIndex = 1;
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
			// btnShowCadastro
			// 
			this.btnShowCadastro.Location = new System.Drawing.Point(12, 43);
			this.btnShowCadastro.Name = "btnShowCadastro";
			this.btnShowCadastro.Size = new System.Drawing.Size(75, 23);
			this.btnShowCadastro.TabIndex = 1;
			this.btnShowCadastro.Text = "Mostrar";
			this.btnShowCadastro.UseVisualStyleBackColor = true;
			this.btnShowCadastro.Click += new System.EventHandler(this.btnShowCadastro_Click);
			// 
			// FrmPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnShowCadastro);
			this.Controls.Add(this.pnlCadastro);
			this.Name = "FrmPanel";
			this.Text = "FrmPanelTabControl";
			this.pnlCadastro.ResumeLayout(false);
			this.pnlCadastro.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlCadastro;
		private System.Windows.Forms.Button btnAlerta;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnShowCadastro;
	}
}