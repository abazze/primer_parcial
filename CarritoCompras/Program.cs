using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarritoCompras
{
    class Program
    {
        //Varibles globales para el sistema
        static int cantidadCamisas = 0;
        static float precioSinDesc = 0.0f;
        static float precioConDesc = 0.0f;
        static float descuento     = 0.0f;
        static float total         = 0.0f;

        static void Main(string[] args)
        {
            menu();

            //Console.ReadKey();
        }

        public static void menu()
        {
            int opcion;

            do {
                Console.Clear();
                Console.WriteLine(" Camisas PRADBIT - Ventas minoristas y mayoristas");
                Console.WriteLine(" ----------------------------------------------------------------");
                Console.WriteLine(" MENÚ PRINCIPAL:");
                Console.WriteLine(" 1- Añadir camisa al carro de compras");
                Console.WriteLine(" 2- Eliminar camisa del carro de compras");
                Console.WriteLine(" 3- Salir");
                Console.WriteLine(" ----------------------------------------------------------------");
                Console.WriteLine("        -  Cantidad de camisas en el carro de compras: {0}", cantidadCamisas);
                Console.WriteLine("        -  Precio unitario: $1000");
                Console.WriteLine("        -  Precio total sin descuento: ${0}", precioSinDesc);
                Console.WriteLine("        -  Tipo de descuento: %{0}", descuento);
                Console.WriteLine("        -  Precio final con descuento: ${0}", precioConDesc);
                Console.WriteLine();
                Console.WriteLine(" ----------------------------------------------------------------");
                Console.Write(" Ingrese una opción del menú: ");
                try
                {
                    opcion = Convert.ToInt32(Console.ReadLine());

                    if (opcion < 1 || opcion > 3)
                        opcion = 0;
                }
                catch(Exception ex)
                {
                    Console.Write("La opción ingresada es incorrecta. Por favor presione una tecla para intentarlo nuevamente...");
                    opcion = 0;
                }
            } while (opcion == 0);

            switch (opcion)
            {
                case 1:
                    agregar();
                    break;
                case 2:
                    eliminar();
                    break;
                case 3:
                    salir();
                    break;
            }
        }

        public static void agregar()
        {
            int cantidad;

            do
            {
                Console.Clear();
                Console.Write("Cantidad de camisas a agregar: ");
                try
                {
                    cantidad = Convert.ToInt32(Console.ReadLine());

                    if (cantidad < 1)
                        cantidad = 0;
                }
                catch (Exception ex)
                {
                    Console.Write("La opción ingresada es incorrecta. Por favor presione una tecla para intentarlo nuevamente...");
                    cantidad = 0;
                }
            } while (cantidad == 0);

            cantidadCamisas += cantidad;

            calcular();
        }

        public static void eliminar()
        {
            int cantidad;

            do
            {
                Console.Clear();
                Console.Write("Cantidad de camisas a eliminar: ");
                try
                {
                    cantidad = Convert.ToInt32(Console.ReadLine());

                    if (cantidad < 1 || cantidad > cantidadCamisas)
                    {
                       cantidad = 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.Write("La opción ingresada es incorrecta. Por favor presione una tecla para intentarlo nuevamente...");
                    cantidad = 0;
                }
            } while (cantidad == 0);

            cantidadCamisas -= cantidad;

            calcular();
        }

        public static void calcular()
        {
            if (cantidadCamisas >= 3 && cantidadCamisas <= 5)
            {
                descuento = 10;
                precioSinDesc = cantidadCamisas * 1000;
                precioConDesc = Convert.ToSingle((precioSinDesc) - cantidadCamisas * 1000 * 0.1);
                total = precioConDesc;
            }
            else if (cantidadCamisas > 5)
            {
                descuento = 20;
                precioSinDesc = cantidadCamisas * 1000;
                precioConDesc = Convert.ToSingle((precioSinDesc) - cantidadCamisas * 1000 * 0.2);
                total = precioConDesc;
            }
            else
            {
                descuento = 0;
                precioSinDesc = cantidadCamisas * 1000;
                precioConDesc = precioSinDesc;
                total = precioSinDesc;
            }

            menu();
        }

        public static void salir()
        {
            string valor = string.Empty;
            do
            {
                Console.Clear();
                Console.Write("¿Está seguro que desea salir?(Presione Y o N): ");
                valor = Console.ReadLine();
                valor = valor.ToLower();
            } while (valor != "y" && valor != "n");

            if (valor == "n")
                menu();

            Console.Write("Presione una tecla para salir...");
        }
    }
}
