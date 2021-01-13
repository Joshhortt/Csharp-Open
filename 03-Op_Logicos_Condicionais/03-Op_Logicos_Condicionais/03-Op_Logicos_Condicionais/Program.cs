
/*
03 - OPERADORES LÓGICOS E CONDICIONAIS - C# - PROGRAMADOR 
Nesta aula você irá aprender os operadores lógicos e condicionais do C#, verá na prática como utilizar
comando como (if, else, switch, &&, ==, !, !=, <, >), desenvolvendo melhor a sua lógica e o seu projeto.

http://www.torneseumprogramador.com.br/aula?id=3kD3lFjGC_I&aula=3&tipo=c-sharp&professor=Danilo
https://www.devmedia.com.br/tipos-de-operadores-do-csharp/18873

 */
 
//***************************************************************************

// 1.a. Operação if else simples  - Condicionais
/*
using System;

namespace _03_Op_Logicos_Condicionais
{
	class Program
	{
		static void Main(string[] args)
		{
			var a = 1;
			string teste = "Josh";

			if(a == 1)
			{
				teste = "O valor de a";
			}
			else
			{
				teste = "Mais um";
			}
			Console.WriteLine("Olá Pessoal!" + 1);
		}
	}
}
*/

// 1.b. Operação if else if else simples  - Condicionais
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Op_Logicos_Condicionais
{
	class Program
	{
		static void Main()
		{
			int i = 20, j = 19;

			if (i > j)
			{
				Console.WriteLine("i é maior j");
			}
			else if (i < j)
			{
				Console.WriteLine("i é menor que j");
			}
			else
			{
				Console.WriteLine("i é igual a j");
			}
		}
		}
}
*/
//******************************************************************

// 2. Operação Switch - case  - Condicionais
/*
using System;

namespace _03_Op_Logicos_Condicionais
{
	class Program
	{
		static void Main(string[] args)
		{
			var a = 2;
			switch (a)
			{
				case 1:
					Console.WriteLine("Case 1");
					break;

				case 2:
					Console.WriteLine("Case 2");
					break;

				case 3:
					Console.WriteLine("Case 3");
					break;

			}

			
			Console.WriteLine("Olá Pessoal!");
			Console.Read();
		}
	}
}
*/
/*
 Case 2
Olá Pessoal!
 */

//*******************************************************************************

// 3. Operação Ternária (Faz o mesmo que a Operação If else simples - Condicionais
/*
using System;

namespace _03_Op_Logicos_Condicionais
{
	class Program
	{
		static void Main(string[] args)
		{
			var a = 1;
			string teste = (a == 1 ? "É o valor de a" : " O valor é maior que 1");
			Console.WriteLine("Olá pessoal! " + teste);
		}
	}
}
*/
// Olá pessoal! É o valor de a
// Se mudarmos o valor da variavel para 2, 3 ou outro numero qualquer 
//o Output será: Olá pessoal!  O valor é maior que 1

//****************************************************************************

// 4.a. Operação simples com 'NOT' '!' Lógica
/*
using System;

namespace _03_Op_Logicos_Condicionais
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = 3;

			if (!(a == 2))
			{

				Console.WriteLine("Olá Pessoal!");
			}
		}
	}
}
*/
//Olá Pessoal

//*************************************************************************

// 4.b. Operação simples com diferente '!='  Lógica
/*
using System;

namespace _03_Op_Logicos_Condicionais
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = 3;

			if (a !=2)
			{

				Console.WriteLine("Olá Pessoal!");
			}
		}
	}
}
// Olá Pessoal
*/

//*************************************************************************

// 4.c. Operação simples com && AND (E) e || OR (OU) Logica

using System;

namespace _03_Op_Logicos_Condicionais
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = 2; 
			//if (a == 2 && a == 3)   nada, pq a==3 não é igual a a=2

			if (a == 2 || a == 3);
			{
				Console.WriteLine("Olá ");
			}
		}
	}
}
// Olá Pessoal


