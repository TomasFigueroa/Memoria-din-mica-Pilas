using System.Collections;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Ejercicio
{
    public static void Main()
    {


        Stack<string> Pila = new Stack<string>();

        while (true)
        {
            Console.WriteLine("Escriba las cadenas de texto que desee almacenar en la Pila");
            Console.WriteLine("o introduzca una cadena vacia para recibir lo almacenado en la Pila");
            Console.WriteLine("");

            string datoEnPila = Console.ReadLine();

            Console.WriteLine("");

            if (datoEnPila == "")
            {
                MostrarPila(Pila);
                break;
            }
            else
            {
                Pila.Push(datoEnPila);
            }
        }

        static void MostrarPila(Stack<string> Pila)
        {
            while (Pila.Count > 0)
            {
                string dato = (string)Pila.Pop();

                Console.WriteLine(dato);
            }
        }

    }
}