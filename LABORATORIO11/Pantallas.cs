using LABORATORIO11;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORIO11
{
    public class Pantallas
    {
        public static float[] notas = new float[20];
        public static int contador = 0;
        public static int pantallaPrincipal()
        {
            string texto ="================================\n" +
                "Casos con arreglos\n" +
                "================================\n" +
                "1: Registrar notas\n" +
                "2: Hallar la nota mayor\n" +
                "3: Hallar la nota menor\n" +
                "4: Encontrar una nota\n" +
                "5: Modificar una nota\n" +
                "6: Ver notas registradas\n" +
                "7: Salir\n" +
                "================================\n";
            Console.Write(texto);
            return Operaciones.getEntero("Ingrese una opción:", texto);   
        }
        public static int registrarNota()
        {
            string texto = "" +
                "================================\n" +
                "Registrar una nota\n" +
                "================================\n";
            Console.Write(texto);

            float ingresenota = Operaciones.getDecimal("Ingrese la nota: ");

            if (contador == 20)
            {
                Console.WriteLine("La lista ya esta llena");
            }
            notas[contador] = ingresenota;
            contador++;

            string texto2 = "================================\n" +
                "1: Registrar otra nota\n" +
                "2: Regresar\n";


            Console.Write(texto2);
            int opcion = Operaciones.getEntero("Ingrese una opción:", texto);
            if (opcion == 2) return 0;
            return opcion;
        }

        public static int notaMayor()
        {
            string texto = "================================\r\n" +
                "La nota mayor\r\n" +
                "================================\r\n" ;
            Console.Write(texto);
            int posicionMayor = 0;
            if (contador == 0)
            {
                Console.WriteLine("No existe producto todavia");
            }
            else
            {
                float mayor = notas[0];
                
                for (int i = 0; i < contador; i++)
                {
                    if (notas[i] > mayor)
                    {
                        mayor = notas[i];
                        posicionMayor = i;
                    }
                }

                float ingresenota = notas[posicionMayor];
                string notamayor = "La nota mayor es: "  + mayor + "\r\n";
                Console.WriteLine(notamayor);
            }

            if (contador == 0)
            {
                Console.WriteLine("No hay notas");
            }
            for (int i = 0; i < contador; i++)
            {
                if (i == posicionMayor)
                {
                    Console.Write(" [" + notas[i]+"]");
                }
                else
                {
                    Console.Write("  " + notas[i]);
                }
                
            }
            string texto2 = "\n================================" +
                "\n1: Regresar";

            Console.Write(texto2);
            int opcion = Operaciones.getEntero("\nIngrese una opción: ", texto);
            if (opcion == 1) return 0;
            return 0;
        }

        public static int notaMenor()
        {
            string texto = "================================\r\n" +
                "La nota menor\r\n" +
                "================================\r\n";
            Console.Write(texto);
            int posicionMenor = 0;
            if (contador == 0)
            {
                Console.WriteLine("No existe producto todavia");
            }
            else
            {
                float menor = notas[0];

                for (int i = 0; i < contador; i++)
                {
                    if (notas[i] < menor)
                    {
                        menor = notas[i];
                        posicionMenor = i;
                    }
                }

                float ingresenota = notas[posicionMenor];
                string notamenor = "La nota menor es: " + menor + "\r\n";
                Console.WriteLine(notamenor);
            }

            if (contador == 0)
            {
                Console.WriteLine("No hay notas");
            }
            for (int i = 0; i < contador; i++)
            {
                if (i == posicionMenor)
                {
                    Console.Write(" [" + notas[i] + "]");
                }
                else
                {
                    Console.Write("  " + notas[i]);
                }

            }
            string texto2 = "\n================================" +
                "\n1: Regresar";

            Console.Write(texto2);
            int opcion = Operaciones.getEntero("\nIngrese una opción: ", texto);
            if (opcion == 1) return 0;
            return 0;
        }

        public static int encontrarNota()
        {
            string texto = "" + "================================\r\n" +
                "Buscar nota\r\n" +
                "================================\r\n";
            Console.Write(texto);

            float valorBuscar = Operaciones.getDecimal("Ingrese la nota a buscar: ");
            int posicionEncontrada = -1;
            for(int i = 0; i < contador; i ++)
            {
                if(valorBuscar == notas[i])
                {
                    posicionEncontrada = i;
                }
            }

            if (posicionEncontrada == -1)
            {
                Console.Write("No se ha encontrado la nota");
            }
            else
            {

                string texto2 = "La nota está en la posición: " + posicionEncontrada + "\r\n";

                Console.Write(texto2);
                for (int i = 0; i < contador; i++)
                {
                        Console.WriteLine(i + " -> " + notas[i]);
                }
            }

            string texto3 = "================================\n"+
                "1: Regresar\n";

            Console.Write(texto3);
            int opcion = Operaciones.getEntero("\nIngrese una opción: ", texto);
            if (opcion == 1) return 0;
            return 0;
        }

        public static int modificarNota()
        {
            string texto = "================================\r\n" +
                "Modificar nota\r\n" +
                "================================\r\n";
            Console.Write(texto);

            int valorBuscar = Operaciones.getEntero("Ingrese la posición: ", texto);
            int nuevaNota = Operaciones.getEntero("Ingrese el nuevo valor: ", texto);
            string texto1 = "================================\n" +
                "Antes: ";

            Console.Write(texto1);
            for (int i = 0; i < contador; i++)
            {
                Console.Write(" - " + notas[i]);

            }

            string texto3 = "\nDespues: ";
            Console.Write(texto3);

            notas[valorBuscar] = nuevaNota;

            for (int i = 0; i < contador; i++)
            {
                Console.Write(" - " + notas[i]);

            }
            

            string texto2 = "\n================================" +
                "\n1: Regresar";


            Console.Write(texto2);
            int opcion = Operaciones.getEntero("Ingrese una opción: ", texto);
            if (opcion == 1) return 0;
            return opcion;
        }

        public static int notasRegistradas()
        {
            string texto = "" + "================================\r\n" +
                "Notas Registradas\r\n" +
                "================================\r\n" ;
            Console.Write(texto);

            Console.WriteLine("Notas actuales: ");
            if (contador == 0)
            {
                Console.WriteLine("No hay notas");
            }
            
            for (int i = 0; i < contador; i++)
            {
                Console.Write( " - " + notas[i]);
                if (i== contador - 1)
                {
                    Console.Write("\nSiguiente posición será: " + contador);
                }
            }

            string texto2 =  "\n================================" +
                "\n1: Regresar\n";


            Console.Write(texto2);
            int opcion = Operaciones.getEntero("\nIngrese una opción: ", texto);
            if (opcion == 1) return 0;
            return opcion;
        }
    }
}
