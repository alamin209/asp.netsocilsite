using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SocileSIte.Models;
using AutoMapper;
using Socile.Controllers.Resources;

namespace SocilSite.Controllers
{
    public class MakeController: Controller
    {
        private readonly IMapper mapper;
        private readonly dbsContext context;

        public MakeController(dbsContext context , IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;
        }

        [HttpGet("/api/makes/")]
        public async Task <IEnumerable<MakeResouce>> GetMakes()
        {

           var make = await context.Makes.Include(m => m.models).ToListAsync();
            return mapper.Map<List<Make>, List<MakeResouce>>(make);
        }


    }
}
