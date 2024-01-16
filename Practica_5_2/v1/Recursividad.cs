/*Programa que utiliza la Recursividad para determinar si los números
 * que dice el usuario están en orden ascendente o no, e intercambia
 * las mayúsculas por las minúsculas y viceversa de una frase*/

using System;
class Recursividad
{
    static bool DigitosAscendentes(int numero)
    {
        int ultNum=numero%10;
        int numAnt=(numero/10)%10;
        
        if(numero < 10)
            return true;
        else if(ultNum < numAnt)
            return false;
        else
            return DigitosAscendentes(numero/10);
    }
    
    static string TransformarTexto(string frase)
    {
        if(frase.Length == 0)
            return "";
        
        char letra = frase[0];
        string letraFinal = letra.ToString();
        string fraseFinal = frase.Substring(1);
        
        if(letra >= 'a' && letra <= 'z')
        {
            return letraFinal.ToUpper() + TransformarTexto(fraseFinal);
        }
        else if(letra >= 'A' && letra <= 'Z')
        {
            return letraFinal.ToLower() + TransformarTexto(fraseFinal);
        }
        else
            return letra + TransformarTexto(fraseFinal);
    }
    
    static void Main()
    {
        Console.WriteLine(DigitosAscendentes(12345));
        Console.WriteLine(DigitosAscendentes(56723));
        Console.WriteLine(DigitosAscendentes(93497));
        
        Console.WriteLine(TransformarTexto("Hola, Mundo"));
        Console.WriteLine(TransformarTexto("Me gusta lEEr LibroS."));
        Console.WriteLine(TransformarTexto("Salgo los VierNes por La nocHe"));

    }
}
