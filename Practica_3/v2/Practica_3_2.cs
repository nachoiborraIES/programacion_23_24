/*
 * Pedir al usuario temperatura en Celsius o Fahrenheit
 * Realizar conversión de uno a otro con un decimal
*/
using System;

class Practica_3_2
{
    static void Main()
    {
        double temperatura = 0, fahr, centi;
        char unidad;
        bool esCorrecto = true;
        
        do
        {
            Console.WriteLine("Introduce la temperatura: ");
            
            try
            {
                temperatura = Convert.ToDouble(Console.ReadLine());
                esCorrecto = true;
            }
            catch(Exception)
            {
                Console.WriteLine("Dato incorrecto");
                esCorrecto = false;
            }
        }
        while(esCorrecto == false);
        
        Console.WriteLine("Escribe la unidad: \"C\" o \"F\":");
        unidad = Convert.ToChar(Console.ReadLine());
        
        if(unidad == 'C')
        {
            fahr = temperatura * 9 / 5 + 32;
            Console.WriteLine("{0}ºC son {1}ºF", temperatura,
                fahr.ToString("N1"));
        }
        else if (unidad == 'F')
        {
            centi = (temperatura - 32) * 5/9;
            Console.WriteLine("{0}ºF son {1}ºC", temperatura,
                centi.ToString("N1"));
        }
        else 
        {
            Console.WriteLine("Unidad no válida");
        }
    }
}
