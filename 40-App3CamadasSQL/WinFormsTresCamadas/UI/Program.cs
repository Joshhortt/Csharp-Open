//40. Aplicação em 3 Camadas - com acesso a Base de Dados SQL
//Nesta aula iremos aprender como conectar a nossa camada de database no banco de dados SQL Server, 
//iremos também criar tabelas no SQL e utilizar o comando insert.
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
