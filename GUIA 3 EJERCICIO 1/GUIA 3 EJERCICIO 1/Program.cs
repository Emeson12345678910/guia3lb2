using System;

class Ejercicio1
{
    static void Main()
    {

        int[] years = new int[10] { 2012, 2013, 2014, 2015, 2016, 2017, 2018, 2019, 2020, 2021 };

        foreach (int year in years)
        {
            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine($"El año {year} ES BISIESTO.");
            }
            else
            {
                Console.WriteLine($"El año {year} NO ES BISIESTO. ");
            }
        }

    }
}
