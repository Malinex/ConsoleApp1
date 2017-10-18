using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			var c = new Postac("JOHN", 6, 1, 10, 3);
			var d = new Postac("GEORGE", 6, 2, 10, 3);
			while (true)
			{
				Walka.Walcz(c, d);

				Console.ReadKey();
			}
			
		}
	}
}
