using System;
public class Acuaticos
{

public string Nombre { get; set; }
public string Tipo { get; set; }
public string Habilidad { get; set; }

public Acuaticos() // poliformismo
{
    
}

public Acuaticos(string nombre, string tipo, string habilidad)
{
    Nombre = nombre;
    Tipo = tipo;
    Habilidad = habilidad;
}
private void Funcion()// encapsulamiento
{ 

    Console.WriteLine("Respirar bajo el agua");
}

}