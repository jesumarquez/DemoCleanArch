using DemoCleanArch.Domain.Common;
using DemoCleanArch.Domain.Entities;
using DemoCleanArch.Domain.Interfaces;
using DemoCleanArch.Infrastructure.Data.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoCleanArch.Infrastructure.Data
{
    public partial class TodoDbContext: DbContext
    {
        ICurrentUserService _currentUserService;
        public TodoDbContext()
        {
        }

        public TodoDbContext(DbContextOptions<TodoDbContext> options, ICurrentUserService currentUserService): base(options)
        {
            _currentUserService = currentUserService;
        }

        public virtual DbSet<Todo> Todo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach(var entry in ChangeTracker.Entries<AuditEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedBy = _currentUserService.UserId;
                        entry.Entity.Created = DateTime.UtcNow;
                        break;
                    case EntityState.Modified:
                        entry.Entity.LastModifiedBy = _currentUserService.UserId;
                        entry.Entity.LastModified = DateTime.UtcNow;
                        break;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
