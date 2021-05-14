using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Enities
{
    class Worker
    {
        public int id;
        public string name;
        public virtual Test Test { get; set; }

    }
}
