using System;

namespace ReadFromCommandLine
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int a = 5, b = 0;

			// Въвеждане на входни параметри
			Console.Write ( "Моля въведете а:  " );
			b = Convert.ToInt32 (Console.ReadLine ());  

			//Печат на резултат
			Console.WriteLine ( "Резултатът a + b e: " + ( a + b ).ToString () + "\n");
			Console.WriteLine ( a + b );

			string test = "1";
			test += ", 2";
			test += ", 3";
			test += ", 4";
			test += ", 5";

			Console.WriteLine ("Събиране с += : " + test + "\n");
			test = test.Replace (", ", ";");
			Console.WriteLine ("Работа с Replace: " + test + "\n");

			Console.WriteLine ("3-ти знак: " + test.Split (';')[2]);
		}
	}
}
