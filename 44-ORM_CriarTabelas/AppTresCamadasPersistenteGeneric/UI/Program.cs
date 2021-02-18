//44. ORM - Object Relational Mapping - Criar Tabelas
//Nesta aula iremos aprender como criar tabelas na Base de Dados de forma dinamica utilizando tecnicas ORM.

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
