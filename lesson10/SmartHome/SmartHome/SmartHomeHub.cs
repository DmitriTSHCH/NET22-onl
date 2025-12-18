using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    delegate void EventHandler(HubEvent hubEvent);
    internal class SmartHomeHub
    {
        public event EventHandler OnEvent;
        
        protected void RaiseEvent(HubEvent hubEvent)
        {
            OnEvent?.Invoke(hubEvent);
        }
        public HubEvent TriggerMotion(bool _secureActive)
        {
            if (_secureActive)
            {
                HubEvent _hubEvent = new HubEvent(EventType.securityBreach);
                RaiseEvent(_hubEvent);
                return _hubEvent;
            }
            else
            {
                HubEvent _hubEvent = new HubEvent(EventType.switchLight);
                RaiseEvent(_hubEvent);
                return _hubEvent; 
            }
        }
        public HubEvent TriggerFireAlarm()
        {
            HubEvent _hubEvent = new HubEvent(EventType.fireAlarm);
            RaiseEvent(_hubEvent);
            return _hubEvent;
        }
        public HubEvent TriggerLeakSensor()
        {
            HubEvent _hubEvent = new HubEvent(EventType.communicationsBreach);
            RaiseEvent(_hubEvent);
            return _hubEvent;
        }
        public HubEvent IntercomCalls()
        {
            HubEvent _hubEvent = new HubEvent(EventType.intercomCall);
            RaiseEvent(_hubEvent);
            return _hubEvent;
        }
    }
}
