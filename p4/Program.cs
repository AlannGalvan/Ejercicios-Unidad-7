using System;

namespace p4
{
    class Program
    {
        static void Main(string[] args)
        {   

            // Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro con 
            //los siguientes datos:

            //- Número de Artículo (1 a 15)
            //- Cantidad Vendida 

            //Puede haber varios registros para el mismo artículo y el último se indica con número de artículo
            // igual a 0.
            //Se pide determinar e informar:
            //a) El número de artículo que más se vendió en total.
            //b) Los números de artículos que no registraron ventas.
            //c) Cuantas unidades se vendieron del número de artículo 10.
            

            int nroArticulo;
            int cantidad;
            int[] nroArticuloMasVendido = new int[15];
            
            //hago un for para poner todos los nroArticuloMasvendido en 0
            for (int x = 0; x < 15; x++)
            {
                nroArticuloMasVendido[x] = 0;
            }
            
            //ingreso numero de articulo y cantidad
            Console.WriteLine("Ingrese número de articulo: ");
            nroArticulo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad: ");
            cantidad = int.Parse(Console.ReadLine());
            
            // nroArticulo diferente(!=) de 0
            while (nroArticulo != 0)
            {
                
                //acomulo los nroArticulosMasVendido en cantidad
                nroArticuloMasVendido[nroArticulo - 1] += cantidad;
                
                //Ingreso numero de articulo y cantidad de nuevo
                Console.WriteLine("Ingrese número de articulo: ");
                nroArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la cantidad: ");
                cantidad = int.Parse(Console.ReadLine());
            }

            //punto a:

            //pongo el nroArticuloMasVendido[0] como el valor maaximo para maxCantidad
            int maxCantidad = nroArticuloMasVendido[0];
            
            //hago un for para encontrar el maximo
            for (int x = 0; x < 15; x++)
            {
                if (nroArticuloMasVendido[x] > maxCantidad)
                {
                    maxCantidad = nroArticuloMasVendido[x];
                    nroArticulo = x + 1;
                }
            }

            Console.WriteLine("El numero de articulo mas vendido es: " + nroArticulo + " la maxima catidad vendida es: " + maxCantidad);

            //punto b:

            //hago un for para mostrar que nroArticulo no tuvo ventas
            for (int x = 0; x < 15; x++)
            {
                if(nroArticuloMasVendido[x] == 0)
                   Console.WriteLine("El producto " + (x + 1) + " no tuvo ventas");
            }

            //punto c:
            Console.WriteLine("La cantidad vendida del numero 10 son: " + nroArticuloMasVendido[9]);
        }

    }
}
