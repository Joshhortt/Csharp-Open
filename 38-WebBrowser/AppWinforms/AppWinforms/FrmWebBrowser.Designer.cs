
namespace AppWinforms
{
	partial class FrmWebBrowser
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
			this.webBrowser = new System.Windows.Forms.WebBrowser();
			this.btnFacebook = new System.Windows.Forms.Button();
			this.btnYoutube = new System.Windows.Forms.Button();
			this.btnFechar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// webBrowser
			// 
			this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
			this.webBrowser.Location = new System.Drawing.Point(0, 0);
			this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser.Name = "webBrowser";
			this.webBrowser.Size = new System.Drawing.Size(1224, 496);
			this.webBrowser.TabIndex = 0;
			this.webBrowser.Url = new System.Uri("http://www.google.pt", System.UriKind.Absolute);
			// 
			// btnFacebook
			// 
			this.btnFacebook.Location = new System.Drawing.Point(30, 31);
			this.btnFacebook.Name = "btnFacebook";
			this.btnFacebook.Size = new System.Drawing.Size(75, 23);
			this.btnFacebook.TabIndex = 1;
			this.btnFacebook.Text = "Facebook";
			this.btnFacebook.UseVisualStyleBackColor = true;
			this.btnFacebook.Click += new System.EventHandler(this.btnFacebook_Click);
			// 
			// btnYoutube
			// 
			this.btnYoutube.Location = new System.Drawing.Point(135, 31);
			this.btnYoutube.Name = "btnYoutube";
			this.btnYoutube.Size = new System.Drawing.Size(75, 23);
			this.btnYoutube.TabIndex = 2;
			this.btnYoutube.Text = "Youtube";
			this.btnYoutube.UseVisualStyleBackColor = true;
			this.btnYoutube.Click += new System.EventHandler(this.btnYoutube_Click);
			// 
			// btnFechar
			// 
			this.btnFechar.Location = new System.Drawing.Point(240, 31);
			this.btnFechar.Name = "btnFechar";
			this.btnFechar.Size = new System.Drawing.Size(75, 23);
			this.btnFechar.TabIndex = 3;
			this.btnFechar.Text = "Fechar";
			this.btnFechar.UseVisualStyleBackColor = true;
			this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
			// 
			// FrmWebBrowser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1224, 496);
			this.Controls.Add(this.btnFechar);
			this.Controls.Add(this.btnYoutube);
			this.Controls.Add(this.btnFacebook);
			this.Controls.Add(this.webBrowser);
			this.Name = "FrmWebBrowser";
			this.Text = "FrmWebBrowser";
			this.Load += new System.EventHandler(this.FrmWebBrowser_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.WebBrowser webBrowser;
		private System.Windows.Forms.Button btnFacebook;
		private System.Windows.Forms.Button btnYoutube;
		private System.Windows.Forms.Button btnFechar;
	}
}