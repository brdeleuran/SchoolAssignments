using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPVaskemaskine
{
    class Washer
    {
        public bool powerOn;
        private bool running;
        public bool locked;

        public Washer()
        {

        }

        public string Power()
        {
            if (powerOn == true)
            {
                powerOn = false;
                return "Power Off";
            }
            else
            {
                powerOn = true;
                return "Power On";
            }

        }

        public string StopProgram()
        {
            if (running == false)
                return "No program is currently running";
            else
            {
                running = false;
                return "Program stopped";
            }
        }

        public string Fill(byte timer)
        {
            if (powerOn == true && running == false)
            {
                running = true;
                locked = true;
                return timer + " second duration";
            }
            return "";
        }

        public string Spin(byte timer)
        {
            if (powerOn == true && running == false)
            {
                running = true;
                locked = true;
                return timer + " second duration";
            }
            return "";
        }

        public string Wash(byte timer)
        {
            if (powerOn == true && running == false)
            {
                running = true;
                locked = true;
                return timer + " second duration";
            }
            return "";
        }

        public string EcoWash(byte timer)
        {
            if (powerOn == true && running == false)
            {
                running = true;
                locked = true;
                return timer + " second duration";
            }
            return "";
        }

    }
}
