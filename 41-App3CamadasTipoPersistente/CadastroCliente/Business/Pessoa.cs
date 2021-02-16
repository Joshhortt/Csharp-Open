using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Pessoa
    {
        // Propriedades
        public string nome { get; set; }
        public string telefone { get; set; }
        public string endereco { get; set; }
        public string email { get; set; }

        // Parametros
        public void SalvarDados()
		{
            new Database.Pessoa().Salvar(this.nome, this.telefone, this.endereco, this.email);
		}
       
    }
   
}
