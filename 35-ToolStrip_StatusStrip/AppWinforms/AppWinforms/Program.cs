//35. Tools Strip & Status Strip
//Nesta aula iremos aprender como utilizar dois componentes em nossa aplicação windows o ToolStrip e o StatusStrip, 
//com eles é possível melhorar a usabilidade de nossa aplicação, gerando mais valor para nosso cliente.
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
