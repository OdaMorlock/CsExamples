using System;
using System.Collections.Generic;
using System.Text;

namespace C12_Interfaces_1
{
    class BandSaw : IMachine
    {
        public bool Start()
        {
            Console.Write("BAND SAW HAS STARTED");
            return true;
        }

        public bool Stop()
        {
            Console.Write("BAND SAW HAS STOPPED");
            return true;
        }
    }
}
