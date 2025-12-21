using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    internal class SmartphoneApp : ISmartDevice
    {
        protected string Name { get; }
        string ISmartDevice.Name => Name;
        protected readonly SmartHomeHub SmartHomeHub;

        public SmartphoneApp(string _name, SmartHomeHub _smartHomeHub)
        {
            Name = _name;
            SmartHomeHub = _smartHomeHub;
            _smartHomeHub.OnEvent += ReactToEvent;
        }

        public void ReactToEvent(HubEvent eventData)
        {
            if (eventData.EventPriority > 2)
            {
                Console.WriteLine($"Уведомление для {Name}");
            }
        }
    }
}
