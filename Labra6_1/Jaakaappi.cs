using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra6_1
{
    class Jääkaappi
    {
        public string Name { get; set; }
        public List<Ruoka> sisältö;

        public Jääkaappi()
        {
            sisältö = new List<Ruoka>();

        }

        public override string ToString()
        {
            string retval = Name + " sisältö:\n";
            foreach (Ruoka item in sisältö)
            {
                retval += item.ToString() + "\n";
            }
            return retval;

        }
    }
}