namespace TP0._5;

class Program
{
       string Curso = ingresarTexto("Ingrese el curso: ");
    Curso curso = new Curso(curso);
    List<string> list = new List<string> { "agregar Nuevo Alumno", "buscar Alumno por DNI ", "agregar Falta  o Media Falta a un Alumno", "mostrar Todos los Alumnos", "mostrar Alumnos Libres", "Salir" };
    Menu menu = new Menu();
    
    int opcion;
    do
    {
        Console.Clear();
        menu.mostrarMenu(list, $"=== Curso {curso.} ===");
        opcion = menu.pedirOpcion(list.Count);

        switch (opcion)
        {
            case 1:
                agregarNuevoAlumno(curso);
                break;

            case 2:
                buscarAlumnoporDNI (curso);
                break;

            case 3:
                agregarFaltaoMediaFaltaaunAlumno(curso);
                break;

            case 4:
                mostrarTodoslosAlumnos(curso);
                break;

            case 5:
               mostrarAlumnosLibres(curso);
                break;

            case 6:
               Salir(curso);
                break;
        }

    }