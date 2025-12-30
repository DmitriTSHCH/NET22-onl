using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace JsonToXmlConverter
{
    [System.Serializable]
    public class members
    {
        public string name { get; set; }
        public int age { get; set; }
        public string secretIdentity { get; set; }
        public string[] powers { get; set; }


        public members() { }
        /*public members(string _name, int _age, string _secretIdentity, string[] _powers) 
        {
            this.name = _name;
            this.age = _age;
            this.secretIdentity = _secretIdentity;
            powers = new string[_powers.Length];
            for (int i = 0; i < _powers.Length; i++)
            {
                string buffer = _powers[i];
                powers[i] = buffer;
            }
        }*/
    }
}
