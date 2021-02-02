using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWinforms
{
	public class Estado
	{
		public int Id;     // atributo Id do tipo int
		public string Nome;   // atributo Nome do tipo string

		public override string ToString()  // override de APPWinforms Estado (fazendo com que nao apareça na textBox
		{
			return this.Nome; // retorna o Nome do Estado 
		}

		public static List<Estado> Lista()  // Criar Lista de Estados com numero Id e Nome
		{
			// SP
			var lista = new List<Estado>();
			var est1 = new Estado();
			est1.Id = 1;
			est1.Nome = "SP";

			var s = est1.ToString();

			lista.Add(est1);

			// RJ
			est1 = new Estado();
			est1.Id = 2;
			est1.Nome = "RJ";
			lista.Add(est1);

			// MG
			est1 = new Estado();
			est1.Id = 3;
			est1.Nome = "MG";
			lista.Add(est1);

			//GO
			est1 = new Estado();
			est1.Id = 4;
			est1.Nome = "GO";
			lista.Add(est1);

			return lista;
		}
	}
}
