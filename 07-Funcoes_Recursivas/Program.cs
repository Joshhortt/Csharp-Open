
//********************************************************************************************************************
/* 07. Funções Recursivas
**********************************************************************************************************************
Nesta aula você irá aprender como criar uma função recursiva no C#, verá as vantagens e as 
desvantagens de utilizar esta função e fará um exercício na prática para entender melhor o conceito.
 */
//********************************************************************************************************************
// I. Função Recursiva que Lê um arquivo txt, dentro de um diretorio independentemente 
// da localização onde esse mesmo directório esteja situado no sistema operativo.
// Criar Diretorio Arquivos07 e criar um ficheiro arq1.txt dentro dele
// Ira oa google e escrever 'ler arquivo c# stack e escolher o primeiro dos links do stackoverflow
// https://pt.stackoverflow.com/questions/115233/ler-multiplas-linhas-de-um-arquivo-paralelamente-com-c
/*
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _07_Funções_Recursivas
{
	class Program
	{
		
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

		
		public static void Tabuada(int numero)
		{
			for (int i = 1; i <= 10; i++)
			{
				Console.WriteLine(numero + "x" + "=" + (numero * i));
			}
		}
		// 1. Criar uma Função que leia um ficheiro aqr1.txt' dentro de um directorio chamado 'Arquivos07'.
		private static void LerArquivo(string nomeArquivo)  // 1. Criar uma funçaõ privada, mas manter static para ir de 
															// encontro com o nosso static void Main() ...
		{
			using (StreamReader arquivo = File.OpenText(nomeArquivo))
			{
				string linha;
				while ((linha = arquivo.ReadLine()) != null)
				{
					Console.WriteLine(linha);
				}
			}
		}
		static void Main(string[] args)
		{

			LerArquivo(@"C:\Users\josec\OneDrive\Área de Trabalho\Csharp-Open\Arquivos_07\arq1.txt");  // o @ evita incopatibilidade com as barras
		}
	}
}
*/
/*
Amorzinho
Diabinha
Fofinha
Bruxinha
Mazinha
 */


// II. Função Recursiva que Lê varios arquivo txt, dentro desse diretorio independentemente 
// da localização (caminho) onde esse mesmo directório esteja situado no sistema operativo.
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _07_Funções_Recursivas
{
	class Program
	{
		private static string nomeArquivo;

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


		public static void Tabuada(int numero)
		{
			for (int i = 1; i <= 10; i++)
			{
				Console.WriteLine(numero + "x" + "=" + (numero * i));
			}
		}
		// 2. Criar uma Função que leia varios ficheiros aqr1.txt'; 'arq2.txt', 'arq3.txt' dentro de um directorio chamado 'Arquivos07'.
		private static void LerArquivo(int numeroArquivo)  // 2. mudar os parametros para...
		{
			string arquivoCaminho = (@"C:\Users\josec\OneDrive\Área de Trabalho\Csharp-Open\Arquivos_07\arq" + numeroArquivo + ".txt");//2. criar
			// uma string que concatena todos os arquivos

			if (File.Exists(arquivoCaminho)) // 3.  Verificar se esse arquvi existe
			{
				using (StreamReader arquivo = File.OpenText(arquivoCaminho)) // 4. Mudei o nome da variavel nomeArquivo para arquivoCaminho
				{
					string linha;
					while ((linha = arquivo.ReadLine()) != null)
					{
						Console.WriteLine(linha);
					}
				}
			}
			string arquivoCaminho2 = (@"C:\Users\josec\OneDrive\Área de Trabalho\Csharp-Open\Arquivos_07\arq" + numeroArquivo + 1 + ".txt");// 5. Criar uma nova variavel para arq2.txt

			if (File.Exists(arquivoCaminho2))// 6. Colocar uma valvula de escapae - Verifcação se existe o arq2.txt'
			{
				LerArquivo(numeroArquivo + 1);// 7. Agora entra em acção a Função Recursivo. Vou chamar a minha próprio Função para Ler o arq1, o arq2, o arq3 etc...
			}
		
		}
		static void Main(string[] args)
		{

			LerArquivo(1);  // 4. Ler o arquivo 1.
		}
	}
}
/*
 Amorzinho
Diabinha
Fofinha
Bruxinha
Mazinha
Joao
Marco
Antonio
Sandra
Felix
Casa
Quintal
Terraço
Garagem
Jardim
 */