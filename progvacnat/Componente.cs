using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progvacnat
{
	abstract class Componente
	{
		public abstract string Descrizione();
		public abstract void Aggiunta(Componente componente);
		public abstract void Rimuovi(int i);
		public abstract Componente GetChild(int i);

		public abstract double CalcolaCosto();

	}
}
