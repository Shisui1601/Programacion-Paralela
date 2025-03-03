/*using System;
using System.Threading.Tasks;

namespace Task_Run
{
    class Program
    {
        static async Task Main()
        {
            Console.WriteLine("Tarea iniciada.");

          
            long result = await Task.Run(() =>
            {
                long sum = 0;
                Console.WriteLine("Iniciando tarea...");
                for (long i = 0; i < 1_000_000_000; i++)
                {
                    sum += i * 2;
                }
                Console.WriteLine("Cálculos completados dentro de la tarea.");
                return sum; 
            });

            // Resultado obtenido desde el hilo principal
            Console.WriteLine($"Resultado de la suma: {result}");
            Console.WriteLine("Tarea completada.");
        }
    }
}*/
