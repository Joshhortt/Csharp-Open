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
	{   
		// III - Criar uma Propriedade Complexa só de Leitura (Read-only). Tem porta de saida, mas não de entrada
		public int Idade;     // Nota: No public é recomenadvel usar PascalCase

		private int IdadePreDefinida = 2;    // 1. Criar Propriedade com um valor definido = 2;
											 // Nota: No private é recomenadvel usar camelCase
		public int Idade2 {     // 2. Criar Propriedade Idade2. so de leitura Get' e colocar o return dentro de outro bloco, retirar ';'
			get { 
				return IdadePreDefinida; 
			} }         
																
	
		public override void Latir()
		{
			Console.WriteLine("Au! Eu sou um cachorrinho");
		}
	}
}


// Vai imprimir para a Tela
//1
//2