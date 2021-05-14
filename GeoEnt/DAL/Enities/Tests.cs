using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Enities
{
    class Tests
    {
        public int Id;
        public virtual Reagents Reagent { get; set; }
        public virtual Workers Worker { get; set; }

    }
}
