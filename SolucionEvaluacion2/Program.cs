using System;
using System.Collections.Generic;

namespace SolucionEvaluacion2
{
    class Program
    {
        static void Main(string[] args)
        {
            Entrada e1 = new Entrada("Normal", 1000, 50);
            Entrada e2 = new Entrada("VIP", 5000, 15);
            Entrada e3 = new Entrada("Socios", 3500, 10);
            Entrada nuevaEntrada = new Entrada("Tercera Edad", 800, 10);

            List<Entrada> listaEntradas = new List<Entrada>();

            listaEntradas.Add(e1);
            listaEntradas.Add(e2);
            listaEntradas.Add(e3);
            listaEntradas.Add(nuevaEntrada);

            List<Venta> listaVentas = new List<Venta>();
            List<Persona> listaPersonas = new List<Persona>();

            Dictionary<string, string> listaPersonas2 = new Dictionary<string, string>();
            listaPersonas2.Add("111111111", "John Doe");

            Console.WriteLine(listaPersonas2["111111111"]);

            int opcion = -1;
            while(opcion != 0)
            {
                Console.WriteLine("MENU");
                Console.WriteLine("1.-Listar Entradas Disponibles");
                Console.WriteLine("2.-Vender Entradas");
                Console.WriteLine("3.-Listar Ventas");
                Console.WriteLine("4.-Dinero Recaudado");
                Console.WriteLine("5.-Registrar Persona");
                Console.WriteLine("6.-Listar Persona");
                Console.WriteLine("7.-Listar Persona por Diccionario");
                Console.WriteLine("0.-Salir");
                Console.WriteLine("===");
                Console.Write("Opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("LISTA DE ENTRADAS");
                        Console.WriteLine("=================");
                        for(int i = 0; i < listaEntradas.Count ; i++)
                        {
                            Console.WriteLine("*****");
                            Console.WriteLine("Entrada {0}", listaEntradas[i].Nombre);
                            Console.WriteLine("Precio ${0}", listaEntradas[i].Precio);
                            Console.WriteLine("Entradas disponibles: {0}", listaEntradas[i].Stock);
                            Console.WriteLine("*****");
                        }
                        break;
                    case 2:
                        int opcionEntrada = -1;
                        int cantidadEntradas;
                        Console.WriteLine("LISTA DE ENTRADAS EN VENTA");
                        Console.WriteLine("=================");
                        for (int i = 0; i < listaEntradas.Count; i++)
                        {
                            Console.WriteLine($"{i+1}.-{listaEntradas[i].Nombre}[{listaEntradas[i].Stock}]");
                        }
                        Console.WriteLine("===");
                        Console.Write("Entrada N°: ");
                        opcionEntrada = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        Console.Write("Cantidad de entradas: ");
                        cantidadEntradas = Convert.ToInt32(Console.ReadLine());

                        Entrada entradaActual = listaEntradas[opcionEntrada - 1];

                        entradaActual.Stock = entradaActual.Stock - cantidadEntradas;

                        Venta ventaActual = new Venta(entradaActual, cantidadEntradas, entradaActual.Precio * cantidadEntradas);

                        listaVentas.Add(ventaActual);

                        Console.WriteLine("{0} entradas vendidas", cantidadEntradas);
                        break;
                    case 3:
                        Console.WriteLine("LISTA DE VENTAS");
                        foreach (Venta item in listaVentas)
                        {
                            Console.WriteLine("===========");
                            Console.WriteLine("Se ha vendido {0} entradas {1}. Dinero total: ${2}", item.Cantidad, item.Ticket.Nombre, item.DineroTotal);
                        }
                        break;
                    case 4:
                        int recaudacion = 0;
                        foreach(Venta venta in listaVentas)
                        {
                            recaudacion = recaudacion + venta.DineroTotal;
                        }
                        Console.WriteLine("El dinero recaudado en la venta de entradas es: {0}", recaudacion);
                        break;
                    case 5:
                        Console.WriteLine("NUEVO REGISTRO DE PERSONA");
                        Console.Write("Ingrese un rut (Sin guión y con dígito verificador): ");
                        string rutActual = Console.ReadLine();
                        //bool existe = false;
                        /*
                                                foreach(Persona personaActual in listaPersonas)
                                                {
                                                    if(personaActual.Rut == rutActual)
                                                    {
                                                        existe = true;
                                                    }
                                                }
                        */

                        if (listaPersonas2.ContainsKey(rutActual))
                        {
                            Console.WriteLine("Esta persona ya se encuentra registrada...");
                        }
                        else
                        {
                            Console.Write("Ingrese nombre: ");
                            string nombreActual = Console.ReadLine();
                            Persona nuevaPersona = new Persona(nombreActual, rutActual);
                            listaPersonas.Add(nuevaPersona);
                            //clave (key) rut , valor (value) nombre
                            listaPersonas2.Add(rutActual, nombreActual);
                            Console.WriteLine("Persona registrada!");
                        }

                        //si la persona existe la variable "existe" será true(verdadero)
                        //si la persona no existe, la variable "existe se mantendrá como estaba originalmente false(falso)
                        /*
                        if (existe)
                        {
                            Console.WriteLine("Esta persona ya se encuentra registrada...");
                        }
                        else
                        {
                            Console.Write("Ingrese nombre: ");
                            string nombreActual = Console.ReadLine();
                            Persona nuevaPersona = new Persona(nombreActual, rutActual);
                            listaPersonas.Add(nuevaPersona);
                            //clave (key) rut , valor (value) nombre
                            listaPersonas2.Add(rutActual, nombreActual);
                            Console.WriteLine("Persona registrada!");
                        }
                        */
                        break;
                    case 6:
                        Console.WriteLine("Lista de Personas Registradas");
                        Console.WriteLine("*****************");
                        for(int i = 0; i < listaPersonas.Count; i++)
                        {
                            Console.WriteLine("{0}.-{1}[{2}]", i+1, listaPersonas[i].Nombre, listaPersonas[i].Rut);
                        }
                        Console.WriteLine("*****************");
                        break;
                    case 7:
                        Console.WriteLine("Lista de Personas Registradas");
                        Console.WriteLine("*****************");
                        foreach(var persona in listaPersonas2)
                        {
                            Console.WriteLine(persona.Key +" - "+ persona.Value);
                        }
                        Console.WriteLine("*****************");
                        break;
                }
            }
            Console.WriteLine("Saliendo del programa...");
        }
    }
}
