using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{

    public class Employee
    {
        public string Name { get; set; }
        public string Profession { get; set; }
        public int Salary { get; set; }
        public override string ToString()
        {
            return Name + " " + Profession + " palkka on " + Salary + " euroa";
        }
    }
    public class Boss : Employee
    {
        public string Car { get; set; }
        public int Bonus { get; set; }
        public override string ToString()
        {
            return base.ToString() + Car + " bonusta: " + Bonus + " euroa";
        }
    }

    public class Vehicle
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public int ProductionYear { get; set; }
        public string Color { get; set; }
        public override string ToString()
        {
            return "Nimi: " + Name + ". Malli: " + Model + ". Valmistusvuosi: " + ProductionYear + ". Väri:  " + Color;
        }
    }
    public class Bike : Vehicle
    {
        public string Vaihteisto { get; set; }
        public string VaihteistonMalli { get; set; }
        public override string ToString()
        {
            return base.ToString() + ". Vaihteisto: " + Vaihteisto + ". Vaihteistonmalli: " + VaihteistonMalli;
        }

    }
    public class Boat : Vehicle
    {
        public string VeneenTyyppi { get; set; }
        public int IstuintenMäärä { get; set; }
        public override string ToString()
        {
            return base.ToString() + ". Veneen tyyppi: " + VeneenTyyppi + ". Istuinten määrä: " + IstuintenMäärä;
        }
    }
}
