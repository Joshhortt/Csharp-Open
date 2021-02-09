using System;
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
	public partial class FrmWebBrowser : Form
	{
		public FrmWebBrowser()
		{
			InitializeComponent();
		}

		private void btnFacebook_Click(object sender, EventArgs e)
		{
			webBrowser.Url = new Uri("https://www.facebook.com");  // Botao que activa a pagina do facebook no Web Browser
		}

		private void btnYoutube_Click(object sender, EventArgs e)
		{
			webBrowser.Url = new Uri("https://www.youtube.com");   // Botao que activa a pagina do youtube no Web Browser
		}

		private void btnFechar_Click(object sender, EventArgs e)
		{
			this.Close();  // Botao que encerra o Web Browser
		}
	}
}
