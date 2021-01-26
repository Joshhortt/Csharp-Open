
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
		public string NIF;    // 1. Adicionar atributo publico NIF
		public Fornecedor(string nome, string telefone, string cc, string nif)  // 2. Preencher o meu Construtor com nif'
		{
			this.Nome = nome;
			this.Telefone = telefone;
			this.CC = cc;
			this.NIF = nif;  // 3. Adicionar aqui tambem o novo atributo craido de NIF
		}
		public Fornecedor() { }


		// 6. Copiar o codigo base deo Gravar para aqui
		public override void Gravar()
		{
			var dados = this.Ler();
			dados.Add(this);

			StreamWriter r = new StreamWriter(DiretorioComArquivo());
			//string conteudo = "nome;telefone;cc;";
			r.WriteLine("nome;telefone;cc;nif;");   // 7. Adicionar nif
			foreach (Fornecedor b in dados)   // 8. Mudar a classe Base para Fornecedor
			{
				var linha = b.Nome + ";" + b.Telefone + ";" + b.CC + ";" + b.NIF + ";";  // 9. Adicionar NIF
				r.WriteLine(linha);
			}
			r.Close();
		}

		// 10. Copiar o codigo base de Ler para aqui e adicional um 'override'
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

						var b = (Fornecedor)Activator.CreateInstance(this.GetType());   // 11. Mudar IPessoa por Fornecedor

						b.SetNome(baseArquivo[0]);
						b.SetTelefone(baseArquivo[1]);
						b.SetCC(baseArquivo[2]);
						b.NIF = baseArquivo[3];  // 12. Adicionar outro item NIF

						dados.Add(b);
					}
				}
			}

			return dados;
		}
	}
}


