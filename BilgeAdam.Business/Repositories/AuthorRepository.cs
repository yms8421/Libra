using BilgeAdam.DataTransferObjects.Models;
using BilgeAdam.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BilgeAdam.Business.Repositories
{
    public class AuthorRepository : RepositoryBase, ICrudRepository<AuthorDTO>
    {
        public void Add(AuthorDTO item)
        {
            throw new NotImplementedException();
        }

        public void Delete(AuthorDTO item)
        {
            throw new NotImplementedException();
        }

        public List<AuthorDTO> GetAll()
        {
            throw new NotImplementedException();

        }

        public List<AuthorDTO> GetAllParametre(object Value)
        {
            throw new NotImplementedException();
        }

        public List<AuthorDTO> GetCombobox()
        {
            var authors = Context.Authors.Where(i => i.IsActive)
                     .Select(i => new AuthorDTO
                     {
                         Id = i.Id,
                         Name = i.FullName,
                     })
                     .ToList();
            return authors;
        }

        public void Update(AuthorDTO item)
        {
            throw new NotImplementedException();
        }
    }
}
