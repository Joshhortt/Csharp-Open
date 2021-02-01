//24. Manipulação de Formularios
//Nesta aula iremos aprender como manipular formulários de nossa Aplicação Windows, 
//iremos notar nesta aula que os conceitos de orientação a objetos são essenciais.

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
