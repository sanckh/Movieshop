﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Contracts.Repository;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Models;

namespace Infrastructure.Services
{
    public class CastService : ICastService
    {
        private readonly ICastRepository _castRepository;
        public CastService(ICastRepository castRepository)
        {
            _castRepository = castRepository;
        }
        public CastResponseModel GetAllCast(int id)
        {
            var castDetail = _castRepository.GetById(id);

            var castModels = new CastResponseModel
            {
                Id = castDetail.Id,
                Name = castDetail.Name,
                Gender = castDetail.Gender,

                ProfilePath = castDetail.ProfilePath
            };


            return castModels;
        }
    }
}
