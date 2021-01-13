
//**********************************************************************************************************************
// 09. Programação Funcional parte 1
//**********************************************************************************************************************
//Nesta aula iremos entender o que é a programação orientada a função em C# bem como irá construir um Aplicação Console, 
//com um menu de opções, enviando para as funções que já criamos.
//********************************************************************************************************************

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_POF_parte1
{

	class Program
	{
		/*private static string nomeArquivo;


		static int CalcularSoma()

		{
			int a = 1;
			int b = 2;
			int c = a + b;
			return c;
		}

		
		public static void MostrarTela()
		{
			Console.WriteLine("Olá Pessoal!");
		}

		*/

		public static void Tabuada(int numero) 
		{
			Console.WriteLine("=================== Calculo da Tabuada de " + numero + " =======================");
			for (int i = 1; i <= 10; i++)
			{
				Console.WriteLine(numero + "x" + "=" + (numero * i));
			}
		}

		private static void LerArquivos(int numeroArquivo) 
		{
			string arquivoCaminho = (@"C:\Users\josec\OneDrive\Área de Trabalho\Csharp-Open\Arquivos_07\arq" + numeroArquivo + ".txt");
			//Console.WriteLine("============ Lendo arquivo ============\n" + arquivoCaminho + "\n========================");

			if (File.Exists(arquivoCaminho))
			{
				using (StreamReader arquivo = File.OpenText(arquivoCaminho))
				{
					string linha;
					while ((linha = arquivo.ReadLine()) != null)
					{
						Console.WriteLine(linha);
					}
				}
			}
			string arquivoCaminho2 = (@"C:\Users\josec\OneDrive\Área de Trabalho\Csharp-Open\Arquivos_07\arq" + numeroArquivo + 1 + ".txt");
		
			if (File.Exists(arquivoCaminho2));
			{
				LerArquivos(numeroArquivo + 1);
			}
		}

		private static void CalcularMediaAlunos()
		{
			Console.WriteLine("Digite o nome do aluno: ");
			string nomeAluno = Console.ReadLine();
			int quantNotas = 3;
			Console.WriteLine("Digite as" + quantNotas + " notas do aluno: " + nomeAluno);

			List<int> notas = new List<int>();
			int totalNotas = 0;
			for (int i = 1; i <= quantNotas; i++)
			{
				Console.WriteLine("Digite o numero de notas " + i);
				int nota = int.Parse(Console.ReadLine());
				totalNotas += nota;
				notas.Add(nota);
			}
			int mediaNotas = totalNotas / notas.Count;
			Console.WriteLine("A media do aluno " + nomeAluno + " é: " + mediaNotas);
			Console.WriteLine("As suas notas são: ");
			foreach (int nota in notas)
			{
				Console.WriteLine("Nota:  " + nota + "\n");
			}
		}

		private static void Menu()
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
					Console.WriteLine("\n===================== Opção Ler Arquivos =====================================\n");
					LerArquivos(1);
					Console.WriteLine("\n===============================================================================\n");
				}
				else if (valor == TABUADA)
				{
					Console.WriteLine("\n==================== Opção Tabuada =============================================\n");
					Console.WriteLine("Digite o numero da Tabuada");
					int numero = int.Parse(Console.ReadLine());
					Tabuada(numero);
					Console.WriteLine("\n================================================================================\n");
				}
				else if (valor == CALCULO_MEDIA)
				{
					Console.WriteLine("\n==================== Opção Calculo da Media========================================\n");
					CalcularMediaAlunos();
					Console.WriteLine("\n================================================================================\n");
				}
				else
				{
					Console.WriteLine("OPÇAO INVALIDA");
				}
			}
		}
	
		public const int SAIDA_PROGRAMA = 0;
		public const int LER_ARQUIVOS = 1;
		public const int TABUADA = 2;
		public const int CALCULO_MEDIA = 3;

		static void Main(string[] args)
		{
			Menu();
		}
	}
}
	

