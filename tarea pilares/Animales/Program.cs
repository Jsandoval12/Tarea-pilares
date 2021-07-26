using System;

namespace Animales
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Seleccione su respuesta");
            Console.WriteLine("\t-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            Console.WriteLine("\t\t1....Terrestres");
            Console.WriteLine("\t\t2....Acuaticos");
            Console.WriteLine("\t\t3....Aereos");
            Console.WriteLine("\t\t4....Salir");
            Console.WriteLine("\t+-+-+-+-+-+-+-+-+-+-+-+-+-+");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
            case "1":
            {
            
            Console.Clear();
            Console.WriteLine("Felicidades selecciono ***Terrestres***");

            Perro p = new Perro();
            p.Nombre = "Foster";
            p.Patas = "4";
            p.Tipo = "Domestico";
            
            Console.WriteLine("");
              Console.WriteLine("***Perro***");
            Console.WriteLine("Su nombre es: " + p.Nombre);
            Console.WriteLine("cantidad de patas: " + p.Patas);
            Console.WriteLine("Su Tipo es nombre es: " + p.Tipo);
            p.DistintivoDelPErro();
            Console.WriteLine("");

            Gato g = new Gato();
            g.Nombre = "Michi";
            g.Patas = "4";
            g.Tipo = "Felino";

            Console.WriteLine("***Gato***");
            Console.WriteLine("");
            Console.WriteLine("Su nombres es : " + g.Nombre);
            Console.WriteLine("Cantidad de Patas : " + g.Patas);
            Console.WriteLine("Su tipo es : " + g.Tipo);
            Console.WriteLine("");

            Vaca v = new Vaca();
            v.Nombre = "LoLa";
            v.Patas = "4";
            v.Tipo = "Lechera";
            Console.WriteLine("***Vaca***");
            Console.WriteLine("");
            Console.WriteLine("Su nombres es :" + v.Nombre);
            Console.WriteLine("Cantidad de Patas : " + v.Patas);
            Console.WriteLine("Su tipo es : " + v.Tipo);
            Console.WriteLine("");
            

            Burro b = new Burro();
            b.Tipo = "Mamifero";
            b.Patas = "4";
            b.Nombre = "Broki";
            Console.WriteLine("***Burro***");
            
            Console.WriteLine("");
            Console.WriteLine("Su nombres es : " + b.Nombre);
            Console.WriteLine("Cantidad de Patas : " + b.Patas);
            Console.WriteLine("Su tipo es : " + b.Tipo);
            Console.WriteLine("");

            Mono m = new Mono();
            m.Tipo = "Mamifero";
            m.Patas = "4";
            m.Nombre = "George";
            Console.WriteLine("***Mono***");
            
            Console.WriteLine("");
            Console.WriteLine("Su nombres es : " + m.Nombre);
            Console.WriteLine("Cantidad de Patas : " + m.Patas);
            Console.WriteLine("Su tipo es : " + m.Tipo);
            Console.WriteLine("");

            break;
            }        

            case "2":
            {
             Console.Clear();
            Console.WriteLine("Felicidades selecciono ***Acuaticos***");


            Tiburon t = new Tiburon();
            t.Nombre = "Tiburonsin";
            t.Habilidad = "Respira en el agua";
            t.Tipo = "Acuatico";
            
            Console.WriteLine("");
              Console.WriteLine("***Tiburon***");
            Console.WriteLine("Su nombre es: " + t.Nombre);
            Console.WriteLine("Su habilidad es : " + t.Habilidad);
            Console.WriteLine("Su Tipo es: " + t.Tipo);
            Console.WriteLine("");

            Anguila c = new Anguila();
            c.Nombre = "RAyita Azul";
            c.Habilidad = "Respira en el agua";
            c.Tipo = "Acuatico";
            
            Console.WriteLine("");
              Console.WriteLine("***Anguila***");
            Console.WriteLine("Su nombre es: " + c.Nombre);
            Console.WriteLine("Su habilidad es : " + c.Habilidad);
            Console.WriteLine("Su Tipo es: " + c.Tipo);
            Console.WriteLine("");

            Mantaraya n = new Mantaraya();
            n.Nombre = "Bespa";
            n.Habilidad = "Respira en el agua";
            n.Tipo = "Acuatico";
            
            Console.WriteLine("");
              Console.WriteLine("***Mantaraya***");
            Console.WriteLine("Su nombre es: " + n.Nombre);
            Console.WriteLine("Su habilidad es : " + n.Habilidad);
            Console.WriteLine("Su Tipo es: " + n.Tipo);
            Console.WriteLine("");
            

            Tilapia j = new Tilapia();
            j.Nombre = "Merin";
            j.Habilidad = "Respira en el agua";
            j.Tipo = "Acuatico";
            
            Console.WriteLine("");
              Console.WriteLine("***Tilapia***");
            Console.WriteLine("Su nombre es: " + j.Nombre);
            Console.WriteLine("Su habilidad es : " + j.Habilidad);
            Console.WriteLine("Su Tipo es: " + j.Tipo);
            Console.WriteLine("");

            break;
            } 
            case "3":
            {
             Console.Clear();
            Console.WriteLine("Felicidades selecciono ***Aereos***");


            Loro l = new Loro();
            l.Plumaje = "colorido";
            l.Habilidad = "Inmita voces";
            l.Distintivo = "Colorido";
            
            Console.WriteLine("");
              Console.WriteLine("***Loro***");
            Console.WriteLine("Su Plumaje es: " + l.Plumaje);
            Console.WriteLine("Su habilidad es : " + l.Habilidad);
            Console.WriteLine("Su distintivo es : " + l.Distintivo);
            Console.WriteLine("");

            Buitre u = new Buitre();
            u.Plumaje = "Negro";
            u.Habilidad = "volar";
            u.Distintivo = "Es carronero";
            
            Console.WriteLine("");
              Console.WriteLine("***Buitre***");
            Console.WriteLine("Su plumaje es: " + u.Plumaje);
            Console.WriteLine("Su habilidad es : " + u.Habilidad);
            Console.WriteLine("Su distintivo es : " + u.Distintivo);
            
            Console.WriteLine("");

            Buho k = new Buho();
            k.Plumaje = "Variado o uniforme";
            k.Habilidad = "Flexibilidad en el cuello";
            k.Distintivo = "Sus grandes ojos";
            
            Console.WriteLine("");
              Console.WriteLine("***Buho***");
            Console.WriteLine("Su Plumaje es : " + k.Plumaje);
            Console.WriteLine("Su habilidad es : " + k.Habilidad);
            Console.WriteLine("Su distintivo : " + k.Distintivo);
            
            Console.WriteLine("");
            

            Colibri f = new Colibri();
            f.Plumaje = "Brillante y variado";
            f.Habilidad = "Volar en un solo puesto";
            f.Distintivo = "Vuelo super rapido";
            
            Console.WriteLine("");
              Console.WriteLine("***Colibri***");
            Console.WriteLine("Su plumaje es: " + f.Plumaje);
            Console.WriteLine("Su habilidad es : " + f.Habilidad);
            Console.WriteLine("Su distintivo es : " + f.Distintivo);
            
            Console.WriteLine("");


            break;
            
            } 
            
             default:
             break;

             if (opcion == "4")
                    {
                        break;   


                    }
                    else Console.WriteLine("Seleccione solo la opcion especificada");
                   
            }

            


        }
    }
}
