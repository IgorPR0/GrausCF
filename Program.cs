using System;

namespace GrausFC
{
    class Program
    {
        static void Main(string[] args)
        {
            double Fahren;
            double Celsius = 97;

           Console.Write("Digite o valor: ");
           Fahren = double.Parse(Console.ReadLine()); 
           Celsius = (Fahren - 32) /1.8;
           Console.WriteLine("Sua conversão de Fahren para Celsius é: {0}", Math.Round(Celsius,2)  );
 

        }
    }
}
