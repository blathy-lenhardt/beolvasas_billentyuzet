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

			// 1. feladat: Írjunk programot, amely bekér két egész számot a billentyűzetről és kiírja az összegüket.
			int x;
			Console.WriteLine("1. feladat: Két szám összegének kiszámítása!");
			Console.WriteLine("Adjon meg két számot egymás után ENTER lenyomásával:");
			x = Convert.ToInt32(Console.ReadLine()) + Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(x);

			// MATEMATIKA FÜGGVÉNY
			/* Math.Abs();
			 * Egy adott szám abszolút értékét adja vissza.
			 * pl.: Math.Abs(-4); -> 4
			 * 
			 * Math.Pow(alap, kitevő);
			 * Hatványozás. Az első paraméter a hatvány alapja, a második paraméter a hatvány kitevője.
			 * N-edik gyök számítására is alkalmas, ha a kitevő tört.
			 * Pl.:	Math.Pow(2, 3);		-> 8
			 *	Math.Pow(2, -3);	-> 0,125
			 *	Math.Pow(-2, 3);	-> -8
			 *	Math.Pow(-3, -3);	-> -0,125
			 * 
			 * Köbgyökvonás
			 * Math.Pow(8, 1/3);		-> 1 (szemantikai hiba)
			 * Math.Pow(8, 1/float(3));	-> 2
			 * 
			 * A hatványozás eredménye valós típusú szám lesz!
			 * 
			 * Math.Round(valós szám);
			 * Kerekítés egész számra a matematika szabályainak megfelelően.
			 * Pl.:	Math.Round(2.325);	-> 2
			 *	Math.Round(2.525);	-> 3
			 *	Math.Round(-2.325);	-> -2
			 *	Math.Round(-2.525);	-> -3
			 *	
			 * Math.Round(valós szám, egész jegy);
			 * Kerekítés a megadott tizedes jegyig.
			 * Pl.:	Math.Round(3.256, 2);	-> 3.26
			 * 
			 * Math.Sqrt();
			 * Visszaadja a megadott szám négyzetgyökét.
			 * Pl.:	Math.Sqrt(4);	-> 2
			 * 
			 * Math.PI;
			 * Konstans szám. Ezen keresztül tudjuk lekérdezni a PI értékét.
			 */
		}
	}
}
