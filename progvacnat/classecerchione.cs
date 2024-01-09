using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progvacnat
{
	internal class classecerchione : Componente
	{

		private string materiale;
		private double pollici;
		public classecerchione(string materiale ,double pollici )
		{
			Materiale = materiale;
			Pollici = pollici;
		}

		public classecerchione(double pollici, string materiale)
			: this(materiale, pollici) { }

        public string Materiale
		{
			get { return materiale; }
			set { materiale = value; }
		}
		public double Pollici
		{
			get { return pollici; }
			set { pollici = value; }
		}
		public override double CalcolaCosto()
		{
			return Pollici * 2;
		}
		public override string Descrizione()
		{
			return $"Cerchione Materiale: {Materiale},Pollici: {Pollici}. ";
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
