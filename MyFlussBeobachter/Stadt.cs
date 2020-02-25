using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFlussBeobachter
{
    class Stadt
    {
        public string Name { get; set; }
        public void WSWerrichten(object o, EventArgs e) {
            Console.WriteLine("Die Wasserschutzwand wird errichtet...");
        }
        public void WSWaufbauen(object o, EventArgs e) {
            Console.WriteLine("Die Wasserschutzwand wird Aufgebaut");
        }
    }
}
