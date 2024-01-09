using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progvacnat
{
	internal class classefusoliera : Componente
	{
		private double lunghezza;
		private string materiale;
		public classefusoliera(double lunghezza, string materiale)
		{

			Lunghezza = lunghezza;
			Materiale = materiale;			
		}

		public classefusoliera(string materiale, double lunghezza)
			: this(lunghezza, materiale) { }
		 
		public double Lunghezza
		{
			get { return lunghezza; }
			set
			{
				if (value > 0)
					lunghezza = value;
			}
		}
		public string Materiale
		{
			get { return materiale; }
			set { materiale = value; }
		}
		public override double CalcolaCosto()
		{
			return Lunghezza * 3;
		}
		public override string Descrizione()
		{
			return $"Fusoliera Lunghezza: {Lunghezza} Materiale: {Materiale}";
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
