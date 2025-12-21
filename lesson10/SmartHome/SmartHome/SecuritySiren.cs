using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    internal class SecuritySiren : ISmartDevice
    {
        protected string Name { get; }
        string ISmartDevice.Name => Name;
        protected readonly SmartHomeHub SmartHomeHub;

        public SecuritySiren(string _name, SmartHomeHub _smartHomeHub)
        {
            Name = _name;
            SmartHomeHub = _smartHomeHub;
            _smartHomeHub.OnEvent += ReactToEvent;
        }

        public void ReactToEvent(HubEvent eventData)
        {
            if (eventData.EventPriority > 3)
            {
                Console.WriteLine($"Сирена {Name} включена");
            }
        }
    }
}
