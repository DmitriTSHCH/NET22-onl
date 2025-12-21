using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    enum EventType
    {
        switchLight,
        fireAlarm,
        securityBreach,
        communicationsBreach,
        intercomCall,
    }
    internal class HubEvent
    {
        public EventType EventType { get; private set; }
        private DateTime EventDateTime;
        public byte EventPriority { get; private set; }

        public HubEvent(EventType _eventType)
        {
            EventType = _eventType;
            EventDateTime = DateTime.Now;
            switch (_eventType.ToString())
            {
                case "switchLight":
                    EventPriority = 1;
                    break;
                case "fireAlarm":
                    EventPriority = 5;
                    break;
                case "securityBreach":
                    EventPriority = 5;
                    break;
                case "communicationsBreach":
                    EventPriority = 4;
                    break;
                case "intercomCall":
                    EventPriority = 3;
                    break;
            }
            Console.WriteLine($"Произошло событие:\n{ToString()}");
        }
        public override string ToString()
        {
            return $"Тип: {Convert.ToString(EventType)}, время: {Convert.ToString(EventDateTime)}, уровень важности: {Convert.ToString(EventPriority)}";
        }
    }
}
