using System;
using System.Collections.Generic;
using System.Text;

namespace C12_Interfaces_1
{
    class CNC : IMachine
    {
        public bool Start()
        {
            Console.Write("CNC MACHINE HAS STARTED");
            return true;
        }

        public bool Stop()
        {
            Console.Write("CNC MACHINE HAS STOPPED");
            return true;
        }
    }
}
