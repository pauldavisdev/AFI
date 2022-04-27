using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Core.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Customer> Customers { get; }
        DbSet<Policy> Policies { get; }
        Task<int> SaveChangesAsync();
    }
}
