using AutoMapper;
using Core.Dtos;
using Core.EntityModels;
using Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VehicleSelectionAPI.Controllers
{
   
    public class BusController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IGenericService<Bus> _service;

        public BusController(IMapper mapper, IGenericService<Bus> service)
        {
            _mapper = mapper;
            _service = service;
        }
        [HttpGet("{Color}")]

        public async Task<IActionResult> GetBusByColor(string Color)
        {
            var Buses = _service.Where(x => x.Color == Color);
            var BusDtos=_mapper.Map<List<BusDto>>(Buses.ToList());
            return CreateActionResult(CustomResponseDto<List<BusDto>>.Success(200, BusDtos));
        }
    }
}
