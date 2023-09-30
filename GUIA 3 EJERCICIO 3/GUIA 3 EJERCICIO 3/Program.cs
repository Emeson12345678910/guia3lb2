using System;

class Program
{
    static void Main()
    {
      
        Console.Write("Por favor, ingresa tu fecha de cumpleaños  ");
        string Usuario = Console.ReadLine();

        if (DateTime.TryParse(Usuario, out DateTime fecha_Cumpleaños))
        {
         
            DateTime fechaActual = DateTime.Now;

           
            DateTime dias_faltantes = new DateTime(fechaActual.Year, fecha_Cumpleaños.Month, fecha_Cumpleaños.Day);

            if (dias_faltantes < fechaActual)
            {
                dias_faltantes = dias_faltantes.AddYears(1);
            }

            TimeSpan tiempoRestante = dias_faltantes - fechaActual;
            int diasRestantes = tiempoRestante.Days;

            Console.WriteLine($"Tu próximo cumpleaños es el {dias_faltantes.ToString("MM/dd/yyyy")}");
            Console.WriteLine($"Faltan {diasRestantes}  para próximo cumpleaños.");
        }
        else
        {
            Console.WriteLine("fecha incorrecta Por favor, ingresa la fecha en el formato correcto (MM/DD/YYYY) EJEMPLO 27/07/2027.");
        }
    }
}
