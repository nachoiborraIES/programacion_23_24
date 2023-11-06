/*Este programa calcula tu nota final en base a tu media de practicas(30%) y a
 * tu media de examen(70%). Si una de las medias no supera el 4, optas como
 * máximo a un 4.*/

using System;

class Practica
{
    static void Main()
    {
        int nPractica;
        float sumaPractica = 0f;
        float sumaExamen = 0f;
        float mediaPractica;
        float mediaExamen;
        float notaFinal;
        
        Console.WriteLine("Indica cuántas prácticas has realizado:");
        nPractica = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Introduce la nota de tus {0} prácticas", nPractica);
        for(int i = 1; i <= nPractica; i++)
        {
            sumaPractica += Convert.ToSingle(Console.ReadLine());
        }
        
        mediaPractica = sumaPractica/nPractica;
        
        Console.WriteLine("Nota del primer examen: ");
        sumaExamen += Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Nota del segundo examen: ");
        sumaExamen += Convert.ToSingle(Console.ReadLine());
        
        mediaExamen = sumaExamen/2;
        
        notaFinal = (mediaPractica*0.3f) + (mediaExamen*0.7f);
        
        if(mediaPractica < 4 || mediaExamen < 4)
        {
            notaFinal = Math.Min(notaFinal,4);
        }
        
        Console.WriteLine("Tu nota final es {0}", notaFinal.ToString("N2"));

    }
}
        
