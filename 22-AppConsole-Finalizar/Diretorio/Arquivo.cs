using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diretorio
{
	class Arquivo
	{
		private static string caminhoArquivo()
		{
			return ConfigurationManager.AppSettings["caminhoArquivos"];
		}
		public static void Ler(int numeroArquivo)
		{
			string arquivoCaminho = caminhoArquivo() + "arq" + numeroArquivo + ".txt";
			Console.WriteLine("");
			Console.WriteLine("============================= Lendo arquivo ============================\n" + arquivoCaminho + "\n========================================================================");
			Console.WriteLine("");

			if (File.Exists(arquivoCaminho))
			{
				using (StreamReader arquivo = File.OpenText(arquivoCaminho))
				{
					string linha;
					while ((linha = arquivo.ReadLine()) != null)
					{
						Console.WriteLine(linha);
					}
				}
			}
			string arquivoCaminho2 = caminhoArquivo() + "arq" + (numeroArquivo + 1) + ".txt";
			//Console.WriteLine("============================= Lendo arquivo ============================\n" + arquivoCaminho2 + "\n========================================================================");

			if (File.Exists(arquivoCaminho2))
			{
				//LerArquivos(numeroArquivo + 1);
				Arquivo.Ler(numeroArquivo + 1);
			}
		}
	}
}
