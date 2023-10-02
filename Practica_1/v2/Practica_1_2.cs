//Programa que convierte grados centígrados  a Fahrenheit
using System;

class Practica
{
    static void Main()
    {
        int centigrados, fahrenheit;
        
        Console.WriteLine("Escribe la temperatura en centígrados: ");
        centigrados = Convert.ToInt32(Console.ReadLine());
        
        fahrenheit = centigrados * 9 / 5 + 32;
        
        Console.WriteLine("La temperatura en fahrenheit es {0} ºF", fahrenheit);
    }
}
