using SocileSIte.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
//using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace SolcileSite.Models
{
    [Table("Users")]

    public class User
    {
        public int Id { get; set; }
        public int  ModelId { get; set; }
        public Model Model { get; set; }
        //so  i need ai Models ar Model remember it altime// 
        public bool IsRegistered { get; set; }
        [Required]
        [StringLength(255)]
        public string ContactName { get; set; }

        [StringLength(255)]
        public string ContactEmail { get; set; }

        [Required]
        [StringLength(255)]
        public string ContactPhone { get; set; }
        public DateTime LastUpdate { get; set; }
        public ICollection<Userfeature> Feature { get; set; }

        public User()
        {
            Feature = new Collection<Userfeature>();

        }

    }
}
