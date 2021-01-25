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
		// IV - Implementar uma Propriedade Complexa com blocos de codigo
		public int Idade;    

		private int IdadePreDefinida = 2;    
											 
		public int Idade2 {     
			get { 
				return IdadePreDefinida; 
			} 
			set       // 2. Implementar o Set'
			{
				IdadePreDefinida = value;      // 3. é o novo valor setado dentro dessa variavel
			}
		}         
																
	
		public override void Latir()
		{
			Console.WriteLine("Au! Eu sou um cachorrinho");
		}
	}
}


// Vai imprimir para a Tela
//1
//1