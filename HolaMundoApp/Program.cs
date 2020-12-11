using System;
using Matematica;

namespace HolaMundoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a mi calculadora");
            Console.WriteLine("Ingresa un primer numero");
            var num1= Console.ReadLine();
            Console.WriteLine("Ingresa un segundo numero");
            var num2 = Console.ReadLine();
            Console.WriteLine("Que operacion quieres realizar");
       Console.WriteLine("+ , - , * , / , Potencia , Raiz");
          
            var operacion = Console.ReadLine();
            var calculadora = new Calculadora();
            

                if (operacion == "+")
                {
                    var respuesta = calculadora.Sumar(int.Parse(num1), int.Parse(num2));
                    Console.WriteLine("la suma de los dos numeros es " + respuesta);
                    Console.WriteLine("Que operacion quieres realizar");
                }
                if (operacion == "-")
                {
                    var respuesta = calculadora.Restar(int.Parse(num1), int.Parse(num2));
                    Console.WriteLine("la resta de los dos numeros es " + respuesta);
                }

                if (operacion == "*")
                {
                    var respuesta = calculadora.Multiplicar(int.Parse(num1), int.Parse(num2));
                    Console.WriteLine("la multiplicacion de los dos numeros es " + respuesta);
                }
                if (operacion == "/")
                {
                    var respuesta = calculadora.Dividir(int.Parse(num1), int.Parse(num2));
                    Console.WriteLine("la division de los dos numeros es " + respuesta);
                }
                if (operacion == "potencia")
                {
                    Console.WriteLine("el primer numero se tomara como exponente y el segundo como base");
                    var respuesta = calculadora.Potencia(int.Parse(num1), int.Parse(num2));
                    Console.WriteLine("la potencia es  " + respuesta);
                }
                if (operacion == "Raiz")
                {

                    var conversion = int.Parse(num1);
                    var conversion2 = int.Parse(num2);
                    double result = Math.Sqrt(conversion);
                    double result2 = Math.Sqrt(conversion2);
                    Console.WriteLine("la raiz del primer numero es =" + result);
                    Console.WriteLine("la raiz del segundo numero es =" + result2);
                }
                 }

            


           
            /*Console.WriteLine("Ingresa el primer numero");
            var numero1 =Console.ReadLine();
            Console.WriteLine("Ingresa un segundo numero");
            var numero2 = Console.ReadLine();
            var calculadora = new Calculadora();
            var respuesta = calculadora.Sumar(int.Parse(numero1) , int.Parse(numero2));
            Console.WriteLine("la suma de los dos numeros es " + respuesta);*/

            /* Console.WriteLine("Ingresa tu nombre");
             var entrada= Console.ReadLine();
             Console.WriteLine("Ingresaste" + entrada);
             var salida=Console.ReadLine();
             if (salida =="salir") 
             {
                 Console.Read();
             }*/

        }
       
    
}