using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleException
{
    class Radio
    {
        public void TurnOn(bool state)
        {
            if (state)
                Console.WriteLine("Jamming...");
            else
                Console.WriteLine("Quiet time...");
        }
    }
}
