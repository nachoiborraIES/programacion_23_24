/*
 * Programa para practicar la recursividad, haremos los siguientes 2 casos:
 * 1º Caso: Diremos con un booleano si el numero que pongamos es con digitos
 * ascendentes, si es asi soltara un True, si hay un numero descendente al
 * anterior, el programa soltara un False
 * 2º Caso: Pondremos un texto y tendra que pasar las minusculas a mayusculas
 * y viceversa.
 */

using System;

class Recursividad
{
    static void Main()
    {
        Console.WriteLine("CASOS DE LOS DIGITOS ASCENDENTES: " );
        Console.WriteLine();
        Console.WriteLine("PRIMER CASO DIGITOS ASCENDENTES (122368): "
            + DigitosAscendentes(122368));
        Console.WriteLine("SEGUNDO CASO DIGITOS ASCENDENTES (46673): " 
            + DigitosAscendentes(46673));
        Console.WriteLine("TERCER CASO DIGITOS ASCENDENTES (1899): " 
            + DigitosAscendentes(1899));
        Console.WriteLine();
        Console.WriteLine("CASOS DE TRANSFORMAR TEXTO: ");
        Console.WriteLine();
        Console.WriteLine("PRIMER CASO TRANSFORMAR TEXTO: " + TransformarTexto
            ("Hola, CSharp es mejor que JAVA 1000 veces"));
        Console.WriteLine("SEGUNDO CASO TRANSFORMAR TEXTO: " + TransformarTexto
            ("mayuscula MINUSCULA"));
        Console.WriteLine("TERCER CASO TRANSFORMAR TEXTO: " + TransformarTexto
            ("MaNhUnT Es Un JuEgO QuE nO dEbErIaN jUgAr MeNoReS dE 18 aÑoS"));
    }
    
    static bool DigitosAscendentes(int numero)
    {
        int ultimoNumero, numerosAnteriores, anteriorUltimoNumero;
        ultimoNumero = numero % 10;
        numerosAnteriores = numero / 10;
        anteriorUltimoNumero = numerosAnteriores % 10;
        
        if (numero <= 9)
        {
            return true;
        }
        else if (anteriorUltimoNumero <= ultimoNumero)
        {
            return DigitosAscendentes(numerosAnteriores);
        }
        else
        {
            return false;
        }
    }
    
    static string TransformarTexto(string texto)
    {
        if (texto.Length == 0)
        {
            return texto;
        }
        
        char primeraLetra;
        string textoRestante;
        
        primeraLetra = texto[0];
        textoRestante = texto.Substring(1);
        
        if (char.IsUpper(primeraLetra))
        {
            primeraLetra = char.ToLower(primeraLetra);
        }
        else
        {
            primeraLetra = char.ToUpper(primeraLetra); 
        }
        
        return primeraLetra + TransformarTexto(textoRestante);
    }
}
