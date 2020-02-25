using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFlussBeobachter
{
    class Schiff
    {
        public string Name { get; set; }
        public void anhalten(object o, EventArgs e){
            Console.WriteLine("Die Schiffe werden angehalten...");
        }
        public void fahren(object o, EventArgs e) {
            Console.WriteLine("Fährt weiter...");
        }
        
    }
    
}
