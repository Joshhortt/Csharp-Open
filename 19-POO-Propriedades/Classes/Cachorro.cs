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
		
		public int Idade;    

		private int IdadePreDefinida = 2;    
											 
		public int Idade2 {     
			get { 
				return IdadePreDefinida; 
			} 
			set      
			{
				IdadePreDefinida = value;    
			}
		}
		// V - Implementar uma forma usual em outras linguagens (getters e setters). Com 2 metodos. Tambem podemos usar no C#
		public int GetIdade2()    // 1. Implmentar Get como Getter, usual noutras linguagens.
		{
			return IdadePreDefinida;
		}

		public void SetIdade2(int idade2)   // 2. Implmentar Set como Setter, usual noutras linguagens.
		{
			IdadePreDefinida = Idade2;
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