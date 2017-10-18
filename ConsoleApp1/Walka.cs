using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Walka
	{
		public Walka()
		{
		}

		public static void Walcz(Postac atakujacy, Postac obronca)
		{
			Random rnd = new Random();
			List<int> wynikiRzutow = new List<int>();
			int sukcesy = 0;

			for (int i = 1; i <= atakujacy.CurSilaAtaku; ++i)
				wynikiRzutow.Add(rnd.Next(1, 7));

			//atakujacy.CurSilaAtaku = 2;
			int poziomTrudnosci = atakujacy.umiejetnosci[0].poziom - obronca.CurObrona;

			Console.WriteLine("Poziom trudności: " + poziomTrudnosci);

			foreach (int rzut in wynikiRzutow)
			{
				Console.WriteLine("Rzut: " + rzut);
				if (rzut <= poziomTrudnosci)
					sukcesy++;
			}
			Console.WriteLine("Ilość sukcesów: " + sukcesy);
		}

	}
}
