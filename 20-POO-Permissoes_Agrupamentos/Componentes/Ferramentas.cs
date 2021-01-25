//using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Componentes
{
    public class Ferramentas
    {
        internal string MetododSomenteParaMeuAssembly()  
		{
            return "Este metodo so pode ser acessado dentro deste assembly componentes.";
		}

        public string MetodoParaTodosQueUtilizarOAssembly()  
        {
 
            return "Este metodo é para todos.";
        }

        public bool ValidarCC(string cc)  
        {

            return true;
        }
    }
}
