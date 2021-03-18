using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace TallerEntrega
{
    class Verificaciones
    {

        public static bool TipoLetra(string texto)
        {
            Regex Regla = new Regex("^[a-zA-Z ]*$");

            if (Regla.IsMatch(texto))
                return true;
            else
            {
                gui.BorrarLinea(40, 20, 90);
                gui.BorrarLinea(10, 14, 90);
                Console.SetCursorPosition(40, 20); Console.WriteLine("el nombre debe ser texto");
                return false;
            }
        }
        public static bool Existe(double codigo)

        {
            bool aux = false;

            foreach (Estudiantes persona in menu.ListaNombres)
            {
                if (persona.codigo == codigo)
                {
                    aux = true;
                }
            }
            return aux;
        }

        public static bool Vacio(string texto)
        {

            if (texto.Equals(""))
            {
                gui.BorrarLinea(40, 20, 90);
                
                Console.SetCursorPosition(40, 20); Console.WriteLine("la opcion no debe estar vacia");
                return true;
            }
            else
                return false;
        }

        public static bool TipoNumero(string numero)
        {
            Regex regla = new Regex("[0-9]{1,9}(\\.[0-9]{0,2})?$");

            if (regla.IsMatch(numero))
                return true;
            else
            {
                gui.BorrarLinea(40, 20, 90);
                
                Console.SetCursorPosition(40, 20); Console.WriteLine("la opcion debe ser un numero");
                return false;
            }
        }

        public static bool SiNo(string texto)
        {
            if (texto == "s" || texto == "S" || texto == "N" || texto == "n")
                return true;
            else
            {
                Console.SetCursorPosition(40, 21); Console.Write("La Entrada debe ser S o N  ");

                return false;
            }
        }

        public static bool TipoCorreo(string correo)
        {
            Regex regla = new Regex("\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*");

            if (regla.IsMatch(correo))
                return true;
            else
            {
                gui.BorrarLinea(40, 20, 90);
                gui.BorrarLinea(10, 14, 90);
                Console.SetCursorPosition(40, 20); Console.WriteLine("no es un correo valido");
                return false;
            }
        }
        public static bool TipoNumeroCodigo(string numero)
        {
            Regex regla = new Regex(@"^[0-9]+$");

            if (regla.IsMatch(numero))
                return true;
            else
            {
                gui.BorrarLinea(40, 20, 90);

                Console.SetCursorPosition(40, 20); Console.WriteLine("el codigo debe ser solo numeros");
                return false;
            }
        }

        public static bool tamañoCodigo (string numero)
        {         

            if (numero.Length <= 10)
                return true;
            else
            {
                gui.BorrarLinea(40, 20, 90);

                Console.SetCursorPosition(40, 20); Console.WriteLine("el codigo debe tener menos de 10 digitos");
                return false;
            }
        }

    }
}
