using System;

namespace ManejoDeErrores
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ingresar un número");
            string valorIngresado = Console.ReadLine();


            //EJEMPO DE MANEJO DE ERROR EN UNA DIVISIÓN

            int num1 = 5;
            int num2 = 0;
            int resultado;

            try { resultado = num1 / num2; } catch(DivideByZeroException) {
                Console.WriteLine("No se puede divir por cero");
            }

            try
            {
                int valorComoInt = int.Parse(valorIngresado);
            }
            catch (FormatException)
            {
                Console.WriteLine("El formato del valor es incorrecto");
            }
            catch(OverflowException)
            {
                Console.WriteLine("El número ingresado es demasiado largo o muy corto");
            }
            catch(ArgumentNullException)
            {
                Console.WriteLine("No se ha ingresado ningún número");
            }
            finally { Console.WriteLine("Esta frase aparecerá pase lo que pase"); }

           
            Console.Read();
        }
    }
}
