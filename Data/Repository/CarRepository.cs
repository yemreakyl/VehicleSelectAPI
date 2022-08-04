using Core.EntityModels;
using Core.Respositories;
using Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class CarRepository : GenericRepository<Car>, ICarRepository
    {
        public CarRepository(AppDbContext contex) : base(contex)
        {
        }

        public async Task<Car> ChangeChangeHeadlightsState(int id)
        {
            var Car = await _dbSet.FindAsync(id);
            if (Car != null)
            {
                if (Car.HeadlightsState == true)
                {
                    Car.HeadlightsState = false;
                }
                else
                {
                    Car.HeadlightsState = true;
                }
                _contex.SaveChanges();
                return Car;
            }
            throw new NotFoundException($"Vehicle not found");
        }
    }
}
