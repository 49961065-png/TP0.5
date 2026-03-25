namespace TP0._5;

class Curso
{
   private List<Alumno> alumnos;

   public Curso()
   {
       alumnos = new List<Alumno>();
   }

   public void agregaNuevoAlumno(int DNI, string nombre, double cantidadfaltas)
   {
       Alumno nuevo = new Alumno(DNI, nombre, cantidadfaltas);
       alumnos.Add(nuevo);
   }

   public Alumno buscarAlumnoxdni(int DNI)
   {
       int i = 0;
       Alumno encontrado = null;

       while (i < alumnos.Count && alumnos[i].getDNI() != DNI)
       {
           i++;
       }

       if (i < alumnos.Count)
       {
           encontrado = alumnos[i];
       }

       return encontrado;
   }

   public string mostrarAlumnos()
   {
       string msg = "";

       for (int i = 0; i < alumnos.Count; i++)
       {
        msg += "DNI: " + alumnos[i].getDNI() +
" - Nombre: " + alumnos[i].getNombre() +
" - Faltas: " + alumnos[i].getFaltas() + "\n";
       }

       return msg;
   }

public string AlumnosLibres()
{
string msg = "";

for (int i = 0; i < alumnos.Count; i++)
{
if (alumnos[i].getFaltas() > 15)
{
msg += "DNI: " + alumnos[i].getDNI() +
" - Nombre: " + alumnos[i].getNombre() +
" - Faltas: " + alumnos[i].getFaltas() + "\n";
}
}

return msg;
}

