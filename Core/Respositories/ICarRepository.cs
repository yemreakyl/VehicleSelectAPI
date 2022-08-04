using Core.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Respositories
{
    public interface ICarRepository : IGenericRepository<Car>
    {
        Task<Car> ChangeChangeHeadlightsState(int id);

    }
}
