using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progvacnat
{
	internal class classealiante : Componente
	{
		List<Componente> componenti = new List<Componente>();
		public List<Componente> Componenti
		{
			get { return componenti; }
			set { componenti = value; }
		}
		public classealiante(List<Componente> componenti)
		{
			Componenti = componenti;
		}
		public classealiante(classeala _ala, classefusoliera _fus, classecoda _coda, classeruota _ruota) 
		{
            Componenti.Add(_ala);
            Componenti.Add(_fus);
            Componenti.Add(_coda);
			Componenti.Add(_ruota);	
        }
        public override void Aggiunta(Componente componente)
		{
			Componenti.Add(componente);
		}
		public override void Rimuovi(int i)
		{
			if (i >= 0 && i < Componenti.Count)
			{
				Componenti.RemoveAt(i);
			}

		}
		public override Componente GetChild(int i)
		{
			if (i < Componenti.Count)
			{
				return Componenti[i];
			}
			else
			{
				return null;
			}
		}
		public override double CalcolaCosto()
		{
			double totale = 0;

			foreach (Componente componente in Componenti)
			{
				totale += componente.CalcolaCosto();
			}
			return totale;
		}
		public override string ToString()
		{
			string stringa = "";
			foreach (Componente componente in Componenti)
			{
				stringa += componente.ToString() + "\n";
			}
			return $"Aliante - {stringa}";
		}
		public override string Descrizione()
		{
			string stringa = "";
			foreach (Componente componente in Componenti)
			{
				stringa += componente.Descrizione() + "\n";
			}
			return $"Aliante - {stringa}";
		}
	}
}
