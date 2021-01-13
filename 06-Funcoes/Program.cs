//********************************************************************************************************************
/* 06. Funções.
**********************************************************************************************************************
Nesta aula você irá aprender como criar uma função, irá entender palavra por 
palavra de como funciona a estrutura de uma função em C#, como criar funções 
publicas, privadas e muito mais.
 */
//********************************************************************************************************************

// I. Funções Locais Public 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Funções
{
	class Program
	{
		// 1. Criar uma função com retorno com PascalCase
		static int CalcularSoma() // se retirmos o public ele permanece oublic da mesma forma.
			// public static CalcularSoma();  
		{
			int a = 1;
			int b = 2;
			int c = a + b;
			return c;
		}
		// 2. Criar uma função sem retorno com PascalCase
		public static void MostrarTela()
		{
			Console.WriteLine("Olá Pessoal!");
		}

		// 3. Criar uma Função sem retorno com parametros. (estrutura de repetição)
		public static void Tabuada(int numero)
		{
			for(int i = 1; i <= 10; i++)
			{
				Console.WriteLine(numero + "x" + "=" + (numero*i));
			}
		}

		static void Main(string[] args)
		{
			//1. o retorno de 3
		
			int retorno = CalcularSoma();
			Console.WriteLine(retorno);
			Console.Write("\n");
			// Console.WriteLine(CalcularSoma());  1. podemos retirar esta linha se incluirmos as linhas acima
			
			 //int retorno = CalcularSoma();  1. o retorno de 3
			 //Console.WriteLine(retorno);
			 
			MostrarTela();  // 2. Não tem retorno nenhum.
			Console.Write("\n");
			Tabuada(9);  // 3. quero mostrar a tabuada do 9 na tela
			Console.Write("\n");
			Tabuada(3);  // 3. quero mostrar a tabuada do 3 na tela

			Console.Read();
		}
	}
}
/*
 3

Olá Pessoal!

9x=9
9x=18
9x=27
9x=36
9x=45
9x=54
9x=63
9x=72
9x=81
9x=90

3x=3
3x=6
3x=9
3x=12
3x=15
3x=18
3x=21
3x=24
3x=27
3x=30

 */

// II. Funções 'INTERNAL' só vao permitir trabalhar internamente com a variavel ' namespace _06_Funções '.
// internal static int CalcularSoma()

// III. Funções 'PROTECTED' só vao permitir trabalhar internamente com a variavel ' namespace _06_Funções + ' class Program '.
// protected static int CalcularSoma()

// IV. Funções 'PRIVATE' só vao permitir trabalhar internamente com a variavel ' class Program '.
// private static int CalcularSoma()


// =================== Mais Exemplos ================================================================================================
/*
Exemplo 1
O  código a seguir mostra uma função FindMax que recebe dois valores inteiros e retorna o maior dos dois. 
Ele tem um especificador de acesso público, portanto, pode ser acessado de fora da classe usando uma instância da classe.
Você pode chamar um método usando o nome do método. O exemplo a seguir ilustra isso também.
 */
/*
using System;

namespace CalculatorApplication
{

	class NumberManipulator
	{

		public int FindMax(int num1, int num2)
		{
			// local variable declaration 
			int result;

			if (num1 > num2)
				result = num1;
			else
				result = num2;
			return result;
		}

		static void Main(string[] args)
		{
			// local variable definition 
			int a = 100;
			int b = 200;
			int ret;
			NumberManipulator n = new NumberManipulator();

			//calling the FindMax method
			ret = n.FindMax(a, b);
			Console.WriteLine("Max value is : {0}", ret);
			Console.ReadLine();
		}
	}
}
*/
// Max value is : 200

// Exemplo 2
/*
using System;

public class Program
{
   public static void Main()
   {
	   var result = Calculator.Sum(10, 25); // chama o metodo static
	   Calculator.Store(result);
	   Console.WriteLine(result);

	   var calcType = Calculator.Type; // cai acessar a variavel static
	   Calculator.Type = "Scientific"; // designa um valor á variavel static
   }
}

public static class Calculator
{
   private static int _resultStorage = 0;

   public static string Type = "Arithmetic";

   public static int Sum(int num1, int num2)
   {
	   return num1 + num2;
   }

   public static void Store(int result)
   {
	   _resultStorage = result;  // retorna o valor
   }
}
// 35
*/
