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
    public class ToLendManager : IToLendService
    {
        private readonly IToLendRepository _toLendRepository;

        public ToLendManager(IToLendRepository toLendRepository)
        {
            _toLendRepository = toLendRepository;
        }

        public void Add(ToLendDTO entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity), "Ödünç verilecek veri boş olamaz.");
            }

            var toLend = new ToLend
            {
                
                BookId = entity.BookId,
                LendDate = entity.LendDate, 
                PersonelId = entity.PersonelId, 
                ReturnDate = entity.ReturnDate, 
                TargetDate = entity.TargetDate,
            };

            _toLendRepository.Add(toLend);
        }

        public void Delete(ToLendDTO entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity), "Ödünç veri silinecek veri boş olamaz.");
            }

            var toLend = _toLendRepository.Get(t => t.Id == entity.Id);

            if (toLend == null)
            {
                throw new InvalidOperationException("Belirtilen ödünç veri bulunamadı.");
            }

  
            _toLendRepository.Delete(toLend);
        }

        public ToLendDTO Get(Expression<Func<ToLendDTO, bool>> filter = null)
        {
            if (filter == null)
            {
                throw new ArgumentNullException(nameof(filter), "Filtre boş olamaz.");
            }

           
            var toLend = _toLendRepository.Get(t => filter.Compile().Invoke(new ToLendDTO
            {
                Id = t.Id,
                BookId = t.BookId,
                LendDate = t.LendDate,
                PersonelId = t.PersonelId,
                ReturnDate = t.ReturnDate,
                TargetDate = t.TargetDate,
             
            }));

            if (toLend == null)
            {
                return null;
            }

            var toLendDTO = new ToLendDTO
            {
                Id = toLend.Id,
                BookId = toLend.BookId,
                LendDate = toLend.LendDate,
                PersonelId = toLend.PersonelId,
                ReturnDate = toLend.ReturnDate,
                TargetDate = toLend.TargetDate,
             
            };

           
            return toLendDTO;
        }


        public List<ToLendDTO> GetAll(Expression<Func<ToLendDTO, bool>> filter = null)
        {
            if (filter == null)
            {
                var toLends = _toLendRepository.GetAll();
                var toLendDTOs = toLends.Select(toLend => new ToLendDTO
                {
                    Id = toLend.Id,
                    BookId = toLend.BookId,
                    LendDate = toLend.LendDate,
                    PersonelId = toLend.PersonelId,
                    ReturnDate = toLend.ReturnDate,
                    TargetDate = toLend.TargetDate,
                   
                }).ToList();

                return toLendDTOs;
            }
            else
            {
                var filteredToLends = _toLendRepository.GetAll(toLend => toLend.Id == toLend.Id);

                var filteredToLendDTOs = filteredToLends.Select(toLend => new ToLendDTO
                {
                    Id = toLend.Id,
                    BookId = toLend.BookId,
                    LendDate = toLend.LendDate,
                    PersonelId = toLend.PersonelId,
                    ReturnDate = toLend.ReturnDate,
                    TargetDate = toLend.TargetDate,
                   
                }).ToList();

                return filteredToLendDTOs;
            }
        }


        public void Update(ToLendDTO entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity), "Güncellenecek ödünç veri boş olamaz.");
            }

            var toLend = _toLendRepository.Get(t => t.Id == entity.Id);

            if (toLend == null)
            {
                throw new InvalidOperationException("Belirtilen ödünç veri bulunamadı.");
            }

        

            toLend.BookId = entity.BookId;
            toLend.LendDate = entity.LendDate;
            toLend.PersonelId = entity.PersonelId;
            toLend.ReturnDate = entity.ReturnDate;
            toLend.TargetDate = entity.TargetDate;

            _toLendRepository.Update(toLend);
        }

    }
}
