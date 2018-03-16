using System.Collections.Generic;
using System.Threading.Tasks;
using EntityFrameworkTest.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkTest.DataAccess
{
    public class ItemsRepository
    {
        private readonly IntegrationDatabase databaseContext;
        public ItemsRepository()
        {
            this.databaseContext = new IntegrationDatabase();
        }

        public async Task<IList<Item>> GetAll()
        {
            return await databaseContext.Items.ToListAsync();
        }
        
        public async Task Create(Item item)
        { 
            databaseContext.Add(item);
            await databaseContext.SaveChangesAsync();
        }
    }
}
