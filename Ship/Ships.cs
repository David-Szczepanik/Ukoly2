using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ships {
    class Ship {
        private string name;
        private string year;
        public Ship(string name, string year) {
            this.name = name;
            this.year = year;
        }
        public Ship(string name) {
            this.name = name;
        }

        public string Name {
            get { return name; }
            set { name = value; }
        }

        public string Year {
            get { return year; }
            set { year = value; }
        }
        public override string ToString() {
            return $"Name: {name} Year built: {year}";
        }
    }
    class CruiseShip : Ship {
        private int maxPassengers;
        public CruiseShip(string name, int maxPassengers) : base(name) {
            this.maxPassengers = maxPassengers;
        }

        public int MaxPassengers {
            get { return maxPassengers; }
            set { maxPassengers = value; }
        }
        public override string ToString() {
            return $"Name: {Name} Maximum number of passengers: {maxPassengers}";
        }
    }
    class CargoShip : Ship {
        private int tonnage;
        public CargoShip(string name, int tonnage) : base(name) {
            this.tonnage = tonnage;
        }

        public int Tonnage {
            get { return tonnage; }
            set { tonnage = value; }
        }
        public override string ToString() {
            return $"Name: {Name} Cargo capacity is : {tonnage}";
        }
    }
    class Program {
        static void Main(string[] args) {
            Ship[] shipArray = new Ship[3];

            shipArray[0] = new Ship("Titanic", "1909");
            shipArray[1] = new CruiseShip("CruiseShip 1", 1000);
            shipArray[2] = new CargoShip("CargoShip 1", 6611);

            foreach (Ship ship in shipArray) {
                Console.WriteLine(ship.ToString());
            }
        }
    }
}