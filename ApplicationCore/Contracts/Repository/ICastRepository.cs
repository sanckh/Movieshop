using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Entities;

namespace ApplicationCore.Contracts.Repository
{
    public interface ICastRepository : IRepository<Cast>
    {
        Task <Cast> GetCastAsync(int id);
    }
}
