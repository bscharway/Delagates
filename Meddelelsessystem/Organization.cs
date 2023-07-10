using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meddelelsessystem
{
    public abstract class Organization
    {
        public string Name { get; }
        public string Addresse { get; set; }
        public Organization(string name) {
            this.Name = name;
        }
    }
}
