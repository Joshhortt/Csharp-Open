﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
	public class Usuario : Cliente  
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
