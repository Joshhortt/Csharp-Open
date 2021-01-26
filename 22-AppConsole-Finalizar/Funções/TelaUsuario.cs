using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funções
{
	class TelaUsuario
	{
		public static void Chamar()
		{
			Console.WriteLine("\n========================== Cadastro de Usuario ==========================\n");
			while (true)
			{
				string mensagem = "Digite uma das opções abaixo:\n" +
				"\n    0 - Sair do Cadastro" +
				"\n    1 - Para cadastrar Usuarios" +
				"\n    2 - Para listar Usuarios";

				Console.WriteLine(mensagem);

				int valor = int.Parse(Console.ReadLine());

				if (valor == 0)
				{
					break;
				}
				else if (valor == 1)
				{
					var usuario = new Usuario();
					
					Console.WriteLine("Digite o nome do Usuario");
					usuario.Nome = Console.ReadLine(); 

					Console.WriteLine("Digite o numero de Telefone do Usuario");
					usuario.Telefone = Console.ReadLine(); 

					Console.WriteLine("Digite o numero do Cartão de Cidadão do Usuario");
					usuario.CC = Console.ReadLine(); 

					usuario.Gravar();
				}
				else
				{
					var Usuarios = new Usuario().Ler(); 
					foreach (Usuario c in Usuarios)
					{   
						Console.WriteLine("=============================================");
						Console.WriteLine("Nome: " + c.Nome);
						Console.WriteLine("Telefone: " + c.Telefone);
						Console.WriteLine("Numero do Cartão de Cidadão" + c.CC);
						Console.WriteLine("=============================================");
					}
				}
			}
		}
	}
}

