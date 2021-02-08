
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastro));
			this.txtNome = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.BtnCalcular = new System.Windows.Forms.Button();
			this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.txtBuscaTool = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
			this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menu2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menu3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menu2FilhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menu2FilhoFilhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripProgressBar2 = new System.Windows.Forms.ToolStripProgressBar();
			this.toolStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
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
			this.maskedTextBox1.Mask = "+000 000000000";
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
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.txtBuscaTool,
            this.toolStripLabel1,
            this.toolStripDropDownButton1,
            this.toolStripComboBox1});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.toolStrip1.Size = new System.Drawing.Size(740, 25);
			this.toolStrip1.TabIndex = 7;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// txtBuscaTool
			// 
			this.txtBuscaTool.Name = "txtBuscaTool";
			this.txtBuscaTool.Size = new System.Drawing.Size(200, 25);
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.RightToLeftAutoMirrorImage = true;
			this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton1.Text = "toolStripButton1";
			this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(133, 22);
			this.toolStripLabel1.Text = "Digite o termo de busca";
			// 
			// toolStripDropDownButton1
			// 
			this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.menu2ToolStripMenuItem,
            this.menu3ToolStripMenuItem});
			this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
			this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
			this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
			this.toolStripDropDownButton1.Text = "Menu";
			// 
			// menuToolStripMenuItem
			// 
			this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
			this.menuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.menuToolStripMenuItem.Text = "Menu";
			// 
			// menu2ToolStripMenuItem
			// 
			this.menu2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu2FilhoToolStripMenuItem});
			this.menu2ToolStripMenuItem.Name = "menu2ToolStripMenuItem";
			this.menu2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.menu2ToolStripMenuItem.Text = "Menu 2";
			// 
			// menu3ToolStripMenuItem
			// 
			this.menu3ToolStripMenuItem.Name = "menu3ToolStripMenuItem";
			this.menu3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.menu3ToolStripMenuItem.Text = "Menu 3";
			// 
			// menu2FilhoToolStripMenuItem
			// 
			this.menu2FilhoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu2FilhoFilhoToolStripMenuItem});
			this.menu2FilhoToolStripMenuItem.Name = "menu2FilhoToolStripMenuItem";
			this.menu2FilhoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.menu2FilhoToolStripMenuItem.Text = "Menu 2 filho";
			// 
			// menu2FilhoFilhoToolStripMenuItem
			// 
			this.menu2FilhoFilhoToolStripMenuItem.Name = "menu2FilhoFilhoToolStripMenuItem";
			this.menu2FilhoFilhoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.menu2FilhoFilhoToolStripMenuItem.Text = "Menu2 filho filho";
			// 
			// toolStripComboBox1
			// 
			this.toolStripComboBox1.Items.AddRange(new object[] {
            "Teste 1",
            "Teste 2",
            "Teste 3",
            "Teste 4"});
			this.toolStripComboBox1.Name = "toolStripComboBox1";
			this.toolStripComboBox1.Size = new System.Drawing.Size(121, 25);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar2});
			this.statusStrip1.Location = new System.Drawing.Point(0, 462);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(740, 22);
			this.statusStrip1.TabIndex = 8;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(129, 17);
			this.toolStripStatusLabel1.Text = "@JoshHortt Unipessoal";
			// 
			// toolStripProgressBar2
			// 
			this.toolStripProgressBar2.Name = "toolStripProgressBar2";
			this.toolStripProgressBar2.Size = new System.Drawing.Size(100, 16);
			this.toolStripProgressBar2.Value = 50;
			// 
			// FrmCadastro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(740, 484);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.maskedTextBox1);
			this.Controls.Add(this.BtnCalcular);
			this.Controls.Add(this.txtNumero);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.txtNome);
			this.Name = "FrmCadastro";
			this.Text = "FrmCadastro";
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
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
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripTextBox txtBuscaTool;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
		private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem menu2ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem menu2FilhoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem menu2FilhoFilhoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem menu3ToolStripMenuItem;
		private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar2;
	}
}