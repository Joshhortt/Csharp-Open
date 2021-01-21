using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
	public class Base : Pessoa
	{
		// Todo o código refatorado aqui
		public Base(string nome, string telefone, string cc)  
		{
			this.Nome = nome;
			this.Telefone = telefone;
			this.CC = cc;
		}

		public Base()  
		{

		}

		public string Nome;
		public string Telefone;
		public string CC;

		private string Sobrenome = "Santos";

		public virtual void Gravar()

		{
			// var dados = new Base().Ler();   substituir o new Base() por this.
			var dados = this.Ler();
			dados.Add(this);

			/*if (File.Exists(DiretorioComArquivo()))  ja não é preciso aqui o if
			{*/
					StreamWriter r = new StreamWriter(DiretorioComArquivo());   
					string conteudo = "nome;telefone;cc;";
					r.WriteLine(conteudo);
					foreach (Base b in dados)  
					{
						var linha = b.Nome + ";" + b.Telefone + ";" + b.CC + ";";  
						r.WriteLine(linha);
					}
					r.Close();
			
		}

		public List<Base> Ler() 
		{
			var dados = new List<Base>();   

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

						var cliente = new Base(baseArquivo[0], baseArquivo[1], baseArquivo[2]);  

						dados.Add(cliente); 
					}
				}
			}

			return dados;  
		}

		private string DiretorioComArquivo()  
		{
			return ConfigurationManager.AppSettings["CaminhoArquivos"] + this.GetType().Name + ".txt"; 
		}

		public virtual void Olhar()
		{
			Console.WriteLine("O cliente " + this.Nome + " " + this.Sobrenome + " está olhando para mim.");
			Console.WriteLine("===================================================");
		}

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
	}
}
