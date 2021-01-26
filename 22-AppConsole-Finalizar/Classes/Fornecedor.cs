
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
	public class Fornecedor : Base
	{
		public string NIF;   
		public Fornecedor(string nome, string telefone, string cc, string nif)  
		{
			this.Nome = nome;
			this.Telefone = telefone;
			this.CC = cc;
			this.NIF = nif;  
		}
		public Fornecedor() { }
		public override void Gravar()
		{
			var dados = this.Ler();
			dados.Add(this);

			StreamWriter r = new StreamWriter(DiretorioComArquivo());
			r.WriteLine("nome;telefone;cc;nif;");   
			foreach (Fornecedor b in dados)   
			{
				var linha = b.Nome + ";" + b.Telefone + ";" + b.CC + ";" + b.NIF + ";";  
				r.WriteLine(linha);
			}
			r.Close();
		}

		public override List<IPessoa> Ler()
		{
			var dados = new List<IPessoa>();

			if (File.Exists(DiretorioComArquivo()))
			{
				using (StreamReader arquivo = File.OpenText(DiretorioComArquivo()))
				{
					string linha;
					int i = 0;
					while ((linha = arquivo.ReadLine()) != null)
					{
						i++;
						if (i == 1) continue;
						var baseArquivo = linha.Split(';');

						var b = (Fornecedor)Activator.CreateInstance(this.GetType());   

						b.SetNome(baseArquivo[0]);
						b.SetTelefone(baseArquivo[1]);
						b.SetCC(baseArquivo[2]);
						b.NIF = baseArquivo[3]; 

						dados.Add(b);
					}
				}
			}

			return dados;
		}
	}
}


