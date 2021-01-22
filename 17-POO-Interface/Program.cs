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
			c.Nome = "Cliente";
			c.Telefone = "100-200-300";
			c.CC = "400500600";
			c.Gravar();
				foreach (Cliente cl in new Cliente().Ler())   // Para melhor implementação da Leitura do Cliente, alterar Base para 'Cliente'
			{
				Console.WriteLine(cl.Nome);
				Console.WriteLine(cl.Telefone);
				Console.WriteLine(cl.CC);
				Console.WriteLine("========================================================");
			}

			Console.WriteLine("================ Cadastro de Usuario ===================");
			Usuario u = new Usuario();
			u.Nome = "Usuario";
			u.Telefone = "500-600-700";
			u.CC = "800900000";
			u.Gravar();
			foreach (Usuario us in new Usuario().Ler())  // Para melhor implementação da Leitura do Usuario, alterar Base para 'Usuario'
			{
				Console.WriteLine(us.Nome);
				Console.WriteLine(us.Telefone);
				Console.WriteLine(us.CC);
				Console.WriteLine("========================================================");
			}
		}
	}
}


