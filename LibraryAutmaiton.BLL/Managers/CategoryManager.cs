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
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryManager(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public void Add(CategoryDTO entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity), "Kategori eklenecek veri boş olamaz.");
            }

            if (string.IsNullOrWhiteSpace(entity.CategoryName))
            {
                throw new ArgumentException("Kategori adı geçerli değil.", nameof(entity.CategoryName));
            }

            // Diğer gerekli kontrolleri burada ekleyin

            var category = new Category
            {
                CategoryName = entity.CategoryName,
                Description = entity.Description
                // Diğer kategori özelliklerini buraya ekleyin
            };

            _categoryRepository.Add(category);
        }

        public void Delete(CategoryDTO entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity), "Silinecek kategori verisi boş olamaz.");
            }

            var category = _categoryRepository.Get(c => c.Id == entity.Id);

            if (category == null)
            {
                throw new InvalidOperationException("Belirtilen kategori bulunamadı.");
            }

            // Silme işlemi burada gerçekleştirilir
            _categoryRepository.Delete(category);
        }

        public CategoryDTO Get(Expression<Func<CategoryDTO, bool>> filter = null)
        {
            if (filter == null)
            {
                throw new ArgumentNullException(nameof(filter), "Filtre boş olamaz.");
            }

            // Belirtilen filtreye göre kategoriyi almak için gereken işlemleri burada gerçekleştirin
            var category = _categoryRepository.Get(c => filter.Compile().Invoke(new CategoryDTO
            {
                Id = c.Id,
                CategoryName = c.CategoryName,
                Description = c.Description,
                // Diğer kategori özelliklerini buraya ekleyin
            }));

            // Eğer filtreye uyan bir kategori bulunamazsa null dönebilirsiniz.
            if (category == null)
            {
                return null;
            }

            // Dönüş değeri olarak CategoryDTO tipinde bir nesne oluşturup bu kategoriyi doldurun
            var categoryDTO = new CategoryDTO
            {
                Id = category.Id,
                CategoryName = category.CategoryName,
                Description = category.Description,
                // Diğer kategori özelliklerini buraya ekleyin
            };

            // Son olarak, oluşturduğunuz CategoryDTO nesnesini döndürün
            return categoryDTO;
        }

        public List<CategoryDTO> GetAll(Expression<Func<CategoryDTO, bool>> filter = null)
        {
            if (filter == null)
            {
                var categories = _categoryRepository.GetAll();
                var categoryDTOs = categories.Select(category => new CategoryDTO
                {
                    Id = category.Id,
                    CategoryName = category.CategoryName,
                    Description = category.Description
                    // Diğer kategori özelliklerini buraya ekleyin
                }).ToList();

                return categoryDTOs;
            }
            else
            {
                // Belirtilen filtreye göre kategorileri almak için gereken işlemleri burada gerçekleştirin
                var categories = _categoryRepository.GetAll(category => category.Id == category.Id);
                var categoryDTOs = categories.Select(category => new CategoryDTO
                {
                    Id = category.Id,
                    CategoryName = category.CategoryName,
                    Description = category.Description
                    // Diğer kategori özelliklerini buraya ekleyin
                }).ToList();

                return categoryDTOs;
            }
        }

        public void Update(CategoryDTO entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity), "Güncellenecek kategori verisi boş olamaz.");
            }

            var category = _categoryRepository.Get(c => c.Id == entity.Id);

            if (category == null)
            {
                throw new InvalidOperationException("Belirtilen kategori bulunamadı.");
            }

            category.CategoryName = entity.CategoryName;
            category.Description = entity.Description;
            // Diğer kategori özelliklerini buraya ekleyin

            _categoryRepository.Update(category);
        }
    }
}
