using AutoMapper;
using Core.Dtos;
using Core.EntityModels;
using Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VehicleSelectionAPI.Controllers
{
    
    public class BoatController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IGenericService<Boat> _service;

        public BoatController(IMapper mapper, IGenericService<Boat> service)
        {
            _mapper = mapper;
            _service = service;
        }
        [HttpGet("{Color}")]

        public async Task<IActionResult> GetBusByColor(string Color)
        {
            var Boats = _service.Where(x => x.Color == Color);
            var BoatDtos = _mapper.Map<List<BoatDto>>(Boats.ToList());
            return CreateActionResult(CustomResponseDto<List<BoatDto>>.Success(200, BoatDtos));
        }
    }
}
