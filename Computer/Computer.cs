using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer {

    class Deska {
        private string oznaceni;
        private string vyrobce;

        public Deska(string oznaceni, string vyrobce) {
            this.oznaceni = oznaceni;
            this.vyrobce = vyrobce;
        }
        public string Oznaceni {
            get { return oznaceni; }
            set { oznaceni = value; }
        }
        public string Vyrobce {
            get { return vyrobce; }
            set { vyrobce = value; }
        }
        public override string ToString() {
            return $"Deska: {Oznaceni}, Výrobce: {Vyrobce}";
        }
    }
    internal class Disk {
        private bool ssd;
        private int capacity;
        private string konektor;

        public Disk(bool ssd, int capacity, string konektor) {
            this.ssd = ssd;
            this.capacity = capacity;
            this.konektor = konektor;
        }
        public bool Ssd
    {
        get { return ssd; }
        set { ssd = value; }
    }

    public int Capacity
    {
        get { return capacity; }
        set { capacity = value; }
    }

    public string Konektor
    {
        get { return konektor; }
        set { konektor = value; }
    }

        public override string ToString() {
            return $"Disk: {(ssd ? "Ano" : "Ne")}, Kapacita: {Capacity} GB, Konektor: {Konektor}";
        }
    }
    internal class Procesor {
        private string vyrobce;
        private double frekvence;
        private string patice;

        public Procesor(string vyrobce, double frekvence, string patice) {
            this.vyrobce = vyrobce;
            this.frekvence = frekvence;
            this.patice = patice;
        }
        public string Vyrobce
    {
        get { return vyrobce; }
        set { vyrobce = value; }
    }

    public double Frekvence
    {
        get { return frekvence; }
        set { frekvence = value; }
    }

    public string Patice
    {
        get { return patice; }
        set { patice = value; }
    }
        public override string ToString()
    {
        return $"Procesor: {Vyrobce}, Frekvence: {Frekvence} GHz, Patice: {Patice}";
    }

    }
    internal class Ram {
        private string typ;
        private int kapacita;

        public Ram(string typ, int kapacita) {
            this.typ = typ;
            this.kapacita = kapacita;
        }
public string Typ
    {
        get { return typ; }
        set { typ = value; }
    }

    public int Kapacita
    {
        get { return kapacita; }
        set { kapacita = value; }
    }
        public override string ToString()
    {
        return $"RAM: {Typ}, Kapacita: {Kapacita} GB";
    }
    }

    class Computer {
            
        public Computer (Deska Deska, Disk Hadr, Ram Operacka, Procesor Procak) {


        }

    }
    class Ucebna {
        public List<Computer> Pocitace { get; set; }
        public Ucebna() {
            Pocitace = new List<Computer>();
        }
        public override string ToString() {
            return $"Učebna: {Pocitace.Count} počítačů";
        }
    }

    class Program {
        public static void Mainx() {
            Procesor p1 = new Procesor("AMD", 4.6, "AM4");
            Deska deska1 = new Deska("B450", "MSI");
            Ram r1 = new Ram("DDR4", 32);
            Disk disk1 = new Disk(true, 2000, "SATA");

            Computer c1 = new Computer(deska1, disk1, r1, p1);
            Computer c2 = new Computer(new Deska("B550", "Asus"), new Disk(false, 1000, "Sata"), new Ram("DDR4", 64), new Procesor("Intel", 5.6, "LGA 1700"));

            Ucebna ucebna1 = new Ucebna();
            ucebna1.Pocitace.Add(c1);
            ucebna1.Pocitace.Add(c2);



            Console.WriteLine(c2.ToString());
        }
    }
}
