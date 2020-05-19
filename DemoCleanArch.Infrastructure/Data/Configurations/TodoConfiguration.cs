using DemoCleanArch.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoCleanArch.Infrastructure.Data.Configurations
{
    public class TodoConfiguration : IEntityTypeConfiguration<Todo>
    {
        public void Configure(EntityTypeBuilder<Todo> builder)
        {
            builder.Property(e => e.Title)
                .IsRequired()
                .HasMaxLength(150);

            builder.HasData(Enumerable.Range(1,5)
                .Select(x => new Todo
                {
                    TodoId = x,
                    Title = $"Title {x}",
                    Created = DateTime.Now,
                    CreatedBy = "Migration"
                }).ToList());
        }
    }
}
