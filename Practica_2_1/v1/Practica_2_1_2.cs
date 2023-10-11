/*programa que le pide al usuario dos números y cuenta con el primero hasta
 *  llegar al segundo número*/
using System;
class Contador
{
	static void Main()
	{
        Console.WriteLine("Dime un número");
        int numero1 = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Dime otro número");
        int numero2 = Convert.ToInt32(Console.ReadLine());
        
        if (numero1 > numero2)
        {
            for (int i = numero1 ; numero1 >= numero2; numero1--)
            {
                Console.WriteLine(numero1);
            }
        }
        else
        {        
            for (int i = numero1 ; numero1 <= numero2; numero1++)
            {
                Console.WriteLine(numero1);
            }
        }
    }
}
