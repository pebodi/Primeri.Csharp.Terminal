﻿using System;

namespace BoolExplore
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//bool _b = true; //true or false

			//bool _test = 5 > 10;

			int[] _i = new int[] { 4, 3, 2};

			int _ui = Convert.ToInt32 (Console.ReadLine ());

			bool _check01 = _ui <= _i.Length;
			bool _check02 = _ui > 0;

			bool _exp01 = _check01 && _check02; 	//Логическо И "&&"
			bool _exp02 = _check01 || _check02; 	//Логическо ИЛИ " || "

			Console.WriteLine ("Логическо И: " + _exp01.ToString ());
			Console.WriteLine ("Логическо ИЛИ: " + _exp02.ToString ());

			//Console.WriteLine ( _i [ _ui - 1]);
		}
	}
}
