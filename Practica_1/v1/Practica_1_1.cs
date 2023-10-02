/*Programa que pida nota de examen y nota de prácticas
y que calcule la nota final como el 70% nota de examen
y el 30% restante nota de prácticas*/

using System;
class Practica_1_1
{
	static void Main()
	{
		int nota_examen, nota_practica, nota_final;
		Console.Write("Ingrese la nota del examen: ");
		nota_examen=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Ingrese ahora la nota de las prácticas");
		nota_practica=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine();
		
		nota_final=nota_examen*70/100+nota_practica*30/100;
	
		Console.WriteLine("Su nota final es {0}", nota_final);
	}
}
