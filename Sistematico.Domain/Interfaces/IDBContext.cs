using Microsoft.EntityFrameworkCore;
using Sistematico.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sistematico.Domain.Interfaces
{
    public interface IDBContext
    {
        public  DbSet<Estudiante> Estudiantes { get; set; }

        public int SaveChanges();
        public Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
