using System;
using System.Linq;

namespace Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
			//var x = System.IO.File.ReadAllLines(@"C:\temp\Wordlist-5k.txt");
			//var x = System.IO.File.ReadAllLines(@".\wordlists\Wordlist-5k.txt");

			var x = System.IO.File.ReadAllLines(@"/Users/markgriep/Desktop/Wordlist-5k.txt");


			//var z = x.Where(v => v.Length < 6 && v.Length > 4);


			var w = from ff in x
					where ff.Length > 3	&& ff.Length < 5	
					orderby ff
					select ff;





			//foreach (var ww in z)
			//{
			//Console.WriteLine(ww);

			//}

			//System.IO.File.AppendAllLines(@"C:\temp\Wordlist-3-5.txt", z);
			//System.IO.File.AppendAllLines(@"c:\temp\Wordlist-5.txt", w.Distinct());
			System.IO.File.WriteAllLines(@"/Users/markgriep/Desktop/Fivers.txt", w.Distinct());
			System.IO.File.WriteAllLines(@"/Users/markgriep/Desktop/fours.txt", w.Distinct());

			Console.WriteLine("Done");
			//Console.ReadKey();

		}
	}
}
