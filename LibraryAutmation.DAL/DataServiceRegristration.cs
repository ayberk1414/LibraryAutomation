using LibraryAutmation.DAL.Interface;
using LibraryAutmation.DAL.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAutmation.DAL
{
    public class DataServiceRegristration
    {
        ServiceProvider serviceProvider;
        public DataServiceRegristration()
        {
            serviceProvider = new ServiceCollection().AddScoped<IPersonelRepository, PersonelRepository>().AddScoped<IToLendRepository,ToLendRepository>().
                AddScoped<IStudentRepository,StudentRepository>().AddScoped<IBookRepository,BookRepository>().
                AddScoped<ICategoryRepository,CategoryRepository>().AddScoped<ILibraryRepository,LibraryRepository>().
                AddScoped<IAuthorRepository,AuthorRepository>()
                .BuildServiceProvider();
        }
        public IPersonelRepository GetPersonelRepositoryInstance()
        {
            return serviceProvider.GetRequiredService<IPersonelRepository>();
        }
        public IToLendRepository GetToLendRepositoryInstance()
        {
            return serviceProvider.GetRequiredService<IToLendRepository>();
        }
        public IStudentRepository GetStudentRepositoryInstance()
        {
            return serviceProvider.GetRequiredService<IStudentRepository>();
        }

        public IBookRepository GetBookRepositoryInstance()
        {
            return serviceProvider.GetRequiredService<IBookRepository>();
        }

        public ICategoryRepository GetCategoryRepositoryInstance()
        {
            return serviceProvider.GetRequiredService<ICategoryRepository>();
        }

        public ILibraryRepository GetLibraryRepositoryInstance()
        {
            return serviceProvider.GetRequiredService<ILibraryRepository>();
        }

        public IAuthorRepository GetAuthorRepositoryInstance()
        {
            return serviceProvider.GetRequiredService<IAuthorRepository>();
        }

    }
}
