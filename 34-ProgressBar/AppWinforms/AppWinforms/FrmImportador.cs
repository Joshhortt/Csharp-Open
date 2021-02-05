using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppWinforms
{
	public partial class FrmImportador : Form
	{
		public FrmImportador()
		{
			InitializeComponent();
		}

		private void FrmImportador_Load(object sender, EventArgs e)
		{

			//fonte: https://stackoverflow.com/questions/8037070/whats-the-fastest-way-to-read-a-text-file-line-by-line
			string fileName = (@"D:\arquivos\dados_importados.txt");
			using (var streamReader = File.OpenText(fileName))
			{
				var lines = streamReader.ReadToEnd().Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
				progressBar.Maximum = lines.Length;  //Maximo de linhas
				progressBar.Minimum = 0;  // Minimo de linhas
				//foreach (var line in lines)
				for(var i = 0; i < lines.Length; i++)
				{
					var line = lines[i];
					progressBar.Value = (i + 1);  // adiciona 1 ao zero para que o progress bar comece em 1
				}
			}
		}
	}
}
