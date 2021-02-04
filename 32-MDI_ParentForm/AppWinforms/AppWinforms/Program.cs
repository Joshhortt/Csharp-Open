//32. MDI Parent Form
//Nesta aula iremos aprender como organizar os nossos formulários,
//com MDI Form é possível colocar formulários dentro de formulários, 
//utilizaremos uma classe singleton para gerenciar a instância.

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
			//Application.Run(new Form1());
			//Application.Run(new MDIParentPrincipal());  
			Application.Run(MDISingleton.InstanciaMDI());  // Agora tem a classe singleton como instancia global do MDI
		}
	}
}
