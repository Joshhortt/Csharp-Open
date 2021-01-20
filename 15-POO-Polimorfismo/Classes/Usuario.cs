using System;
using System.Collections.Generic;
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

		public void Gravar() 
				{
			var usuario = Usuario.LerUsuarios();
			Usuario u = new Usuario(this.Nome, this.Telefone, this.CC);
			usuario.Add(u);
			if (File.Exists(caminhoBaseUsuarios()))
			{
				StreamWriter r = new StreamWriter(caminhoBaseUsuarios());
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
	}
}
