using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace JsonToXmlConverter
{
    [Serializable]
    public class Squad
    {
        public string squadName { get; set; }
        public string homeTown { get; set; }
        public int formed { get; set; }
        public string secretBase { get; set; }
        public bool active { get; set; }
        public members[] members { get; set; }

        public Squad() { }
        /*public Squad(string _squadName, string _homeTown, int _formed, string _secretBase, bool _active, members[] _members) 
        { 
            this.squadName = _squadName;
            this.homeTown = _homeTown;
            this.formed = _formed;
            this.secretBase = _secretBase;
            this.active = _active;
            members = new members[_members.Length];
            for (int i = 0; i < _members.Length; i++)
            {
                members[i] = new members();
            }
        }*/
        internal void Print()
        {
            Console.WriteLine($"Название команды: {squadName}\nГород: {homeTown}\nГод создания: {formed}\nСекретная база: {secretBase}\nДействуют: {active}\nУчастники: ");
            foreach ( var member in members) 
            {
                Console.WriteLine(member.name ); 
            }
        }
    }
}

