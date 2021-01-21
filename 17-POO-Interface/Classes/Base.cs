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

		public Base(string nome, string telefone, string cc)  // Criado Construtor Base
		{
			this.Nome = nome;
			this.Telefone = telefone;
			this.CC = cc;
		}

		public Base()  // Criar tambem o Construtor sem parametros senão não consegue compilar
		{

		}

		public string Nome;
		public string Telefone;
		public string CC;

		// colocar codigo aqui
		private string Sobrenome = "Santos";

		public virtual void Gravar()

		{
			var dados = new Base().Ler();   // Alterar clientes para dados e Cliente.LerClientes para new Base().Ler();
			dados.Add(this);
			if (File.Exists(DiretorioComArquivo()))  // Alterar CaminhoBase para DiretorioComArquivo
			{
				StreamWriter r = new StreamWriter(DiretorioComArquivo());    // Alterar CaminhoBase para DiretorioComArquivo
				string conteudo = "nome;telefone;cc;";
				r.WriteLine(conteudo);
				foreach (Base b in dados)  // Alterar Cliente para Base e c para b
				{
					var linha = b.Nome + ";" + b.Telefone + ";" + b.CC + ";";  // Alterar todos os c por b.
					r.WriteLine(linha);
				}
				r.Close();
			}
		}

		// Bloco de codigo da classe Cliente colocado aqui

		public List<Base> Ler() // Mudar de Cliente para Base e em vez de LerClientes somente Ler, e retirar o static
		{
			var dados = new List<Base>();   // Mudar de Cliente para Base e clientes para dados

			if (File.Exists(DiretorioComArquivo()))  // Alterar CaminhoBase para DiretorioComArquivo
			{
				using (StreamReader arquivo = File.OpenText(DiretorioComArquivo()))  // Alterar CaminhoBase para DiretorioComArquivo
				{
					string linha;
					int i = 0;
					while ((linha = arquivo.ReadLine()) != null)
					{
						i++;
						if (i == 1) continue;
						var baseArquivo = linha.Split(';');  // alterar clienteArquivo para baseArquivo

						var cliente = new Base(baseArquivo[0], baseArquivo[1], baseArquivo[2]);  // alterar clienteArquivo para baseArquivo em todos tres.

						dados.Add(cliente);  // Alterar clientes para dados
					}
				}
			}

			return dados;  // Alterar clientes para dados
		}
		private string DiretorioComArquivo()    // Alterar CaminhoBase para DiretorioComArquivo e retirar o static
		{
			return ConfigurationManager.AppSettings["CaminhoArquivos"] + this.GetType().Name + ".txt"; // Alterar a string para CaminhoArquivos e alterar caminho no 'App.config'.
		}

		// colocar o codigo aqui

		   //public override void Olhar()   mudar de override para virtual, pois aqui é uma classe principal.
		/*	public virtual void Olhar()
		{
			int resultado = this.CalcularUmMaisDois();
			//this.CalcularUmMaisDois();     
			//this.CalcularUmMaisDois3(); 
			//this.CalcularUmMaisDois4();  


			Console.WriteLine("O usuario " + this.Nome + " não tem o sobrenome, pois é atribuito da classe Pai, está olhando para mim.");
			Console.WriteLine("=======================================================================================================");
			Console.WriteLine("O método original é: ");
			base.Olhar();
		} */

		// colocar o codigo aqui
		public virtual void Olhar()
		{
			Console.WriteLine("O cliente " + this.Nome + " " + this.Sobrenome + " está olhando para mim.");
			Console.WriteLine("===================================================");
		}

		// colocar o codigo aqui
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
