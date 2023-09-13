using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

/*namespace AppSuma2numeros
{
    class program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe tu primer numero: ");
            double num1= Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escribe tu segundo numero: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double resultado;

            resultado = num1 + num2;
            Console.WriteLine("Tu resultado es " + resultado);
            Console.ReadLine();
        }
    }
}
*/
/*namespace InvertirTexto
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa una cadena de texto de al menos 8 caracteres: ");
            string cadena = Console.ReadLine();

            // Validar que la cadena tenga al menos 8 caracteres
            if (cadena.Length < 8)
            {
                Console.WriteLine("La cadena debe tener al menos 8 caracteres");
                return;
            }

            // Cortar la cadena en 4 caracteres
            cadena = cadena.Substring(cadena.Length - 4);

            // Imprimir la cadena invertida
            Console.WriteLine("Cadena cortada: {0}", cadena);
            Console.ReadKey();
        }
    }
}
*/

/*
namespace ObtenerFechaHora
{
    class Program
    {
        static void Main(string[] args)
        {
            // Obtener la fecha y hora actual
            DateTime fechaHora = DateTime.Now;

            // Imprimir la fecha y hora
            Console.WriteLine("Fecha: {0}", fechaHora.Date);
            Console.WriteLine("Hora: {0}", fechaHora.TimeOfDay);
            Console.ReadKey();
        }
    }
}*/
/*
namespace Enumeraciones
{
    public enum DiaSemana
    {
        Domingo = 1,
        Lunes,
        Martes,
        Miercoles,
        Jueves,
        Viernes,
        Sabado
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número del 1 al 7: ");
            int dia = int.Parse(Console.ReadLine());

            // Obtener el día de la semana correspondiente al número ingresado
            DiaSemana diaSemana = (DiaSemana)dia;

            // Imprimir el día de la semana
            Console.WriteLine("El día de la semana correspondiente al número ingresado es {0}", diaSemana);

            Console.ReadKey();
        }
    }
}
*/
/*   // 1. Convertir true, false, 1 y 0 utilizando los métodos Convert., bool.Parse y bool.TryParse
//Los métodos Convert.ToBoolean(), bool.Parse() y bool.TryParse() se utilizan para convertir un valor a un tipo de datos booleano.
//El método Convert.ToBoolean() siempre devuelve un valor booleano, incluso si el valor de entrada no es un booleano válido.Si el valor de entrada no es un booleano válido, el método devolverá false.
//El método bool.Parse() devuelve un valor booleano solo si el valor de entrada es un booleano válido.Si el valor de entrada no es un booleano válido, el método devolverá null.
//El método bool.TryParse() devuelve un valor booleano y un indicador de éxito. El indicador de éxito es true si el valor de entrada es un booleano válido, y false si no lo es.
//Ejemplos:
   // Convertir true a booleano
bool b1 = Convert.ToBoolean(true);
Console.WriteLine(b1); // true

// Convertir false a booleano
bool b2 = Convert.ToBoolean(false);
Console.WriteLine(b2); // false

// Convertir 1 a booleano
bool b3 = Convert.ToBoolean(1);
Console.WriteLine(b3); // true

// Convertir 0 a booleano
bool b4 = Convert.ToBoolean(0);
Console.WriteLine(b4); // false

// Parsear "true" a booleano
bool b5 = bool.Parse("true");
Console.WriteLine(b5); // true

// Parsear "false" a booleano
bool b6 = bool.Parse("false");
Console.WriteLine(b6); // false

// Parsear "1" a booleano
bool b7 = bool.Parse("1");
Console.WriteLine(b7); // true

// Parsear "0" a booleano
bool b8 = bool.Parse("0");
Console.WriteLine(b8); // false

// TryParse("true")
bool? b9 = bool.TryParse("true");
Console.WriteLine(b9); // true

// TryParse("false")
bool? b10 = bool.TryParse("false");
Console.WriteLine(b10); // true

// TryParse("1")
bool? b11 = bool.TryParse("1");
Console.WriteLine(b11); // true

// TryParse("0")
bool? b12 = bool.TryParse("0");
Console.WriteLine(b12); // true

*/

//2 .Explicar qué sucede en los siguientes intentos de casteos de datos
//a) int a = (int)344.4;
//Este casteo es válido y exitoso.El número 344.4 se convierte a un entero con pérdida de precisión.El resultado es el número 344.
//b) decimal a = 10;
//Este casteo es válido y exitoso.El número 10 se convierte a un decimal sin pérdida de precisión.El resultado es el número 10.0.
//**c) int a = 443444;
//short b = (short)a;**
//Este casteo es válido, pero no exitoso.El número 443444 es demasiado grande para ser almacenado en un short. El resultado es un error de desbordamiento.

/*
namespace SwitchEnumeracion
{
    public enum Color
    {
        Blanco = 1,
        Azul = 2,
        Negro = 3
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar al usuario que ingrese el color
            Console.WriteLine("Ingrese el color (1-3): ");
            int color = int.Parse(Console.ReadLine());

            // Evaluar el color ingresado
            switch (color)
            {
                case 1:
                    Console.WriteLine("El color es blanco");
                    break;
                case 2:
                    Console.WriteLine("El color es azul");
                    break;
                case 3:
                    Console.WriteLine("El color es negro");
                    break;
            }

            Console.ReadKey();
        }
    }
}
*/

/*
namespace IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar al usuario que ingrese un número
            Console.WriteLine("Ingrese un número: ");
            int numero = int.Parse(Console.ReadLine());

            // Evaluar el número ingresado
            if (numero > 10)
            {
                Console.WriteLine("El número es mayor a 10");
            }
            else
            {
                Console.WriteLine("El número no es mayor a 10");
            }

            Console.ReadKey();
        }
    }
}
*/

/*
6. ¿Cuál es la diferencia entre la sentencia for y foreach? ¿Cuándo se debe utilizar cada una de ellas?
La principal diferencia entre las sentencias for y foreach es que la sentencia for se utiliza para iterar sobre una colección de datos, 
mientras que la sentencia foreach se utiliza para iterar sobre una colección de objetos.
La sentencia for tiene la siguiente sintaxis:

for (int i = 0; i < array.Length; i++)
{
    // Código a ejecutar
}
La sentencia for utiliza tres variables:
i: Es una variable de control que se utiliza para iterar sobre la colección de datos.
0: Es el valor inicial de la variable de control.
array.Length: Es el valor final de la variable de control.

La sentencia foreach tiene la siguiente sintaxis:

    foreach (var item in array)
{
    // Código a ejecutar
}

La sentencia foreach utiliza una variable de control llamada item para iterar sobre la colección de objetos.
En general, la sentencia for se utiliza cuando es necesario iterar sobre una colección de datos
*/

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definir una variable a
            int a = 0;

            // Bucle while
            while (a <= 50)
            {
                // Incrementar el valor de a
                a += 5;

                // Imprimir el valor de a
                Console.WriteLine(a);
            }

            // Mensaje de finalización
            Console.WriteLine("El valor de a ha excedido 50");

            Console.ReadKey();
        }
    }
}