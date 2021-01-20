using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
	public class Usuario : Cliente  
	{
		public Usuario(string nome, string telefone, string cc)  
		{
			this.Nome = nome;
			this.Telefone = telefone;
			this.CC = cc;
		}
		public Usuario() { }

		private static string caminhoBase()  
		{
			return ConfigurationManager.AppSettings["BaseDeClientes"];
		}

		public void Gravar() 
				{
			var usuario = Usuario.LerUsuarios();
			Usuario u = new Usuario(this.Nome, this.Telefone, this.CC);
			usuario.Add(u);
			if (File.Exists(caminhoBase()))  
			{
				StreamWriter r = new StreamWriter(caminhoBase());  
				string conteudo = "nome;telefone;cc;";
				r.WriteLine(conteudo);
				foreach (Usuario c in usuario)
				{
					var linha = c.Nome + ";" + c.Telefone + ";" + c.CC + ";";
					r.WriteLine(linha);
				}
				r.Close();
			}
		}
		public static List<Usuario> LerUsuarios()
		{
			var usuarios = new List<Usuario>();

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
						var usuarioArquivo = linha.Split(';');

						var usuario = new Usuario(usuarioArquivo[0], usuarioArquivo[1], usuarioArquivo[2]);

						usuarios.Add(usuario);
					}
				}
			}

			return usuarios;
		}
	}
}
