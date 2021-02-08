//38. Web Browser
//Nesta aula iremos aprender um componente chamado WebBrowser, iremos ver um caso real onde podemos utilizá-lo.
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
