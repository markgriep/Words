using System;
using System.Linq;

namespace Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
			var x = System.IO.File.ReadAllLines(@"C:\temp\Wordlist-5k.txt");

			var z = x.Where(v => v.Length < 6 && v.Length > 2);

			//foreach (var ww in z)
			//{
			//Console.WriteLine(ww);

			//}

			System.IO.File.AppendAllLines(@"C:\temp\Wordlist-3-5.txt", z);

			Console.WriteLine("Done");
			Console.ReadKey();

		}
	}
}
