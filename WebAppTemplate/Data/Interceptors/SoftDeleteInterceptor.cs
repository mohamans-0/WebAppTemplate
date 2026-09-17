using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using WebAppTemplate.Models;

namespace WebAppTemplate.Data.Interceptors
{
    public class SoftDeleteInterceptor : SaveChangesInterceptor
    {
        public override InterceptionResult<int> SavingChanges(DbContextEventData eventData, InterceptionResult<int> result)
        {
            var dbContext = eventData.Context;

            if (dbContext is null)
            {
                return new InterceptionResult<int>();
            }

            var models = dbContext.ChangeTracker.Entries<BaseEntity>();
            foreach (var item in models)
            {

                if (item.State is EntityState.Deleted)
                {
                    item.State = EntityState.Modified;
                    item.Entity.isDeleted = true;
                    item.Entity.DeleteDate = DateTime.UtcNow;
                }
            }

            return base.SavingChanges(eventData, result);
        }
    }
}