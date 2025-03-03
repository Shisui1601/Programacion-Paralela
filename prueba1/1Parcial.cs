/*
using System;
using System.Collections.Generic;
using System.Threading;

class Motoconchista
{
    public string Nombre { get; set; }
    public int Distancia { get; set; } = 0;
    public bool Cancelado { get; set; } = false;

    private Random CrearRandom()
    {
        return new Random(Guid.NewGuid().GetHashCode()); 
    }

    public void Acelerar()
    {
        Random rnd = CrearRandom();
        int avance = rnd.Next(15, 41);
        if (rnd.NextDouble() < 0.1)
        {
            Console.WriteLine($"{Nombre} cayó en un hoyo y pierde 20 metros.");
            avance -= 20;
        }
        Distancia += Math.Max(avance, 0);
    }

    public void HacerZiczac()
    {
        Random rnd = CrearRandom();
        int avance = rnd.Next(10, 31);
        if (rnd.NextDouble() < 0.05)
        {
            Console.WriteLine($"{Nombre} chocó con otro motoconcho y pierde 20 metros.");
            avance -= 20;
        }
        Distancia += Math.Max(avance, 0);
    }

    public void EvadirAmet()
    {
        Random rnd = CrearRandom();
        if (rnd.NextDouble() < 0.5)
        {
            Console.WriteLine($"{Nombre} evadió al Amet sin problemas.");
        }
        else
        {
            Console.WriteLine($"{Nombre} fue detenido por un Amet y pierde 2 segundos.");
        }
    }

    public void LidiarConPasajero()
    {
        Random rnd = CrearRandom();
        if (rnd.NextDouble() < 0.3)
        {
            Console.WriteLine($"{Nombre} perdió al pasajero y pierde 6 segundos.");
        }
        else
        {
            Console.WriteLine($"{Nombre} sigue con su pasajero y avanza 20 metros.");
            Distancia += 20;
        }
    }

    public void VerificarCancelacion()
    {
        Random rnd = CrearRandom();
        if (rnd.NextDouble() < 0.1)
        {
            Console.WriteLine($"{Nombre} fue cancelado por robarse el motor o el dinero.");
            Cancelado = true;
        }
    }
}

class Program
{
    static void Main()
    {
        List<Motoconchista> motoconchos = new List<Motoconchista>
        {
            new Motoconchista { Nombre = "1" },
            new Motoconchista { Nombre = "2" },
            new Motoconchista { Nombre = "3" },
            new Motoconchista { Nombre = "4" }
        };

       
        bool carreraTerminada = false;
        while (!carreraTerminada)
        {
            
            var activos = motoconchos.Where(m => !m.Cancelado).ToList();

      
            if (!activos.Any())
            {
                Console.WriteLine("Todos los motoconchistas han sido cancelados. La carrera ha terminado.");
                break;
            }

            foreach (var moto in motoconchos)
            {

                moto.VerificarCancelacion();
                if (moto.Cancelado) continue;

                Random rnd = new Random(Guid.NewGuid().GetHashCode());
                int accion = rnd.Next(1, 5);
                switch (accion)
                {
                    case 1: moto.Acelerar(); break;
                    case 2: moto.HacerZiczac(); break;
                    case 3: moto.EvadirAmet(); break;
                    case 4: moto.LidiarConPasajero(); break;
                }

                Console.WriteLine($"{moto.Nombre} ha recorrido {moto.Distancia} metros.");
                if (moto.Distancia >= 500)
                {
                    Console.WriteLine($"{moto.Nombre} ha ganado la carrera!");
                    carreraTerminada = true;
                    break;
                }
            }
            Console.WriteLine("\n--- Siguiente turno ---\n");
            Thread.Sleep(500);
        }
    }
}
*/