using SocileSIte.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SolcileSite.Models
{
    [Table("Userfeatures")]
    public class Userfeature
    {

        public int UserId { get; set; }
        public int FeatureId { get; set; }
        public User User { get; set; }
        public Feature Feature { get; set; }
    }
}
