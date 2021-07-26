
using System;
public class Aves
{

public string Plumaje { get; set; }
public string Habilidad { get; set; }
public string Distintivo { get; set; }


public Aves() //Poliformismo
{
    
}
public Aves(string plumaje, string habilidad, string distintivo)
{
    Plumaje = plumaje;
    Habilidad = Habilidad;
    Distintivo = Distintivo;
}

private void Funcion()// encapsulamiento
{ 

    Console.WriteLine("Volar es su funcion");
}


}