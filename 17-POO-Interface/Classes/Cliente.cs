using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
	   //public class Cliente : Pessoa   refatorado para Cliente : Base
		public class Cliente : Base
	{
		/// <summary>
		/// construtor com 3 parametros
		/// </summary>
		/// <param name="nome"></param>
		/// <param name="telefone"></param>
		/// <param name="cc"></param>
		public Cliente(string nome, string telefone, string cc)
		{
			this.Nome = nome;
			this.Telefone = telefone;
			this.CC = cc;
		}

		/// <summary>
		/// Criar Construtor para telefone com parametro 'int'. 
		/// <param name="telefone">telefone inteiro</param>
		public Cliente(int telefone)
		{
			this.Telefone = telefone.ToString();
		}

		/// <summary>
		/// Construtor sem parametros
		/// </summary>
		public Cliente() { }

		public static string Teste;

		//public string Nome;
		//public string Telefone;
		//public string CC;

		// private string Sobrenome = "Santos";

		/*
		protected int CalcularUmMaisDois()  
		{
			return 1 + 2;
		}

		private int CalcularUmMaisDois2()  
		{
			return 1 + 2;
		}

		public int CalcularUmMaisDois3()  
		{
			return 1 + 2;
		}

		internal int CalcularUmMaisDois4()  
		{
			return 1 + 2;
		}
		*/

		//Este Bloco de Codigo do metodo Gravar() deve ser copiado para Base.cs
		
		  public virtual void Gravar()

		{
			var clientes = Cliente.LerClientes();
			clientes.Add(this);
			if (File.Exists(CaminhoBase()))
			{
				StreamWriter r = new StreamWriter(CaminhoBase());
				string conteudo = "nome;telefone;cc;";
				r.WriteLine(conteudo);
				foreach (Cliente c in clientes)
				{
					var linha = c.Nome + ";" + c.Telefone + ";" + c.CC + ";";
					r.WriteLine(linha);
				}
				r.Close();
			}
		}
		/*
		public virtual void Olhar()
		{
			Console.WriteLine("O cliente " + this.Nome + " " + this.Sobrenome + " está olhando para mim.");
			Console.WriteLine("===================================================");
		}
		*/

		//Este Bloco de Codigo do metodo CaminhoBase() deve ser copiado para Base.cs
		private static string CaminhoBase()
		{
			return ConfigurationManager.AppSettings["BaseDeClientes"];
		}

		//Este Bloco de Codigo do metodo CaminhoBase() deve ser copiado para Base.cs
		public static List<Cliente> LerClientes()
		{
			var clientes = new List<Cliente>();

			if (File.Exists(CaminhoBase()))
			{
				using (StreamReader arquivo = File.OpenText(CaminhoBase()))
				{
					string linha;
					int i = 0;
					while ((linha = arquivo.ReadLine()) != null)
					{
						i++;
						if (i == 1) continue;
						var clienteArquivo = linha.Split(';');

						var cliente = new Cliente(clienteArquivo[0], clienteArquivo[1], clienteArquivo[2]);

						clientes.Add(cliente);
					}
				}
			}

			return clientes;
		}	
	}
}
