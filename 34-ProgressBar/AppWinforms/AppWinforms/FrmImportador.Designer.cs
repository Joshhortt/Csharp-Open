
namespace AppWinforms
{
	partial class FrmImportador
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
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.label1 = new System.Windows.Forms.Label();
			this.btnImportar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// progressBar
			// 
			this.progressBar.Location = new System.Drawing.Point(71, 108);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(389, 110);
			this.progressBar.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(66, 65);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(394, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "Clique no botao para atualizar os dados";
			// 
			// btnImportar
			// 
			this.btnImportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnImportar.Location = new System.Drawing.Point(71, 244);
			this.btnImportar.Name = "btnImportar";
			this.btnImportar.Size = new System.Drawing.Size(389, 62);
			this.btnImportar.TabIndex = 2;
			this.btnImportar.Text = "Importar";
			this.btnImportar.UseVisualStyleBackColor = true;
			// 
			// FrmImportador
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(540, 450);
			this.Controls.Add(this.btnImportar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.progressBar);
			this.Name = "FrmImportador";
			this.Text = "FrmImportador";
			this.Load += new System.EventHandler(this.FrmImportador_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ProgressBar progressBar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnImportar;
	}
}