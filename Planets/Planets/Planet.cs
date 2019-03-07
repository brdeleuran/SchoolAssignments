using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planets
{
    class Planet
    {
        public string name;
        public double mass1024kg;
        public double diameter;
        public byte numberOfMoons;
        public bool ringSystem;
        public double meanTemp;


        static List<Planet> planetList = new List<Planet>();
        static List<Planet> planetsBelowZero = new List<Planet>();
        static List<Planet> planetsDiameter = new List<Planet>();

        public List<Planet> PlanetsDiameter { get { return planetsDiameter; } }
        public List<Planet> PlanetsBelowZero { get { return planetsBelowZero; } }
        public List<Planet> PlanetList { get { return planetList; } }

        public Planet()
        {
            
        }

        public Planet(string name, double mass1024kg, double diameter, byte numberOfMoons, bool ringSystem, double meanTemp)
        {
            this.name = name;
            this.mass1024kg = mass1024kg;
            this.diameter = diameter;
            this.numberOfMoons = numberOfMoons;
            this.ringSystem = ringSystem;
            this.meanTemp = meanTemp;
            planetList.Add(this);
        }
    }
}
