using System;
using System.Threading;
using System.Threading.Tasks;

class Restaurante
{
    static async Task Main()
    {
        var cts = new CancellationTokenSource(); // Permite cancelaciones de tareas

        var orden1 = ProcesarOrdenAsync("Orden 1", cts.Token);
        var orden2 = ProcesarOrdenAsync("Orden 2", cts.Token);
        var orden3 = ProcesarOrdenAsync("Orden 3", cts.Token);

        // Esperar a que la primera orden esté lista
        var primeraLista = await Task.WhenAny(orden1, orden2, orden3);
        Console.WriteLine($" {primeraLista.Id} está lista antes que las demas.");

        // Esperar a que todas las órdenes se completen antes de finalizar
        await Task.WhenAll(orden1, orden2, orden3);
        Console.WriteLine("🍽️ Todas las órdenes han sido entregadas.");
    }

    static async Task ProcesarOrdenAsync(string orden, CancellationToken token)
    {
        try
        {
            Console.WriteLine($"📥 {orden} recibida.");
            await Task.Delay(1000, token); // Simula tiempo de recepción

            await PrepararComidaAsync(orden, token);

            Console.WriteLine($"🚗 {orden} en camino.");
            await Task.Delay(1500, token); // Simula entrega
            Console.WriteLine($"✅ {orden} entregada.");
        }
        catch (OperationCanceledException)
        {
            Random rand = new Random();
            if (rand.Next(1, 101) <= 10) 
            {
                Console.WriteLine($"❌ {orden} cancelada por error.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"⚠️ Error en {orden}: {ex.Message}");
        }
    }

    static Task PrepararComidaAsync(string orden, CancellationToken token)
    {
        return Task.Factory.StartNew(async () =>
        {
            Console.WriteLine($"🍳 {orden} en preparación...");
            var tareasIngredientes = new Task[]
            {
                CocinarIngredienteAsync(orden, "Carne", 2000, token),
                CocinarIngredienteAsync(orden, "Verduras", 1500, token),
                CocinarIngredienteAsync(orden, "Salsa", 1000, token)
            };

            await Task.WhenAll(tareasIngredientes);
            Console.WriteLine($"🔥 {orden} comida lista.");
        }, token, TaskCreationOptions.AttachedToParent, TaskScheduler.Default).Unwrap();
    }

    static async Task CocinarIngredienteAsync(string orden, string ingrediente, int tiempo, CancellationToken token)
    {
        Random rand = new Random();
        Console.WriteLine($"🔪 Preparando {ingrediente} para {orden}...");
        await Task.Delay(tiempo, token);


        if (rand.Next(1, 101) <= 5)
        {
            Console.WriteLine($"⚠️ Error crítico en {ingrediente} de {orden}. Cancelando orden...");
            throw new OperationCanceledException($"Orden cancelada por fallo en {ingrediente}.");
        }

        Console.WriteLine($"✅ {ingrediente} listo para {orden}.");
    }
}
