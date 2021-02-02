using System.Diagnostics; // adicionar o System.Diagnostics para que o Process.Start execute.
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
	public partial class FrmDoacao : Form
	{
		public FrmDoacao()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Process.Start("https://github.com/Joshhortt/Csharp-Open");  // Vai para a URL onde o usuario Doar uma quantia.
		}
	}
}
