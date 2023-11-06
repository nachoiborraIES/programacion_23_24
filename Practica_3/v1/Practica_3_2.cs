/*Este programa permite convertir grados Celsius a Fahrenheit y viceversa.
 * El programa detecta errores si la temperatura o la unidad no han sido
 * introducidas correctamente.*/
 
using System;

class Practica
{
    static void Main()
    {
        double temp = 0;
        bool error = false;
        char unidad;
        double conversion;
        
        do
        {
            try
            {
                Console.WriteLine("Introduce la temperatura:");
                temp = Convert.ToDouble(Console.ReadLine());
                error = false;
            }
            catch(Exception)
            {
                Console.WriteLine("Valor de temperatura no válido");
                error = true;
            }
        }
        while(error);
        
        Console.WriteLine("Introduce la unidad: ");
        unidad = Convert.ToChar(Console.ReadLine());
        if(unidad != 'C' && unidad != 'F')
        {
            Console.WriteLine("Unidad no válida");
        }
        else if(unidad == 'C')
        {
            conversion = temp*9/5+32;
            Console.WriteLine("{0} grados Celsius son {1} grados Fahrenheit",
            temp.ToString("N1"), conversion.ToString("N1"));
        }
        else
        {
            conversion = 5*(temp-32)/9;
            Console.WriteLine("{0} grados Fahreneheit son {1} grados Celsius",
            temp.ToString("N1"), conversion.ToString("N1"));
        }
    }
}
