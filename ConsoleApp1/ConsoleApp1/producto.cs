using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class producto
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public void AgregarNombre(string nombre)
        {
            Nombre = nombre;
        }
        public void productoDisp()
        {
            Console.WriteLine("Producto:  " + Nombre + "\nDescripcion:  " + Descripcion);
        }
    }
    public class VerProd
    {

        public void Main()
        {
            producto prdct1 = new producto();
            producto prdct2 = new producto();

            Console.Write("Ingrese el nombre de su producto 1:  ");
            prdct1.AgregarNombre(Console.ReadLine());
            Console.Write("Ingrese la descripcion de su producto:  ");
            prdct1.Descripcion = Console.ReadLine();





            Console.Write("Ingrese el nombre de su producto 2:  ");
            prdct2.AgregarNombre(Console.ReadLine());
            Console.Write("Ingrese la descripcion de su producto:  ");
            prdct2.Descripcion = Console.ReadLine();

            Console.Clear();
            prdct1.productoDisp();
            prdct2.productoDisp();
            Console.ReadKey();
        }

    }
}
