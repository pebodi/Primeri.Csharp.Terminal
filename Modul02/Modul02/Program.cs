﻿using System;

namespace Modul02
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Дефиниране на променливи
			int a = 0, b=0;
			int sum = 0;

			//Събиране на числа
			a = 10;
			b = 5;

			sum = a + b;

			//Писане в конзола
			Console.Write ( a );
			Console.Write (" + ");
			Console.Write ( b );
			Console.Write (" = ");
			Console.WriteLine ( sum );

			//Допълнителни оператори 
			Console.WriteLine ("\n Използване на += ");
			Console.WriteLine ( a );
			a += b;//a = 10 + 5, a = a+b

			Console.WriteLine ("\n Използване на -= ");
			a -= b;
			Console.WriteLine ( a );

			Console.WriteLine ("\n Използване на *= ");
			a *= b;
			Console.WriteLine ( a );

			Console.WriteLine ("\n Използване на ++ ");
			a++;
			Console.WriteLine ( a );

			Console.WriteLine ("Стандартно делене: " + ( 7 / 3 ).ToString ()); // - > 2 - 7/3 - 2.3333
			Console.WriteLine ( "Стандартно делене: " + ( 7 % 3 ).ToString ()); // - > 1 (1/3=0.3333)



		}
	}
}
