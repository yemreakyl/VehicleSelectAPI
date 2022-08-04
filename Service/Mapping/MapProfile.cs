using AutoMapper;
using Core.Dtos;
using Core.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<Car, CarDto>().ReverseMap();
            CreateMap<Bus, BusDto>().ReverseMap();
            CreateMap<Boat, BoatDto>().ReverseMap();        
        }
    }
}
