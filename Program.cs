using System;

class Program
{
    static void Main()
    {
        const int MaxTamC = 10;
        int[] A = new int[MaxTamC];
        int frente = 0, final = 0;
        int contador = 0;

        //Inicializar la cola
        frente = 0;
        final = 0;

        Console.Write("¿Desea agregar elementos a la cola? (s/n): ");
        char respuesta = Console.ReadKey().KeyChar;

        while ((respuesta == 's' || respuesta == 'S') && contador < 10)
        {
            if ((final + 1) % MaxTamC == frente)
            {
                Console.WriteLine("\nDesbordamiento de la cola");
                return;
            }

            Console.Write("\nIngrese un elemento para la cola: ");
            int elemento = Convert.ToInt32(Console.ReadLine());

            final = (final + 1) % MaxTamC;
            A[final] = elemento;

            contador++;
            Console.WriteLine("Elemento " + contador + "agregado a la cola: " + elemento);

            if (contador < 10)
            {
                Console.Write("¿Desea agregar más elementos a la cola? (s/n): ");
                respuesta = Console.ReadKey().KeyChar;
            }
        }

        //Validar si la cola está vacía
        if (frente == final)
        {
            Console.WriteLine("La cola está vacía.");
            return;
        }

        //Obtener el primer elemento de la cola
        int primerElemento = A[(frente + 1) % MaxTamC];
        Console.WriteLine("El primer elemento de la cola es: " + primerElemento);

        // Eliminar un elemento de la cola
        frente = (frente + 1) % MaxTamC;

        //Imprimir elementos de la cola en el orden en que fueran ingresados
        Console.WriteLine("Elementos de la cola en el orden de ingreso:");
        for (int i = frente + 1; i <= final; i = (i + 1) % MaxTamC)
        {
            Console.Write(A[i] + " ");
        }
        Console.WriteLine();
    }
}