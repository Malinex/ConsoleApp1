using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public class Umiejetnosc
	{
		public string nazwa;
		public int poziom;
		public int obrazenia;

		public Umiejetnosc()
		{
			nazwa = "Umiejętność";
			poziom = 7;
			obrazenia = 4;
		}

		public Umiejetnosc(string nazwa, int poziom, int obrazenia)
		{
			this.nazwa = nazwa;
			this.poziom = poziom;
			this.obrazenia = obrazenia;
		}
	}
}
