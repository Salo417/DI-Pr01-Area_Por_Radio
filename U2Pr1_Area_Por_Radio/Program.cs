using System;

namespace U2Pr1_Area_Por_Radio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radio = 0.0f;
            const double PI = 3.14f;
            double area = 0.0f;
            
            Console.Write("Escriba el radio de tu círculo, te calcularemos el área: ");
            radio = double.Parse( Console.ReadLine() );
            area = PI * Math.Pow(radio, 2.0);


            //Console.WriteLine( "El área del del circulo de radio " + radio + " es " + (3.14 * Math.Pow(radio, 2)) );
            
            Console.WriteLine($"El área del del circulo de radio {radio} es {area}");
        }
    }
}
