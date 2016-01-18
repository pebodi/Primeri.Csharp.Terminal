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
			Console.WriteLine ( "Резултатът a + b e: " + ( a + b ).ToString () + "\n\n\n");
			Console.WriteLine ( a + b );
		}
	}
}
