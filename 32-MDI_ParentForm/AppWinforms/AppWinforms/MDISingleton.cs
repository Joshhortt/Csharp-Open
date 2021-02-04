using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWinforms
{
	public class MDISingleton  // classe singleton que vai abrir a instancia no MDI
	{
		private MDISingleton() { }  // construtor


		private static MDIParentPrincipal instanceMDIParentPrincipal;

		public static MDIParentPrincipal InstanciaMDI()
			{
			if (instanceMDIParentPrincipal == null)
			{
				instanceMDIParentPrincipal = new MDIParentPrincipal();
				return instanceMDIParentPrincipal;
			}
			return instanceMDIParentPrincipal;
		}
	}
}
