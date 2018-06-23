using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace Socile.Controllers.Resources
{
    public class MakeResouce
    {
        public int Id { get; set; }
      
        public string Name { get; set; }
        public ICollection<ModelResouce> Models { get; set; }
        //public object Model { get; internal set; }
        //public object Models { get; internal set; }

        public MakeResouce()
        {
            Models = new Collection<ModelResouce>();
        }
    }
}
