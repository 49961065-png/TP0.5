namespace TP0._5; 

class Curso
{
   private List<Alumno> Alumno;

   public Curso()
{

   
   
}

 public Alumno agregaNuevoAlumno(int DNI, string nombre, double cantidadfaltas )
 {
    Alumno alumnos = null;
     int pos = 0;
     while (pos < alumnos.Count())
     if (pos < alumnos.Count())

         alumnos = this.alumnos[pos];
     return alumnos;
   
}
}
public Alumno buscarAlumnoxdni(int DNI)
{

     int i = 0;
    Alumno encontrado = null;
    while (i < this.alumnos.Count && !this.alumnos[i].esMismoNombre(nombre))
        i++;
    if (i < this.alumnos.Count)
        encontrado = this.alumnos[i];
    return encontrado;
}
public int faltas(int alumnos)
{


int faltacompleta = 0;
int mediafalta = 0;
bool faltotodoeldia;
bool faltosolounturno;

if(faltotodoeldia = true)
{
  faltacompleta++;
}
else if(faltosolounturno == true)
{
   mediafalta++
   mediafalta + mediafalta = faltacompleta
}

else
{
   mediafalta == false;
   faltacompleta == false;
}
return faltas;
}
   


