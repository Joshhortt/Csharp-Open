﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
	public interface IPessoa
	{
		void SetNome(string nome);
		void SetTelefone(string telefone);
		void SetCC(string cc);
		//void SetNIF(string nif);
		void Gravar();   
	}
}
