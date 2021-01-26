//**********************************************************************************************************************
//21. Programação orientada a Objectos - Classe Singleton (Continuação da aula anterior)
//**********************************************************************************************************************
//Nesta aula iremos aprender o que é uma classe singleton, como criar e utilizar esta classe em C#.
//**********************************************************************************************************************
using Classes;
using Componentes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tela;

namespace _21_POO_Singleton
{
	class Program
	{
		static void Main(string[] args)
		{

			// Email e = new Email();
		}
	}
}

/*
var c = new Cachorro();
c.Idade = 1;
Console.WriteLine(c.Idade);

c.Idade2 = 1;

Console.WriteLine(c.Idade2);

c.SetIdade2(2);
c.GetIdade2();

var cachorro = new Classes.Cachorro();

//Menu.Criar();

Console.WriteLine("================= Cadastro de Cliente ==================");
Cliente c = new Cliente();
c.Nome = "Cliente";
c.Telefone = "100-200-300";
c.CC = "400500600";
c.Gravar();
foreach (Cliente cl in new Cliente().Ler())
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
foreach (Usuario us in new Usuario().Ler())
{
	Console.WriteLine(us.Nome);
	Console.WriteLine(us.Telefone);
	Console.WriteLine(us.CC);
	Console.WriteLine("========================================================");
}

*/


/*
	public string Teste;
	public string Teste2()

	{
		return "";
	}
}

class Macaco : Animal
{  
	public new string Teste2()
	{
		return "sss";
	}
}

partial class Animal  
{
	public string teste;  
	partial void tt();   
}

partial class Animal 
{
	public string teste2; 
	partial void tt()  
	{
		Console.WriteLine("teste");
	}
} */


