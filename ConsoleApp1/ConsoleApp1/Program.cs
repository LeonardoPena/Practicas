using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string seleccion = "";
            do {
                Console.Clear();
                Console.WriteLine("Escriba algun ejercicio");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("1---Metodo Hola estudiante");
                Console.WriteLine("2---Numeros del 1 al 50");
                Console.WriteLine("3---Adivinar el unmero entre 1 y 100");
                Console.WriteLine("4---Vehiculo");
                Console.WriteLine("5---Ver Producto y Cambiar nombre");
                Console.WriteLine("6---[SALIR]");

                seleccion = Console.ReadLine();

                switch (seleccion)
                {
                    case "1":
                        HolaEstudiante();
                        break;
                    case "2":
                        BucleFor();
                        break;
                    case "3":
                        RandomNumber();
                        break;
                    case "4":
                        Carro();
                        break;
                    case "5":
                        VerProd ver = new VerProd();
                        ver.Main();
                        break;
                    case "6":
                        break;
                   

                }
            }
            while (seleccion != "6");
        }
        static void HolaEstudiante()
        {
            Console.Clear();
            Console.WriteLine("Escriba su Nombre Por favor");
            string nombre = Console.ReadLine();
            Console.WriteLine("Hola, estudiante: " + nombre + " Bienvenido a Programacion 1");
            Console.WriteLine("");
            Console.WriteLine("presione cualquier tecla para salir");
            Console.ReadKey();
        }
        
        static void BucleFor()
        {
            Console.Clear();
            for(int i=0; i<=50; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }

        static void RandomNumber()
        {
            inicio:
            Console.Clear();
            int intentos = 6;
            string numero;
            do
            {
                Console.Clear();
                Random Ran = new Random();
                int NumRan = Ran.Next(1, 100);

                Console.WriteLine("En este juego se genero un numero entre 1 y 100, tienes 6 intentos para acertar");
                Console.WriteLine("");
                Console.WriteLine("Te Quedan: " + intentos + " Intentos");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.Write("Ingrese Un Numero o escriba SALIR para salir del juego: ");
                numero = Console.ReadLine();
                numero = numero.ToLower();
                if (numero=="salir")
                {
                    return ;
                }
                try
                {
                    if (Convert.ToInt32(numero) == NumRan)
                    {
                        Console.Clear();
                        Console.WriteLine("USTED A ADIVINADO!!!!!!! FELICIDADES!!!");
                        Console.WriteLine("El numero era: " + NumRan);
                        intentos = 0;
                    }

                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Que pena, no pudo adivinar el numero, Intentelo de nuevo");
                        Console.WriteLine("El numero era: " + NumRan);
                        intentos--;

                    }
                }catch(Exception)
                {
                    Console.Clear();
                    Console.WriteLine("Ingrese un Numero o la palabra Salir");
                    Console.ReadKey();
                    goto inicio;
                }
                Console.ReadLine();
            } while (intentos > 0);
            Console.WriteLine("Fin del Juego, Volviendo a Pagina Principal");
            Console.ReadKey();
        }

        static void Carro()
        {
            A:
            Console.Clear();
            vehiculo carro = new vehiculo();
            Console.WriteLine("Quieres que el vehiculo este encendido o apagado? [S/N]");
            string res = Console.ReadLine();
            res = res.ToLower();
            if (res == "s")
            {
                carro.estado = "Encendido";
            }
            else if (res == "n")
            {
                carro.estado = "Apagado";
            }
            else
            {
                Console.WriteLine("Letra equivocada, por favor escriba S o N");
                Console.ReadKey();
                goto A;
            }
            Console.WriteLine("Marca: "+carro.marca);
            Console.WriteLine("Modelo: " + carro.modelo);
            Console.WriteLine("Anio: " + carro.anio);
            Console.WriteLine("Color del vehiculo: " + carro.color);
            Console.WriteLine("Estado: " + carro.estado);
            Console.ReadKey();
        }
        public class vehiculo
        {
           public string marca= "Hyundai";
           public string modelo="Santa Fe";
           public string anio="2020";
           public string color="Rojo";
           public string estado="Encendido";
        }
    }
    }

