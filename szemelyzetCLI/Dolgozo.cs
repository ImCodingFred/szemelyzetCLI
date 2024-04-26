using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szemelyzetCLI
{
    internal class Dolgozo
    {
        public string nev { get; set; }
        public DateTime munkabaallas { get; set; }
        public string beosztas { get; set; }
        public int fizetes { get; set; }
        public string telephely { get; set; }
        public Dolgozo(string be)
        {
            string[] dbok = be.Split(',');
            nev = dbok[0];
            munkabaallas = DateTime.Parse(dbok[1]);
            beosztas = dbok[2];
            fizetes = int.Parse(dbok[3]);
            telephely = dbok[4];
        }
    }
}
