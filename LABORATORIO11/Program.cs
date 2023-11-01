using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORIO11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int opcion = Pantallas.pantallaPrincipal();
            do
            {
                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        opcion = Pantallas.registrarNota();
                        break;
                    case 2:
                        opcion = Pantallas.notaMayor();
                        break;
                    case 3:
                        opcion = Pantallas.notaMenor();
                        break;
                    case 4:
                        opcion = Pantallas.encontrarNota();
                        break;
                    case 5:
                        opcion = Pantallas.modificarNota();
                        break;
                    case 6:
                        opcion = Pantallas.notasRegistradas();
                        break;
                    case 0:
                    default:
                        opcion = Pantallas.pantallaPrincipal();
                        break;
                }
            }while (opcion != 7);

        } 
    }
}
