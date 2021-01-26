using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funções
{
	class TelaFornecedor
	{
		public static void Chamar()
		{
			Console.WriteLine("\n========================== Cadastro de Fornecedor ==========================\n");
			while (true)
			{
				string mensagem = "Digite uma das opções abaixo:\n" +
				"\n    0 - Sair do Cadastro" +
				"\n    1 - Para cadastrar Fornecedores" +
				"\n    2 - Para listar Fornecedores";

				Console.WriteLine(mensagem);

				int valor = int.Parse(Console.ReadLine());

				if (valor == 0)
				{
					break;
				}
				else if (valor == 1)
				{
					var fornecedor = new Fornecedor();
					// 4. Adicionar numero fiscal ao Fornecedor NIF
					Console.WriteLine("Digite o numero fiscal do Fornecedor");
					fornecedor.NIF = Console.ReadLine();

					Console.WriteLine("Digite o nome do Fornecedor");
					fornecedor.Nome = Console.ReadLine(); 

					Console.WriteLine("Digite o numero de Telefone do Fornecedor");
					fornecedor.Telefone = Console.ReadLine(); 

					Console.WriteLine("Digite o numero do Cartão de Cidadão do Gerente");
					fornecedor.CC = Console.ReadLine(); 

					fornecedor.Gravar();
				}
				else
				{
					var fornecedores = new Fornecedor().Ler(); 
					foreach (Fornecedor c in fornecedores)
					{   
						Console.WriteLine("=============================================");
						Console.WriteLine("Numero Identifição Fiscal: " + c.NIF);   // 5. Adicionar NIF aqui tambem
						Console.WriteLine("Nome: " + c.Nome);
						Console.WriteLine("Telefone: " + c.Telefone);
						Console.WriteLine("Numero Cartão de Cidadão do Gerente: " + c.CC);
						Console.WriteLine("=============================================");
					}
				}
			}
		}
	}
}

