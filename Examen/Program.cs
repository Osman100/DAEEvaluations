// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("Menú Principal:");
            Console.WriteLine("1. Ejercicio 1");
            Console.WriteLine("2. Ejercicio 2");
            Console.WriteLine("3. Salir");

            Console.Write("Ingrese la opción deseada: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Ejercicio1Clave2.RealizarEjercicio();
                    break;
                case "2":
                    Ejercicio2Clave2.RealizarEjercicio();
                    break;
                case "3":
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }
        }
    }
}







public class Ejercicio1Clave2
{
    public static void RealizarEjercicio()
    {
            String[] artista = new String[1000];
            String[] titulo = new String[1000];
            double[] duracion = new double[1000];
            double[] size = new double[1000];
            Boolean stopProgram = false;
            int songsSize = 0;

            String respuesta = "";

            for (int i = 0; stopProgram == false; i++)
            {
                Console.WriteLine("Bienvenido al programa de ingreso de datos de canciones");
                Console.WriteLine("A continuacion se le pediran algunos datos:");
                Console.WriteLine("Ingrese el nombre del artistas de la cancion:");
                artista[i] = Console.ReadLine();

                Console.WriteLine("Ingrese el titulo de la cancion:");
                titulo[i] = Console.ReadLine();

                Console.WriteLine("Ingrese la duracion de la cancion en segundos(solo ingrese el valor numerico)");
                duracion[i] = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el tama;o de la cancion en KB (solo ingrese el valor numerico)");
                size[i] = double.Parse(Console.ReadLine());

                songsSize++;

                Console.WriteLine("Los datos que se ingresaron son:");
                for (int j = 0; j < songsSize; j++)
                {
                    Console.WriteLine($"Cancion {j + 1}:");
                    Console.WriteLine($"Nombre del artista: {artista[j]}");
                    Console.WriteLine($"Titulo de la cancion: {titulo[j]}");
                    Console.WriteLine($"Duracion de la cancion: {duracion[j]} s");
                    Console.WriteLine($"Tama;o de la cancion: {size[j]} KB");
                    Console.WriteLine("------------------------------------------------");

                }

                Console.WriteLine("Desea ingresar los datos de otra cancion? [Si/No]");
                respuesta = Console.ReadLine();

                if (respuesta == "Si" || respuesta == "si")
                {
                    stopProgram = false;
                }
                else
                {
                    stopProgram = true;
                    Console.WriteLine("Gracias por usar el programa, que tenga un buen dia");
                }

            }

    }
}

public class Ejercicio2Clave2
{
    private static string[] codigoEstudiante = new string[1000];
    private static string[] nombreCompleto = new string[1000];
    private static string[] fechaNacimiento = new string[1000];
    private static string[] grado = new string[1000];
    private static string[] fechaRegistro = new string[1000];
    private static int totalEstudiantes = 0;

    public static void RealizarEjercicio()
    {
        bool mostrarMenu = true;
        while (mostrarMenu)
        {
            mostrarMenu = menuPrincipal();
        }
    }


    static public bool menuPrincipal()
    {
        Console.Clear();
        Console.WriteLine("Bienvenido menu escolar de estudiantes");

        Console.WriteLine("Menu escolar");
        Console.WriteLine("1. Agregar un alumno");
        Console.WriteLine("2. Mostrar listado de alumnos");
        Console.WriteLine("3. Buscar alumno por codigo");
        Console.WriteLine("4. Editar informacion de estudiante");
        Console.WriteLine("5. Salir del programa");
        Console.WriteLine("Seleccione el numero de opcion:");

        switch (Console.ReadLine())
        {
            case "1":
                agregarAlumno();
                return true;

            case "2":
                String respuestaLocal = "";
                mostrarAlumnos();
                Console.WriteLine("¿Desea regresar al menú? (Si o no)");
                respuestaLocal = Console.ReadLine();

                if (respuestaLocal == "Si" || respuestaLocal == "si")
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Gracias por usar el programa");
                    return false;

                }


            case "3":
                String respuestaLocal2 = "";

                mostrarAlumnoCodigo();
                Console.WriteLine("¿Desea regresar al menu principal? (Si o No)");
                respuestaLocal2 = Console.ReadLine();

                if (respuestaLocal2 == "Si" || respuestaLocal2 == "si")
                {
                    return true;
                }
                else
                {
                    return false;
                }



            case "4":
                editarInformation();
                return true;

            case "5":
                return false;

            default:
                Console.WriteLine("Se ingresó un valor no reconocido");
                return true;





        }

    }

    static void agregarAlumno()

    {
        bool agregarMasEstudiantes = true;
        String respuesta = "";
        Console.WriteLine("--------------Agregado de estudiantes---------------");
        for (int i = 0; agregarMasEstudiantes; i++)
        {
            Console.WriteLine("Ingrese el codigo del estudiante:");
            codigoEstudiante[i] = Console.ReadLine();

            Console.WriteLine("Ingrese el nombre completo del estudiant:");
            nombreCompleto[i] = Console.ReadLine();

            Console.WriteLine("Ingrese la fecha de nacimiento del estudiante:");
            fechaNacimiento[i] = Console.ReadLine();

            Console.WriteLine("Ingrese el grado del estudiante:");
            grado[i] = Console.ReadLine();

            Console.WriteLine("Ingrese la fecha de registro del estudiante");
            fechaRegistro[i] = Console.ReadLine();

            totalEstudiantes++;

            Console.WriteLine("¿Desea agregar otro estudiante? (Si/No)");
            respuesta = Console.ReadLine();

            if (respuesta == "Si" || respuesta == "si")
            {
                agregarMasEstudiantes = true;
            }
            else
            {
                agregarMasEstudiantes = false;
            }

        }



    }

    private static void mostrarAlumnos()
    {
        Console.WriteLine("----------Listado de alumnos-----------");
        Console.WriteLine("{0,-15} {1,-30} {2,-15} {3,-15} {4,-15}", "Código", "Nombre Completo", "Fecha Nacimiento", "Grado", "Fecha Registro");
        for (int i = 0; i < totalEstudiantes; i++)
        {
            Console.WriteLine("{0,-15} {1,-30} {2,-15} {3,-15} {4,-15}", codigoEstudiante[i], nombreCompleto[i], fechaNacimiento[i], grado[i], fechaRegistro[i]);
        }

    }

    private static void mostrarAlumnoCodigo()
    {
        String codigoLocal = "";
        int posicionAlumno = 0;
        bool encontroAlumno = false;
        Console.WriteLine("--------Mostrado de alumno por codigo--------");
        Console.WriteLine("Ingrese el codigo del alumno");
        codigoLocal = Console.ReadLine();

        for (int j = 0; j < totalEstudiantes; j++)
        {
            if (codigoEstudiante[j] == codigoLocal)
            {
                posicionAlumno = j;
                encontroAlumno = true;
            }
            else
            {
                encontroAlumno = false;

            }
        }
        if (encontroAlumno == true)
        {
            Console.WriteLine("De acuerdo al codigo ingresado, el alumno es:");
            Console.WriteLine("{0,-15} {1,-30} {2,-15} {3,-15} {4,-15}", "Código", "Nombre Completo", "Fecha Nacimiento", "Grado", "Fecha Registro");
            Console.WriteLine("{0,-15} {1,-30} {2,-15} {3,-15} {4,-15}", codigoEstudiante[posicionAlumno], nombreCompleto[posicionAlumno], fechaNacimiento[posicionAlumno], grado[posicionAlumno], fechaRegistro[posicionAlumno]);

        }


    }

    private static void editarInformation()
    {
        String codigoLocal = "";
        int posicionAlumno = 0;
        bool encontroAlumno = false;
        Console.WriteLine("Editado de informacion de un estudiante");
        Console.WriteLine("Ingrese el codigo del alumno que quiere editar");
        codigoLocal = Console.ReadLine();


        for (int j = 0; j < totalEstudiantes; j++)
        {
            if (codigoEstudiante[j] == codigoLocal)
            {
                posicionAlumno = j;
                encontroAlumno = true;
            }
            else
            {
                encontroAlumno = false;

            }
        }
        if (encontroAlumno == true)
        {
            Console.WriteLine("Ingrese el codigo del estudiante:");
            codigoEstudiante[posicionAlumno] = Console.ReadLine();

            Console.WriteLine("Ingrese el nombre completo del estudiant:");
            nombreCompleto[posicionAlumno] = Console.ReadLine();

            Console.WriteLine("Ingrese la fecha de nacimiento del estudiante:");
            fechaNacimiento[posicionAlumno] = Console.ReadLine();

            Console.WriteLine("Ingrese el grado del estudiante:");
            grado[posicionAlumno] = Console.ReadLine();

            Console.WriteLine("Ingrese la fecha de registro del estudiante");
            fechaRegistro[posicionAlumno] = Console.ReadLine();

            Console.WriteLine($"Se ha editado la informacion del estudiante con codigo {codigoLocal}");

        }
        else
        {
            Console.WriteLine("No se encontro el estudiante");
        }

    }
}




    





