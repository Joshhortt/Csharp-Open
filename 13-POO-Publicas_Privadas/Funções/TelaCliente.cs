﻿using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funções
{
	class TelaCliente
	{
		public static void Chamar()
		{

			Console.WriteLine("\n========================== Cadastro de Cliente ==========================\n");
			while (true)
			{

				string mensagem = "Digite uma das opções abaixo:\n" +
				"\n    0 - Sair do Cadastro" +
				"\n    1 - Para cadastrar clientes" +
				"\n    2 - Para listar clientes";

				int valor = int.Parse(Console.ReadLine());

				if (valor == 0)
				{
					break;
				}
				else if (valor == 1)
				{
					// Ler para dentro do cliente
					var cliente = new Cliente();
					Console.WriteLine("");
					cliente.Nome = Console.ReadLine();  //"Geraldo";
					cliente.Telefone = Console.ReadLine();  //"911815870";
					cliente.CC = Console.ReadLine(); // "9690540";
					cliente.Gravar();
				}
				else
				{
					var clientes = Cliente.LerClientes();
					foreach (Cliente c in clientes)
					{
						Console.WriteLine(c.Nome);
						Console.WriteLine(c.Telefone);
						Console.WriteLine(c.CC);
						Console.WriteLine("=============================================");
					}
				}

				var clientes = Cliente.LerClientes();
				foreach (Cliente c in clientes)
				{
					Console.WriteLine(c.Nome);
					Console.WriteLine(c.Telefone);
					Console.WriteLine(c.CC);
					Console.WriteLine("=============================================");
				}
			 }
			}
		}
	}
}

