﻿
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
		public class Usuario : Base
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
