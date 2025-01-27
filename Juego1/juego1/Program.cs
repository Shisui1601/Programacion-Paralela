using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("\n*** Bienvenido a la Simulación de Carrera ***\n");

        List<Vehicle> vehicles = new List<Vehicle>
        {
            new Vehicle("Coche Rojo", 5, 15),
            new Vehicle("Robot Azul", 6, 10),
            new Vehicle("Moto Verde", 7, 20)
        };

        Console.WriteLine("Participantes:");
        foreach (var v in vehicles)
        {
            Console.WriteLine($"- {v.Name} (Velocidad: {v.Speed}, Probabilidad de Boost: {v.BoostChance}%)");
        }

        Console.WriteLine("\nPresiona Enter para iniciar la carrera...");
        Console.ReadLine();

        await RunRaceAsync(vehicles);

        Console.WriteLine("\n¡Gracias por jugar!\n");
    }

    static async Task RunRaceAsync(List<Vehicle> vehicles)
    {
        int raceDistance = 100; 
        List<Task<Vehicle>> raceTasks = new List<Task<Vehicle>>();

        foreach (var vehicle in vehicles)
        {
            raceTasks.Add(StartVehicleRace(vehicle, raceDistance));
        }

        Console.WriteLine("La carrera ha comenzado...\n");


        while (raceTasks.Any())
        {
            var finishedTask = await Task.WhenAny(raceTasks);
            var winner = await finishedTask;

            Console.WriteLine($"{winner.Name} ha terminado en el lugar #{vehicles.Count - raceTasks.Count + 1}!");

            raceTasks.Remove(finishedTask);
        }
    }

    static async Task<Vehicle> StartVehicleRace(Vehicle vehicle, int raceDistance)
    {
        Random random = new Random();

        while (vehicle.DistanceCovered < raceDistance)
        {

            await Task.Delay(500); 


            if (random.Next(100) < vehicle.BoostChance)
            {
                vehicle.DistanceCovered += vehicle.Speed * 2; 
                Console.WriteLine($"{vehicle.Name} usa Boost y avanza rápidamente! (Distancia: {vehicle.DistanceCovered})");
            }
            else
            {
                vehicle.DistanceCovered += vehicle.Speed; 
                Console.WriteLine($"{vehicle.Name} avanza. (Distancia: {vehicle.DistanceCovered})");
            }
        }

        return vehicle;
    }
}

class Vehicle
{
    public string Name { get; }
    public int Speed { get; } 
    public int BoostChance { get; } 
    public int DistanceCovered { get; set; }

    public Vehicle(string name, int speed, int boostChance)
    {
        Name = name;
        Speed = speed;
        BoostChance = boostChance;
        DistanceCovered = 0;
    }
}
