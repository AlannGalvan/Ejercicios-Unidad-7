using System;

namespace p2
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Hacer un programa que solicite 10  números enteros y los guarde en un vector. 
            //Luego recorrer ese vector para calcular el promedio. Mostrar por pantalla los valores 
            //que son mayores al promedio.
            
            //creo un vector de 10
            int[] vector = new int[10];
            int acu, promedio;
            
            //creo un FOR  de 10 y lo guardo en un vector
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese un nro.. ");
                vector[x] = int.Parse(Console.ReadLine());
                
            }

            acu = 0;
            
            //acomulo el promedio en la variable "acu"
            for (int x = 0; x < 10; x++)
            {
                acu += vector[x];
            }
            

            promedio = acu / 10;

            Console.WriteLine("El promedio es: " + promedio);
            
            //muestro los numeros mayor al promedio
            for (int x = 0; x < 10; x++)
            {   

                //Pregunto si lo que tiene el vector en esa posicion es mayor al promedio y lo muestro por pantalla
                if(vector[x] > promedio)
                Console.WriteLine("Valor mayor al promedio " + vector[x]);
            }

        Console.WriteLine("Fin del programa..");
            
        }
    }
}
