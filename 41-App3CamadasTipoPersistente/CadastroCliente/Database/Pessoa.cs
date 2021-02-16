using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;  // adicionar
using System.Data.SqlClient;  // adicionar
using System.Data;  // adicionar

namespace Database
{
       public class Pessoa

    {
        private string connString = "";

        public Pessoa()  // Construtor
		{
            connString = ConfigurationManager.ConnectionStrings["conectar"].ConnectionString;
		}

        // Todas as Ligações com o Base de Dados
        public void Salvar(string nome, string telefone, string endereco, string email)
		{
            using(SqlConnection conn = new SqlConnection(connString))
			{
                string sql = "InserirDados";
                SqlCommand cmd = new SqlCommand(sql, conn);
                {
                    cmd.CommandType = CommandType.StoredProcedure;  // Para reconhecer a Procedure que fizemos no SQL
                    // nome
                    cmd.Parameters.Add("@nome", SqlDbType.VarChar);
                    cmd.Parameters["@nome"].Value = nome;
                    // telefone
                    cmd.Parameters.Add("@telefone", SqlDbType.VarChar);
                    cmd.Parameters["@telefone"].Value = telefone;
                    // endereco
                    cmd.Parameters.Add("@endereco", SqlDbType.VarChar);
                    cmd.Parameters["@enderecoe"].Value = endereco;
                    // email
                    cmd.Parameters.Add("@email", SqlDbType.VarChar);
                    cmd.Parameters["@email"].Value = email;

                    conn.Open();  // Abre concexao
                    cmd.ExecuteNonQuery();  // Executa a inserção dos dados inseridos na BD
                }
			}
		}
    }
}
