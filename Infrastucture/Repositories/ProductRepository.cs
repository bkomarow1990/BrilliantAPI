using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.Models;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class ProductRepository : GenericRepository<Product>
    {
        public ProductRepository(BrilliantDbContext context)
            :base(context)
        {
            
        }
    }
}
