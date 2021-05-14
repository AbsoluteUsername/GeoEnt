using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Enities
{
    class Test
    {
        public int Id;
        public virtual Reagent Reagent { get; set; }
        public virtual Worker Worker { get; set; }

    }
}
