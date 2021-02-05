//33. Masked Text Box
//Nesta aula iremos aprender como colocar mascara em nossos inputs de dados, 
//obrigando o nosso usuário digitar de acordo com a mascara que colocarmos em nosso text.

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
