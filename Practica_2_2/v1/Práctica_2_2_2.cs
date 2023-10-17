/*Este programa calcula la media de 5 números introducidos por el usuario.
 * El número siguiente siempre tiene que ser mayor que el anterior*/
 
using System;

class Programa
{
    static void Main()
    {
        int n;
        int ultimaN = 0;
        int suma = 0;
        
        for(int i = 1; i <= 5; i++)
        {
            do
            {
                Console.WriteLine("Introduzca el número {0}", i);
                n = Convert.ToInt32(Console.ReadLine());
                
                if(i != 1 && n <= ultimaN)
                {
                    Console.WriteLine("El número escrito debe ser mayor "
                    + "que el número anterior.");
                }
            }
            while(i != 1 && n <= ultimaN);
            ultimaN = n;
            suma += n;
        }
        Console.WriteLine("La media es {0}", suma/5);
    }
}
                    
                    
