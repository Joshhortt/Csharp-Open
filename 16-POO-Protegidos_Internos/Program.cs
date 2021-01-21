//**********************************************************************************************************************
// 16. Programação orientada a Objectos - Protegidos e Internos (Continuação da aula anterior)
//**********************************************************************************************************************
//Nesta aula iremos aprender para que serve os métodos protegidos e internos de uma classe, iremos aprender 
//também o que é uma DLL e o que uma DLL tem a ver com métodos internos. Veremos também o que é um assembly.
//**********************************************************************************************************************
using Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tela;

namespace _16_POO_Protegidos_Internos

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
			Cliente c = new Cliente();
			// c.CalcularUmMaisDois3();
			c.CalcularUmMaisDois4();  // 4. Consegue acessar o metodo ..4();
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


