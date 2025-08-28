using FuncionesLambda;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Expresion lambda como funcion");

        //=> operador flecher

        //Func<int, int> b = (a) => a * 2;
        //int resultado = b(4);
        //Console.WriteLine("El resultado es: " + resultado);



        //Func<int, int, int> suma =(a, b) => a + b;
        //int resultado = suma(4, 5);
        //Console.WriteLine("El resultado es: " + resultado);



        //Un ambito

        //Func<int, int, int> mayor = (a, b) =>
        //{
        //    if (a > b)
        //    {
        //        return a;
        //    }
        //    else
        //    {
        //        return b;
        //    }              
        //};
        //int res = mayor(45, 20);
        //Console.WriteLine("El mayor es: " + res);



        //Mandar una cantidad de numeros y validarlos, var tipo generico, para no castear

        var numeros = new List<int> {8, 5, 9, 34, 2, 26, 8 };
        Func<int, bool> ObtenerPares = (num) => num % 2 == 0;
        //var pares = numeros.Where(ObtenerPares);
        var pares = numeros.Where((num) => num % 2 == 0);
        Console.WriteLine("Hola ");





        //Encontrar en que direccion de memoria se encuentra edad

        //Persona pers = new Persona();
        //unsafe
        //{
        //    int edad = 18;
        //   edad++;
        //    edad++;
        //    int* pointerToNumber = &edad;
        //    Console.WriteLine($"Value of the variable: {edad}");
        //    Console.WriteLine($"Address of the variable: {(long)pointerToNumber:X}");
        //}



        Console.ReadKey();
    }
}