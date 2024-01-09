using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progvacnat
{
	internal class classegomma : Componente
	{
		private double larghezza;
		private double altezza;
		private double raggio;
		public classegomma(double larghezza, double altezza, double raggio)
		{

			Larghezza = larghezza;
			Altezza = altezza;
			Raggio = raggio;
			
		}
		public double Larghezza
		{
			get { return larghezza; }
			set { larghezza = value; }
		}
		public double Altezza
		{
			get { return altezza; }
			set { altezza = value; }
		}
		public double Raggio
		{
			get { return raggio; }
			set { raggio = value; }
		}
		public override double CalcolaCosto()
		{
			return Altezza * Larghezza * Raggio;
		}
		public override string Descrizione()
		{
			return $"Cerchione Larghezza: {Larghezza}, Altezza: {Altezza}, Raggio: {Raggio}";
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
