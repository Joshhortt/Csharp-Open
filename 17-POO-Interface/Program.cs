//**********************************************************************************************************************
// 17. Programação orientada a Objectos - Interface (Continuação da aula anterior)
//**********************************************************************************************************************
//Nesta aula iremos aprender como utilizar uma interface, veremos que utilizando a interface iremos conseguir fazer 
//coisas muito mais poderosas utilizando muito pouco código.
//**********************************************************************************************************************
using Classes;
using Componentes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tela;

namespace _17_POO_Interface

{
	class Program
	{
		static void Main(string[] args)
		{
			//Menu.Criar();
			
			Console.WriteLine("================= Cadastro de Cliente ==================");
			Cliente c = new Cliente();
			c.Nome = "ClienteNOVO";
			c.Telefone = "926600040";
			c.CC = "236936529";
			c.Gravar();

			//foreach (Cliente cl in Cliente.LerClientes())
				foreach (Cliente cl in new Cliente().Ler())
				{
				Console.WriteLine(cl.Nome);
				Console.WriteLine(cl.Telefone);
				Console.WriteLine(cl.CC);
				Console.WriteLine("========================================================");
			}
			
			/*
			Ferramentas f = new Ferramentas();  
			f.MetodoParaTodosQueUtilizarOAssembly();  
			bool d = f.ValidarCC("123456789");   

			Cliente c = new Cliente();
			// c.CalcularUmMaisDois3();
			c.CalcularUmMaisDois4();  

			Console.WriteLine("================ Cadastro de Usuario ===================");
			Usuario u = new Usuario();  
			u.Nome = "Usuario";
			u.Telefone = "929955440";
			u.CC = "188736529";
			//u.Gravar();
			u.Olhar();  
			*/
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


