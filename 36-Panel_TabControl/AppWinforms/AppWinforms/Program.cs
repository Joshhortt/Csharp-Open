//36. Panel & Tab Control
//Nesta aula iremos aprender sobre dois componentes bem utilizados para aplicação windows, 
//com Panel e TabControl, você pode organizar os seus forms e organizar o código.
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
