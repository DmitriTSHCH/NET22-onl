using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Vocation
{
    internal abstract class Employee : IPrintVocation
    {
        public virtual void SetName(string _name)
        {
        }
        public virtual string GetName()
        {
            return "неназначено";
        }
        public virtual void PrintVocation()
        {
        }
    }
}
