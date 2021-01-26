
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

		public override void Gravar()
		{
			var dados = this.Ler();
			dados.Add(this);

			// 5. Copiar o codigo base deo Gravar para aqui
			StreamWriter r = new StreamWriter(DiretorioComArquivo());
			//string conteudo = "nome;telefone;cc;";
			r.WriteLine("nome;telefone;cc;nif;"); // 6. Adicionar nif
			foreach (Fornecedor b in dados)      // 8. Mudar a classe Base para Fornecedor
			{
				var linha = b.Nome + ";" + b.Telefone + ";" + b.CC + ";" + b.NIF + ";";  // 7. Adicionar NIF
				r.WriteLine(linha);
			}
			r.Close();
		}
	}

}
