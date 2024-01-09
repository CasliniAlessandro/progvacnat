using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progvacnat
{
	internal class classeala : Componente
	{
		private double lunghezza;
		private double apertura;
		public classeala(double lunghezza, double apertura)
		{
			Lunghezza = lunghezza;
			Apertura = apertura;
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
		public double Apertura
		{
			get { return apertura; }
			set
			{
				if (value > 0)
					apertura = value;
			}
		}

		public override string Descrizione()
		{
			return $"Ala  Lunghezza: {Lunghezza}, Apertura: {Apertura}";
		}
		public override double CalcolaCosto()
		{
			return Lunghezza * Apertura;
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
