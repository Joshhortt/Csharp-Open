//39. Aplicação em 3 Camadas
//Nesta aula iremos aprender como organizar uma aplicação na padrão de arquitetura 3 camadas, 
//separando cada camada com sua responsabilidade, organizando o seu projeto e pensando em evoluções futuras.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsTresCamadas
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
