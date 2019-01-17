using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ejercicio 1
            Console.WriteLine("----- Ejercicio 1: inicio -----\n");
            //Uso de variables. En C# las variables son case sensitive y no deben chocar con palabra reservada.
            //Si es estrictamente necesario (desarrollo etiquetas HTML en MVC...) se usara el caracter @ antes del identificador de variable con nombre de palabra reservada
            string mensaje = "Mensaje minus", Mensaje = "Mensaje 1a mayus", MENSAJE = "Mensaje todo mayus", @string = "Mensaje con identificador igual a palabra reservada";
            Console.WriteLine(mensaje);
            Console.WriteLine(Mensaje);
            Console.WriteLine(MENSAJE);
            Console.WriteLine(@string);
            Console.WriteLine("----- Ejercicio 1: final -----\n");
            #endregion

            #region Ejercicio 2
            Console.WriteLine("----- Ejercicio 2: inicio -----\n");
            //Uso de variables. Los nombres de las variables deben ser únicas (aunque difieran solo en tipo).
            //string variableTestA;
            //int variableTestA;
            Console.WriteLine("----- Ejercicio 2: final -----\n");
            #endregion

            #region Ejercicio 3
            Console.WriteLine("----- Ejercicio 3: inicio -----\n");
            //Uso de variables. Los nombres de las variables deben ser únicas, INCLUSO SI SON CONSTANTES.
            //const int VariableTestB = 1;
            //int VariableTestB = 3;
            Console.WriteLine("----- Ejercicio 3: final -----\n");
            #endregion

            #region Ejercicio 4
            Console.WriteLine("----- Ejercicio 4: inicio -----\n");
            //Los tipos de datos se pueden declarar al menos de dos modos: con la palabra reservada de C#, o con el struct que representa ese dato en CTS (common type system)
            //Opcionalmente, como los tipos de dato CTS pertenecen al namespace System, se puede poner le nombre completo. No se puede hacer con el alias de C# porque es palabra reservada
            int variableTestC;
            Int32 variableTestD;
            System.Int32 variableTestE;
            Console.WriteLine("----- Ejercicio 4: final -----\n");
            #endregion

            #region Ejercicio 5
            Console.WriteLine("----- Ejercicio 5: inicio -----\n");
            //Las constanes se definen segun reglas de tipado de C#. Estas definen el tipo dato lo más acotado posible en capacidad
            //Las constantes de coma flotante las crea como double;

            //Opcion 1: uso de sufijo especial que indique al compilador el tipo a usar --> Notación literal
            decimal valorTestF = 1.23M;
            //Opción 2: conversión explicita
            decimal valorTestG = (decimal)1.23;
            Console.WriteLine("----- Ejercicio 5: final -----\n");
            #endregion

            #region Ejercicio 6
            Console.WriteLine("----- Ejercicio 6: inicio -----\n");
            //El caracter especial \r es retorno de carro --> En windows: retorna del final de la linea al principio (sin saltos). En linux es salto de linea.
            //El caracter especial \n es salto de linea --> En windows: retorna al final de la linea + hace un salto.
            string textoVersionA = "X\tX\tX\rX\tX\tX\rX\tX\tX\rX\tX\tX\rX\tX\tX\r";
            string textoVersionB = "X\tX\tX\nX\tX\tX\nX\tX\tX\nX\tX\tX\nX\tX\tX\n";

            Console.WriteLine("Versión A:\n");
            Console.WriteLine(textoVersionA);
            Console.WriteLine("Versión B:\n");
            Console.WriteLine(textoVersionB);

            Console.WriteLine("----- Ejercicio 6: final -----\n");
            #endregion

            #region Ejercicio 7
            Console.WriteLine("----- Ejercicio 7: inicio -----\n");
            //Para escribir cadenas sin pensar en secuencias de escape: usar @ delante de cadena
            string cadenaSinSecuenciaEscape = @"Esto
                                                Es una      cadena


                                                sin secuencias de               escape";
            Console.WriteLine(cadenaSinSecuenciaEscape);
            Console.WriteLine("----- Ejercicio 7: final -----\n");
            #endregion

            #region Ejercicio 8
            Console.WriteLine("----- Ejercicio 8: inicio -----\n");

            //Conversión implicita de un tipo de dato grande a uno pequeño no lo permite el compulador. Hay que indicarle explicitamente
            long numeroGrande = 1234567890123456789;
            int numeroReceptor = (int)numeroGrande;

            //Al ser un numero guardado en el LONG mucho mas grande que la capacidad de INT, existe truncado. Pasamos de guardar 8 bytes a guardar 4 bytes
            Console.WriteLine(numeroGrande);
            Console.WriteLine(numeroReceptor);

            //Si multiplicamos por 10 el numero grande, ya no cabe en long. Habria que apuntar al tipo de dato siguiente en capacidad. Como es positivo, el sigueinte seria ulong 
            ulong numeroMasGrande = 12345678901234567890;
            Console.WriteLine(numeroMasGrande);
            Console.WriteLine("----- Ejercicio 8: final -----\n");
            #endregion

            Console.ReadLine();
        }
    }
}
