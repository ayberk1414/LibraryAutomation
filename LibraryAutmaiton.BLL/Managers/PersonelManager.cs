using LibraryAutmation.BLL.Interfaces;
using LibraryAutmation.BLL.Tools;
using LibraryAutmation.DAL.Interface;
using LibraryAutmation.DTO.Models;
using LibraryAutmation.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace LibraryAutmation.BLL.Managers
{
    public class PersonelManager : IPersonelService
    {
        private readonly IPersonelRepository _personelRepository;

        public PersonelManager(IPersonelRepository personelRepository)
        {
            _personelRepository = personelRepository;
        }

        public void Add(PersonelDTO entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity), "Personel eklenecek veri boş olamaz.");
            }

            if (string.IsNullOrWhiteSpace(entity.FirstName) || string.IsNullOrWhiteSpace(entity.LastName))
            {
                throw new ArgumentException("Personel adı ve soyadı geçerli değil.", $"{nameof(entity.FirstName)} veya {nameof(entity.LastName)}");
            }

           

            var personel = new Personel
            {
                FirstName = entity.FirstName,
                LastName = entity.LastName,
               BirtDate = entity.BirtDate,
               Gender = entity.Gender,
               LibrayId=entity.LibraryId,
               Password = HashHelper.HashString(entity.Password,"abc"),
                // Diğer personel özelliklerini buraya ekleyin
            };

            _personelRepository.Add(personel);
        }

        public void Delete(PersonelDTO entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity), "Silinecek personel verisi boş olamaz.");
            }

            var personel = _personelRepository.Get(p => p.Id == entity.Id);

            if (personel == null)
            {
                throw new InvalidOperationException("Belirtilen personel bulunamadı.");
            }

        
            _personelRepository.Delete(personel);
        }

        public PersonelDTO Get(Expression<Func<PersonelDTO, bool>> filter = null)
        {
            if (filter == null)
            {
                throw new ArgumentNullException(nameof(filter), "Filtre boş olamaz.");
            }

            
            var personel = _personelRepository.Get(p => filter.Compile().Invoke(new PersonelDTO
            {
                Id = p.Id,
                FirstName = p.FirstName,
                LastName = p.LastName,
                BirtDate = p.BirtDate,
                Gender = p.Gender,
                LibraryId = p.LibrayId,
                Password = HashHelper.HashString(p.Password,"abc"),
              
            }));

            if (personel == null)
            {
                return null;
            }

        
            var personelDTO = new PersonelDTO
            {
                Id = personel.Id,
                FirstName = personel.FirstName,
                LastName = personel.LastName,
                BirtDate = personel.BirtDate,
                Gender = personel.Gender,
                LibraryId = personel.LibrayId,
                Password = HashHelper.HashString(personel.Password,"abc"),
                
            };

            return personelDTO;
        }


        public List<PersonelDTO> GetAll(Expression<Func<PersonelDTO, bool>> filter = null)
        {
            if (filter == null)
            {
                var personels = _personelRepository.GetAll();
                var personelDTOs = personels.Select(personel => new PersonelDTO
                {
                    Id = personel.Id,
                    FirstName = personel.FirstName,
                    LastName = personel.LastName,
                    BirtDate = personel.BirtDate,
                    Gender = personel.Gender,
                    LibraryId = personel.LibrayId,
                    Password = HashHelper.HashString(personel.Password, "abc")

                }).ToList();

                return personelDTOs;
            }
            else
            {
               
                var personels = _personelRepository.GetAll(personel => personel.Id == personel.Id);
                var personelDTOs = personels.Select(personel => new PersonelDTO
                {
                    Id = personel.Id,
                    FirstName = personel.FirstName,
                    LastName = personel.LastName,
                  BirtDate=personel.BirtDate,
                  Gender=personel.Gender,
                  LibraryId=personel.LibrayId,
                  Password=HashHelper.HashString(personel.Password,"abc"),
                  
                }).ToList();

                return personelDTOs;
            }
        }

        public void Update(PersonelDTO entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity), "Güncellenecek personel verisi boş olamaz.");
            }

            var personel = _personelRepository.Get(p => p.Id == entity.Id);

            if (personel == null)
            {
                throw new InvalidOperationException("Belirtilen personel bulunamadı.");
            }

            personel.FirstName = entity.FirstName;
            personel.LastName = entity.LastName;
          personel.BirtDate = entity.BirtDate;
            personel.Gender = entity.Gender;
            personel.LibrayId=entity.LibraryId;
            personel.Password=HashHelper.HashString(entity.Password,"abc");
            

            _personelRepository.Update(personel);
        }
    }
}

