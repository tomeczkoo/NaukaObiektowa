
using System;

namespace Fajguji
{

	public class Kwadrat : Figura 
	{
		public Kwadrat(int a)
		{
			bokA = a;
			
		}
		public int obliczPole()
		{
			return bokA * bokA;
		}
		public int obliczObwod()
		{
			return bokA * 4;
		}
		
	}
}
