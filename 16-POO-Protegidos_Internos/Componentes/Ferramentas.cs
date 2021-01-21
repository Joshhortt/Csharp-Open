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

           // Cliente c = new Cliente();  // 1. Criar nova instancia
           // c.CalcularUmMaisDois3();   // 2. So consigo acessar o CalcularUmMaisDois3(). O ...4(); Inacessivel devido ao seu estado protegido Interno.
            
            return "Este metodo é para todos.";
        }
    }
}
