namespace TP0._5;

class Program
{
static void Main(string[] args)
{
Curso curso = new Curso();

int opcion;

do
{
Console.Clear();
Console.WriteLine("=== MENU ===");
Console.WriteLine("1 - Agregar nuevo alumno");
Console.WriteLine("2 - Buscar alumno por DNI");
Console.WriteLine("3 - Agregar falta o media falta");
Console.WriteLine("4 - Mostrar todos los alumnos");
Console.WriteLine("5 - Mostrar alumnos libres");
Console.WriteLine("6 - Salir");

Console.Write("Opcion: ");
opcion = int.Parse(Console.ReadLine());

switch (opcion)
{
case 1:
agregarNuevoAlumno(curso);
break;

case 2:
buscarAlumnoporDNI(curso);
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
Console.WriteLine("Saliendo...");
break;
}

Console.WriteLine("Presione una tecla para continuar...");
Console.ReadKey();

} while (opcion != 6);
}

static void agregarNuevoAlumno(Curso curso)
{
Console.Write("Ingrese DNI: ");
int dni = int.Parse(Console.ReadLine());

Console.Write("Ingrese nombre: ");
string nombre = Console.ReadLine();

Console.Write("Ingrese cantidad de faltas: ");
double faltas = double.Parse(Console.ReadLine());

curso.agregaNuevoAlumno(dni, nombre, faltas);

Console.WriteLine("Alumno agregado.");
}

static void buscarAlumnoporDNI(Curso curso)
{
Console.Write("Ingrese DNI: ");
int dni = int.Parse(Console.ReadLine());

Alumno a = curso.buscarAlumnoxdni(dni);

if (a != null)
{
Console.WriteLine("Alumno encontrado:");
Console.WriteLine("DNI: " + a.getDNI());
Console.WriteLine("Faltas: " + a.getFaltas());
}
else
{
Console.WriteLine("Alumno no encontrado.");
}
}

static void agregarFaltaoMediaFaltaaunAlumno(Curso curso)
{
Console.Write("Ingrese DNI del alumno: ");
int dni = int.Parse(Console.ReadLine());

Alumno a = curso.buscarAlumnoxdni(dni);

if (a != null)
{
Console.WriteLine("1 - Falta completa");
Console.WriteLine("2 - Media falta");

int opcion = int.Parse(Console.ReadLine());

if (opcion == 1)
{
a.agregarFaltaCompleta();
}
else if (opcion == 2)
{
a.agregarMediaFalta();

}

}

else
{
Console.WriteLine("Alumno no encontrado.");
}
}

static void mostrarTodoslosAlumnos(Curso curso)
{
Console.WriteLine("Lista de alumnos:");
Console.WriteLine(curso.mostrarAlumnos());
}

static void mostrarAlumnosLibres(Curso curso)
{
Console.WriteLine("Alumnos libres:");
Console.WriteLine(curso.AlumnosLibres());
}
}
