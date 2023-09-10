using LibraryAutmation.BLL.Interfaces;
using LibraryAutmation.DAL.Interface;
using LibraryAutmation.DTO.Models;
using LibraryAutmation.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace LibraryAutmation.BLL.Managers
{
    public class LibraryManager : ILibraryService
    {
        private readonly ILibraryRepository _libraryRepository;

        public LibraryManager(ILibraryRepository libraryRepository)
        {
            _libraryRepository = libraryRepository;
        }

        public void Add(LibraryDTO entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity), "Kütüphane eklenecek veri boş olamaz.");
            }

            if (string.IsNullOrWhiteSpace(entity.LibraryName))
            {
                throw new ArgumentException("Kütüphane adı geçerli değil.", nameof(entity.LibraryName));
            }

            // Diğer gerekli kontrolleri burada ekleyin

            var library = new Library
            {
                LibraryName = entity.LibraryName,
                Location = entity.Location,
                ContactEmail = entity.ContactEmail, 
                FoundingYear = entity.FoundingYear,
                PhoneNumber = entity.PhoneNumber,
                Website = entity.Website,   
                // Diğer kütüphane özelliklerini buraya ekleyin
            };

            _libraryRepository.Add(library);
        }

        public void Delete(LibraryDTO entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity), "Silinecek kütüphane verisi boş olamaz.");
            }

            var library = _libraryRepository.Get(l => l.Id == entity.Id);

            if (library == null)
            {
                throw new InvalidOperationException("Belirtilen kütüphane bulunamadı.");
            }

            // Silme işlemi burada gerçekleştirilir
            _libraryRepository.Delete(library);
        }

        public LibraryDTO Get(Expression<Func<LibraryDTO, bool>> filter = null)
        {
            if (filter == null)
            {
                throw new ArgumentNullException(nameof(filter), "Filtre boş olamaz.");
            }

            // Belirtilen filtreye göre kütüphaneyi almak için gereken işlemleri burada gerçekleştirin
            var library = _libraryRepository.Get(l => filter.Compile().Invoke(new LibraryDTO
            {
                Id = l.Id,
                LibraryName = l.LibraryName,
                Location = l.Location,
                ContactEmail = l.ContactEmail,
                FoundingYear = l.FoundingYear,
                PhoneNumber = l.PhoneNumber,
                Website = l.Website,
                // Diğer kütüphane özelliklerini buraya ekleyin
            }));

            // Eğer filtreye uyan bir kütüphane bulunmazsa null dönebilirsiniz.
            if (library == null)
            {
                return null;
            }

            // Dönüş değeri olarak LibraryDTO tipinde bir nesne oluşturup bu kütüphaneyi doldurun
            var libraryDTO = new LibraryDTO
            {
                Id = library.Id,
                LibraryName = library.LibraryName,
                Location = library.Location,
                ContactEmail = library.ContactEmail,
                FoundingYear = library.FoundingYear,
                PhoneNumber = library.PhoneNumber,
                Website = library.Website,
                // Diğer kütüphane özelliklerini buraya ekleyin
            };

            // Son olarak, oluşturduğunuz LibraryDTO nesnesini döndürün
            return libraryDTO;
        }

        public List<LibraryDTO> GetAll(Expression<Func<LibraryDTO, bool>> filter = null)
        {
            if (filter == null)
            {
                var libraries = _libraryRepository.GetAll();
                var libraryDTOs = libraries.Select(library => new LibraryDTO
                {
                    Id = library.Id,
                    LibraryName = library.LibraryName,
                    Location = library.Location,
                    ContactEmail = library.ContactEmail,
                    FoundingYear = library.FoundingYear,
                    PhoneNumber=library.PhoneNumber,
                    Website=library.Website,
                    // Diğer kütüphane özelliklerini buraya ekleyin
                }).ToList();

                return libraryDTOs;
            }
            else
            {
                // Belirtilen filtreye göre kütüphaneleri almak için gereken işlemleri burada gerçekleştirin
                var libraries = _libraryRepository.GetAll(library => library.Id == library.Id);
                var libraryDTOs = libraries.Select(library => new LibraryDTO
                {
                    Id = library.Id,
                    LibraryName = library.LibraryName,
                    Location = library.Location,
                    ContactEmail = library.ContactEmail,
                    FoundingYear = library.FoundingYear,
                    PhoneNumber=library.PhoneNumber,
                    Website=library.Website,
                    // Diğer kütüphane özelliklerini buraya ekleyin
                }).ToList();

                return libraryDTOs;
            }
        }

        public void Update(LibraryDTO entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity), "Güncellenecek kütüphane verisi boş olamaz.");
            }

            var library = _libraryRepository.Get(l => l.Id == entity.Id);

            if (library == null)
            {
                throw new InvalidOperationException("Belirtilen kütüphane bulunamadı.");
            }

            library.LibraryName = entity.LibraryName;
            library.Location = entity.Location;
            library.ContactEmail = entity.ContactEmail;
            library.FoundingYear = entity.FoundingYear;
            library.PhoneNumber = entity.PhoneNumber;
            library.Website = entity.Website;
            
            // Diğer kütüphane özelliklerini buraya ekleyin

            _libraryRepository.Update(library);
        }
    }
}
