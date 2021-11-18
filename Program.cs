using System;

namespace Segundo_Proyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena = "";
            int edad = 0;
            double altura = 0.0;

            Console.WriteLine("Bienvenido al parque extremo ¡¡VENEZUELA!! Por favor ingrese su Edad en años:");
            cadena = Console.ReadLine();
            edad = Convert.ToInt32(cadena);

            if (edad < 18)
            {
                Console.WriteLine("No se permite el acceso a menores de edad por motivos extremos");
            }
            else
            {
                Console.WriteLine("Bienvenido!!");
            
                Console.WriteLine("Por favor ingrese su estatura en metros:");
                cadena = Console.ReadLine();
                altura = Convert.ToDouble(cadena);

                if(altura < 1.5)
                {
                Console.WriteLine("Medio extremo!! Una estatura promedio es necesaria para entrar a algunas atracciones extremas, de todas maneras puedes disfrutar del gusanito. YEAH!");
                }
                else
                {
                Console.WriteLine("EXTREMOOO!!");
                }

            }
            

            
        
        }
    }
}
