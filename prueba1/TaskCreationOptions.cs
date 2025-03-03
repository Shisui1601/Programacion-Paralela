
/*using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Task chefTask = Task.Factory.StartNew(() =>
        {
            Console.WriteLine("Chef comienza la preparación del plato.");

            Task.Factory.StartNew(() =>
            {
                Console.WriteLine("Tarea: Cortar las verduras iniciada.");
                Task.Delay(1000).Wait(); 
                Console.WriteLine("Tarea: Cortar las verduras completada.");
            }, TaskCreationOptions.AttachedToParent);

            Task.Factory.StartNew(() =>
            {
                Console.WriteLine("Tarea: Cocinar la pasta iniciada.");
                Task.Delay(2000).Wait(); 
                Console.WriteLine("Tarea: Cocinar la pasta completada.");
            }, TaskCreationOptions.AttachedToParent);

            Task.Factory.StartNew(() =>
            {
                Console.WriteLine("Tarea: Preparar la salsa iniciada.");
                Task.Delay(1500).Wait(); 
                Console.WriteLine("Tarea: Preparar la salsa completada.");
            }, TaskCreationOptions.AttachedToParent);

            Task.Factory.StartNew(() =>
            {
                Console.WriteLine("Tarea: Hacer el emplatado iniciada.");
                Task.Delay(500).Wait(); 
                Console.WriteLine("Tarea: Hacer el emplatado completada.");
            });
        });

        await chefTask;

        Console.WriteLine("Chef completó la preparación del plato.");
    }
}
*/
