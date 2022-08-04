using AutoMapper;
using Core.Dtos;
using Core.EntityModels;
using Core.Respositories;
using Core.Services;
using Core.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class CarService : GenericService<Car>, ICarService
    {
        private readonly ICarRepository _carRepository;
        private readonly IMapper _mapper;

        public CarService(IGenericRepository<Car> repository, IUnitOfWork unitOfWork, ICarRepository carRepository, IMapper mapper) : base(repository, unitOfWork)
        {
            _carRepository = carRepository;
            _mapper = mapper;
        }

        public async Task<CarDto> ChangeChangeHeadlightsState(int id)
        {
            var Response=await _carRepository.ChangeChangeHeadlightsState(id);
            
            return _mapper.Map<CarDto>(Response);
        }
    }
}
