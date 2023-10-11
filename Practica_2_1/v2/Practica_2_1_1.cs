//Programa que diga que estación es dependiedo de los valores que se den

using System;

public class Practica_2_1_1
{
	public static void Main()
	{
        int temperatura1, temperatura2, temperatura3;
        
		Console.WriteLine("Introduce la temperatura del primer día: ");
        temperatura1 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Introduce la temperatura del segundo día: ");
        temperatura2 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Introduce la temperatura del tercer día: ");
        temperatura3 = Convert.ToInt32(Console.ReadLine());
        
        Console.Clear();
        
        if (temperatura1 > 25 && temperatura2 > 25 && temperatura3 > 25)
        {
            Console.WriteLine("{0} {1} {2} --> Es verano",
            temperatura1,temperatura2, temperatura3);
        }
        else if (temperatura1 < 15 || temperatura2 < 15 ||
				 temperatura3 < 15)
        {
            Console.WriteLine("{0} {1} {2} --> Es invierno", 
            temperatura1,temperatura2, temperatura3);
        }
        else 
        {
            Console.WriteLine("{0} {1} {2} --> Es primavera u otoño", 
            temperatura1,temperatura2, temperatura3);
        }
	}
}
