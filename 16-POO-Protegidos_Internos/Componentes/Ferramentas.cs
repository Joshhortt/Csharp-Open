using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Componentes
{
    public class Ferramentas
    {
        internal string MetododSomenteParaMeuAssembly()  // 1. Metodo Interno
		{
            return "Este metodo so pode ser acessado dentro deste assembly componentes.";
		}

        public string MetodoParaTodosQueUtilizarOAssembly()  // 2. Metodo Publico
        {
            return "Este metodo é para todos.";
        }
    }
}
