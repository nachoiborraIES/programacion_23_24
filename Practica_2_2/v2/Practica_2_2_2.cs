/*Programa le pide 5 números al usuario, cada uno mayor que el otro, y le hace
 * la media de los números introducidos validos*/

using System;
class Secuencia
{
    static void Main()
    {
        int numero, numeroAnterior = 0, total = 0, contador = 1;
        do
        {
            Console.WriteLine("Dime el número nº" + contador);
            numero = Convert.ToInt32(Console.ReadLine());
            if (contador == 1)
            {
                numeroAnterior = numero - 1;
            }
            if (numero > numeroAnterior)
            {
                numeroAnterior = numero;
                total = total + numero;
                contador++;
            }
            else
            {
                Console.WriteLine
                ("El número introducido debe ser mayor que el anterior.");
            }
        }
        while (contador <= 5);

        Console.WriteLine
        ("La media de los valores introducidos es: " + total / 5);
    }
}
