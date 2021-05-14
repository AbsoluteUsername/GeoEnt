using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Enities
{
    class Reagents
    {
        public int Id;
        public string Name;
        public virtual Tests Test{ get; set; }

    }
}
