using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Enities
{
    class Workers
    {
        public int id;
        public string name;
        public virtual Tests Test { get; set; }

    }
}
