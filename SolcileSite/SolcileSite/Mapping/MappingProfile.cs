using AutoMapper;
using Socile.Controllers.Resources;
using SocileSIte.Models;
using SolcileSite.Controllers.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Socile.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Make, MakeResouce>();
            CreateMap<Model, ModelResouce>();

            CreateMap<Feature, FeatureResouce>();

        }

    }
}
