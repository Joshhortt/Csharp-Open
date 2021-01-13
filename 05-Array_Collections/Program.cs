
//******************************************************************************
/* 05. Arrays e Collections.
********************************************************************************
Nesta aula você irá aprender como o C# trabalha com Arrays e Collections, 
verá como instanciar as variáveis e colocar valores dentro delas..
 */
//******************************************************************************

// ARRAYS
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Array_Collections
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] a = new string[3];
			a[0] = "Manuel";
			a[1] = "Maria";
			a[2] = "Manuela";

			Array.Sort(a); // aqui é ordenado o array ascendente

			foreach (string nome in a)
			{
				Console.WriteLine(nome);
			}
			Console.Read();
		}
	}
}
*/
/*
Manuel
Maria
Manuela
 */

// com a linha de codigo Array.Sort(a); ele imprime o array ordenado ascendente:
/*
Manuel
Manuela
Maria

mais Examplos de: Array Methods
int[] nums = new int[5]{ 10, 15, 16, 8, 6 };

Array.Sort(nums); // sorts array 
Array.Reverse(nums); // sorts array in descending order
Array.ForEach(nums, n => Console.WriteLine(n)); // iterates array
Array.BinarySearch(nums, 5);// binary search 
*/

//***************************************************************
// COLLECTIONS
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Array_Collections
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> primeNums = new List<int>();
			primeNums.Add(1); // adicinoar elementos add() metodo.
			primeNums.Add(3); // posição 1 do array
			primeNums.Add(5);
			primeNums.Add(7);

			Console.WriteLine(primeNums[1]);

			Console.Read();
		}
	}
}
*/
// 3  (está na posiçao 1 do array)

// Outro exemplo
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Array_Collections
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> a = new List<string>();
			a.Add("João"); // adicinoar elementos add() metodo.
			a.Add("Maria");
			a.Add("Franz"); // posição 2 do array
			a.Add("Soraia");

			Console.WriteLine(a[2]);

			Console.Read();
		}
	}
}

// Franz ( que está na posição 2 do array)
*/

// Outro exemplo com o foreach' usando o .Add();
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Array_Collections
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> a = new List<string>();
			a.Add("João"); // adicinoar elementos add() metodo.
			a.Add("Maria");
			a.Add("Franz"); // posição 2 do array
			a.Add("Soraia");

			foreach(string nome in a)
			{
				Console.WriteLine(nome);
			}

			Console.Read();
		}
	}
}
*/
/*
João
Maria
Franz
Soraia
 */

// Outro exemplo mostrando array ne collection list.
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Array_Collections
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] aUm = new string[3];
			aUm[0] = "Manuel";
			aUm[1] = "Maria";
			aUm[2] = "Manuela";


			List<string> a = new List<string>();
			a.Add("João"); 
			a.Add("Maria");
			a.Add("Franz"); 
			a.Add("Soraia");

			foreach(string nome in a)
			{
				Console.WriteLine(nome);
			}

			if(a.Exists(encontrei => encontrei == "Franz"))
			{
				Console.WriteLine("Encontrei o Franz dentro da minha collection list.");
			}
			int size_list = a.Count;

			Console.Read();
		}
	}
}
*/
/*
João
Maria
Franz
Soraia
Encontrei o Franz dentro da minha collection list.

 */
/*Adicionar uma Array a uma Lista
Useo método AddRange () para adicionar todos os elementos de uma matriz ou outra coleção a List.
Assinatura AddRange (): void AddRange (coleção IEnumerable <T>) 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Array_Collections
{
	class Program
	{
		static void Main(string[] args)
		{
			IList<int> intList1 = new List<int>();
			intList1.Add(10);
			intList1.Add(20);
			intList1.Add(30);
			intList1.Add(40);

			List<int> intList2 = new List<int>();

			intList2.AddRange(intList1);


			Console.WriteLine(intList2.Count);

		}
	}
}
*/
// 4