using System;

namespace p1
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Hacer un programa que solicite 10 números enteros y los guarde en un vector. Luego recorrer los 
            //elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector.
            
            //creo un vector de 10 para guardas los numeros
            int[] vector = new int[10];

            //creo el numero, posicion y el numero maximo
            int posicion, max;
            
            //hago un FOR de 10
            for (int x = 0; x < 10; x++)
            {   
                //con esto ingreso el numero y lo guarda en el vector en esa posicion                        
                Console.WriteLine("Ingrese un nro..");
                vector[x] = int.Parse(Console.ReadLine());
                
            }
            
            //aca hago que el valor maximo se lo que tiene el vector en la posicion 0
            max = vector[0];

            //hago que la posicion sea 1
            posicion = 1;
            
            //hago un FOR  de 10 para recorrer el vector y ver que numeros tiene
            for (int x = 0; x < 10; x++)
            {   
                //hago un IF para buscar el numero maximo dentro del vector, con la ayuda del FOR.
                //si lo que tiene el vector es mayor al max.
                if(vector[x] > max){
                    
                    //el nuevo max pasa a ser los que tiene el vector en esa posicion
                    max = vector[x];
                    posicion = x + 1;
                }
                   
            }
            
            //aca muestro el numero mas grande ingresado y en que posiscion fue encontrado
            Console.WriteLine("El valor maximo es: " + max + " y su posicion es: " + posicion);


        }
    }
}
