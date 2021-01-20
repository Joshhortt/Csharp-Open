//**********************************************************************************************************************
// 15. Programação orientada a Objectos - Polimorfismo (Continuação da aula anterior)
//**********************************************************************************************************************
//Nesta aula iremos aprender um pouco mais sobre orientação a objetos, falando sobre polimorfismo, 
//iremos alterar e separar a nossa aplicação console refatorando o nosso código deixando o mais simples.
//**********************************************************************************************************************
using Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tela;

namespace _15_POO_Polimorfismo

{
	class Program
	{
		static void Main(string[] args)
		{
			//Menu.Criar();
			/*
			Console.WriteLine("================= Cadastro de Cliente ==================");
			Cliente c = new Cliente();
			c.Nome = "Cliente";
			c.Telefone = "926600040";
			c.CC = "236936529";
			c.Gravar();

			foreach (Cliente cl in Cliente.LerClientes())
			{
				Console.WriteLine(cl.Nome);
				Console.WriteLine(cl.Telefone);
				Console.WriteLine(cl.CC);
				Console.WriteLine("========================================================");
			}
			*/
			// Ler Usuarios
			Console.WriteLine("================ Cadastro de Usuario ===================");
			Usuario u = new Usuario();  
			u.Nome = "Usuario";
			u.Telefone = "929955440";
			u.CC = "188736529";
			//u.Gravar();
			u.Olhar();  // Testar o Usuario
			/*
			foreach (Usuario us in Usuario.LerUsuarios())
			{
				Console.WriteLine(us.Nome);
				Console.WriteLine(us.Telefone);
				Console.WriteLine(us.CC);
				Console.WriteLine("========================================================");
			} */
		}
	}
}


