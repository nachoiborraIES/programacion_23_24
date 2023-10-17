/*Programa que le pide al usuario una altura y le dibuja dos picos de 
 * esa altura*/

using System;
class Dibujo
{
    static void Main()
    {
        int altura, espacios, asteriscos = 1;

        try
        {
            Console.WriteLine("Dime una altura");
            altura = Convert.ToInt32(Console.ReadLine());
            espacios = altura - 1;
            if (altura > 0)
            {
                for (int i = 1; i <= altura; i++)
                {
                    for (int j = 1; j <= espacios; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 1; k <= asteriscos; k++)
                    {
                        Console.Write("*");
                    }
                    for (int j = 1; j <= espacios * 2; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 1; k <= asteriscos; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                    espacios--;
                    asteriscos = asteriscos + 2;
                }
            }
            else
            {
                Console.WriteLine("Altura no válida");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Altura no válida");
        }
    }
}
