
namespace CadastroCliente
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
			this.btnSalvar = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.textBoxNome = new System.Windows.Forms.TextBox();
			this.textBoxTelefone = new System.Windows.Forms.TextBox();
			this.textBoxEndereco = new System.Windows.Forms.TextBox();
			this.textBoxEmail = new System.Windows.Forms.TextBox();
			this.labelNome = new System.Windows.Forms.Label();
			this.labelTelefone = new System.Windows.Forms.Label();
			this.labelEndereco = new System.Windows.Forms.Label();
			this.labelEmail = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnSalvar
			// 
			this.btnSalvar.Location = new System.Drawing.Point(35, 375);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(75, 23);
			this.btnSalvar.TabIndex = 0;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.UseVisualStyleBackColor = true;
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(154, 375);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 1;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(271, 375);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(75, 23);
			this.btnUpdate.TabIndex = 2;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			// 
			// textBoxNome
			// 
			this.textBoxNome.Location = new System.Drawing.Point(154, 44);
			this.textBoxNome.Name = "textBoxNome";
			this.textBoxNome.Size = new System.Drawing.Size(192, 20);
			this.textBoxNome.TabIndex = 3;
			// 
			// textBoxTelefone
			// 
			this.textBoxTelefone.Location = new System.Drawing.Point(154, 104);
			this.textBoxTelefone.Name = "textBoxTelefone";
			this.textBoxTelefone.Size = new System.Drawing.Size(192, 20);
			this.textBoxTelefone.TabIndex = 4;
			// 
			// textBoxEndereco
			// 
			this.textBoxEndereco.Location = new System.Drawing.Point(154, 163);
			this.textBoxEndereco.Name = "textBoxEndereco";
			this.textBoxEndereco.Size = new System.Drawing.Size(192, 20);
			this.textBoxEndereco.TabIndex = 5;
			// 
			// textBoxEmail
			// 
			this.textBoxEmail.Location = new System.Drawing.Point(154, 222);
			this.textBoxEmail.Name = "textBoxEmail";
			this.textBoxEmail.Size = new System.Drawing.Size(192, 20);
			this.textBoxEmail.TabIndex = 6;
			// 
			// labelNome
			// 
			this.labelNome.AutoSize = true;
			this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelNome.Location = new System.Drawing.Point(32, 47);
			this.labelNome.Name = "labelNome";
			this.labelNome.Size = new System.Drawing.Size(51, 20);
			this.labelNome.TabIndex = 7;
			this.labelNome.Text = "Nome";
			// 
			// labelTelefone
			// 
			this.labelTelefone.AutoSize = true;
			this.labelTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTelefone.Location = new System.Drawing.Point(32, 104);
			this.labelTelefone.Name = "labelTelefone";
			this.labelTelefone.Size = new System.Drawing.Size(71, 20);
			this.labelTelefone.TabIndex = 8;
			this.labelTelefone.Text = "Telefone";
			// 
			// labelEndereco
			// 
			this.labelEndereco.AutoSize = true;
			this.labelEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelEndereco.Location = new System.Drawing.Point(32, 163);
			this.labelEndereco.Name = "labelEndereco";
			this.labelEndereco.Size = new System.Drawing.Size(78, 20);
			this.labelEndereco.TabIndex = 9;
			this.labelEndereco.Text = "Endereço";
			// 
			// labelEmail
			// 
			this.labelEmail.AutoSize = true;
			this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelEmail.Location = new System.Drawing.Point(32, 222);
			this.labelEmail.Name = "labelEmail";
			this.labelEmail.Size = new System.Drawing.Size(48, 20);
			this.labelEmail.TabIndex = 10;
			this.labelEmail.Text = "Email";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.labelEmail);
			this.Controls.Add(this.labelEndereco);
			this.Controls.Add(this.labelTelefone);
			this.Controls.Add(this.labelNome);
			this.Controls.Add(this.textBoxEmail);
			this.Controls.Add(this.textBoxEndereco);
			this.Controls.Add(this.textBoxTelefone);
			this.Controls.Add(this.textBoxNome);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnSalvar);
			this.Name = "Form1";
			this.Text = "Cadastro Cliente";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.TextBox textBoxNome;
		private System.Windows.Forms.TextBox textBoxTelefone;
		private System.Windows.Forms.TextBox textBoxEndereco;
		private System.Windows.Forms.TextBox textBoxEmail;
		private System.Windows.Forms.Label labelNome;
		private System.Windows.Forms.Label labelTelefone;
		private System.Windows.Forms.Label labelEndereco;
		private System.Windows.Forms.Label labelEmail;
	}
}

