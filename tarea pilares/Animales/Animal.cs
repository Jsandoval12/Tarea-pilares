using System;
public class Animal
{

    public string Nombre { get; set; }
    public string Tipo { get; set; }
    public string Patas { get; set; }

    public string Distintivo  { get; set; }


    public Animal() // poliformismo
    {
        
    }
    public Animal(string nombre = "Foster", string tipo = "Domestico", string patas = "4", string distintivo = "Ladra") // Abstraccion
    {
        
    }


 private void Funcion()// encapsulamiento
{ 

    Console.WriteLine("Pueden ser Carnivoros , omnivoros y Herbivoros");
}

}