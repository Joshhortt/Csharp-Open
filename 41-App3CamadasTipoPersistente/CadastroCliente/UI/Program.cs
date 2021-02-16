//41. Aplicação em 3 Camadas - Tipos de Arquiteturas não persistentes e persistentes.
//Nesta aula iremos aprender duas arquiteturas diferentes, objetos não persistentes e objetos persistentes.
//Construimos uma pequena Aplicação de Cadastro de Cliente com ligação ao SQL com objectos persistentes.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroCliente
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
