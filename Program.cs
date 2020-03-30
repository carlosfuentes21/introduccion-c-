using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suma
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=0, b=0, c=0, d=0, suma=0;
            float prom = 0;
            string cadena = "";

            //EJERCICIOS DE OPERADORES
            //operadores1();
            //operadores2(a, b, c, d);
            //operadores3(a, b, c, d);

            //EJERCICIOS DE SENTENCIAS CONDICIONALES IF-ELSE
            //condicionales1(a, b);
            //condicionales2(a, b, c, prom);
            //condicionales3(a);

            //EJERCICIOS DE SENTENCIAS CONDICIONALES SWICTH
            //switch1(a);
            //switch2(cadena);

            //EJERCICIOS DE BLOQUES REPETITIVOS WHILE
            //while1();
            //while2(a);
            //while3(suma,prom);
            //while4(a,b,suma, prom);

            //EJERCICIOS DE BLOQUES REPETITIVOS FOR
            //for1();
            //for2(suma);
            //for3(a,b,c);
            //for4(a, b);

            //EJERCICIOS DE BLOQUES REPETITIVOS DO-WHILE
            //doWhile1(a);
            //doWhile2(a, suma, prom);
            //doWhile3(a, suma);

            //EJERCICIO DE BLOQUES REPETITIVOS FOREACH
            //foreach1(a);

            //EJERCICIO DE ERRORES
            //errores1();


            Console.ReadKey();
        }
        public static void operadores1()
        {
            //ejercicio del cuadrado
            Console.WriteLine("perimetro de un cuadrado");
            Console.WriteLine("digite el lado del cuadrado");
            Console.WriteLine("el perimetro es = " + ((int.Parse(Console.ReadLine())) * 4));
        }
         public static void operadores2(int a, int b, int c, int d)
        {
            //ejercicio de suma y producto
            Console.WriteLine("ejercicio de suma y producto");
            Console.WriteLine("digite el primer numero");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("digite el segundo numero");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("digite el tercer numero");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("digite el cuarto numero");
            d = int.Parse(Console.ReadLine());
            Console.WriteLine("la suma los primeros es = " + (a + b));
            Console.WriteLine("el producto del tercero y el cuarto es = " + (c * d));
        }

        public static void operadores3(int a, int b, int c, int d)
        {
            //ejercicio de promedio de 4 numeros
            Console.WriteLine("ejercicio de suma y promedio");
            Console.WriteLine("digite el primer numero");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("digite el segundo numero");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("digite el tercer numero");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("digite el cuarto numero");
            d = int.Parse(Console.ReadLine());
            int suma = a + b + c + d; ;
            Console.WriteLine("la suma los numeros es = " + suma);
            Console.WriteLine("el promedio de los numeros es = " + (Convert.ToSingle(suma) / 4));//se convierte de int a float
        }

        public static void condicionales1(int a, int b)
        {
            Console.WriteLine("digite el primer numero");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("digite el segundo numero");
            b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("la suma es = " + (a + b));
                Console.WriteLine("la resta es = " + (a - b));
            }
            else
            {
                Console.WriteLine("producto es = " + (a * b));
                Console.WriteLine("division es = " + (Convert.ToSingle(a) / b));
            }
        }

        public static void condicionales2(int a, int b, int c, float prom)
        {
            Console.WriteLine("digite la primera nota");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("digite la segunda nota");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("digite la tercera nota");
            c = int.Parse(Console.ReadLine());
            prom = (a + b + c) / 3;
            if( prom >= 7)
            {
                Console.WriteLine("promocionado");
            }
            else
            {
                Console.WriteLine("no promocionado");
            }
        }

        public static void condicionales3(int a)
        {
            Console.WriteLine("digite el numero de 1 o dos cifras");
            a = int.Parse(Console.ReadLine());
            if (a < 10)
            {
                Console.WriteLine("el numero es de una cifra");
            }
            else if(a < 100)
            {
                Console.WriteLine("el numero es de dos cifras");
            }
            else
            {
                Console.WriteLine("el numero debe ser de una o dos cifras");
            }
        }

        public static void switch1(int a)
        {
            Console.WriteLine("digite el numero entre 1 y 5");
            a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Console.WriteLine("uno");
                    break;
                case 2:
                    Console.WriteLine("dos");
                    break;
                case 3:
                    Console.WriteLine("tres");
                    break;
                case 4:
                    Console.WriteLine("cuatro");
                    break;
                case 5:
                    Console.WriteLine("cinco");
                    break;
                default:
                    Console.WriteLine("numero no valido");
                    break;
            }
        }

        public static void switch2(string cadena)
        {
            Console.WriteLine("digite el numero escrito entre 1 y 5");
            cadena = Console.ReadLine();
            switch (cadena)
            {
                case "uno":
                    Console.WriteLine(1);
                    break;
                case "dos":
                    Console.WriteLine(2);
                    break;
                case "tres":
                    Console.WriteLine(3);
                    break;
                case "cuatro":
                    Console.WriteLine(4);
                    break;
                case "cinco":
                    Console.WriteLine(5);
                    break;
                default:
                    Console.WriteLine("numero no valido");
                    break;
            }
        }

        public static void while1()
        {
            int i = 1;
            while (i <= 100)
            {
                Console.Write(i+" ");
                i++;
            }
        }

        public static void while2(int a)
        {
            Console.WriteLine("digite el numero maxamo");
            a = int.Parse(Console.ReadLine());
            int i = 1;
            while (i <= a)
            {
                Console.Write(i + " ");
                i++;
            }
        }

        public static void while3(int suma, float prom)
        {
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine("digite un numero");
                suma += int.Parse(Console.ReadLine());
                i++;
            }
            prom = suma / 10;
            Console.WriteLine(prom);
        }

        public static void while4(int a, int b, int suma, float prom)
        {
            Console.WriteLine("digite el numero de piezas");
            a = int.Parse(Console.ReadLine());
            int i = 1, cont = 0;
            while (i <= a)
            {
                Console.WriteLine("digite la medida de la pieza");
                b = int.Parse(Console.ReadLine());
                if(b>120 && b<130){
                    cont++;
                }
                i++;
            }
            Console.WriteLine("el numero de piezas aptas es");
            Console.WriteLine(cont);
        }

        public static void for1()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.Write(i+" ");
            }
        }

        public static void for2(int suma)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("digite el numero");
                suma += int.Parse(Console.ReadLine());
            }
            Console.Write("la suma es = "+ suma);
            Console.Write("y el promedio es "+(Convert.ToSingle(suma)/10));
        }

        public static void for3(int a, int b, int c)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("digite la nota");
                a = int.Parse(Console.ReadLine());
                if (a >= 7)
                {
                    b++;
                }
                else
                {
                    c++;
                }
            }
            Console.WriteLine("mayores o iguales a 7 = " + b);
            Console.WriteLine("menores a 7 = " + c);
        }

        public static void for4(int a, int b, int c)
        {
            Console.WriteLine("digite la cantidad de valores");
            a = int.Parse(Console.ReadLine());

            for (int i = 1; i <= a; i++)
            {
                Console.WriteLine("digite el numero");
                b = int.Parse(Console.ReadLine());
                if (b >= 1000)
                {
                    c++;
                }
            }
            Console.WriteLine("mayores o iguales a 1000 = " + c);
        }

        public static void doWhile1(int a)
        {
            do
            {
                Console.WriteLine("digite el numero");
                a = int.Parse(Console.ReadLine());
                if (a < 10)
                {
                    Console.WriteLine("un digito");
                }
                else if (a < 100)
                {
                    Console.WriteLine("dos digitos");
                }
                else if(a < 1000)
                {
                    Console.WriteLine("tres digitos");
                }
                else
                {
                    Console.WriteLine("es mayor de 3 digitos");
                }
            } while (a != 0);
        }

        public static void doWhile2(int a, int suma, float prom)
        {
            int i = 0;
            do
            {
                Console.WriteLine("digite el numero");
                a = int.Parse(Console.ReadLine());
                suma += a;
                i++;
                prom = Convert.ToSingle(suma) / i;
            } while (a != 0);
            Console.WriteLine(prom);
        }

        public static void doWhile3(int a, int suma)
        {
            do
            {
                Console.WriteLine("digite el numero");
                a = int.Parse(Console.ReadLine());
                if (a != 9999)
                {
                    suma += a;
                }
            } while (a !=9999);
            Console.WriteLine(suma);
            if (suma < 0)
            {
                Console.WriteLine("es memor que cero");
            }
            else if(suma == 0)
            {
                Console.WriteLine("es igual que cero");
            }
            else
            {
                Console.WriteLine("es mayor que cero");
            }
        }

        public void foreach1(int a)
        {
            Console.WriteLine("digite el numero de elementos");
            a = int.Parse(Console.ReadLine());
            int [] elementos = new int[a];
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("digite el elemento");
                elementos[i] = int.Parse(Console.ReadLine());
            }
            foreach (var e in elementos)
            {
                Console.WriteLine(e);
            }
        }

        public static void errores1()
        {
            try
            {
                int i = 10;
                float I = i / 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
