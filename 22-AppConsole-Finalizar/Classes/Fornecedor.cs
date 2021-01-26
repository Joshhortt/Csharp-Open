
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
		public Fornecedor(string nome, string telefone, string cc)
		{
			this.Nome = nome;
			this.Telefone = telefone;
			this.CC = cc;
		}
		public Fornecedor() { }
		}
	}
