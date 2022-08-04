using Core.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _contex;

        public UnitOfWork(AppDbContext contex)
        {
            _contex = contex;
        }

        public void Commit()
        {
            _contex.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _contex.SaveChangesAsync();
        }
    }
}
