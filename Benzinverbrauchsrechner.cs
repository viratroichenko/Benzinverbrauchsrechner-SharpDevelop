/*
 * Created by SharpDevelop.
 * User: vira.troichenko
 * Date: 16.09.2025
 * Time: 08:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace erstellung_einer_Benzinverbrauchsabrechnung
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			string Name; 
			double GetankeLiter, letzentanken, literverbraucht, literverbraucht2; 
			int Kilometerletzestand, Kilometerstand; 
			
			Console.WriteLine("Berechnung des Benzinverbrauchs auf 100 km"); 
			Console.WriteLine("");
			
			Console.Write("Kilometerstand vor dem letzten Tanken:");
			Console.SetCursorPosition(40,2); 			
			Kilometerletzestand = Convert.ToInt32(Console.ReadLine()); 
			
			Console.Write("Kilometerstand beim aktuellen Tanken:"); 
			Console.SetCursorPosition(40,3); 
			Kilometerstand = Convert.ToInt32(Console.ReadLine());
			
			Console.Write("Getankte Liter:");
			Console.SetCursorPosition(40,4); 
			GetankeLiter = Convert.ToDouble(Console.ReadLine());
			
			Console.Write("Name des Autofahrers/der Autofahrerin:"); 
			Console.SetCursorPosition(40,5); 
			Name = Console.ReadLine(); 
			
			Console.Clear();
			
			letzentanken = Kilometerstand - Kilometerletzestand; 
			literverbraucht = letzentanken/100; 
			literverbraucht2 = GetankeLiter/literverbraucht; 
			
			
			Console.WriteLine("Berechnung des Benzinverbrauchs auf 100 km für {0}", Name); 
			Console.WriteLine(""); 
			
			Console.WriteLine("seit dem letzten Tanken wurden {0} km gefahren und {1:F2} Liter verbraucht.", letzentanken, GetankeLiter); 
			Console.WriteLine(""); 
			
			Console.WriteLine("Auf 100 km verbraucht der PKW von {0} {1:F2} liter", Name, literverbraucht2); 
			
			
			
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}