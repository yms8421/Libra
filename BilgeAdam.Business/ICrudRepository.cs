using BilgeAdam.DataTransferObjects;
using System.Collections.Generic;

namespace BilgeAdam.Business
{
    interface ICrudRepository<T> where T : DTOBase
    {
        List<T> GetAll();
        void Add(T item);
        void Update(T item);
        void Delete(T item);
    }
}
