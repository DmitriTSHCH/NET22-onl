using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    internal interface ISmartDevice
    {
        string Name { get; }
        public abstract void ReactToEvent(HubEvent eventData);
    }
}
