using DataBase;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
		public class Usuario : Base
		// public class Usuario : DataBase.Base  // Assim tb funciona com o using DataBase comentado
	{
		public Usuario(string nome, string telefone, string cc)
		{
			this.Nome = nome;
			this.Telefone = telefone;
			this.CC = cc;
		}
		public Usuario() { }
		}
	}
