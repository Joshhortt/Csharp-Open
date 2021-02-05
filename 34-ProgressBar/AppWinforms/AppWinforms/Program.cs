//34. Progress Bar
//Nesta aula iremos aprender como criar uma barra de progresso para nossas aplicações windows, 
//iremos simular uma importação de um arquivo texto com várias linhas, dando um status para nossos clientes.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppWinforms
{
	static class Programs
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false); 
			Application.Run(MDISingleton.InstanciaMDI());  
		}
	}
}
