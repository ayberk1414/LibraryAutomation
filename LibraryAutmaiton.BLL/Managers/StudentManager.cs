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
    public class StudentManager : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentManager(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public void Add(StudentDTO entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity), "Öğrenci eklenecek veri boş olamaz.");
            }

            if (string.IsNullOrWhiteSpace(entity.StudentName) || string.IsNullOrWhiteSpace(entity.StudentSurname))
            {
                throw new ArgumentException("Öğrenci adı ve soyadı geçerli değil.", $"{nameof(entity.StudentName)} veya {nameof(entity.StudentSurname)}");
            }

           

            var student = new Student
            {
              StudentName = entity.StudentName,
              Password = HashHelper.HashString(entity.Password,"abc"),
              StudentId = entity.StudentId,
              StudentSurname = entity.StudentSurname,
              TCKN = entity.TCKN,
              
            };

            _studentRepository.Add(student);
        }

        public void Delete(StudentDTO entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity), "Silinecek öğrenci verisi boş olamaz.");
            }

            var student = _studentRepository.Get(s => s.StudentId == entity.StudentId);

            if (student == null)
            {
                throw new InvalidOperationException("Belirtilen öğrenci bulunamadı.");
            }

            _studentRepository.Delete(student);
        }

        public StudentDTO Get(Expression<Func<StudentDTO, bool>> filter = null)
        {
            if (filter == null)
            {
                throw new ArgumentNullException(nameof(filter), "Filtre boş olamaz.");
            }
            var student = _studentRepository.Get(s => filter.Compile().Invoke(new StudentDTO
            {
                StudentId = s.StudentId,
                Password = HashHelper.HashString(s.Password,"abc"),
                StudentName = s.StudentName,
                StudentSurname = s.StudentSurname,
                TCKN = s.TCKN,
           
            }));

     
            if (student == null)
            {
                return null;
            }


            var studentDTO = new StudentDTO
            {
                StudentId = student.StudentId,
                Password = HashHelper.HashString(student.Password,"abc"),
                StudentName = student.StudentName,
                StudentSurname = student.StudentSurname,
                TCKN = student.TCKN,
      
            };

           
            return studentDTO;
        }


        public List<StudentDTO> GetAll(Expression<Func<StudentDTO, bool>> filter = null)
        {
            if (filter == null)
            {
                var students = _studentRepository.GetAll();
                var studentDTOs = students.Select(student => new StudentDTO
                {
                   StudentId=student.StudentId,
                   Password=HashHelper.HashString(student.Password,"abc"),   
                   StudentName=student.StudentName,
                   StudentSurname=student.StudentSurname,
                   TCKN=student.TCKN,
                }).ToList();

                return studentDTOs;
            }
            else
            {
             
                var students = _studentRepository.GetAll(student => student.StudentId == student.StudentId);
                var studentDTOs = students.Select(student => new StudentDTO
                {
                    StudentId = student.StudentId,
                    Password = HashHelper.HashString(student.Password,"abc"),
                    StudentName = student.StudentName,
                    StudentSurname = student.StudentSurname,
                    TCKN = student.TCKN,
                   
                }).ToList();

                return studentDTOs;
            }
        }

        public void Update(StudentDTO entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity), "Güncellenecek öğrenci verisi boş olamaz.");
            }

            var student = _studentRepository.Get(s => s.StudentId == entity.StudentId);

            if (student == null)
            {
                throw new InvalidOperationException("Belirtilen öğrenci bulunamadı.");
            }

         student.StudentName = entity.StudentName;
            student.StudentSurname = entity.StudentSurname;
            student.TCKN = entity.TCKN;
            student.Password = HashHelper.HashString(entity.Password,"abc");
            
           

            _studentRepository.Update(student);
        }
    }
}
