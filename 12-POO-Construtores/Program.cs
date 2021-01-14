//**********************************************************************************************************************
// 11. Programação orientada a Objectos - Classes e Instâncias (Continuação da aula anterior)
//**********************************************************************************************************************
//Nesta aula você irá entender o que é uma classe em C#, iremos organizar os arquivos de configuração no ficheiro 
//'App.config' e iremos ver as diferenças entre métodos estáticos e de instâncias. Continuação de REFACTORAR o código.
//**********************************************************************************************************************

using Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tela;

namespace _12_POO_Construtores

{
	class Program
	{
		static void Main(string[] args)
		{
			// Menu.Criar();

			var clientes = Cliente.LerClientes();

			// Sempre que criamos algo static' é sempre para varias pessoas do modelo, não é para um só.
			
			var cliente = new Cliente();
			cliente.Nome = "Jose";
			cliente.Telefone = "911815877";
			cliente.CC = "9690543";
			cliente.Gravar();

			Cliente c = new Cliente();
			
			var cliente2 = new Cliente();
			cliente2.Nome = "Rita";
			cliente2.Telefone = "911815878";
			cliente2.CC = "9690544";
			cliente2.Gravar();
			
		}
	}
}


