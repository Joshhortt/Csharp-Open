using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
	public abstract class Base : IPessoa
	{
		public Base(string nome, string telefone, string cc)
		{
			this.Nome = nome;
			this.Telefone = telefone;
			this.CC = cc;
		}

		public Base() { }

		public string Nome;
		public string Telefone;
		public string CC;
		public string NIF;

		public void SetNome(string nome) { this.Nome = nome; }
		public void SetTelefone(string telefone) { this.Telefone = telefone; }
		public void SetCC(string cc) { this.CC = cc; }


		private string Sobrenome = "Santos";

		public virtual void Gravar()
		{
			var dados = this.Ler();
			dados.Add(this);

			StreamWriter r = new StreamWriter(DiretorioComArquivo());
			r.WriteLine("nome;telefone;cc;");
			foreach (Base b in dados)
			{
				var linha = b.Nome + ";" + b.Telefone + ";" + b.CC + ";";
				r.WriteLine(linha);
			}
			r.Close();
		}

		public virtual List<IPessoa> Ler()
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

						var b = (IPessoa)Activator.CreateInstance(this.GetType());

						b.SetNome(baseArquivo[0]);
						b.SetTelefone(baseArquivo[1]);
						b.SetCC(baseArquivo[2]);

						dados.Add(b);
					}
				}
			}

			return dados;
		}

		public string DiretorioComArquivo()
		{
			return ConfigurationManager.AppSettings["CaminhoArquivos"] + this.GetType().Name + ".txt";
		}

		public virtual void Olhar()
		{
			Console.WriteLine("O cliente " + this.Nome + " " + this.Sobrenome + " está olhando para mim.");
			Console.WriteLine("===================================================");
		}
	}
}
		#region Codigos Teste das aulas anteriores em relação a Programação orientada a objetos.
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
#endregion