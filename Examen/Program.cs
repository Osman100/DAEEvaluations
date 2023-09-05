//Programador: Osman Robles --- Carnet: 194723
class Program
{
    //Menu principal desde donde se llaman las otras dos clases
    static void Main(string[] args)
    {
        bool salir = false;

        while (!salir)

        {
            Console.Clear();
            Console.WriteLine("---------Menú Principal del programa---------");
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
                    Console.WriteLine("Gracias por utilizar el programa, que tenga un buen día");
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }
        }
    }
}






//Clase para el ejercicio 1
public class Ejercicio1Clave2
{
    public static void RealizarEjercicio()
    {
            //Declaración de arreglos para datos de la cancion
            String[] artista = new String[1000];
            String[] titulo = new String[1000];
            double[] duracion = new double[1000];
            double[] size = new double[1000];


            //Variables auxiliares
            Boolean stopProgram = false;
            int songsSize = 0;
            String respuesta = "";

            //Bucle para ir agregando canciones
            for (int i = 0; stopProgram == false; i++)
            {

                Console.WriteLine("Bienvenido al programa de ingreso de datos de canciones");
                Console.WriteLine("A continuacion se le pediran algunos datos");
                Console.WriteLine("----------------------------------------------\n");
            
                Console.WriteLine("Ingrese el nombre del artista de la canción:");
                artista[i] = Console.ReadLine();

                Console.WriteLine("Ingrese el título de la canción:");
                titulo[i] = Console.ReadLine();

                Console.WriteLine("Ingrese la duración de la canción en segundos (solo ingrese el valor numérico): ");
                
                duracion[i] = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el tamaño de la canción en KB (solo ingrese el valor numérico): ");
                size[i] = double.Parse(Console.ReadLine());

                songsSize++;


                //Impresion de datos ingresados 

                Console.WriteLine("Los datos que se ingresaron son:");

                for (int j = 0; j < songsSize; j++)
                {

                    Console.WriteLine($"Canción {j + 1}:-------------------------------");
                    Console.WriteLine($"Nombre del artista: {artista[j]}");
                    Console.WriteLine($"Título de la canción: {titulo[j]}");
                    Console.WriteLine($"Duración de la canción: {duracion[j]} segundos");
                    Console.WriteLine($"Tamaño de la canción: {size[j]} KB");
                    Console.WriteLine("------------------------------------------------");

                }

                Console.WriteLine("Desea ingresar los datos de otra cancion? [Si/No]");
                respuesta = Console.ReadLine();


                //Condicional para detener o seguir el programa de acuerdo a la respuesta anterior
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

//Clase para el ejercicio 2
public class Ejercicio2Clave2
{
    //Declaracion de arreglos para los datos de los estudiantes
    private static string[] codigoEstudiante = new string[1000];
    private static string[] nombreCompleto = new string[1000];
    private static string[] fechaNacimiento = new string[1000];
    private static string[] grado = new string[1000];
    private static string[] fechaRegistro = new string[1000];
    private static int totalEstudiantes = 0;


    //Llamado del menu del ejercicio
    public static void RealizarEjercicio()
    {
        bool mostrarMenu = true;
        while (mostrarMenu)
        {
            mostrarMenu = menuPrincipal();
        }
    }


    //Menu local del programa
    static public bool menuPrincipal()
    {
        Console.Clear();
        Console.WriteLine("Bienvenido menú escolar de estudiantes");

        Console.WriteLine("--------------Menu escolar--------------");
        Console.WriteLine("1. Agregar un alumno");
        Console.WriteLine("2. Mostrar listado de alumnos");
        Console.WriteLine("3. Buscar alumno por código");
        Console.WriteLine("4. Editar información de estudiante");
        Console.WriteLine("5. Salir del programa");

        Console.WriteLine("\nSeleccione el número de opción:");


        //Seleccion de tarea de acuerdo a la opcion seleccionada anteriormente
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
                    Console.WriteLine("Gracias por utilizar el programa");
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

    //Metodo para agregar datos de estudiantes a cada array
    static void agregarAlumno()

    {
        bool agregarMasEstudiantes = true;
        String respuesta = "";
        Console.WriteLine("--------------Agregado de estudiantes---------------");

        for (int i = 0; agregarMasEstudiantes; i++)
        {
            Console.WriteLine("Ingrese el código del estudiante: ");
            codigoEstudiante[i] = Console.ReadLine();

            Console.WriteLine("Ingrese el nombre completo del estudiante: ");
            nombreCompleto[i] = Console.ReadLine();

            Console.WriteLine("Ingrese la fecha de nacimiento del estudiante: ");
            fechaNacimiento[i] = Console.ReadLine();

            Console.WriteLine("Ingrese el grado del estudiante: ");
            grado[i] = Console.ReadLine();

            Console.WriteLine("Ingrese la fecha de registro del estudiante: ");
            fechaRegistro[i] = Console.ReadLine();

            totalEstudiantes++;

           
            Console.WriteLine("¿Desea agregar otro estudiante? (Si/No)");
            respuesta = Console.ReadLine();

            //Condicional para detener o seguir con el programa

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
                break;
            }
        }
        if (encontroAlumno == true)
        {
            Console.WriteLine("De acuerdo al codigo ingresado, el alumno es:");
            Console.WriteLine("{0,-15} {1,-30} {2,-15} {3,-15} {4,-15}", "Código", "Nombre Completo", "Fecha Nacimiento", "Grado", "Fecha Registro");
            Console.WriteLine("{0,-15} {1,-30} {2,-15} {3,-15} {4,-15}", codigoEstudiante[posicionAlumno], nombreCompleto[posicionAlumno], fechaNacimiento[posicionAlumno], grado[posicionAlumno], fechaRegistro[posicionAlumno]);

        }
        else
        {
            Console.WriteLine("No se encontró el estudiante con el código proporcionado");
        }


    }

    private static void editarInformation()
    {
        String codigoLocal = "";
        int posicionAlumno = 0;
        bool encontroAlumno = false;
        Console.WriteLine("Editado de información de un estudiante");
        Console.WriteLine("Ingrese el código del alumno que quiere editar");
        codigoLocal = Console.ReadLine();


        for (int j = 0; j < totalEstudiantes; j++)
        {
            if (codigoEstudiante[j] == codigoLocal)
            {
                posicionAlumno = j;
                encontroAlumno = true;
                break;
            }

        }
        if (encontroAlumno == true)
        {


            Console.WriteLine("Ingrese el nombre completo del estudiante: ");
            nombreCompleto[posicionAlumno] = Console.ReadLine();

            Console.WriteLine("Ingrese la fecha de nacimiento del estudiante: ");
            fechaNacimiento[posicionAlumno] = Console.ReadLine();

            Console.WriteLine("Ingrese el grado del estudiante: ");
            grado[posicionAlumno] = Console.ReadLine();

            Console.WriteLine("Ingrese la fecha de registro del estudiante");
            fechaRegistro[posicionAlumno] = Console.ReadLine();

            Console.WriteLine($"Se ha editado la información del estudiante con código {codigoLocal}");

        }
        else
        {
            Console.WriteLine("No se encontro el estudiante con el código proporcionado");
        }

    }
}




    





