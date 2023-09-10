using LibraryAutmation.BLL.Interfaces;
using LibraryAutmation.BLL.Managers;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAutmation.BLL
{
    public class BusinessServiceRegistragion
    {
        ServiceProvider serviceprovider;

        public BusinessServiceRegistragion()
        {
            serviceprovider = new ServiceCollection().AddScoped<IAuthorService, AuthorManager>().AddScoped<ICategoryService, CategoryManager>().AddScoped<ILibraryService, LibraryManager>().AddScoped<IPersonelService, PersonelManager>().AddScoped<IStudentService, StudentManager>().AddScoped<IToLendService,ToLendManager>().AddScoped<IBookService,BookManager>().BuildServiceProvider();
        }

        public IAuthorService GetAuthorServiceInstance()
        {
            return serviceprovider.GetRequiredService<IAuthorService>();
        }
        public ICategoryService GetCategoryServiceInstance()
        {
            return serviceprovider.GetRequiredService<ICategoryService>();
        }
        public ILibraryService GetLibraryServiceInstance()
        {
            return serviceprovider.GetRequiredService<ILibraryService>();
        }
        public IPersonelService GetPersonelServiceInstance()
        {
            return serviceprovider.GetRequiredService<IPersonelService>();
        }
        public IStudentService GetStudentServiceInstance()
        {
            return serviceprovider.GetRequiredService<IStudentService>();
        }
        public IToLendService GetToLendServiceInstance()
        {
            return serviceprovider.GetRequiredService<IToLendService>();
        }
        public IBookService GetBookServiceInstance()
        {
            return serviceprovider.GetRequiredService<IBookService>();
        }
    }
}
