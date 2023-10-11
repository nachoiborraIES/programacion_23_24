/*programa que le pide al usuario dos notas numericas del 0 al 10 y le
 * calcula la media*/
using System;
class Notas
{
	static void Main()
	{
        int nota1, nota2;
        
        do
        {
            Console.WriteLine("Dime tu primera nota");
            nota1 = Convert.ToInt32(Console.ReadLine());
        }
        while(nota1 < 0 || nota1 > 10);
        
        do
        {
            System.Console.WriteLine("Dime tu segunda nota");
            nota2 = Convert.ToInt32(Console.ReadLine());
        }
        while(nota2 < 0 || nota2 > 10);
        
        Console.WriteLine("Tu media es: " + (nota1+nota2)/2);
    }
}
