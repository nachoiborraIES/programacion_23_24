//Programa que pide 2 notas del 1 al 10 y calcula la media
//si se pone un dato incorrecto se volvera a pedir hasta que
//se ponga el correcto

using System;

public class Practica_2_1_3
{
	public static void Main()
	{
		int nota1, nota2, media;
        
        do
        {
            Console.WriteLine("Introduce la primera nota: ");
            nota1 = Convert.ToInt32(Console.ReadLine());
        }
        while (nota1 <0 || nota1 >10);
        
        Console.Clear();
        
        do
        {
            Console.WriteLine("Introduce la segunda nota: ");
            nota2 = Convert.ToInt32(Console.ReadLine());
        }
        while (nota2 <0 || nota2 >10);

        Console.Clear();
        
        media = (nota1 + nota2) / 2;
        
        Console.WriteLine("Has sacado un {0} y un {1}, por lo que tu" +
			"nota media es {2}:", nota1, nota2, media);
	}
}
