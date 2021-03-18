using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace TallerEntrega
{
    class menu
    {

        public static List<int> ListaNotas = new List<int>();
        public static List<Estudiantes> ListaNombres = new List<Estudiantes>();
        public static void MenuSecundario()
        {
            string opciones;
            double Opcion;
            do
            {
                bool DatoCorrecto = false;

                Console.Clear();
                gui.Marco(1, 110, 1, 25);
                Console.SetCursorPosition(10, 10); Console.WriteLine("1. agregar datos de estudiantes");
                Console.SetCursorPosition(10, 11); Console.WriteLine("2. listar datos de estudiantes");
                Console.SetCursorPosition(10, 12); Console.WriteLine("3. lista de notas de estudiantes");
                Console.SetCursorPosition(10, 13); Console.WriteLine("4. buscar datos de estudiantes");
                Console.SetCursorPosition(10, 14); Console.WriteLine("5. menu principal");

                do
                {
                    gui.BorrarLinea(10, 16, 90);
                    Console.SetCursorPosition(10, 15); Console.WriteLine("Seleccione una opcion");
                    Console.SetCursorPosition(10, 16); opciones = Console.ReadLine();

                    if (!Verificaciones.Vacio(opciones))
                        if (Verificaciones.TipoNumero(opciones))
                            DatoCorrecto = true;

                } while (!DatoCorrecto);


                Opcion = Convert.ToDouble(opciones);

                switch (Opcion)
                {
                    case 1:
                        menu.AgregarNombre();
                        break;
                    case 2:
                        menu.ListarNombre();
                        break;
                    case 3:
                        menu.ListarNotas();
                        break;
                    case 4:
                        menu.BuscarNombre();
                        break;
                    case 5:
                        gui.BorrarLinea(64, 20, 109);
                        Console.SetCursorPosition(40, 20); Console.WriteLine("volvera al menu anterior");
                        break;
                    default:
                        gui.BorrarLinea(57, 20, 109);
                        Console.SetCursorPosition(40, 20); Console.WriteLine("Opcion incorrecta");
                        Console.SetCursorPosition(40, 22); Console.WriteLine("presione una tecla para continuar");
                        Console.SetCursorPosition(40, 23); Console.ReadKey();
                        break;
                }

            } while (Opcion != 5);

        }

        static void AgregarNombre()
        {
            bool DatoValido = false;
            Console.Clear();
            string nombre;
            string codigo;
            string correo;
            string nota;
            string nota2;
            string nota3;

            gui.Marco(1, 110, 1, 25);
            Console.SetCursorPosition(10, 10); Console.WriteLine("Agrega los datos de estudiantes ");

            do
            {
                DatoValido = false;
                Console.SetCursorPosition(10, 11); Console.WriteLine("Digite el Codigo del estudiante");
                Console.SetCursorPosition(10, 12); codigo = Console.ReadLine();
                if (!Verificaciones.Vacio(codigo))
                {
                    gui.BorrarLinea(10, 12, 90);
                    if (Verificaciones.TipoNumeroCodigo(codigo))
                        if(Verificaciones.tamañoCodigo(codigo))
                            
                    {
                        DatoValido = true;
                    }
                }

            } while (!DatoValido);
            gui.BorrarLinea(10, 12, 90);

            if (Verificaciones.Existe(Convert.ToDouble(codigo)))
            {
                Console.SetCursorPosition(40, 20); Console.WriteLine("el Codigo ya existe");
                Console.SetCursorPosition(40, 21); Console.WriteLine("presione una tecla para continuar");
                Console.SetCursorPosition(40, 22); Console.ReadKey();

            }
            else
            {
                gui.BorrarLinea(10, 11, 90);
                do
                {
                    DatoValido = false;
                    Console.SetCursorPosition(10, 11); Console.WriteLine("Digite el nombre del estudiante");
                    Console.SetCursorPosition(10, 12); nombre = Console.ReadLine();

                        if (!Verificaciones.Vacio(nombre))
                        {
                            gui.BorrarLinea(10, 12, 90);
                            if (Verificaciones.TipoLetra(nombre))
                            {
                                DatoValido = true;
                            }
                        }
                    
                } while (!DatoValido);
                gui.BorrarLinea(10, 12, 90);

                do
                {
                    DatoValido = false;
                    gui.BorrarLinea(10, 11, 90);
                    Console.SetCursorPosition(10, 11); Console.WriteLine("Digite el Correo electronico ");
                    Console.SetCursorPosition(10, 12); correo = Console.ReadLine();

                    if (!Verificaciones.Vacio(correo))
                    {
                        gui.BorrarLinea(10, 12, 90);
                        if (Verificaciones.TipoCorreo(correo))
                        {
                            DatoValido = true;
                        }
                    }
                } while (!DatoValido);

                gui.BorrarLinea(10, 12, 90);
                gui.BorrarLinea(40, 20, 90);
                gui.BorrarLinea(40, 21, 90);

                do
                {
                    DatoValido = false;
                    gui.BorrarLinea(10, 11, 90);
                    Console.SetCursorPosition(10, 11); Console.WriteLine("Digite la nota 1 (1-5)");
                    Console.SetCursorPosition(10, 12); nota = Console.ReadLine();
                    nota = nota.Replace('.', ',');


                    if (!Verificaciones.Vacio(nota))
                    {
                        gui.BorrarLinea(10, 12, 90);
                        if (Verificaciones.TipoNumero(nota))
                        {
                            if (Convert.ToDouble(nota) > 5)
                            {
                                Console.SetCursorPosition(40, 20); Console.WriteLine("la nota debe ser de 1 a 5");
                                gui.BorrarLinea(65, 20, 90);

                            }
                            else
                                DatoValido = true;
                        }
                    }

                } while (!DatoValido);

                gui.BorrarLinea(10, 12, 90);
                gui.BorrarLinea(40, 20, 90);
                gui.BorrarLinea(40, 21, 90);

                do
                {
                    DatoValido = false;
                    gui.BorrarLinea(10, 11, 90);
                    Console.SetCursorPosition(10, 11); Console.WriteLine("Digite la nota 2 (1-5)");
                    Console.SetCursorPosition(10, 12); nota2 = Console.ReadLine();
                    nota2 = nota2.Replace('.', ',');


                    if (!Verificaciones.Vacio(nota2))
                    {
                        gui.BorrarLinea(10, 12, 90);
                        if (Verificaciones.TipoNumero(nota2))
                        {
                            if (Convert.ToDouble(nota2) > 5)
                            {
                                Console.SetCursorPosition(40, 20); Console.WriteLine("la nota debe ser de 1 a 5");
                                gui.BorrarLinea(65, 20, 90);

                            }
                            else
                            DatoValido = true;
                        }
                    }

                } while (!DatoValido);

                gui.BorrarLinea(10, 12, 90);
                gui.BorrarLinea(40, 20, 90);
                gui.BorrarLinea(40, 21, 90);

                do
                {
                    DatoValido = false;
                    gui.BorrarLinea(10, 11, 90);
                    Console.SetCursorPosition(10, 11); Console.WriteLine("Digite la nota 3 (1-5)");
                    Console.SetCursorPosition(10, 12); nota3 = Console.ReadLine();
                    nota3 = nota3.Replace('.', ',');


                    if (!Verificaciones.Vacio(nota3))
                    {
                        gui.BorrarLinea(10, 12, 90);
                        if (Verificaciones.TipoNumero(nota3))
                        {
                            if (Convert.ToDouble(nota3) > 5)
                            {
                                Console.SetCursorPosition(40, 20); Console.WriteLine("la nota debe ser de 1 a 5");
                                gui.BorrarLinea(65, 20, 90);
                            }
                            else
                                DatoValido = true;
                        }
                    }

                } while (!DatoValido);


                Estudiantes myEstudiantes = new Estudiantes();
                myEstudiantes.codigo = Convert.ToDouble(codigo);
                myEstudiantes.nombre = nombre;
                myEstudiantes.correo = correo;
                myEstudiantes.nota1 = Convert.ToDouble(nota);
                myEstudiantes.nota2 = Convert.ToDouble(nota2);
                myEstudiantes.nota3 = Convert.ToDouble(nota3);

                ListaNombres.Add(myEstudiantes);

                gui.BorrarLinea(10, 12, 90);
                gui.BorrarLinea(10, 12, 90);
                Console.SetCursorPosition(40, 21); Console.WriteLine("presione una tecla para continuar");
                Console.SetCursorPosition(40, 22); Console.ReadKey();
                gui.BorrarLinea(40, 20, 90);
                gui.BorrarLinea(40, 21, 90);

            }
        }

        public static void ListarNombre()
        {
            int altura = 7;
            Console.Clear();
            gui.Marco(1, 110, 1, 25);
            Console.SetCursorPosition(10, 5); Console.WriteLine("CODIGO");
            Console.SetCursorPosition(25, 5); Console.WriteLine("NOMBRE");
            Console.SetCursorPosition(60, 5); Console.WriteLine("CORREO ELECTRONICO");
            


            foreach (Estudiantes estudiante in ListaNombres)
            {
                Console.SetCursorPosition(10, altura); Console.WriteLine(estudiante.codigo);
                Console.SetCursorPosition(25, altura); Console.WriteLine(estudiante.nombre);
                Console.SetCursorPosition(60, altura); Console.WriteLine(estudiante.correo);
                altura++;
            }
            Console.SetCursorPosition(40, 21); Console.WriteLine("presione una tecla para continuar");
            Console.SetCursorPosition(40, 22); Console.ReadKey();
        }

        static void ListarNotas()
        {
            int altura = 7;
            Console.Clear();
            gui.Marco(1, 110, 1, 25);
            Console.SetCursorPosition(10, 5); Console.WriteLine("CODIGO");
            Console.SetCursorPosition(25, 5); Console.WriteLine("NOMBRE");
            Console.SetCursorPosition(60, 5); Console.WriteLine("NOTA 1");
            Console.SetCursorPosition(68, 5); Console.WriteLine("NOTA 2");
            Console.SetCursorPosition(76, 5); Console.WriteLine("NOTA 3");
            Console.SetCursorPosition(84, 5); Console.WriteLine("NOTA FINAL");
            Console.SetCursorPosition(96, 5); Console.WriteLine("APROBO");



            foreach (Estudiantes estudiante in ListaNombres)
            {
                Console.SetCursorPosition(10, altura); Console.WriteLine(estudiante.codigo);
                Console.SetCursorPosition(25, altura); Console.WriteLine(estudiante.nombre);
                Console.SetCursorPosition(60, altura); Console.WriteLine(estudiante.nota1);
                Console.SetCursorPosition(68, altura); Console.WriteLine(estudiante.nota2);
                Console.SetCursorPosition(76, altura); Console.WriteLine(estudiante.nota3);
                Console.SetCursorPosition(84, altura); Console.WriteLine(Math.Round(((estudiante.nota3+estudiante.nota2+estudiante.nota1)/3),2));
                Console.SetCursorPosition(96, altura); menu.NotaFinal(estudiante.nota1,estudiante.nota2,estudiante.nota3);
                altura++;
            }
            Console.SetCursorPosition(40, 21); Console.WriteLine("presione una tecla para continuar");
            Console.SetCursorPosition(40, 22); Console.ReadKey();
        }

        static void BuscarNombre()
        {
            Console.Clear();
            gui.Marco(1, 110, 1, 25);
            string NombreABuscar;
            bool DatoValido = false;           

            do
            {
                Console.SetCursorPosition(10, 11); Console.WriteLine("Digite el codigo del estudiante que desea buscar");
                Console.SetCursorPosition(10, 12); NombreABuscar = Console.ReadLine();
                if (!Verificaciones.Vacio(NombreABuscar))
                    if (Verificaciones.TipoNumeroCodigo(NombreABuscar))
                        if (Verificaciones.TipoNumero(NombreABuscar))
                        DatoValido = true;
                gui.BorrarLinea(10, 12, 90);
            } while (!DatoValido);
            gui.BorrarLinea(40, 20, 90);
            if (Verificaciones.Existe(Convert.ToInt32(NombreABuscar)))
            {
                gui.BorrarLinea(10, 11, 90);
                Estudiantes myEstudiantes = obtenerDato(Convert.ToInt32(NombreABuscar));

                Console.SetCursorPosition(10, 5); Console.WriteLine("CODIGO");
                Console.SetCursorPosition(25, 5); Console.WriteLine("NOMBRE");
                Console.SetCursorPosition(60, 5); Console.WriteLine("NOTA 1");
                Console.SetCursorPosition(68, 5); Console.WriteLine("NOTA 2");
                Console.SetCursorPosition(76, 5); Console.WriteLine("NOTA 3");
                Console.SetCursorPosition(84, 5); Console.WriteLine("NOTA FINAL");
                Console.SetCursorPosition(96, 5); Console.WriteLine("APROBO");

                Console.SetCursorPosition(10, 7); Console.WriteLine(myEstudiantes.codigo);
                Console.SetCursorPosition(25, 7); Console.WriteLine(myEstudiantes.nombre);
                Console.SetCursorPosition(60, 7); Console.WriteLine(myEstudiantes.nota1);
                Console.SetCursorPosition(68, 7); Console.WriteLine(myEstudiantes.nota2);
                Console.SetCursorPosition(76, 7); Console.WriteLine(myEstudiantes.nota3);
                Console.SetCursorPosition(84, 7); Console.WriteLine(Math.Round(((myEstudiantes.nota3 + myEstudiantes.nota2 + myEstudiantes.nota1) / 3), 2));
                Console.SetCursorPosition(96, 7); menu.NotaFinal(myEstudiantes.nota1, myEstudiantes.nota2, myEstudiantes.nota3);

                Console.SetCursorPosition(40, 21); Console.WriteLine("presione una tecla para continuar");
                Console.SetCursorPosition(40, 22); Console.ReadKey();
            }
            else
            {
                Console.SetCursorPosition(40, 20); Console.WriteLine("El codigo " + NombreABuscar + " no existe");
                Console.SetCursorPosition(40, 21); Console.WriteLine("presione una tecla para continuar");
                Console.SetCursorPosition(40, 22); Console.ReadKey();
            }
        }

        static Estudiantes obtenerDato (int codigo)
        {
            
            foreach (Estudiantes myEstudiantes in ListaNombres)
            {
                if (myEstudiantes.codigo == codigo)                
                    return myEstudiantes;                
            }
            return null;
            
        }

        public static void NotaFinal(double nota1, double nota2, double nota3)
        {
           
            double notaFinal;
            
            notaFinal = (nota1 + nota2 + nota3) / 3;

            if (notaFinal > 3.5)
                Console.WriteLine("APROBO");
            else
                Console.WriteLine("NO APROBO");


        }
        public static void GuardarArchivoXML()
        {
            XmlSerializer codificador = new XmlSerializer(typeof(List<Estudiantes>));
            TextWriter escribirXml = new StreamWriter("D:/RealizarDiseñoOrientadoObjetosLenguajedeProgramaciónI.NET/datos/ArchivoNombres.xml");
            codificador.Serialize(escribirXml, ListaNombres);
            escribirXml.Close();
        }

        public static void CargarArchivoXML()
        {
            if (File.Exists("D:/RealizarDiseñoOrientadoObjetosLenguajedeProgramaciónI.NET/datos/ArchivoNombres.xml"))
            {
                ListaNombres.Clear();
                XmlSerializer codificador = new XmlSerializer(typeof(List<Estudiantes>));
                FileStream leerXml = File.OpenRead("D:/RealizarDiseñoOrientadoObjetosLenguajedeProgramaciónI.NET/datos/ArchivoNombres.xml");
                ListaNombres = (List<Estudiantes>)codificador.Deserialize(leerXml);
                leerXml.Close();
            }
        }

    }
}
