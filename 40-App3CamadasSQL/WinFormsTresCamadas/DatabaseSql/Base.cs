using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseSQL
{
	public abstract class Base : IPessoa
	{
		public Base(string nome, string telefone, string cc)
		{
			this.Nome = nome;
			this.Telefone = telefone;
			this.CC = cc;
		}

		public Base() { }

		public string Nome;
		public string Telefone;
		public string CC;
		public string NIF;

		public void SetNome(string nome) { this.Nome = nome; }
		public void SetTelefone(string telefone) { this.Telefone = telefone; }
		public void SetCC(string cc) { this.CC = cc; }

		public virtual void Gravar()
		{
			//this.GetType().Name;
		}
	}
}