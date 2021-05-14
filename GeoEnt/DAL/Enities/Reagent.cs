using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Enities
{
    class Reagent
    {
        public int Id;
        public string Name;
        public virtual Test Test{ get; set; }

    }
}
