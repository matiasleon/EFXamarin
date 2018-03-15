using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EntityFrameworkTest.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkTest.DataAccess
{
    public class ItemsRepository
    {
        private readonly Database databaseContext;
        public ItemsRepository()
        {
            this.databaseContext = new Database();
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
