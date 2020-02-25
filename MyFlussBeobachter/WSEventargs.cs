using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFlussBeobachter
{
    class WSEventargs:EventArgs
    {
        public int alterWS { get; set; }
        public int neuerWS { get; set; }
    }
}
