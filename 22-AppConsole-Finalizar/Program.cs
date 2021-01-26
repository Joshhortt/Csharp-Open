//**********************************************************************************************************************
//22. Programação orientada a Objectos - Finalizar Aplicação Console (Continuação das aulas anteriores)
//**********************************************************************************************************************
// Nesta aula iremos finalizar a aplicação console que iniciamos no inicio de nossas aulas de C#, 
// criando de uma forma muito fácil um cadastro de cliente e fornecedores.
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

namespace _22_AppConsole_Finalizar
{
	class Program
	{
		static void Main(string[] args)
		{

			Menu.Criar();
		}
	}
}

#region Codigos Teste das aulas anteriores em relação a Programação orientada a objetos.
/* #########################################################
Email.Instancia.Origem = "joshhortt@rocketmail.com";
Email.Instancia.Destino = "joshhortt@yahoo.com";
Email.Instancia.Titulo = "Meeting hoje as 19 horas";
Email.Instancia.Corpo = "Lorem ipsum";
Email.Instancia.EnviarEmail();

OUTPUT
Enviando Email para: joshhortt@yahoo.com
Com o titulo: Meeting hoje as 19 horas
Corpo: Lorem ipsum
############################################################ */


/* #########################################################
var c = new Cachorro();
c.Idade = 1;
Console.WriteLine(c.Idade);

c.Idade2 = 1;

Console.WriteLine(c.Idade2);

c.SetIdade2(2);
c.GetIdade2();

var cachorro = new Classes.Cachorro();

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
############################################################ */


/* #########################################################
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
}
############################################################ */

#endregion
