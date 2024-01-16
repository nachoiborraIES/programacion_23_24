/*Programa que calcula la media de las 5 notas que recibe el Main
 * y muestra el resultado en color verde*/
using System;
class SaltoTrampolin
{
    static float ValidarNotas(string[] args)
    {
        bool correctas = true;
        int[] notas = new int[5];
        int auxiliarNota = 0;
        float media;
        
        if(args.Length != notas.Length)
            correctas = false;
        
        if(correctas)
        {                
            for (int i=0;i<notas.Length;i++)
            {
                if(Int32.TryParse(args[i], out auxiliarNota) &&
                    auxiliarNota >= 0 && auxiliarNota <= 10)
                {
                        notas[i] = auxiliarNota;
                }
                else
                    correctas = false;
            }
        }
        
        if(!correctas)
            media = -10;
        else
        {
            int[] notasFinales = DescartarNotas(notas);
            media = CalcularNotas(notasFinales);
        }
        
        return media;
    }
    static int[] DescartarNotas(int[] notas)
    {
        Array.Sort(notas);
        int[] notasFinales = new int[notas.Length-2];
        
        for(int i=0; i<notasFinales.Length;i++)
        {
            notasFinales[i] = notas[i+1];
        }

        return notasFinales;
    }
    static float CalcularNotas(int[] notas)
    {
        float media, sumar = 0;
        for(int i=0;i<notas.Length;i++)
        {
            sumar = sumar + notas[i];
        }
        
        media = sumar/notas.Length;
        
        return media;
    }
    static void Main(string[] args)
    {
        float media = ValidarNotas(args);
        
        if(media != -10)
        {
            Console.Write("Nota final: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(media.ToString("N2"));
            Console.ResetColor();
        }
        else
            Console.WriteLine("Notas incorrectas");
    }
}
