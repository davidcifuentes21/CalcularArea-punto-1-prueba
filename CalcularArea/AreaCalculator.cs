using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularArea
{
    public class AreaCalculator
    {
        public static void Main(string[] args)
        {
            int altura = 0, b = 0, opcion, areaRectangulo;
            double r = 0, areaCirculo;
            string seguir = "";
            do
            {
                Console.WriteLine("Por favor seleccione la figura que desea para calcular el area:");
                Console.WriteLine("1. Circulo");
                Console.WriteLine("2. Rectangulo");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        do
                        {
                            try
                            {
                                Console.WriteLine("Coloque el radio del circulo:");
                                r = Convert.ToDouble(Console.ReadLine());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("El valor del radio debe ser un numero");
                                r = 0;
                            }
                        } while(r == 0);

                        if(r != 0)
                        {
                            areaCirculo = Calculator.CircleCalculator(r);
                            Console.WriteLine("El area del circulo es: " + areaCirculo);
                        }
                        break;

                    case 2:
                        do
                        {
                            try
                            {
                                Console.WriteLine("Coloque la base del rectangulo: ");
                                b = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Coloque la altura del rectangulo: ");
                                altura = Convert.ToInt32(Console.ReadLine());
                            }
                            catch(Exception ex)
                            {
                                Console.WriteLine("El valor ingresado para la base y la altura debe ser un numero entero");
                            }
                        } while (b == 0 && altura == 0);

                        if (b != 0 && altura != 0)
                        {
                            areaRectangulo = Calculator.RectangleCalculator(altura, b);
                            Console.WriteLine("El area del rectangulo es: " + areaRectangulo);
                        }
                        break;

                    default:
                        Console.WriteLine("La opcion elegida no esta dentro de las mostradas");
                        break;
                }
                Console.WriteLine("Escriba 'si' si desea continuar ");
                seguir = Console.ReadLine();
            } while (seguir == "si" || seguir == "SI");
        }
    }
}
