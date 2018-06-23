using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SocileSIte.Models;
using SolcileSite.Controllers.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolcileSite.Controllers
{
    public class featureController :Controller
    {

        private readonly IMapper mapper;
        private readonly dbsContext context;
        public featureController(dbsContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;
        }

        [HttpGet("/api/feature/")]
        public async Task<IEnumerable<FeatureResouce>> GetFeatures()
        {

            var features = await context.Feature.ToListAsync();
            return mapper.Map<List<Feature>, List<FeatureResouce>>(features);
        }

    }
}
