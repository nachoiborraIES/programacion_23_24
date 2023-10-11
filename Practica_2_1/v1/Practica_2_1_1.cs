/*programa que le pide al usuario tres temperaturas y según los datos le dice 
 * si es verano, invierno o primavera/otoño*/
using System;
class Temperatura
{
	static void Main()
	{
        
        Console.WriteLine("Dime la primera temperatura");
        int temperatura1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Dime la segunda temperatura");
        int temperatura2 =Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Dime la tercera temperatura");
        int temperatura3 = Convert.ToInt32(Console.ReadLine());
        
        if (temperatura1 > 25 && temperatura2 >25 && temperatura3 >25)
        {
            Console.WriteLine("Es verano");
        }
        else if (temperatura1 < 15 || temperatura2 < 15 || temperatura3 < 15)
        {
            Console.WriteLine("Es invierno");
        }
        else
        {
            Console.WriteLine("Es primavera o Otoño");
        }
    }
}
