﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Random r = new Random();
            int aleatorio = r.Next(1, 7);
            Console.WriteLine("Indica el numero que creas: ");
            //1er intento
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero == aleatorio)
                Console.WriteLine("Correcto, has acertado el numero");
            else
            {
                if (numero < aleatorio)
                    Console.WriteLine("Prueba un numero mas alto");
                if (numero > aleatorio)
                    Console.WriteLine("Prueba un numero mas bajo");
                //2do intento
                Console.WriteLine("Indica el numero que creas: ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero < aleatorio)
                    Console.WriteLine("Prueba un numero mas alto");
                if (numero > aleatorio)
                    Console.WriteLine("Prueba un numero mas bajo");
                Console.WriteLine("Indica el numero que creas: ");
                numero = Convert.ToInt32(Console.ReadLine());
  
             

                    if (numero == aleatorio)
                        Console.WriteLine("Correcto, has acertado el numero");
                    else
                    {
                        if (numero < aleatorio)
                            Console.WriteLine("Prueba un numero mas alto");
                        if (numero > aleatorio)
                            Console.WriteLine("Prueba un numero mas bajo");
                        Console.WriteLine("Indica el numero que creas: ");
                        numero = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Indica el numero que creas: ");
                        numero = Convert.ToInt32(Console.ReadLine());
                        if (numero == aleatorio)
                            Console.WriteLine("Correcto, has acertado el numero");
                        else
                        {
                        Console.WriteLine("No has acertado, era {0}", aleatorio);
                        Console.ReadKey();
                        }


                    }


                }
            }

        }
    }

