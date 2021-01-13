using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funções
{
	class Tabuada
	{
		public static void Calcular (int numero)
		{
			Console.WriteLine("=================== Calculo da Tabuada de " + numero + " =======================");
			for (int i = 1; i <= 10; i++)
			{
				Console.WriteLine(numero + "x" + "=" + (numero * i));
			}
		}
	}
}
