using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignoZodiacal
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            Aries - Marzo 21 –Abril 19 
            Tauro - Abril 20 – Mayo 20
            Géminis - Mayo 21 – Junio 20
            Cáncer - Junio 21 – Julio 22
            Leo - Julio 23–Agosto 22
            Virgo - Agosto 23 – Septiembre 22
            Libra - Septiembre 23 – Octubre 22
            Escorpio - Octubre 23 – Noviembre 21
            Sagitario - Noviembre 22 – Diciembre 21
            Capricornio - Diciembre 22 – Enero 19
            Acuario - Enero 20 – Febrero 18
            Piscis - Febrero 19 – Marzo 20 
            */

            int dia, mes;
            string linea;

            Console.WriteLine("Ingresa (con 2 digitos) tu día de nacimiento");
            linea = Console.ReadLine();
            dia = int.Parse(linea);
            Console.WriteLine("Ingresa (con 2 digitos) tu mes de nacimiento");
            linea = Console.ReadLine();
            mes = int.Parse(linea);

            if (mes == 03)
            {
                if(dia >= 21)
                {
                    Console.WriteLine("Aries");
                }
                else
                {
                    Console.WriteLine("Piscis");
                }
            }

            if (mes == 04)
            {
                if(dia >= 20)
                {
                    Console.WriteLine("Tauro");
                }
                else
                {
                    Console.WriteLine("Aries");
                }
            }
            if (mes == 05)
            {
                if (dia >= 21)
                {
                    Console.WriteLine("Géminis");
                }
                else
                {
                    Console.WriteLine("Tauro");
                }
            }

            if (mes == 06)
            {
                if (dia >= 21)
                {
                    Console.WriteLine("Cáncer");
                }
                else
                {
                    Console.WriteLine("Géminis");
                }
            }
            if (mes == 07)
            {
                if (dia >= 23)
                {
                    Console.WriteLine("Leo");
                }
                else
                {
                    Console.WriteLine("Cáncer");
                }
            }

            if (mes == 08)
            {
                if (dia >= 23)
                {
                    Console.WriteLine("Virgo");
                }
                else
                {
                    Console.WriteLine("Leo");
                }
            }
            if (mes == 09)
            {
                if (dia >= 23)
                {
                    Console.WriteLine("Libra");
                }
                else
                {
                    Console.WriteLine("Virgo");
                }
            }

            if (mes == 10)
            {
                if (dia >= 23)
                {
                    Console.WriteLine("Escorpio");
                }
                else
                {
                    Console.WriteLine("Libra");
                }
            }
            if (mes == 11)
            {
                if (dia >= 22)
                {
                    Console.WriteLine("Sagitario");
                }
                else
                {
                    Console.WriteLine("Escorpio");
                }
            }

            if (mes == 12)
            {
                if (dia >= 22)
                {
                    Console.WriteLine("Capricornio");
                }
                else
                {
                    Console.WriteLine("Sagitario");
                }
            }
            if (mes == 01)
            {
                if (dia >= 20)
                {
                    Console.WriteLine("Acuario");
                }
                else
                {
                    Console.WriteLine("Capricornio");
                }
            }
            if (mes == 02)
            {
                if (dia >= 19)
                {
                    Console.WriteLine("Piscis");
                }
                else
                {
                    Console.WriteLine("Acuario");
                }
            }


            Console.ReadKey();

            
        }
             
             

           
    }
}
