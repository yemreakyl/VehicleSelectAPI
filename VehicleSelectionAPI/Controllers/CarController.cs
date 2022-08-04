using AutoMapper;
using Core.Dtos;
using Core.EntityModels;
using Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VehicleSelectionAPI.Controllers
{

    public class CarController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly ICarService _carService;

     

        public CarController(IMapper mapper,ICarService carService)
        {
            _mapper = mapper;
            _carService = carService;
        }

        [HttpGet("{Color}")]
        public async Task<IActionResult> GetByColor(string Color)
        {

            var Cars = _carService.Where(x => x.Color == Color);
            var CarsDtos = _mapper.Map<List<CarDto>>(Cars.ToList());

            return CreateActionResult(CustomResponseDto<List<CarDto>>.Success(200, CarsDtos));
        }
        [HttpPost()]
        public async Task<IActionResult> ChangeHeadlightsState(int id)
        {
           var response= await _carService.ChangeChangeHeadlightsState(id);
            return CreateActionResult(CustomResponseDto<CarDto>.Success(200, response));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCar(int id)
        {           
                var Product = await _carService.GetByIdAsync(id);
                await _carService.RemoveAsync(Product);
                return CreateActionResult(CustomResponseDto<NoContentDto>.Success(200));          
        }

    }
}
