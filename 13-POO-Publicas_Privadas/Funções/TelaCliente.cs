using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funções
{
	class TelaCliente
	{
		public static void Chamar()

		{
			Cliente.Teste = "sss";

			var cliente = new Cliente();

			cliente.Nome = "Geraldo";
			cliente.Telefone = "911815870";
			cliente.CC = "9690540";
			cliente.Gravar();

			var clientes = Cliente.LerClientes();
			foreach (Cliente c in clientes)
			{
				Console.WriteLine(c.Nome);
				Console.WriteLine(c.Telefone);
				Console.WriteLine(c.CC);
				Console.WriteLine("=============================================");
			}
			Console.ReadLine();
			var l = new List<String>();

			var cliente2 = new Cliente();
			cliente2.Nome = "Rita";
			cliente2.Telefone = "911815878";
			cliente2.CC = "9690544";
			cliente2.Gravar();
		}
	}
}
