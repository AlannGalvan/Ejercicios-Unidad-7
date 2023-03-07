using System;

namespace p3
{
    class Program
    {
        static void Main(string[] args)
        {   

            // // Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos).
            // // El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan 
            // // sido reemplazadas por el segundo. Mostrar el resultado en pantalla. Ejemplo:
            // // CADENA FUENTE: “La mar estaba serena"
            // // CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
            // // CADENA RESULTADO: “Li mir estibi sereni"
            

            // //creo una cadena de caracteres con un CHAR DE 30
            // char[] nombre = new char[30];

            // char letra, letraActual, letraNueva;

            // //creo indice para recorrer mi cadena en un WHILE
            // int indice = 0;


            // Console.WriteLine("Ingrese una frase..");
            // letra = char.Parse(Console.ReadLine());
            
            // //creo un WHILE que corte cuando LETRA sea diferente de \0  Y el indice sea menor de 30
            // while (letra != '0' && indice < 30)
            // { 
            //     //hago que LETRA que ingrese se guarde en el NOMBRE y en el INDICE donde esta
            //     nombre[indice] = letra;
            //     letra = char.Parse(Console.ReadLine());

            //     // incremento el INDICE para recorrer la cadena en el WHILE
            //     indice++;
            // }

            // //hago que termine el \0
            // nombre[indice] = '\0';

           
            // Console.WriteLine("La frase es: ");
            //  indice = 0;

            //  //recorro y muestro el WHILE hasta encontrar el \0
            // while (nombre[indice] != '\0')
            // {
            //     Console.Write(nombre[indice]);
            //     indice++;
            // }
             
            //  //Increso la letra que quiero cambiar
            //  Console.WriteLine(" Ingrese letra a remplazar: ");
            //  letraActual = char.Parse(Console.ReadLine());

            //  //ingreso la nueva letra que quiero poner
            //  Console.WriteLine("Ingrese letra nueva: ");
            //  letraNueva = char.Parse(Console.ReadLine());

            //  indice = 0;

            //  while (nombre[indice] != '\0')
            //  {  
            //     //si en el indice donde estoy encuentro la letraActual que ingrese 
            //     if(nombre[indice] == letraActual)

            //     //la cambio por letraNueva
            //        nombre[indice] = letraNueva;

            //        indice++;
            //  }
            
            // //muestro la frase nueva
            //  Console.WriteLine("la nueva frase es: ");
            //  indice = 0;
            //  while (nombre[indice] != '\0')
            //  {
            //     Console.Write(nombre[indice]);
            //     indice++;
            //  }
            

            
            string frase;
            char letraActual, letraNueva;

            Console.WriteLine("Ingrese frase:");
            frase = Console.ReadLine();

            Console.WriteLine("la frase es: " + frase);

            Console.WriteLine("ingrese letra a remplazar: ");
            letraActual = char.Parse(Console.ReadLine());
            Console.WriteLine("ingrese letra nueva: ");
            letraNueva = char.Parse(Console.ReadLine());
            
            //a la frase asignale lo que tiene la frase pero remplazando(Replace) letraActual por letraNueva
            frase = frase.Replace(letraActual, letraNueva);

            Console.WriteLine("la nueva frase es: " + frase);

            





            
        }
    }
}
