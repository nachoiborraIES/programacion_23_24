/*
 * Calcular la nota del primer trimestre
 * Pedir al usuario cuantas prácticas ha realizado y sus notas
 * Las notas de los dos exámenes
 * nota final 70 % exámenes mas 30% prácticas
 * Si la nota final no llega a 4 en algunas de las dos medias, la nota 
 * final podrá ser 4 como máximo
 * Nota final redondeada a 2 decimales.
*/
using System;

class Practica_3_1
{
    static void Main()
    {
        int practicas = 0;
        double notaPr, sumaPr = 0, mediaPr = 0, primerExa, segundoExa,
            mediaExa, notaFinal;
        
        Console.WriteLine("Número de prácticas realizadas:");
        practicas = Convert.ToInt32(Console.ReadLine());
        
        if(practicas > 0)
        {
            Console.WriteLine("Introduce las {0} notas: ", practicas);
            
            for(int i = 1; i <= practicas; i++)
            {
                notaPr = Convert.ToDouble(Console.ReadLine());
                sumaPr += notaPr;
            }
            mediaPr = sumaPr / practicas;
        }
        
        Console.WriteLine("Nota del primer examen: ");
        primerExa = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nota del segundo examen: ");
        segundoExa = Convert.ToDouble(Console.ReadLine());
        
        mediaExa = (primerExa + segundoExa) / 2;
        notaFinal = (mediaPr * 0.3) + (mediaExa * 0.7);
        
        if(mediaPr < 4 || mediaExa < 4)
        {
            notaFinal = Math.Min(notaFinal,4);
        }
       
        Console.WriteLine("Tu nota final es: " +
                (notaFinal.ToString("N2")));
    }
}


