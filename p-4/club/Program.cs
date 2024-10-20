using System;
using System.Collections;

namespace TP_FINAL_04
{
	class Program
	{
		public static void Main(string[] args)
		{
			Entrenador c = new Entrenador ("Catriel", 45544474);
			c.Imprimir();
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}