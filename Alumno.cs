namespace TP0._5;

class Alumno
{
private int DNI;
private string nombre;
private double cantidadfaltas;

public Alumno(int DNI, string nombre, double cantidadfaltas)
{
this.DNI = DNI;
this.nombre = nombre;
this.cantidadfaltas = cantidadfaltas;
}

public int getDNI()
{
return this.DNI;
}

public string getNombre()
{
return this.nombre;
}

public double getFaltas()
{
return this.cantidadfaltas;
}

public void agregarFaltaCompleta()
{
this.cantidadfaltas = this.cantidadfaltas + 1;
}

public void agregarMediaFalta()
{
this.cantidadfaltas = this.cantidadfaltas + 0.5;

}
}

