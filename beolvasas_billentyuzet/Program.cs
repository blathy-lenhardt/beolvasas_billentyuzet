using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beolvasas_billentyuzet
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Beolvasás billentyűzetről

			/* C#-ban csak szöveg típusú adatot lehet beolvasni.
			 * 
			 * a = Console.ReadLine();
			 * 
			 * Ha számot szeretnénk bekérni, akkor konvertálni kell a megfelelő számtípusra a bekért szöveget.
			 * 
			 * ADATOK KOVERTÁLÁSA
			 * 
			 * Statikus konvertálás: már fordítási időben az egyik típusú adat átkonvertálódik egy másik típusra.
			 * 
			 * Példa:
			 * int x = 3;
			 * Console.WriteLine(x/4);
			 * Eredmény: 0
			 * 
			 * Console.WriteLine((float)x/4);
			 * Eredmény: 0.75
			 * 
			 * Hátránya: nem tud mit kezdeni azzal, ha szövegből szeretnénk számotak nyerni, vagy fordítva.
			 * 
			 * Convert class: Különböző alap típusok közötti konvertálására.
			 * 
			 * Pl.:
			 * 
			 * int e = 0;
			 * e = Convert.ToInt32(Console.ReadLine());
			 * 
			 * double v = 0;
			 * v = Convert.ToDouble(Console.ReadLine());
			 * 
			 * char k = ' ';
			 * k = Convert.ToChar(Console.ReadLine());
			 */
		}
	}
}
