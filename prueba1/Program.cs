
/*
using System;
using System.Threading.Tasks;

public class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Iniciando Main");
        await Operacion1();
        Console.WriteLine("Finalizando Main");
        Console.ReadLine();
    }
    
    private async static Task Operacion1()
    {
        Console.WriteLine("Iniciando Operacion1");
        var task1 =  Task.Run (()=> SumarHasta(1, 250000));//Cargar imágenes
        var task2 =  Task.Run (() => SumarHasta(250001, 500000));//Procesar cálculos
        var task3 =  Task.Factory.ContinueWhenAll([task1, task2], task=> SumarHasta(500001, 750000));//Procesar cálculos
        var task4 =  Task.Factory.ContinueWhenAll([task1,task2, task3],task=> SumarHasta(7500, 1000));//Procesar cálculos
    
        //int[] result = await Task.WhenAll(task1, task2);
    
        Console.WriteLine($"Finalizando Operacion1");
    }
    
    private async static Task<long> SumarHasta(int desde, int hasta)
    {
        return await Task.Run(() =>
        {
            Console.WriteLine($"Iniciando suma desde {desde} hasta {hasta}");
            long total = 0;
            for (int i = desde; i <= hasta; i++)
            {
                total += i;
            }
            Task.Delay(200);
            Console.WriteLine($"Terminando suma desde {desde} hasta {hasta}");
            return total;
        });
    }
}
*/


/*
{
    public static async Task Main(string[] args)
    {
        Console.WriteLine("Iniciando Main");
        await Operacion1();
        Console.WriteLine("Finalizando Main");
        Console.ReadLine();
    }

    private static async Task Operacion1()
    {
        Console.WriteLine("Iniciando Operacion1");
        var task1 = SumarHasta(1, 250000); // Cargar imágenes
        var task2 = SumarHasta(250001, 500000); // Procesar cálculos
      
        await Task.WhenAny(task1, task2);

        var task3 = SumarHasta(500001, 750000); // Procesar cálculos
        var task4 = SumarHasta(750001, 1000000); // Procesar cálculos

      
        await Task.WhenAll(task3, task4);

        Console.WriteLine("Finalizando Operacion1");
    }

    private static async Task<long> SumarHasta(int desde, int hasta)
    {
        return await Task.Run(() =>
        {
            Console.WriteLine($"Iniciando suma desde {desde} hasta {hasta}");
            long total = 0;
            for (int i = desde; i <= hasta; i++)
            {
                total += i;
            }

            Task.Delay(200);
            Console.WriteLine($"Terminando suma desde {desde} hasta {hasta}");
            return total;
        });
    }
}
*/


/*
using System;
using System.Threading.Tasks;

public class Program
{
    public static async Task Main(string[] args)
    {
        Console.WriteLine("Iniciando Main");
        await Operacion1();
        Console.WriteLine("Finalizando Main");
        Console.ReadLine();
    }

    private static async Task Operacion1()
    {
        Console.WriteLine("Iniciando Operacion1");
        var task1 = SumarHasta(1, 250000); // Cargar imágenes
        var task2 = SumarHasta(250001, 500000); // Procesar cálculos

        await Task.WhenAll(task1, task2);

        var task3 = SumarHasta(500001, 750000); // Procesar cálculos
        var task4 = SumarHasta(750001, 1000000); // Procesar cálculos

        await Task.WhenAll(task3, task4);

        Console.WriteLine("Finalizando Operacion1");
    }

    private static async Task<long> SumarHasta(int desde, int hasta)
    {
        return await Task.Run(() =>
        {
            Console.WriteLine($"Iniciando suma desde {desde} hasta {hasta}");
            long total = 0;
            for (int i = desde; i <= hasta; i++)
            {
                total += i;
            }

            Task.Delay(200)
            Console.WriteLine($"Terminando suma desde {desde} hasta {hasta}");
            return total;
        });
    }
}
*/

/*
static async Task Main(string[] args)
  {
      Console.WriteLine("Iniciando Main");
      await Operacion1();
      Console.WriteLine("Finalizando Main");
      Console.ReadLine();
  }
 
  private async static Task Operacion1()
  {
      Console.WriteLine("Iniciando Operacion1");
      var task1 =  SumarHasta(1, 250000);//Cargar imágenes
      var task2 =  SumarHasta(250001, 500000);//Procesar cálculos
      var task3 =  Task.Factory.ContinueWhenAll([task1, task2], task=> SumarHasta(500001, 750000));//Procesar cálculos
      var task4 =  Task.Factory.ContinueWhenAll([task1,task2, task3],task=> SumarHasta(7500, 1000));//Procesar cálculos
 
      //int[] result = await Task.WhenAll(task1, task2);
 
      Console.WriteLine($"Finalizando Operacion1");
  }
 
  private async static Task<long> SumarHasta(int desde, int hasta)
  {
     return await Task.Run(() =>
      {
          Console.WriteLine($"Iniciando suma desde {desde} hasta {hasta}");
          long total = 0;
          for (int i = desde; i <= hasta; i++)
          {
              total += i;
          }
          Task.Delay(200);
          Console.WriteLine($"Terminando suma desde {desde} hasta {hasta}");
          return total;
      });
  }
  */