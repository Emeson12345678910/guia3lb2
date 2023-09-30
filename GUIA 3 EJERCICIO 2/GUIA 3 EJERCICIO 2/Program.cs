using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        double prestamo = 3000; 
        int plazo = 6;    
        DateTime fechaInicio = DateTime.Now; 

        double cuota_Mensual = prestamo / plazo;

 
        Console.WriteLine($"Monto del préstamo: ${prestamo}");
        Console.WriteLine($"Plazo en meses: {plazo} meses");
        Console.WriteLine($"Cuota mensual: ${cuota_Mensual:F2}");
        Console.WriteLine("Fechas de pago futuras:");

        //FORMULA
        for (int i = 1; i <= plazo; i++)
        {
            DateTime fechacancelar = fechaInicio.AddMonths(i);
            Console.WriteLine($"Cuota {i}: {fechacancelar.ToString("dd-MM-yyyy")}, Cuota a pagar: ${cuota_Mensual: Pague tacaño}");
        }
    }
}
