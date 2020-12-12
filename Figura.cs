
using System;

namespace Fajguji
{
	public abstract class Figura
	{
		public int bokA;
		public int bokB;
		
		public Figura()
		{
			Console.WriteLine("jestem abstrakcyjna figora");
		}
		
		public int obliczPole()
		{
			return 0;
		}
		
		
	}
}


//"; Utwórz 2 metody abstrakcyjne - ObliczPole i ObliczObwod; Utworz 2 klasy : Kwadrat i Kolo. Wykonaj dziedziczenie z klasy abstrakcyjnej i zaimplementuj odpowiednio metody do wyliczania pola i obwodu danej figury. W klasach Kwadrat i Kolo utworz 1 konstruktor ktory bedzie pobieral od uzytkownika potrzebne parametry do obliczen. Klasy Kwadrat i Kolo maja dziedziczyc z figury :smile:
