using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; 
using System.Configuration;  

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
			string connectionString = ConfigurationManager.AppSettings["sqlConnection"];
			using (SqlConnection connection = new SqlConnection(
			   connectionString))
			{
				string queryString = "insert into usuarios(nome,telefone,cc)values('" + this.Nome + "', '" + this.Telefone + "', '" + this.CC + "');";
				//string queryString = "insert into " + this.GetType().Name + "s (nome,telefone,cc)values('" + this.Nome + "', '" + this.Telefone + "', '" + this.CC + "');";
				SqlCommand command = new SqlCommand(queryString, connection);
				command.Connection.Open();
				command.ExecuteNonQuery();
				
			}
			//this.GetType().Name;
		}
	}
}