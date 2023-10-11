//Programa que realiza conteo del primero al segundo que se han pedido
//al usuario ascendente o descendente

using System;

public class Practica_2_1_2
{
	public static void Main()
	{
		int num1, num2;
        
        Console.WriteLine("Introduce el primer número: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Introduce el segundo número: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        
        Console.Clear();
        
        if (num1 < num2)
        {
            for (int i = num1; i <= num2; i++ )
            {
                Console.WriteLine(i);
            }
        }
        else
        {
            for (int i = num1; i >= num2; i-- )
            {
                Console.WriteLine(i);
            }
        }
	}
}
