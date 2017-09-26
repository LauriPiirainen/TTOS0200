using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    public static class Lab03
    {

        public static bool OnkoLuku(string syote)
        {
            if (syote.All(char.IsDigit) || syote.ToLower().Contains(','))
            {
                return true;
            }
            if (syote.All(char.IsDigit) || syote.ToLower().Contains('+'))
            {
                return true;
            }
            if (syote.All(char.IsDigit) || syote.ToLower().Contains('-'))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool OnkoPvm(string syote)
        {
            string[] format = new string[] { "dd.MM.yyyy", "dd.MM.yy" };
            DateTime dateTime;

            if (DateTime.TryParseExact(syote, format, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.NoCurrentDateDefault, out dateTime))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    public class Hissi
    {
        public int NykyinenKerros { get; set; }

        public int Kerroksessa
        {
            get
            {
                return NykyinenKerros;
            }
            set
            {
                NykyinenKerros = value;
            }
        }
    }
    public class Vahvistin
    {
        public int Aanenvoimakkuus { get; set; }
        public int Saato
        {
            set
            {
                if (Aanenvoimakkuus > 100)
                {
                    Aanenvoimakkuus = 100;
                }
                if (Aanenvoimakkuus < 0)
                {
                    Aanenvoimakkuus = 0;
                }
            }
            get
            {
                if (Aanenvoimakkuus > 100)
                {
                    return 100;
                }
                if (Aanenvoimakkuus < 0)
                {
                    return 0;
                }
                else
                {
                    return 5555;
                }
            }
        }
    }
}