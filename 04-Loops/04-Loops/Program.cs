//******************************************************************************
/* 04. Loops (while, do while, for, foreach e ainda Função recursivas.
********************************************************************************
Nesta aula você verá os principais comandos para utilização dos loops em C#, 
comandos como (while, do;while, for, foreach) e verá que é possível fazer loop 
com funções recursivas.
 */
//******************************************************************************

// Exemplo ´while' Loop
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
	class Program
	{
		static void Main(string[] args)
		{
			int i = 0; // initialization

			while (i < 10) // condition
			{
				Console.WriteLine("i = {0}", i);

				i++; // increment
			}
		}
	}
}

i = 0
i = 1
i = 2
i = 3
i = 4
i = 5
i = 6
i = 7
i = 8
i = 9
*/
//********************************************
// Outro Exemplo 'while' Loop
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = 1; // initialization

			while (a < 3) // condition
			{
				Console.WriteLine(a);

				a++; // increment, sem esta linha de codigo torna-se um loop infinito
			}
		}
	}
}

1
2
*/

//***********************************************
// Outro Exemplo 'while' Loop com 'continue'.
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = 1; // initialization

			while (a <= 5) // condition
			{
				if(a==1)
				{
					a++;
					continue;
				}
				Console.WriteLine(a);

				a++; // increment, sem esta linha de codigo torna-se um loop infinito
			}
		}
	}
}

2
3
4
5
 */

//*************************************************
// Outro Exemplo 'while' Loop com 'break'.
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = 1; // initialization

			while (a <= 10) // condition
			{
				if(a==3)
				{
					//a++;   aqui podemos tirar esse a++ que funciona da mesma forma.
					break;
				}
				Console.WriteLine(a);

				a++; // increment, sem esta linha de codigo torna-se um loop infinito
			}
		}
	}
}


1
2
 */


//********************************
// Exemplo 'do while' Loop 
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = 1; // initialization
			do
			{
				if (a == 3)
				{
					break;
				}
				Console.WriteLine(a);
				a++;
			}

			while (a <= 10); // condition while fica em baixo
			
		}
	}
}
*/
/*
1
2
*/


//****************************************************
// Outro Exemplo 'do while' Loop parecido ao de acima
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = 1; // initialization
			do
			{
				
				Console.WriteLine(a);
				a++;
			}

			while (a < 3); // condition while fica em baixo

		}
	}
}
*/
/*
1
2
*/

//********************************************
// Exemplo 'for' Loop.
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
	class Program
	{
		static void Main(string[] args)
		{
			for(int a = 1; a < 3; a++)
			{
				Console.WriteLine(a);
			}
		}
	}
}
*/
/*
1
2
*/


//***************************************************
// Exemplo 'foreach' Loop. (e comparação com for')
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] a = { 1, 2, 3 };
			foreach(int valor in a)
			{
				Console.WriteLine(valor);
			}

			// tambem podemos fazer em vez do foreach' com for', mas para arrays é mais simples usar o foreach'.
			for (int i = 0; i < a.Length; i++)
			{
				Console.WriteLine(a[i]);
			}
		}
	}
}
*/
/*
1
2
3
1 // apartir daqui é o for' loop.
2
3
*/



//*******************************************
// Exemplo Função Recursiva (introdução)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
	class Program
	{
		static void Main(string[] args)
		{
			ping(1);
		}

		public static void ping(int a)
		{
			Console.WriteLine(a);
			if(a < 3)
			{
				ping(a + 1);
			}	
		}
	}
}
/*
1
2
3
*/