using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planets
{
    class Program
    {
        static void Main(string[] args)
        {
            Planet Merkur = new Planet("Merkur", 0.33, 4879, 0, false, 167);
            Planet Jorden = new Planet("Jorden", 5.97, 12756, 1, false, 464);
            Planet Mars = new Planet("Mars",0.642, 6792, 2, false, 15);
            Planet Jupiter = new Planet("Jupiter",1898, 142984, 67, true, -65);
            Planet Saturn = new Planet("Saturn", 568, 120536, 62, true, -110);
            Planet Uranus = new Planet("Uranus", 86.8, 51118, 27, true, -140);
            Planet Neptun = new Planet("Neptun", 102, 49528, 14, true, -195);
            Planet Pluto = new Planet("Pluto", 0.0146, 2370, 5, false, -200);
            Planet Venus = new Planet("Venus", 4.87, 12104, 0, false, -225);
            Merkur.PlanetList.RemoveAt(8);
            Merkur.PlanetList.Insert(1, Venus);
            Merkur.PlanetList.RemoveAt(8);
            Merkur.PlanetList.Insert(8, Pluto);

            foreach (Planet planet in Merkur.PlanetList)
            {
                Console.WriteLine(planet.name + " " + planet.mass1024kg + " " + planet.diameter + " " + planet.numberOfMoons + " " + planet.ringSystem + "\r\n");
                
            }

            foreach (Planet planet in Merkur.PlanetList)
            {
                if (planet.meanTemp < 0)
                {
                    Merkur.PlanetsBelowZero.Add(planet);
                }
            }

            foreach (Planet planet in Merkur.PlanetList)
            {
                if (planet.diameter < 50000 && planet.diameter > 10000)
                {
                    Merkur.PlanetsDiameter.Add(planet);
                }
            }

            Console.WriteLine(Merkur.PlanetList.Count + " Planets in the list \r\n");
            Console.WriteLine(Merkur.PlanetsBelowZero.Count + " Planets with a mean temp under 0 \r\n");
            Console.WriteLine(Merkur.PlanetsDiameter.Count + " Planets with a diameter larger than 10.000 but smaller than 50.000 \r\n");
            Merkur.PlanetList.Clear();
            Console.WriteLine(Merkur.PlanetList.Count + " Planets in the list \r\n");
            Console.ReadKey();
        }
    }
}
