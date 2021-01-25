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
	{   // I - Criar uma Propriedade Simples ou Atributo
		public int Idade;  // 1. Criar Propriedade Idade
		public override void Latir()
		{
			Console.WriteLine("Au! Eu sou um cachorrinho");
		}
	}
}
