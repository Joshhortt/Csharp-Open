//43. ORM - Object Relational Mapping - Alterar e Excluir (Update & Delete) 
//Nesta aula iremos aprender como alterar o nosso ORM para fazer alterações e exclusões de forma genérica.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTresCamadasPersistenteGeneric
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
