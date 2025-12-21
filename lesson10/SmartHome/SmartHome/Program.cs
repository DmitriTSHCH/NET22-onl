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
            SmartLamp lamp1 = new SmartLamp("lampCorridor", hub1);
            SecuritySiren siren1 = new SecuritySiren("securitySiren", hub1);
            SmartphoneApp account1 = new SmartphoneApp("user1", hub1);

            HubEvent event1 = hub1.TriggerMotion(false);

            HubEvent event2 = hub1.TriggerMotion(true);

            HubEvent event3 = hub1.IntercomCalls();

            HubEvent event4 = hub1.TriggerLeakSensor();

        }
    }
}