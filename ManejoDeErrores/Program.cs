using System;

namespace ManejoDeErrores
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ingresar un número");
            string valorIngresado = Console.ReadLine();

            int valorComoInt = int.Parse(valorIngresado);
            Console.Read();
        }
    }
}
