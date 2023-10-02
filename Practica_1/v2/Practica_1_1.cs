/*Programa para calcular a partir de dos notas, una nota final
 sabiendo que el examen es un 70% y las practicas un 30%*/
using System;

class Practica
{
        static void Main()
        {
            int examen, practicas, final;
            
            Console.WriteLine("Introduce tu nota de examen");
            examen = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce tu nota de prácticas");
            practicas = Convert.ToInt32(Console.ReadLine());
            
            final = (examen*70 /100 + practicas*30 / 100);
             
            Console.WriteLine("Tu nota final es: {0}", final);
        }
}
