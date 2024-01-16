/*
 * Programa en el que pasaremos 5 notas de un concurso de saltos de trampolin,
 * veremos si las 5 notas sean correctas, es decir que sean exactamente 5 y que
 * esten entre 0 y 10, calcularemos la media borrando la peor nota y la maxima 
 * nota.
 * Luego el resultado lo tendremos que mostrar de color verde.
 */

using System;

class SaltoTrampolin
{
    static void Main(string[] args)
    {
        int[] notas = new int[5];
        double media;
        
        if (args.Length != 5)
        {
            Console.WriteLine("Tienes que poner 5 numeros");
        }
        else if (!ConseguirNotas(args, notas))
        {
            Console.WriteLine("Las notas tienen que ser numeros enteros");
        }
        else if (!ValidarNotas(notas))
        {
            Console.WriteLine("Los numeros tienen que estar entre 0 y 10");
        }
        else
        {
            media = CalcularMedia(notas);
        
            Console.Write("Nota final: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(media.ToString("N2"));
            Console.ResetColor();
        }
    }
    
    static bool ConseguirNotas(string[] args, int[] notas)
    {
        bool resultado = true;
        for (int i = 0; i < 5; i++)
        {
            if(!int.TryParse(args[i], out notas[i]))
            {
                resultado = false;
            }
        }
        return resultado;
    }
    
    static bool ValidarNotas(int[] notas)
    {
        bool resultado = true;
        foreach (int nota in notas)
        {
            if (nota > 10 || nota < 0)
            {
                resultado = false;
            }
        }
        return resultado;
    }
    
    static double CalcularMedia(int[] notas)
    {
        Array.Sort(notas);
        double media;
        media = (notas[1] + notas[2] + notas[3]) / 3.0;
        return media;
    }
}

