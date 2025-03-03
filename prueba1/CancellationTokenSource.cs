/*
using System;
using System.Threading;
using System.Threading.Tasks;

class CarreraTortugas
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("La carrera de tortugas programadoras.");
        Console.WriteLine("Que comience la carrera.");

        // 1. Crear un CancellationTokenSource
        var cts = new CancellationTokenSource();

        // 2. Crear una tarea para cada tortuga usando starnew.

        var tortuga1 = Task.Factory.StartNew(() => AvanzarTortuga("Tortuga Veterana", 6000, cts.Token), cts.Token);
        var tortuga2 = Task.Factory.StartNew(() => AvanzarTortuga("Tortuga Novata", 5000, cts.Token), cts.Token);
        var tortuga3 = Task.Factory.StartNew(() => AvanzarTortuga("Tortuga Genia", 6500, cts.Token), cts.Token);
        var tortuga4 = Task.Factory.StartNew(() => AvanzarTortuga("Tortuga Prodigio", 6500, cts.Token), cts.Token);
        var tortuga5 = Task.Factory.StartNew(() => AvanzarTortuga("Tortuga Estupida", 4000, cts.Token), cts.Token);

        // 4. Permitir que el usuario cancele la carrera de una tortuga presionando una tecla
        Console.WriteLine("\nPresiona 'V', 'N', 'G', 'P' o 'E' para cancelar la participación de una tortuga.");
        Console.WriteLine("Presiona 'C' para cancelar toda la carrera.\n");

        while (!cts.IsCancellationRequested)
        {
            var key = Console.ReadKey(true).Key;

            if (key == ConsoleKey.V || key == ConsoleKey.N || key == ConsoleKey.G || key == ConsoleKey.P || key == ConsoleKey.E)
            {
                Console.WriteLine($"¡Se ha cancelado la participación de la Tortuga {key}!");
                cts.Cancel(); 
                break;
            }
            else if (key == ConsoleKey.C)
            {
                Console.WriteLine("¡Se ha cancelado toda la carrera!");
                cts.Cancel(); 
                break;
            }
        }

        try
        {
            await Task.WhenAll(tortuga1, tortuga2, tortuga3, tortuga4, tortuga5);
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("\nAl menos una tortuga fue descalificada o la carrera fue cancelada.");
        }

        Console.WriteLine("\nPresiona cualquier tecla para salir.");
        Console.ReadKey();
    }

    static void AvanzarTortuga(string nombreTortuga, int tiempoLimite, CancellationToken token)
    {
        try
        {
            Console.WriteLine($"{nombreTortuga} está avanzando...");

            for (int i = 0; i <= 100; i += 20)
            {
                token.ThrowIfCancellationRequested(); 
                Console.WriteLine($"{nombreTortuga} ha avanzado {i}%.");
                Thread.Sleep(tiempoLimite / 5);        
            }

            Console.WriteLine($"{nombreTortuga} ha llegado a la meta.");
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine($"{nombreTortuga} ha sido descalificada.");
        }
    }

}
*/








































































/*
using System;
using System.Threading;
using System.Threading.Tasks;

internal class Program

{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Iniciando descarga...");
        var cts = new CancellationTokenSource();
        var token = cts.Token;
        Console.WriteLine("Presiona cualquier tecla c para cancelar o cualquier otra para salir.");
        var descargaTask = DescargarArchivo("archivo_grande.zip", token);
        var cancelTask = Task.Run(() =>
        {
            Console.WriteLine("Presiona la tecla 'c' para cancelar o cualquier otra para salir.");
            while (true)
            {
                var key = Console.ReadKey().KeyChar;
                if (key == 'c')
                {
                    cts.Cancel();
                    break;
                }
            }
        });

        var completedTask = await Task.WhenAny(descargaTask, cancelTask);
        if (completedTask == cancelTask)
        {
            Console.WriteLine("Cancelando descarga...");
            try
            {
                await descargaTask;
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("Descarga cancelada.");
            }
        }
        else
        {
            Console.WriteLine("Descarga completada.");
        }
    }


    static async Task DescargarArchivo(string nombreArchivo, CancellationToken token)
    {
        // Simular el proceso de descarga
        for (int i = 0; i <= 100; i += 10)
        {
            // Verificar si se ha solicitado la cancelación
            token.ThrowIfCancellationRequested();           
            Console.WriteLine($"Descargando {nombreArchivo}: {i}%");
            await Task.Delay(500, token); // Simular un pequeño retraso en la descarga
        }
    }
}*/