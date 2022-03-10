using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Models;


namespace ApplicationCore.Contracts.Services
{
    public interface ICastService
    {
        //int InsertCast(Cast entity);
        //int UpdateCast(int id);
        //int DeleteCast(int id);
        //IEnumerable<Cast> GetAllCasts();
        //Cast GetCast(int id);
        Task<CastResponseModel> GetAllCastAsync(int id);
    }
}
