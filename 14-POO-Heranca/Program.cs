//**********************************************************************************************************************
// 14. Programação orientada a Objectos - Herança (Continuação da aula anterior)
//**********************************************************************************************************************
//Nesta aula iremos aprender como utilizar herança em uma classe, aproveitando assim os seus
//atributos públicos e os seus métodos públicos
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
			Console.WriteLine("================= Cadastro de Cliente ==================");
			Cliente c = new Cliente();
			c.Nome = "Chico";
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

			// Ler Usuarios
			Console.WriteLine("================ Cadastro de Usuario ===================");
			Usuario u = new Usuario();  
			u.Nome = "Joao";
			u.Telefone = "929955440";
			u.CC = "188736529";
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


