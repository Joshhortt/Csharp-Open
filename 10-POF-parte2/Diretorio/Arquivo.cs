using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diretorio
{
	class Arquivo
	{
		public static void Ler(int numeroArquivo)
		{
			string arquivoCaminho = (@"C:\Users\josec\OneDrive\Área de Trabalho\Csharp-Open\Arquivos_07\arq" + numeroArquivo + ".txt");
			//Console.WriteLine("============ Lendo arquivo ============\n" + arquivoCaminho + "\n========================");

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
			string arquivoCaminho2 = (@"C:\Users\josec\OneDrive\Área de Trabalho\Csharp-Open\Arquivos_07\arq" + numeroArquivo + 1 + ".txt");

			if (File.Exists(arquivoCaminho2))
			{
				//LerArquivos(numeroArquivo + 1);
				Arquivo.Ler(numeroArquivo + 1);
			}
		}
	}
}
