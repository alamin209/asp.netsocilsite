using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SocileSIte.Models
{
    public class Make
    {
    
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public ICollection<Model> models { get; set; }

        public Make()
        {
            models = new Collection<Model>();
        }
    }
}
