using LibraryAutmation.BLL.Interfaces;
using LibraryAutmation.DAL.Interface;
using LibraryAutmation.DTO.Models;
using LibraryAutmation.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAutmation.BLL.Managers
{
    public class AuthorManager : IAuthorService
    {
        private readonly IAuthorRepository _authorRepository;
        private readonly IBookRepository _bookRepository;

        public AuthorManager(IAuthorRepository authorRepository, IBookRepository bookRepository)
        {
            _authorRepository = authorRepository;
            _bookRepository = bookRepository;
        }

        public void Add(AuthorDTO entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity), "Yazar eklenecek veri boş olamaz.");
            }

            if (string.IsNullOrWhiteSpace(entity.FirstName))
            {
                throw new ArgumentException("Yazar adı geçerli değil.", nameof(entity.FirstName));
            }

            // Diğer gerekli kontrolleri burada ekleyin

            var author = new Author
            {
               BirthDate = entity.BirthDate,
               FirstName = entity.FirstName,    
               LastName = entity.LastName,
            };

            _authorRepository.Add(author);
        }

        public void Delete(AuthorDTO entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity), "Silinecek yazar verisi boş olamaz.");
            }

            var author = _authorRepository.Get(a => a.Id == entity.Id);

            if (author == null)
            {
                throw new InvalidOperationException("Belirtilen yazar bulunamadı.");
            }

            // Silme işlemi burada gerçekleştirilir
            _authorRepository.Delete(author);
        }

        public AuthorDTO Get(Expression<Func<AuthorDTO, bool>> filter = null)
        {
            if (filter == null)
            {
                throw new ArgumentNullException(nameof(filter), "Filtre boş olamaz.");
            }

            throw new NotImplementedException();
        }
        public List<AuthorDTO> GetAll(Expression<Func<AuthorDTO, bool>> filter = null)
        {
            if (filter == null)
            {
                var authors = _authorRepository.GetAll();
                var authorDTOs = authors.Select(author => new AuthorDTO
                {
                    Id = author.Id,
                    FirstName = author.FirstName,
                    LastName = author.LastName,
       
                }).ToList();

                return authorDTOs;
            }
            else
            {
                // Belirtilen filtreye göre yazarları almak için gereken işlemleri burada gerçekleştirin
                var authors = _authorRepository.GetAll(author => author.Id == author.Id);
                var authorDTOs = authors.Select(author => new AuthorDTO
                {
                    Id = author.Id,
                    FirstName = author.FirstName,
                    LastName = author.LastName,
                    // Diğer Author nesnesi özelliklerini buraya ekleyin
                }).ToList();

                return authorDTOs;
            }

        }



        public void Update(AuthorDTO entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity), "Güncellenecek yazar verisi boş olamaz.");
            }

            var author = _authorRepository.Get(a => a.Id == entity.Id);

            if (author == null)
            {
                throw new InvalidOperationException("Belirtilen yazar bulunamadı.");
            }

            author.FirstName = entity.FirstName;
            author.LastName = entity.LastName;
            author.BirthDate = entity.BirthDate;
           
            _authorRepository.Update(author);
        }
    }
}