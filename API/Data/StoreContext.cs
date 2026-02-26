using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using API.Entities;

namespace API.Data
{
    public class StoreContext(DbContextOptions options) : DbContext(options)
    {
            public required DbSet<Product> Products { get; set; }
    }
}