using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ejercicio 1
            ////Versión sencilla, pero pedimos los inputs en lugar de hardcodearlos 
            //int num1, num2, num3;

            //Console.WriteLine("----- Ejercicio 1: inicio -----\n");

            //Console.WriteLine("Introduzca 3 números. Posteriormente se detectará el mayor de estos");
            //Console.Write("Número A: ");

            ////Se puede convertir por clase estática convert o con método estático asociado al struct que el CTS define para el tipo de dato: int (Int32) --> int.Parse()
            //num1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Número B: ");
            //num2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Número C: ");
            //num3 = Convert.ToInt32(Console.ReadLine());

            ////Dado que debemos trabajar con 3 variables... empezamos las comparaciones. Recordad: pueden ser numeros iguales...

            //if (num1 > num2)
            //{
            //    if(num1 > num3)
            //    {
            //        Console.WriteLine("Máximo número es A");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Máximo número es C");
            //    }
            //}
            //else if (num1 < num2)
            //{
            //    if (num2 > num3)
            //    {
            //        Console.WriteLine("Máximo número es B");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Máximo número es C");
            //    }
            //}
            //else //A la fuerza num1 = num2
            //{
            //    if(num1 > num3)
            //    {
            //        Console.WriteLine("Máximo número es A");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Máximo número es C");
            //    }
            //}

            //Console.WriteLine("----- Ejercicio 1: final -----\n");
            #endregion

            #region Ejercicio 2
            //Console.WriteLine("----- Ejercicio 2: inicio -----\n");
            ////Aprovechamos bucle para hacer las dos tareas de comparación

            //int[] numVector;
            //int cap = -1;
            //int numMin = 0, numMax = 0;

            //Console.WriteLine("Comparador de máximo y minimo de un conjunto de números.");

            //while(cap < 5)
            //{
            //    Console.WriteLine("Introduzca cantidad de numeros a comparar (mínimo  5): ");
            //    cap = Convert.ToInt32(Console.ReadLine());
            //}

            //numVector = new int[cap];

            //for (int i = 0; i < cap; i++)
            //{
            //    Console.WriteLine("Introducza valor " + (i+1).ToString() + ": ");
            //    numVector[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //for(int i = 0; i < numVector.Length; i++)
            //{
            //    numMin = numVector[i] < numMin ? numVector[i] : numMin;
            //    numMax = numVector[i] > numMax ? numVector[i] : numMax;
            //}

            //Console.WriteLine("Valor máximo: " + numMax.ToString());
            //Console.WriteLine("Valor mínimo: " + numMin.ToString());

            //Console.WriteLine("----- Ejercicio 2: final -----\n");
            #endregion

            #region Ejercicio 3
            //Console.WriteLine("----- Ejercicio 3: inicio -----\n");

            //Console.WriteLine("Introduza un número para múltiplicarlo x 3. Si introduce 0 se realiza la multiplicación y se finaliza");
            //int numEj3 = 0;
            //const int multConst = 3;

            //do
            //{
            //    Console.WriteLine("Introduzca valor: ");
            //    numEj3 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Resultado: " + numEj3.ToString() + " X " + multConst.ToString() + " = " + (numEj3 * multConst).ToString());
            //}
            //while (numEj3 != 0);

            //Console.WriteLine("----- Ejercicio 3: final -----\n");

            #endregion

            #region Ejercicio 4
            //Console.WriteLine("----- Ejercicio 4: inicio -----\n");

            //Console.WriteLine("Introduza un número para múltiplicarlo x 3. Si introduce 0 se realiza la multiplicación y se finaliza");
            //int numEj3;
            //const int multConst = 3;
            //bool OKvalue;

            //do
            //{
            //    Console.WriteLine("Introduzca valor: ");
            //    OKvalue = int.TryParse(Console.ReadLine(), out numEj3);

            //    if (OKvalue)
            //    {
            //        Console.WriteLine("Resultado: " + numEj3.ToString() + " X " + multConst.ToString() + " = " + (numEj3 * multConst).ToString());
            //    }
            //    else
            //    {
            //        Console.WriteLine("Valor no valido. Reinténtelo.");
            //        numEj3 = -1;
            //    }
            //}
            //while (numEj3 != 0);

            //Console.WriteLine("----- Ejercicio 4: final -----\n");
            #endregion

            #region Ejercicio 5
            //Console.WriteLine("----- Ejercicio 5: inicio -----\n");

            //bool ERRvalueEj5;
            //int valueEj5;
            //Console.WriteLine("Introduzca un valor del 0 al 9 para mostrar la tabla de múltiplicar");

            //do
            //{
            //    Console.WriteLine("Valor: ");
            //    ERRvalueEj5 = !(int.TryParse(Console.ReadLine(), out valueEj5));

            //    if (ERRvalueEj5)
            //    {
            //        Console.WriteLine("Valor erroneo. Reinténtelo.");
            //    }
            //    else if (valueEj5 < 0 || valueEj5 > 9)
            //    {
            //        Console.WriteLine("Valor fuera de rango. Debe ser entre 0 y 9");
            //        ERRvalueEj5 = true;
            //    }
            //} while (ERRvalueEj5);

            //Console.WriteLine("Tabla del " + valueEj5.ToString() + ":");
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(valueEj5.ToString() + " X " + i.ToString() + " = " + (valueEj5 * i).ToString() + "\n");
            //}

            //Console.WriteLine("----- Ejercicio 5: final -----\n");
            #endregion

            #region Ejercicio 6
            //Console.WriteLine("----- Ejercicio 6: inicio -----\n");

            //Console.WriteLine("Tablas de múltiplicar del 2 al 5");

            //for (int j = 2; j <= 5; j++)
            //{
            //    Console.WriteLine("Tabla del " + j.ToString() + ":");
            //    for (int i = 0; i < 10; i++)
            //    {
            //        Console.WriteLine(j.ToString() + " X " + i.ToString() + " = " + (j * i).ToString() + "\n");
            //    }
            //}
            
            //Console.WriteLine("----- Ejercicio 6: final -----\n");
            #endregion

            Console.ReadLine();
        }
    }
}
