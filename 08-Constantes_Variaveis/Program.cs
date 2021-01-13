
//********************************************************************************************************************
/* 08. Constantes e Variáveis
**********************************************************************************************************************
Nesta aula você irá aprender como criar constantes em C#, verá as formas de utilizar, os conceitos empregados, 
como é a estrutura e o design de código para criar.
 */
//********************************************************************************************************************
/*
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _08_Constantes_Variáveis
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

		private static void LerArquivo(int numeroArquivo)  
		{
			string arquivoCaminho = (@"C:\Users\josec\OneDrive\Área de Trabalho\Csharp-Open\Arquivos_07\arq" + numeroArquivo + ".txt");
																																  

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

			if (File.Exists(arquivoCaminho2)) ;
			{
				LerArquivo(numeroArquivo + 1);
			}

		}

// Criar uma constante aparir daqui
		public const int SAIDA_PROGRAMA = 1; // 1. Criei uma constante


		static void Main(string[] args)
		{
			// SAIDA_PROGRAMA = 2; // 6. Não podemos declarar a constante com outro valor por ser constante e imuatavel.
			while(true)
			{
				Console.WriteLine("Digite " + SAIDA_PROGRAMA + "para sair do programa"); // 2. criar uma concatenação de texto com a variavel constante
				int valor = int.Parse(Console.ReadLine());// 3. criar uma variavel de entrada que o usuario digitar.
				                                             //(Note é preciso converter a string para inteiro.
				if (SAIDA_PROGRAMA == valor) // 4. Verificação
				{
					break; // 5. Commando para evitar o looping eterno
				}	
						}
			LerArquivo(1);  
		}
	}
}
*/
/*
 Digite 1 para sair do programa
2
Digite 1 para sair do programa
3
Digite 1 para sair do programa
6
Digite 1 para sair do programa
1

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

