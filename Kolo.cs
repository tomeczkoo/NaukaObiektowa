using System;

namespace Fajguji
{
	
	public class Kolo
	{
		int promien; 
		public const double PI = 3.1415926535897931;
		
		public Kolo(int r)
		{
			promien = r; 
		}
		
		public double obliczPole()
		{
			promien = promien * promien;
			return PI * promien;
		}
		public double obliczObwod()
		{
			return 2*PI * promien; 
		}
	}
}
