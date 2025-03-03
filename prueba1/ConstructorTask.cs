/*using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Task<int> task1 = new Task<int>(() =>
        {
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum += i * i;
            }
            Console.WriteLine("Resultado de Task 1 (Suma de cuadrados): " + sum);
            return sum;
        });

        Task<int> task2 = new Task<int>(() =>
        {
            int sum = 0;
            for (int i = 1; i <= 50; i++)
            {
                sum += i * i * i;
            }
            Console.WriteLine("Resultado de Task 2 (Suma de cubos): " + sum);
            return sum;
        });

        task1.Start();
        task2.Start();

        Task.WaitAll(task1, task2);

        int resultadoFinal = task1.Result + task2.Result;

        Console.WriteLine("Resultado final (Suma de Task 1 y Task 2): " + resultadoFinal);

        Console.WriteLine("Todas las tareas han sido completadas.");
    }
}
*/