using System;

class Program
{
    static void Main()
    {
        // Definimos el número de términos que queremos imprimir
        int terminos = 10;
        int a = 0; // Primer término
        int b = 1; // Segundo término

        Console.WriteLine("Serie de Fibonacci hasta el décimo término:");

        // Imprimir los primeros dos términos
        Console.WriteLine(a);
        Console.WriteLine(b);

        // Bucle for para calcular e imprimir los siguientes términos
        for (int i = 2; i < terminos; i++)
        {
            int siguiente = a + b; // Calcular el siguiente término
            Console.WriteLine(siguiente); // Imprimir el siguiente término

            // Actualizar los valores de a y b
            a = b;
            b = siguiente;
        }

        // Esperar a que el usuario presione una tecla
        Console.WriteLine("Presiona cualquier tecla para continuar...");
        Console.ReadKey();
    }
}