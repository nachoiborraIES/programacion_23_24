/*Este programa dibuja dos piramides juntas 
 * en función de la altura que introduzcas.
 * Si la altura es inferior a 1 o el formato
 * incorrecto, ejecuta un mensaje de error.*/
using System;

class Programa
{
    static void Main()
    {
        int altura;
        int asteriscos = 1;
        
        try
        {
            Console.WriteLine("Introduzca la altura:");
            altura = Convert.ToInt32(Console.ReadLine());
            if(altura > 1)
            {
                for(int i = 1; i <= altura; i++)
                {
                    for(int j = 1; j <= altura-i; j++)
                    {
                        Console.Write(" ");
                    }
                    for(int k = 1; k <= asteriscos; k++)
                    {
                        Console.Write("*");
                    }
                    for(int l = 1; l <= (altura-i)*2; l++)
                    {
                        Console.Write(" ");
                    }
                    for(int m = 1; m <= asteriscos; m++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                    asteriscos+=2;
                }
            }
            else
            {
                Console.WriteLine("Altura no válida");
            }
        }
        catch(Exception)
        {
            Console.WriteLine("Altura no válida");
        }
    }
}
            
