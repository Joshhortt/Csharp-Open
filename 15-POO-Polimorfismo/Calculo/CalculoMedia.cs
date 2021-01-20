using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo
{
	class Media
	{
		public static void Alunos()  // Refactorado
		{
			Console.WriteLine("Digite o nome do aluno: ");
			string nomeAluno = Console.ReadLine();
			int quantNotas = 3;
			Console.WriteLine("Digite as " + quantNotas + " notas do aluno: " + nomeAluno);

			List<int> notas = new List<int>();
			int totalNotas = 0;
			for (int i = 1; i <= quantNotas; i++)
			{
				Console.WriteLine("Digite o numero da nota " + i);
				int nota = int.Parse(Console.ReadLine());
				totalNotas += nota;
				notas.Add(nota);
			}
			int mediaNotas = totalNotas / notas.Count;
			Console.WriteLine("\nA media do aluno " + nomeAluno + " é: " + mediaNotas);
			Console.WriteLine("\nAs suas notas são: \n");
			foreach (int nota in notas)
			{
				Console.WriteLine("Nota:  " + nota + "\n");
			}
		}
	}
}
