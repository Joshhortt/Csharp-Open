using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
	public abstract class Animal
	{
		public string coleira;
		public string pelos;
		public string olhos;

		public abstract void Latir();

		public string Correr()
		{
			return "animal esta correndo.";
		}
	}

}
