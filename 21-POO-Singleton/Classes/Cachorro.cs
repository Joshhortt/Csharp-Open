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
		
		public int GetIdade2()   
		{
			return IdadePreDefinida;
		}

		public void SetIdade2(int idade2)   
		{
			IdadePreDefinida = Idade2;
		}


		public override void Latir()
		{
			Console.WriteLine("Au! Eu sou um cachorrinho");
		}
	}
}
