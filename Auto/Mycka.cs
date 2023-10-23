using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto {
    class Auto { }
    class Mycka {
        public double Umyj(Auto a) {
            return 200;
        }
        public double Navoskovat(Auto a) {
            return 100;
        }
        public double KompletniProgram(Auto a) {
            double myti = Umyj(a);
            double voskovani = Navoskovat(a);

            return (myti + voskovani) * 0.8;
        }
    }
    class RucniMycka : Mycka {
        public double VycistiInterier(Auto a) {
            return 300;
        }
        public new double KompletniProgram(Auto a) {
            return base.KompletniProgram(a) + (VycistiInterier(a) * 0.8);
        }
    }
    class MyckaSUdrzbou : RucniMycka {
        public double provedUdrzbuSpodku(Auto a) {
            return 400;
        }
        public new double KompletniProgram(Auto a) {
            return base.KompletniProgram(a) + (provedUdrzbuSpodku(a) * 0.8);
        }
    }
    class Demo {
        public static void Main() {
            Auto a1 = new Auto();
            Mycka m1 = new Mycka();
            RucniMycka r1 = new RucniMycka();
            MyckaSUdrzbou u1 = new MyckaSUdrzbou();

            Console.WriteLine($"Cena mytí: {m1.Umyj(a1)}\nCena navoskování: {m1.Navoskovat(a1)}\nKompletní program s 20% slevou: {m1.KompletniProgram(a1)}");
            Console.WriteLine($"Cena čištění interiéru: {r1.VycistiInterier(a1)}\nKompletní program Ruční myčka s 20% slevou: {r1.KompletniProgram(a1)}");
            Console.WriteLine($"Cena údržby podvozku: {u1.provedUdrzbuSpodku(a1)}\nKompletní program s údržbou: {u1.KompletniProgram(a1)}");
        }
    }
}
