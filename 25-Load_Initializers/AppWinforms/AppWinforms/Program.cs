//25. Load e Initializers
//Nesta aula iremos aprender os eventos Load e Initializer de uma Aplicação Windows, 
//iremos saber como os programas verificam se o acesso a aplicação é válida ou não.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppWinforms
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
