using DAL.EF;
using DAL.Repositories.Impl;
using DAL.Repositories.Interfaces;

namespace DAL.Enities
{
    public class Worker
    {
        public int id;
        public string name;
        public virtual Test Test { get; set; }



    }
}
