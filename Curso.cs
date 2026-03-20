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
    while (i < this.alumnos.Count && DNI != alumnos[i].getDNI()) {

        i++;

    }
    encontrado = alumnos[i];
    return encontrado;
}
public int faltas()
{


int faltacompleta = 0;
int mediafalta = 0;
bool faltotodoeldia;
bool faltosolounturno;

if(faltotodoeldia)
{
  faltacompleta++;
}
else if(faltosolounturno)
{
   mediafalta++;
   mediafalta + mediafalta = faltacompleta;
}

else
{
   mediafalta = false;
   faltacompleta = false;
}
return faltas;
}
public string mostrarAlumnos() {

    string msg = "";
    for (int i = 0; i < alumnos.Count; i++) {

        msg += alumnos[i] + ", \n";

    }
    return msg;

}

public string AlumnosLibres() {


string msg = "";
for(int i=0; i < alumnos.Count; i++) {

    if (alumnos[i].getFaltas() > 15) {

        msg += alumnos[i] + ", \n";

    }
}



}
   


