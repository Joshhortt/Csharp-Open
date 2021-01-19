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
			Menu.Criar();

			Usuario u = new Usuario();  // Criar ba nova classe usuario
			u.Nome = "sss";
			u.Telefone = "zzz";
			u.CC = "yyy";
			u.Gravar();
			//Usuario.LerClientes();
		}
	}
}


