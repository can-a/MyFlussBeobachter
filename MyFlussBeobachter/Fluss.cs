using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFlussBeobachter
{
    class Fluss
    { private readonly Random zfg = new Random();
        public string Name { get; set; }
        public  int Wasserstand { get; set; }
        public delegate void Eventhanlder(object o,EventArgs e);
        public event Eventhanlder StadtEvent;
        public event EventHandler SchiffEvent;
        public event EventHandler KlärwerkEvent;
        public event EventHandler KlärwerkSecondEvent;


        public void ÄndereWS() {
            int Wasserstand = zfg.Next(100, 1000);
            System.Threading.Thread.Sleep(1000);          
        }

        protected virtual void SchiffMeldung()
        {
            if (Wasserstand >= 8000 || Wasserstand <= 250)
            {
                SchiffEvent(this, EventArgs.Empty);
            }
            else
            {
                SchiffEvent(this,EventArgs.Empty);
            }
        }

        protected virtual void StadtMeldung() {
            if (Wasserstand>=8200)
            {
                StadtEvent(this, EventArgs.Empty);
            }
            else
            {
                StadtEvent(this, EventArgs.Empty);
            }
        }

        protected virtual void KlärwerkMeldung() {
            if (Wasserstand>=8000||Wasserstand<=3000)
            {
                KlärwerkEvent(this, EventArgs.Empty);
            }
        }

        

    }
}
