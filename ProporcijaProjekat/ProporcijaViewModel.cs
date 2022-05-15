using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProporcijaProjekat
{
    public class ProporcijaViewModel
    {
        public string Opcija1 { get; set; }
        public string Opcija2 { get; set; }
        public string Tip
        {
            get
            {
                return "";
            }
        }
        public int Vrednost1 { get; set; }
        public int Vrednost2 { get; set; }
        public int Vrednost3 { get; set; }
        public int Vrednost4 { get; set; }
    }
}
