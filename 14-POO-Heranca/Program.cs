//**********************************************************************************************************************
// 13. Programação orientada a Objectos - Construtores (Continuação da aula anterior)
//**********************************************************************************************************************
//Nesta aula iremos aprender a utilização dos atributos e métodos públicos e privados, você verá na prática como 
//utilizá-lo e também iremos alterar a nossa aplicação console criando mais uma opção no menu.
//**********************************************************************************************************************

using Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tela;

namespace _14_POO_Heranca

{
	class Program
	{
		static void Main(string[] args)
		{
			//Menu.Criar();

			// Ler Clientes
			Console.WriteLine("====================== Cadastro de Cliente ============================");
			Cliente c = new Cliente();
			c.Nome = "Maria";
			c.Telefone = "926655440";
			c.CC = "178736529";
			c.Gravar();

			foreach (Cliente cl in Cliente.LerClientes())
			{
				Console.WriteLine(cl.Nome);
				Console.WriteLine(cl.Telefone);
				Console.WriteLine(cl.CC);
				Console.WriteLine("========================================================");
			}

			// Ler Usuarios
			Console.WriteLine("====================== Cadastro de Usuario ============================");
			Usuario u = new Usuario();  
			u.Nome = "Maria";
			u.Telefone = "926655440";
			u.CC = "178736529";
			u.Gravar();

			foreach(Usuario us in Usuario.LerUsuarios())
			{
				Console.WriteLine(us.Nome);
				Console.WriteLine(us.Telefone);
				Console.WriteLine(us.CC);
				Console.WriteLine("========================================================");
			}
		}
	}
}


