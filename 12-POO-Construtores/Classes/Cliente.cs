using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
	public class Cliente
	{   
		/*
		/// <summary>
		/// Construtor da classe. O Construtor - metodo com o mesmo nome da classe.
		/// </summary>
		/// <param name="nome">Para preencher o nome do objeto</param>
		public Cliente(string nome)   		  
		{
			this.Nome = nome;  
		}

		/// <summary>
		/// Criar Construtor para telefone com parametro 'int'. Se fosse string o programa nao iria compilar.
		/// <param name="telefone">telefone inteiro</param>
		public Cliente(int telefone)
		{
			this.Telefone = telefone.ToString();
		}

		/// <summary>
		/// Construtor sem parametros
		/// </summary>
		public Cliente()  { }
		*/
		public static string Teste;
		public string Nome;
		public string Telefone;
		public string CC;

		public void Gravar()
		{
			// TODO Implementar
		}
		private static string caminhoBaseClientes()
		{
			return ConfigurationManager.AppSettings["BaseDeClientes"];
		}


		public static List<Cliente> LerClientes()
		{
			var clientes = new List<Cliente>();

			if (File.Exists(caminhoBaseClientes()))
			{
				using (StreamReader arquivo = File.OpenText(caminhoBaseClientes()))
				{
					string linha;
					int i = 0;
					while ((linha = arquivo.ReadLine()) != null)
					{
						i++;
						if (i == 1) continue;

						var clienteArquivo = linha.Split(';');
						var cliente = new Cliente();

						cliente.Nome = clienteArquivo[0];
						cliente.Telefone = clienteArquivo[1];
						cliente.CC = clienteArquivo[2];

						clientes.Add(cliente);
					}
				}
			}

				return clientes;
		}
	}
}

