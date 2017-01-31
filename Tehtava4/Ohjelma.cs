
/*ohjelman nimi, kanava (jolta ohjelma tulee), alku- ja loppuaika sekä pienimuotoinen infoteksti ohjelmasta*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Ohjelma
    {
        public string Nimi { get; set; }
        public string Kanava { get; set; }
        public string AlkuJaLoppuAika { get; set; }
        public string Info { get; set; }

        // Constructor that takes no arguments.
        public Ohjelma()
        {        }

        // Constructor that takes one argument.
        public Ohjelma(string nimi, string kanava, string alkujaloppuaika, string info)
        {
            Nimi = nimi;
            Kanava = kanava;
            AlkuJaLoppuAika = alkujaloppuaika;
            Info = info;
        }
    }
}
