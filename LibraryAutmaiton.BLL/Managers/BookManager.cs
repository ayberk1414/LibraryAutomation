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
    public class BookManager : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookManager(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public void Add(BookDTO entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity), "Kitap eklenecek veri boş olamaz.");
            }

            if (string.IsNullOrWhiteSpace(entity.Title))
            {
                throw new ArgumentException("Kitap başlığı geçerli değil.", nameof(entity.Title));
            }

          
            var book = new Book
            {
                Title = entity.Title,
             AuthorId = entity.AuthorId,
             CategoryId = entity.CategoryId,
             LibraryId = entity.LibraryId,
             PublicationYear = entity.PublicationYear,
             Quantity = entity.Quantity,
             StudentId = entity.StudentId,
            };

            _bookRepository.Add(book);
        }

        public void Delete(BookDTO entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity), "Silinecek kitap verisi boş olamaz.");
            }

            var book = _bookRepository.Get(b => b.Id == entity.Id);

            if (book == null)
            {
                throw new InvalidOperationException("Belirtilen kitap bulunamadı.");
            }

            // Silme işlemi burada gerçekleştirilir
            _bookRepository.Delete(book);
        }

        public BookDTO Get(Expression<Func<BookDTO, bool>> filter = null)
        {
            if (filter == null)
            {
                throw new ArgumentNullException(nameof(filter), "Filtre boş olamaz.");
            }

            // Belirtilen filtreye göre kitabı almak için gereken işlemleri burada gerçekleştirin
             var book = _bookRepository.Get(book=>book.Id==book.Id);

            // Dönüş değeri olarak BookDTO tipinde bir nesne oluşturup bu kitabı doldurun
           var bookDTO = new BookDTO { 
               Id = book.Id, 
               Title = book.Title,
               AuthorId = book.AuthorId,
               CategoryId = book.CategoryId,
               LibraryId = book.LibraryId,
               PublicationYear= book.PublicationYear,   
               Quantity= book.Quantity,
               StudentId= book.StudentId,
 };

            // Son olarak, oluşturduğunuz BookDTO nesnesini dönün
             return bookDTO;
        }

        public List<BookDTO> GetAll(Expression<Func<BookDTO, bool>> filter = null)
        {
            if (filter == null)
            {
                var books = _bookRepository.GetAll();
                var bookDTOs = books.Select(book => new BookDTO
                {
                    Id = book.Id,
                    Title = book.Title,
                    AuthorId = book.AuthorId,
                    CategoryId = book.CategoryId,
                    LibraryId = book.LibraryId,
                    PublicationYear = book.PublicationYear,
                    Quantity = book.Quantity,
                    StudentId = book.StudentId,
                    // Diğer kitap özelliklerini buraya ekleyin
                }).ToList();

                return bookDTOs;
            }
            else
            {
                // Belirtilen filtreye göre kitapları almak için gereken işlemleri burada gerçekleştirin
                var books = _bookRepository.GetAll(book => filter.Compile().Invoke(new BookDTO
                {
                    Id = book.Id,
                    Title = book.Title,
                    AuthorId = book.AuthorId,
                    CategoryId = book.CategoryId,
                    LibraryId = book.LibraryId,
                    PublicationYear = book.PublicationYear,
                    Quantity = book.Quantity,
                    StudentId = book.StudentId,
                    // Diğer kitap özelliklerini buraya ekleyin
                }));

                var bookDTOs = books.Select(book => new BookDTO
                {
                    Id = book.Id,
                    Title = book.Title,
                    AuthorId = book.AuthorId,
                    CategoryId = book.CategoryId,
                    LibraryId = book.LibraryId,
                    PublicationYear = book.PublicationYear,
                    Quantity = book.Quantity,
                    StudentId = book.StudentId,
                    // Diğer kitap özelliklerini buraya ekleyin
                }).ToList();

                return bookDTOs;
            }
        }

        public void Update(BookDTO entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity), "Güncellenecek kitap verisi boş olamaz.");
            }

            var book = _bookRepository.Get(b => b.Id == entity.Id);

            if (book == null)
            {
                throw new InvalidOperationException("Belirtilen kitap bulunamadı.");
            }

            book.Title = entity.Title;
          book.AuthorId = entity.AuthorId;
            book.Quantity = entity.Quantity;
            book.CategoryId= entity.CategoryId;
            book.PublicationYear = entity.PublicationYear;
            book.LibraryId = entity.LibraryId;
            book.StudentId = entity.StudentId;
            
            // Diğer kitap özelliklerini buraya ekleyin

            _bookRepository.Update(book);
        }
    }
}