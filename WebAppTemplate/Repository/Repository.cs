using Microsoft.EntityFrameworkCore;
using WebAppTemplate.Data;
using WebAppTemplate.Models;
using System.Collections.Generic;

namespace WebAppTemplate.Repository
{
    public class Repository<T> : iRepository<T> where T : BaseEntity
    {

        DataDbContext dataDbContext;
        DbSet<T> dbSet;


        public Repository(DataDbContext dataDbContext)
        {
            this.dataDbContext = dataDbContext;
            dbSet = dataDbContext.Set<T>();
        }

        public void Add(T model)
        {
            dbSet.Add(model);
            dataDbContext.SaveChanges();
        }

        public void changeStatus(int id)
        {
            var model = dbSet.Find(id);
            model.isActive = !model.isActive;
            dbSet.Update(model);
            dataDbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            dbSet.Remove(dbSet.Find(id));
            dataDbContext.SaveChanges();
        }

        public T Find(int id)
        {
            return dbSet.FirstOrDefault(x=> x.Id == id && !x.isDeleted);
        }

        public void Update(T model)
        {
            dbSet.Update(model);
            dataDbContext.SaveChanges();
        }

        public List<T> View()
        {
            return dbSet.Where(x => !x.isDeleted).ToList();
        }

        public List<T> ViewClinet()
        {
            return dbSet.Where(x => !x.isDeleted && x.isActive).ToList();
        }
    }
}
