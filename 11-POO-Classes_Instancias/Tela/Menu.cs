using Calculo;
using Diretorio;
using Funções;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tela
{
	class Menu
	{
		public const int SAIDA_PROGRAMA = 0;
		public const int LER_ARQUIVOS = 1;
		public const int TABUADA = 2;
		public const int CALCULO_MEDIA = 3;

		public static void Criar()
		{
			while (true)
			{
				string mensagem = "Olá Usuário! Benvindo ao programa,\n" +
				"\n  utilizando a Progrmação Funcional\n" +
				"\n\n   Digite uma das opções abaixo: \n" +
				"\n    0 - Sair do Programa" +
				"\n    1 - Para Ler Arquivos" +
				"\n    2 - Para executar a Tabuada" +
				"\n    3 - Para Calcular a Média dos Alunos";

				Console.WriteLine(mensagem);
				//Console.ReadLine();
				int valor = int.Parse(Console.ReadLine());

				if (valor == SAIDA_PROGRAMA)
				{
					break;
				}
				else if (valor == LER_ARQUIVOS)
				{
					Console.WriteLine("\n========================== Opção Ler Arquivos ==========================\n");
					Arquivo.Ler(1);
					Console.WriteLine("\n============================================================================\n");
				}
				else if (valor == TABUADA)
				{
					Console.WriteLine("\n==================== Opção Tabuada =============================================\n");
					Console.WriteLine("Digite o numero da Tabuada");
					int numero = int.Parse(Console.ReadLine());
					Tabuada.Calcular(numero);
					Console.WriteLine("\n================================================================================\n");
				}
				else if (valor == CALCULO_MEDIA)
				{
					Console.WriteLine("\n==================== Opção Calculo da Media========================================\n");
					Media.Alunos(); // Refactorado
									//Media.CalcularMediaAlunos();
									//CalcularMediaAlunos();
					Console.WriteLine("\n================================================================================\n");
				}
				else
				{
					Console.WriteLine("OPÇAO INVALIDA");
				}
			}
		}
	}
}
