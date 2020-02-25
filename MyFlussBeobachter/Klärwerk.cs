using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFlussBeobachter
{
    class Klärwerk
    {
        public string Name { get; set; } ="Strauss1";
        public void stoppen(object o, EventArgs e) {
            Console.WriteLine("Einleitung wir gestoppt");
        }

        public void steigern(object o, EventArgs e) {
            Console.WriteLine("Einleitung wird gestiegen");
        }
    }
}
