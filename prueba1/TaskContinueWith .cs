/*using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Task mainTask = Task.Factory.StartNew(async () =>
        {
            Console.WriteLine("Tarea principal ejecutándose.");
            await Task.Delay(1000); 
            Console.WriteLine("Tarea principal terminada.");
        }).Unwrap();

        // Tarea hermana
        Task siblingTask = mainTask.ContinueWith(t =>
        {
            Console.WriteLine("Tarea hermana ejecutándose.");
        });

        // continuación 1
        await mainTask.ContinueWith(t =>
        {
            Console.WriteLine("Tarea1 de continuación ejecutándose.");
        });

        // continuación 2
        await mainTask.ContinueWith(t =>
        {
            Console.WriteLine("Tarea2 de continuación ejecutándose.");
        }, TaskContinuationOptions.OnlyOnRanToCompletion);

        // Nueva tarea de continuación
        await siblingTask.ContinueWith(t =>
        {
            Console.WriteLine("Nueva tarea de continuación ejecutándose después de la tarea hermana.");
        });

        await siblingTask;
        Console.WriteLine("Todas las tareas han finalizado.");
    }
}
*/