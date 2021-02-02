using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWinforms
{
	public class Estado
	{
		public int Id { get; set; }     // Alterar o atributo para propriedade
		public string Nome { get; set; }  // Alterar o atributo para propriedade 

		public override string ToString()  
		{
			return this.Nome; 
		}

		public static List<Estado> Lista()  
		{
			var lista = new List<Estado>();
			var est1 = new Estado();
			est1.Id = 1;
			est1.Nome = "SP";

			lista.Add(est1);

			est1 = new Estado();
			est1.Id = 2;
			est1.Nome = "RJ";
			lista.Add(est1);

			est1 = new Estado();
			est1.Id = 3;
			est1.Nome = "MG";
			lista.Add(est1);

			est1 = new Estado();
			est1.Id = 4;
			est1.Nome = "GO";
			lista.Add(est1);

			return lista;
		}
	}
}
