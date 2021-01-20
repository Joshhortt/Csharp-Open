﻿using System;
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
		public Cliente()  { }
		
		public static string Teste;
		public string Nome;
		public string Telefone;
		public string CC;

		private string Sobrenome = "Santos";

		public virtual void Gravar() // Ao incluir o 'virtual'no metodo Cliente (Pai) em vez de 'new' no metodo Usuario (filho) ele força sub escrever, 
									// permitindo o programador nao advinhar o nome do metodo, assim aparecendo disponivel nas opções, 
									// tornando mais facil ao Programador editar esse mesmo codigo.
		{
				var clientes = Cliente.LerClientes();
				clientes.Add(this);
				if (File.Exists(caminhoBase()))
				{
					StreamWriter r = new StreamWriter(caminhoBase());
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

		private void Olhar() 
		{
			Console.WriteLine("O cliente " + this.Nome + " " + this.Sobrenome + " está olhando para mim.");
			Console.WriteLine("===================================================");
		}

		private static string caminhoBaseUsuarios()
		{
			return ConfigurationManager.AppSettings["BaseDeUsuarios"];
		}

		public static List<Cliente> LerClientes()
		{
			var clientes = new List<Cliente>();

			if (File.Exists(caminhoBase()))
			{
				using (StreamReader arquivo = File.OpenText(caminhoBase()))
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

	  	private static string caminhoBase()
		{
			throw new NotImplementedException();
		}
	}
}

