using MotorcycleRepoGeneric.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MotorcycleRepoGeneric.Repositories
{
    interface IRepository<T>
    {
        public void Add(T motorcycle);
        public List<T> GetAll();
        public T GetById(Guid id);
        public void Delete(Guid id);
        public void Update(T motorcycle);
    }
}
