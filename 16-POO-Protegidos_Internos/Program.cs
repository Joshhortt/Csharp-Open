//**********************************************************************************************************************
// 16. Programação orientada a Objectos - Protegidos e Internos (Continuação da aula anterior)
//**********************************************************************************************************************
//Nesta aula iremos aprender para que serve os métodos protegidos e internos de uma classe, iremos aprender 
//também o que é uma DLL e o que uma DLL tem a ver com métodos internos. Veremos também o que é um assembly.
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

			Ferramentas f = new Ferramentas();  // 2. criado nova instancia Ferramentas();
			f.MetodoParaTodosQueUtilizarOAssembly();  // 3. é possivel acessar o metodo publico mas não o internal criado anteriormente.
			bool d = f.ValidarCC("123456789");   // 4. é possivel acessar o metodo bool mas não o internal criado anteriormente.

			// 5. Nota de que agora Se forem ao diretorio Componentes, dentro de bin/Debug ja encontram uma dll que podem enviar a outros para partilhar
			// por E-mail por exemplo. o ficheiro Componentes.dll -->  C:\Users\josec\Source\Repos\Csharp-Open\16-POO-Protegidos_Internos\Componentes\bin\Debug

			Cliente c = new Cliente();
			// c.CalcularUmMaisDois3();
			c.CalcularUmMaisDois4();  

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


