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
            Ejercicio14();
            Console.ReadLine();
        }

        public static void Ejercicio1()
        {
            //Versión sencilla, pero pedimos los inputs en lugar de hardcodearlos 
            int num1, num2, num3;

            Console.WriteLine("----- Ejercicio 1: inicio -----\n");

            Console.WriteLine("Introduzca 3 números. Posteriormente se detectará el mayor de estos");
            Console.Write("Número A: ");

            //Se puede convertir por clase estática convert o con método estático asociado al struct que el CTS define para el tipo de dato: int (Int32) --> int.Parse()
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Número B: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Número C: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            //Dado que debemos trabajar con 3 variables... empezamos las comparaciones. Recordad: pueden ser números iguales...

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("Máximo número es A");
                }
                else
                {
                    Console.WriteLine("Máximo número es C");
                }
            }
            else if (num1 < num2)
            {
                if (num2 > num3)
                {
                    Console.WriteLine("Máximo número es B");
                }
                else
                {
                    Console.WriteLine("Máximo número es C");
                }
            }
            else //A la fuerza num1 = num2
            {
                if (num1 > num3)
                {
                    Console.WriteLine("Máximo número es A");
                }
                else
                {
                    Console.WriteLine("Máximo número es C");
                }
            }

            Console.WriteLine("----- Ejercicio 1: final -----\n");
        }

        public static void Ejercicio2()
        {
            Console.WriteLine("----- Ejercicio 2: inicio -----\n");
            //Aprovechamos bucle para hacer las dos tareas de comparación

            int[] numVector;
            int cap = -1;
            int numMin = 0, numMax = 0;

            Console.WriteLine("Comparador de máximo y minimo de un conjunto de números.");

            while (cap < 5)
            {
                Console.WriteLine("Introduzca cantidad de números a comparar (mínimo  5): ");
                cap = Convert.ToInt32(Console.ReadLine());
            }

            numVector = new int[cap];

            for (int i = 0; i < cap; i++)
            {
                Console.WriteLine("Introducza valor " + (i + 1).ToString() + ": ");
                numVector[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < numVector.Length; i++)
            {
                numMin = numVector[i] < numMin ? numVector[i] : numMin;
                numMax = numVector[i] > numMax ? numVector[i] : numMax;
            }

            Console.WriteLine("Valor máximo: " + numMax.ToString());
            Console.WriteLine("Valor mínimo: " + numMin.ToString());

            Console.WriteLine("----- Ejercicio 2: final -----\n");
        }

        public static void Ejercicio3()
        {
            Console.WriteLine("----- Ejercicio 3: inicio -----\n");

            Console.WriteLine("Introduza un número para múltiplicarlo x 3. Si introduce 0 se realiza la multiplicación y se finaliza");
            int numEj3 = 0;
            const int multConst = 3;

            do
            {
                Console.WriteLine("Introduzca valor: ");
                numEj3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Resultado: " + numEj3.ToString() + " X " + multConst.ToString() + " = " + (numEj3 * multConst).ToString());
            }
            while (numEj3 != 0);

            Console.WriteLine("----- Ejercicio 3: final -----\n");
        }

        public static void Ejercicio4()
        {
            Console.WriteLine("----- Ejercicio 4: inicio -----\n");

            Console.WriteLine("Introduza un número para múltiplicarlo x 3. Si introduce 0 se realiza la multiplicación y se finaliza");
            int numEj3;
            const int multConst = 3;
            bool OKvalue;

            do
            {
                Console.WriteLine("Introduzca valor: ");
                OKvalue = int.TryParse(Console.ReadLine(), out numEj3);

                if (OKvalue)
                {
                    Console.WriteLine("Resultado: " + numEj3.ToString() + " X " + multConst.ToString() + " = " + (numEj3 * multConst).ToString());
                }
                else
                {
                    Console.WriteLine("Valor no valido. Reinténtelo.");
                    numEj3 = -1;
                }
            }
            while (numEj3 != 0);

            Console.WriteLine("----- Ejercicio 4: final -----\n");
        }

        public static void Ejercicio5()
        {
            Console.WriteLine("----- Ejercicio 5: inicio -----\n");

            bool ERRvalueEj5;
            int valueEj5;
            Console.WriteLine("Introduzca un valor del 0 al 9 para mostrar la tabla de múltiplicar");

            do
            {
                Console.WriteLine("Valor: ");
                ERRvalueEj5 = !(int.TryParse(Console.ReadLine(), out valueEj5));

                if (ERRvalueEj5)
                {
                    Console.WriteLine("Valor erroneo. Reinténtelo.");
                }
                else if (valueEj5 < 0 || valueEj5 > 9)
                {
                    Console.WriteLine("Valor fuera de rango. Debe ser entre 0 y 9");
                    ERRvalueEj5 = true;
                }
            } while (ERRvalueEj5);

            Console.WriteLine("Tabla del " + valueEj5.ToString() + ":");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(valueEj5.ToString() + " X " + i.ToString() + " = " + (valueEj5 * i).ToString() + "\n");
            }

            Console.WriteLine("----- Ejercicio 5: final -----\n");
        }

        public static void Ejercicio6()
        {
            Console.WriteLine("----- Ejercicio 6: inicio -----\n");

            Console.WriteLine("Tablas de múltiplicar del 2 al 5");

            for (int j = 2; j <= 5; j++)
            {
                Console.WriteLine("Tabla del " + j.ToString() + ":");
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(j.ToString() + " X " + i.ToString() + " = " + (j * i).ToString() + "\n");
                }
            }

            Console.WriteLine("----- Ejercicio 6: final -----\n");
        }

        public static void Ejercicio7()
        {
            Console.WriteLine("----- Ejercicio 7: inicio -----\n");

            string claveUsuario;
            const int MAX_INTENTOS = 5;
            Console.WriteLine("Introducza clave de acceso.");

            //Lo creamos con un for puesto que controlamos el número de reintentos
            for (int i = 1; i <= MAX_INTENTOS; i++)
            {
                Console.WriteLine("Clave: ");
                claveUsuario = Console.ReadLine();

                if (claveUsuario.Equals("secreto"))
                {
                    Console.WriteLine("Acceso condedido");
                    break;
                }
                else
                {
                    Console.WriteLine("Acceso denegado. Le restan " + (MAX_INTENTOS - i).ToString() + " intentos.");
                }
            }

            Console.WriteLine("----- Ejercicio 7: final -----\n");
        }

        public static void Ejercicio8VersionFor()
        {
            Console.WriteLine("----- Ejercicio 8. Version for: inicio -----\n");

            bool inputKO = true;
            const int COTA_INFERIOR = 1;
            int cotaSuperior = 0;
            Console.WriteLine("Introduzca un valor superior a 1. Se mostrarán todos los enteros entre el " + COTA_INFERIOR.ToString() + " y el número introducido");

            while (inputKO)
            {
                Console.WriteLine("Cota superior escogida: ");
                inputKO = !int.TryParse(Console.ReadLine(), out cotaSuperior);

                if (inputKO)
                {
                    Console.WriteLine("Valor inválido. Reinténtelo");
                }
                else if (cotaSuperior < COTA_INFERIOR)
                {
                    inputKO = true;
                    Console.WriteLine("Valor fuera de rango. Debe ser mayor que " + COTA_INFERIOR.ToString() + ". Reinténtelo");
                }
            }

            for (int i = COTA_INFERIOR; i <= cotaSuperior; i++)
            {
                Console.Write(i);
                Console.Write((i + 1) > cotaSuperior ? "\n " : ", ");
            }

            Console.WriteLine("----- Ejercicio 8. Version for: final -----\n");
        }

        public static void Ejercicio8VersionWhile()
        {
            Console.WriteLine("----- Ejercicio 8. Version while: inicio -----\n");

            bool inputKO = true;
            int cotaInferior = 1;
            int cotaSuperior = 0;
            Console.WriteLine("Introduzca un valor superior a 1. Se mostrarán todos los enteros entre el " + cotaInferior.ToString() + " y el número introducido");

            while (inputKO)
            {
                Console.WriteLine("Cota superior escogida: ");
                inputKO = !int.TryParse(Console.ReadLine(), out cotaSuperior);

                if (inputKO)
                {
                    Console.WriteLine("Valor inválido. Reinténtelo");
                }
                else if (cotaSuperior < cotaInferior)
                {
                    inputKO = true;
                    Console.WriteLine("Valor fuera de rango. Debe ser mayor que " + cotaInferior.ToString() + ". Reinténtelo");
                }
            }

            while (cotaInferior <= cotaSuperior)
            {
                //Post incremento, primero evalua valor para la operación, luego incrementa variable
                Console.Write(cotaInferior++);
                Console.Write(cotaInferior > cotaSuperior ? "\n " : ", ");
            }

            Console.WriteLine("----- Ejercicio 8. Version while: final -----\n");
        }

        public static void Ejercicio8VersionDoWhile()
        {
            Console.WriteLine("----- Ejercicio 8. Version do-while: inicio -----\n");

            bool inputKO = true;
            int cotaInferior = 1;
            int cotaSuperior = 0;
            Console.WriteLine("Introduzca un valor superior a 1. Se mostrarán todos los enteros entre el " + cotaInferior.ToString() + " y el número introducido");

            while (inputKO)
            {
                Console.WriteLine("Cota superior escogida: ");
                inputKO = !int.TryParse(Console.ReadLine(), out cotaSuperior);

                if (inputKO)
                {
                    Console.WriteLine("Valor inválido. Reinténtelo");
                }
                else if (cotaSuperior < cotaInferior)
                {
                    inputKO = true;
                    Console.WriteLine("Valor fuera de rango. Debe ser mayor que " + cotaInferior.ToString() + ". Reinténtelo");
                }
            }

            do
            {
                //Post incremento, primero evalua valor para la operación, luego incrementa variable
                Console.Write(cotaInferior++);
                Console.Write(cotaInferior > cotaSuperior ? "\n " : ", ");
            } while (cotaInferior <= cotaSuperior);

            Console.WriteLine("----- Ejercicio 8. Version do-while: final -----\n");
        }

        public static void Ejercicio9()
        {
            Console.WriteLine("----- Ejercicio 9: inicio -----\n");

            bool inputKO = true;
            const int COTA_INFERIOR = 1;
            int cotaSuperior = 0;
            Console.WriteLine("Introduzca un valor superior a 1. Se mostrarán todos los enteros impares entre el " + COTA_INFERIOR.ToString() + " y el número introducido excepto 15 y 21");

            while (inputKO)
            {
                Console.WriteLine("Cota superior escogida: ");
                inputKO = !int.TryParse(Console.ReadLine(), out cotaSuperior);

                if (inputKO)
                {
                    Console.WriteLine("Valor inválido. Reinténtelo");
                }
                else if (cotaSuperior < COTA_INFERIOR)
                {
                    inputKO = true;
                    Console.WriteLine("Valor fuera de rango. Debe ser mayor que " + COTA_INFERIOR.ToString() + ". Reinténtelo");
                }
            }

            for (int i = COTA_INFERIOR; i <= cotaSuperior; i += 2)
            {
                if (i == 15 || i == 21)
                {
                    continue;
                }
                Console.Write(i.ToString());
                Console.Write(i + 2 >= cotaSuperior ? "\n" : ", ");
            }

            Console.WriteLine("----- Ejercicio 9: final -----\n");
        }

        public static void Ejercicio10VersionIncremental()
        {
            Console.WriteLine("----- Ejercicio 10. Versión incremental: inicio -----\n");

            bool inputOK = true;
            int numValores = 0, numMin = 0, numMax = 0;
            float numMedia = 0F; //La media puede ser decimal. Asumimos media aritmética
            Console.WriteLine("Introduzca valores enteros hasta que desee. Para indicar que no desea, introduzca cualquier valor que no sea entero. " +
                              "Se mostrarán la cantidad de valores, su media, su máximo y su mínimo");

            //Mientras usuario pase valor entero válido
            while (inputOK)
            {
                int inputValor;

                Console.WriteLine("Introduzca valor: ");
                inputOK = int.TryParse(Console.ReadLine(), out inputValor);

                if (!inputOK)
                {
                    Console.WriteLine("Valor no entero. Fin de ejecución");
                }
                else
                {

                    numMax = inputValor > numMax || numValores == 0 ? inputValor : numMax;
                    numMin = inputValor < numMin || numValores == 0 ? inputValor : numMin;
                    //Para la media: desnormalizamos cálculo anterior, actualizamos suma y ponderamos por la nueva cantidad de valores
                    numMedia *= numValores;
                    numMedia += inputValor;
                    //Preincrementamos valores para que la ponderación sera correcta y admitir primera iteración. Todo en uno.
                    numMedia /= ++numValores;

                    Console.WriteLine("Número valores: " + numValores.ToString());
                    Console.WriteLine("Número mínimo: " + numMin.ToString());
                    Console.WriteLine("Número máximo: " + numMax.ToString());
                    Console.WriteLine("Media aritmética: " + numMedia.ToString());
                }
            }

            Console.WriteLine("----- Ejercicio 10. Versión incremental: final -----\n");
        }

        public static void Ejercicio10VersionTotal()
        {
            Console.WriteLine("----- Ejercicio 10. Versión total: inicio -----\n");

            bool inputOK = true;
            const int BUFFER_SIZE = 3;
            int pos_buffer = 0;
            int numMin, numMax;
            float numMedia; //La media puede ser decimal. Asumimos media aritmética

            //Inicializamos con un tamaño. Si se va a exceder, hacemos copia de objeto actual y reinstanciamos objeto doblando capacidad, luego copiamos lo acumulado
            int[] valores = new int[BUFFER_SIZE];

            Console.WriteLine("Introduzca valores enteros hasta que desee. Para indicar que no desea, introduzca cualquier valor que no sea entero. " +
                              "Se mostrarán la cantidad de valores, su media, su máximo y su mínimo");

            //Mientras usuario pase valor entero válido
            while (inputOK)
            {
                Console.WriteLine("Introduzca valor: ");
                inputOK = int.TryParse(Console.ReadLine(), out valores[pos_buffer]);

                if (!inputOK)
                {
                    Console.WriteLine("Valor no entero. Calculamos resultado");
                }
                else
                {
                    //Lectura correcta. Desplazamos posición y validamos si toca redimensionar matriz
                    if (++pos_buffer == valores.Length)
                    {
                        int[] tmp_valores = new int[valores.Length];
                        valores.CopyTo(tmp_valores, 0);

                        //Como se evalua de izquierda a derecha, es válido.
                        valores = new int[valores.Length + BUFFER_SIZE];
                        //Copiamos, no igualamos variables.
                        //valores = tmp_valores no sería correcto. Al ser por referencia, necesitamos un volcado exacto o al salir del if valores = null... 
                        tmp_valores.CopyTo(valores, 0);
                    }
                }
            }

            //OJO: Calculamos parámetros dentro de la colección de valores introducidos, no de todo el array
            //Este está sobredimensionado para que siempre haya espacio

            //Inicializamos para tener comparación relativa a la colección de valores (siempre dentro de rango)
            numMax = valores[0];
            numMin = valores[0];
            numMedia = 0F;

            for (int i = 0; i < pos_buffer; i++)
            {
                numMax = valores[i] > numMax ? valores[i] : numMax;
                numMin = valores[i] < numMin ? valores[i] : numMin;
                numMedia += valores[i];
            }

            Console.WriteLine("Número valores: " + pos_buffer.ToString());
            Console.WriteLine("Número mínimo: " + numMin.ToString());
            Console.WriteLine("Número máximo: " + numMax.ToString());
            Console.WriteLine("Media aritmética: " + (pos_buffer == 0 ? 0 : numMedia / pos_buffer).ToString());

            Console.WriteLine("----- Ejercicio 10: final -----\n");
        }

        public static void Ejercicio11()
        {
            Console.WriteLine("----- Ejercicio 11: inicio -----\n");

            bool inputKO = true;
            const int COTA_INFERIOR = 0;
            const int COTA_SUPERIOR = 10;
            int valor = 0;

            Console.WriteLine("Introduzca un entero superior a " + COTA_INFERIOR.ToString() + " e inferior a " + COTA_SUPERIOR.ToString() + ". Se mostrará la valoración del examen");

            while (inputKO)
            {
                Console.WriteLine("Valor a introducir: ");
                inputKO = !int.TryParse(Console.ReadLine(), out valor);

                if (inputKO)
                {
                    Console.WriteLine("Valor inválido. Reinténtelo");
                }
                else if (valor < COTA_INFERIOR || valor > COTA_SUPERIOR)
                {
                    inputKO = true;
                    Console.WriteLine("Valor fuera de rango. Debe ser mayor que " + COTA_INFERIOR.ToString() + " e inferior a " + COTA_SUPERIOR.ToString() + ". Reinténtelo");
                }
            }

            //Anidamos cases para que salen instrucciones que dan mismo resultado
            switch (valor)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                    Console.WriteLine("Suspenso");
                    break;
                case 5:
                case 6:
                    Console.WriteLine("Aprobado");
                    break;
                case 7:
                case 8:
                    Console.WriteLine("Notable");
                    break;
                case 9:
                case 10:
                    Console.WriteLine("Sobresaliente");
                    break;
            }

            Console.WriteLine("----- Ejercicio 11: final -----\n");
        }

        public static void Ejercicio12()
        {
            Console.WriteLine("----- Ejercicio 12: inicio -----\n");

            bool inputKO = true;
            int valorA = 0, valorB = 0;
            int numValores = 0;

            Console.WriteLine("Introduzca dos numeros enteros para detectar cual es mayor");

            while (numValores < 2)
            {
                if(numValores < 1)
                {
                    Console.WriteLine("Valor A: ");

                    inputKO = !int.TryParse(Console.ReadLine(), out valorA);

                    if (inputKO)
                    {
                        Console.WriteLine("Valor A inválido. Reinténtelo");
                    }
                    else
                    {
                        numValores++;
                    }
                }
                else
                {
                    Console.WriteLine("Valor B: ");

                    inputKO = !int.TryParse(Console.ReadLine(), out valorB);
                    if (inputKO)
                    {
                        Console.WriteLine("Valor B inválido. Reinténtelo");
                    }
                    else
                    {
                        numValores++;
                    }
                }
            }

            Console.WriteLine("El valor más grande es " + (valorA > valorB ? "A" : "B"));

            Console.WriteLine("----- Ejercicio 12: final -----\n");
        }

        public static void Ejercicio13()
        {
            Console.WriteLine("----- Ejercicio 13: inicio -----\n");

            bool inputKO = true;
            bool esPrimo = true;
            int valor = 0;

            Console.WriteLine("Introduzca un número entero para saber si es primo o no");

            while (inputKO)
            {
                Console.WriteLine("Valor a evaluar: ");
                inputKO = !int.TryParse(Console.ReadLine(), out valor);

                if (inputKO)
                {
                    Console.WriteLine("Valor inválido. Reinténtelo");
                }
                else if (valor <= 1)
                {
                    inputKO = true;
                    Console.WriteLine("Valor fuera de rango. Debe ser superior a 1. Reinténtelo");
                }
            }

            //Asumimos que es primo. Si se detecta, se corrige el flag y detenemos búsqueda
            for(int i = 2; i < valor; i++)
            {
                if (valor % i == 0)
                {
                    esPrimo = false;
                    break;
                }
            }

            Console.WriteLine("El número " + valor.ToString() + (esPrimo ? " es primo" : " no es primo"));

            Console.WriteLine("----- Ejercicio 13: final -----\n");
        }

        public static void Ejercicio14()
        {
            Console.WriteLine("----- Ejercicio 14: inicio -----\n");

            int coste = 0, pago = 0, pend_devolver = 0, num_billetes = 0;
            //Se podria definir como enum fuera del método...
            int[] billetes = { 500, 200, 100, 50, 20, 10, 5 , 2, 1};
            bool Correcto = false;

            Console.WriteLine("Introduzca coste y pago (enteros) para cálculo de devolución: ");
            while (!Correcto || coste <= 0)
            {
                Console.WriteLine("Coste: ");
                Correcto = int.TryParse(Console.ReadLine(), out coste);
            }
            Correcto = false;

            while (!Correcto || pago < coste)
            {
                Console.WriteLine("Pago: ");
                Correcto = int.TryParse(Console.ReadLine(), out pago);
            }

            pend_devolver = pago - coste;
            Console.WriteLine("Devolución:");

            for (int i = 0; i < billetes.Length; i++)
            {
                //Empezar por el billete más alto posible
                if (billetes[i] > pend_devolver)
                {
                    continue;
                }

                //Validamos cuantos billetes de esta cantidad podemos devolver
                while (billetes[i] <= pend_devolver)
                {
                    pend_devolver = pend_devolver - billetes[i];
                    num_billetes++;
                }

                Console.WriteLine(billetes[i].ToString() + " X " + num_billetes.ToString());
                num_billetes = 0;
            }

            Console.WriteLine("----- Ejercicio 14: final -----\n");
        }
    }
}
