using BilgeAdam.DataTransferObjects.Models;
using BilgeAdam.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BilgeAdam.Business.Repositories
{
    public class BookRepository : RepositoryBase, ICrudRepository<BookDTO>
    {
        public void Add(BookDTO item)
        {
            var book = new Book
            {
                Name = item.Name,
                ISBNNumber = item.Code,
                AuthorId = item.AuthorId
            };
            Context.Books.Add(book);
            Context.SaveChanges();
        }

        public void Delete(BookDTO item)
        {
            throw new NotImplementedException();
        }

        public List<BookDTO> GetAll()
        {
            var books = Context.Books.Where(i => i.IsActive)
                                 .Select(i => new BookDTO
                                 {
                                     Id = i.Id,
                                     Created = i.Created,
                                     Code = i.ISBNNumber,
                                     Name = i.Name,
                                     Author = i.Author.FullName
                                 })
                                 .ToList();
            return books;
        }

        public List<BookDTO> GetAllParametre(object Value)
        {
            //Obje Olarak Alına Veriler . Listelemeden Kullanılacak.
            var books = Context.Books.Where(i => i.IsActive)
                      .Select(i => new BookDTO
                      {
                          Id = i.Id,
                          Created = i.Created,
                          Code = i.ISBNNumber,
                          Name = i.Name,
                          Author = i.Author.FullName
                      })
                      .ToList();
            return books;
        }

        public List<BookDTO> GetCombobox()
        {
            throw new NotImplementedException();
        }

        public void Update(BookDTO item)
        {
            throw new NotImplementedException();
        }
    }
}
