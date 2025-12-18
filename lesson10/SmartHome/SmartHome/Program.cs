using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SmartHome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SmartHomeHub hub1 = new SmartHomeHub();
            SmartLamp lamp1 = new SmartLamp("lampKitchin", hub1);

            HubEvent event1 = new HubEvent(EventType.switchLight);
        }
    }
}