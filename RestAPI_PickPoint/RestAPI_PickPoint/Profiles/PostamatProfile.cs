using AutoMapper;
using RestAPI_PickPoint.Dtos;
using RestAPI_PickPoint.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPI_PickPoint.Profiles
{
    public class PostamatProfile : Profile
    {
        public PostamatProfile()
        {
            CreateMap<Postamat, PostamatReadDto>();
        }
    }
}
