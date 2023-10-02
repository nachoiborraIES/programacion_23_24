//Ingresa valor temperatura en celsius y lo convierta en grados Fahrenheit

using System;
class Practica_1_2
{
	static void Main()
	{
		int grados, fahrenheit;
		
		Console.Write("Introduce el valor en celsius para conversión: ");
		grados=Convert.ToInt32(Console.ReadLine());
		fahrenheit=grados*9/5+32;
		Console.WriteLine("{0}º centigrados son {1}º Fahrenheit", grados, 
			fahrenheit);
	}
}
