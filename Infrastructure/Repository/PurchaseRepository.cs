﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Entities;
using ApplicationCore.Contracts.Repository;
using System.Linq.Expressions;

namespace Infrastructure.Repository
{
    public class PurchaseRepository : BaseRepository<PurchaseRepository>, IPurchaseRepository
    {
        public Purchase GetByCondition(Expression<Predicate<Purchase>> filter)
        {
            throw new NotImplementedException();
        }

        public int Insert(Purchase entity)
        {
            throw new NotImplementedException();
        }

        public int Update(Purchase entity)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Purchase> IRepository<Purchase>.GetAll()
        {
            throw new NotImplementedException();
        }

        Purchase IRepository<Purchase>.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
