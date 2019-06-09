using BilgeAdam.DataTransferObjects;
using System.Collections.Generic;

namespace BilgeAdam.Business
{
    interface ICrudRepository<T> where T : DTOBase
    {
        List<T> GetAll();
        List<T> GetAllParametre(object Value);
        List<T> GetCombobox();
        void Add(T item);
        void Update(T item);
        void Delete(T item);
    }
}
