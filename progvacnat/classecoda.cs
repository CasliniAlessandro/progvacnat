using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progvacnat
{
	internal class classecoda : Componente
	{
		private double lunghezza;
		public classecoda( double lunghezza )
		{
			Lunghezza = lunghezza;
		}
		public double Lunghezza
		{
			get { return lunghezza; }
			set
			{
				if (value > 0)
					lunghezza = value;
			}

		}
		public override double CalcolaCosto()
		{
			return Lunghezza * 5;
		}
		public override string Descrizione()
		{
			return $"Coda Lunghezza: {Lunghezza} ";
		}
		public override Componente GetChild(int i)
		{
			return null;
		}
		public override void Aggiunta(Componente componente)
		{
			throw new NotImplementedException();
		}
		public override void Rimuovi(int i)
		{
			throw new NotImplementedException();
		}
	}
}
