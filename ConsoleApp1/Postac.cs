using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
	public class Postac
	{
		public string Nazwa { get; private set; }

		public int MaxSilaAtaku { get; private set; }
		public int MaxObrona { get; private set; }
		public int MaxPunktyZycia { get; private set; }
		public int MaxZmeczenie { get; private set; }

		public int CurSilaAtaku { get; private set; }
		public int CurObrona { get; private set; }
		public int CurPunktyZycia { get; private set; }
		public int CurZmeczenie { get; private set; }

		public List<Umiejetnosc> umiejetnosci = new List<Umiejetnosc>();

		public Postac(string nazwa, int silaAtaku, int obrona, int punktyZycia, int zmeczenie)
		{
			Nazwa = nazwa;

			MaxSilaAtaku = silaAtaku;
			MaxObrona = obrona;
			MaxPunktyZycia = punktyZycia;
			MaxZmeczenie = zmeczenie;

			CurSilaAtaku = silaAtaku;
			CurObrona = obrona;
			CurPunktyZycia = punktyZycia;
			CurZmeczenie = 0;

			umiejetnosci.Add(new Umiejetnosc("SKILL 1", 4, 2));
		}

		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override string ToString()
		{
			return base.ToString();
		}
	}
}
