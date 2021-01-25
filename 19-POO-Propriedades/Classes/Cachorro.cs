using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
	public class Cachorro : Animal
	{   // II - Criar uma Propriedade Complexa
		public int Idade;  // 1. Criar Propriedade Idade

		public int Idade2  { get; set; }          // 2. Criar Propriedade Idade2. com abertura do bloco de codigo
	
		public override void Latir()
		{
			Console.WriteLine("Au! Eu sou um cachorrinho");
		}
	}
}
