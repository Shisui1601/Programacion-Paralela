/*
internal class Program
{
    static async Task Main()
    {
         Task task = Task.Factory.StartNew(() =>
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Tarea ejecutándose: {i}");
            }
            /*
             Usar TaskCreationOptions.LongRunning le dice al ThreadPool de .NET que esta tarea debería 
            ejecutarse en un hilo separado, en lugar de en un hilo del grupo de hilos 
            del sistema, para evitar que se agoten los hilos de ese grupo.
            Cuando usarlo: Si una tarea implica cálculos complejos, acceso a recursos 
            Cuando usarlo: Si una tarea implica cálculos complejos, acceso a recursos 
            externos (como bases de datos o servicios web), o cualquier operación que pueda 
            llevar un tiempo considerable, es un buen candidato para usar LongRunning.
             /*
        }, TaskCreationOptions.LongRunning);

        await task; /* asi como usted explico lo del metodo "Task.Factory.StartNew ofrece más control sobre la creación de tareas, permitiendo especificar opciones avanzadas." tambien hay que tener en cuenta que se ejecuta de manera asincronica
         y por ende no espera a que el codigo finalice y debido a eso no puede finalizarse ni la tarea, ni el mismo codigo y la razon de que no se muestre la ultima linea de codigo, es porque el programa finaliza antes de completar la tarea o el mismo codigo.
         pero con el metodo await task, yo le estoy pidienod que espere a que se termine la tarea sin bloquear nada.*/ 

        /*Console.WriteLine("Tarea completada.");
    }
}
*/