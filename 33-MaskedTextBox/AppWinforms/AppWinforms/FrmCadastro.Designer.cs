
namespace AppWinforms
{
	partial class FrmCadastro
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
			this.txtNome = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.BtnCalcular = new System.Windows.Forms.Button();
			this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtNome
			// 
			this.txtNome.AutoSize = true;
			this.txtNome.Location = new System.Drawing.Point(69, 95);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(35, 13);
			this.txtNome.TabIndex = 0;
			this.txtNome.Text = "Nome";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(130, 95);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(432, 20);
			this.textBox1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(69, 159);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Numero";
			// 
			// txtNumero
			// 
			this.txtNumero.Location = new System.Drawing.Point(130, 152);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(432, 20);
			this.txtNumero.TabIndex = 3;
			// 
			// BtnCalcular
			// 
			this.BtnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnCalcular.Location = new System.Drawing.Point(130, 212);
			this.BtnCalcular.Name = "BtnCalcular";
			this.BtnCalcular.Size = new System.Drawing.Size(432, 39);
			this.BtnCalcular.TabIndex = 4;
			this.BtnCalcular.Text = "Calcular";
			this.BtnCalcular.UseVisualStyleBackColor = true;
			this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
			// 
			// maskedTextBox1
			// 
			this.maskedTextBox1.BeepOnError = true;
			this.maskedTextBox1.Location = new System.Drawing.Point(227, 35);
			this.maskedTextBox1.Mask = "+00(00)00000-0000";
			this.maskedTextBox1.Name = "maskedTextBox1";
			this.maskedTextBox1.Size = new System.Drawing.Size(124, 20);
			this.maskedTextBox1.TabIndex = 5;
			this.maskedTextBox1.Leave += new System.EventHandler(this.maskedTextBox1_Leave);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(130, 33);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 6;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// FrmCadastro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(910, 484);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.maskedTextBox1);
			this.Controls.Add(this.BtnCalcular);
			this.Controls.Add(this.txtNumero);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.txtNome);
			this.Name = "FrmCadastro";
			this.Text = "FrmCadastro";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label txtNome;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNumero;
		private System.Windows.Forms.Button BtnCalcular;
		private System.Windows.Forms.MaskedTextBox maskedTextBox1;
		private System.Windows.Forms.Button button1;
	}
}