using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
	public class Email   // 1. classe sem Instancias
	{
		private Email() { }      // 2. Construtor

		private static Email instancia;// 3. atributo privado static somente uma instancia
		
		public static Email Instancia  // 4. criar uma propriedade com retorno E mail chamado Instancia publica
		{
			get
			{
				if (instancia == null)  // 5. Get com instancia Unica e nula
				{
					instancia = new Email();  // 6. preciso de criar a minha instancia. Como estou dentro da classe posso criar a minha instancia
				}
				return instancia;   // 7. Dar um retorno da minha instancia
			} 	
		}
	}
}
