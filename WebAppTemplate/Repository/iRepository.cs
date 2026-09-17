using System.Collections.Generic;
namespace WebAppTemplate.Repository
{
    public interface iRepository<T> 
    {
        void Add(T model);
        void Update(T model);
        void Delete(int id);
        void changeStatus(int id);
        T Find(int id);
        List<T> View();
        List<T> ViewClinet();

    }
}
