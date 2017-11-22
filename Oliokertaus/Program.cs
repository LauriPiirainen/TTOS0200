using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oliokertaus
{
    public class AMK
    {
        public List <Tutkinto> tutkinnot = new List<Tutkinto>();
        public string Tutkinto;
        public void HaeTutkinnot()
        {
            foreach (var tutkinto in tutkinnot)
            {
                Console.WriteLine(tutkinto.TutkintoNimi);
            }
        }
    }

    public class Tutkinto
    {
        public string TutkintoNimi;
        public List<Opintojakso> Opintojaksot { get; set; }
        public Tutkinto(string tutkinto)
        {
            TutkintoNimi = tutkinto;
            Opintojaksot = new List<Opintojakso>();
        }
        public void HaeOpintojaksot()
        {
            foreach (var opintojakso in Opintojakso)
            {
                Console.WriteLine(Opintojakso.TutkintoNimi);
            }
        }

    }

    public class Opintojakso
    {
        public string OpintojaksoNimi;
        public List<Opettaja> Opettajat { get; set; }
        public List<Opiskelija> Opiskelijat { get; set; }
        public Opintojakso(string Opintojakso)
        {
            OpintojaksoNimi = Opintojakso;
            Opettajat = new List<Opettaja>();
            Opiskelijat = new List<Opiskelija>();
        }
    }

    public class Opettaja
    {
        public string Name { get; set; }
    }
    public class Opiskelija
    {
        public string Name { get; set; }
    }
}