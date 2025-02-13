﻿using AltenChallengeApp.Core.Entities;
using System;
using System.Collections.Generic;

namespace AltenChallengeApp.Core.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        T GetById(Guid id);
        T GetSingleBySpec(ISpecification<T> spec);
        IEnumerable<T> ListAll();
        IEnumerable<T> List(ISpecification<T> spec);
        T Add(T entity);
        int Update(T entity);
        void Delete(T entity);
    }
}
