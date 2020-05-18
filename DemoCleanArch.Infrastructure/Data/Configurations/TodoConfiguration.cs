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
            builder.HasKey(e => e.TodoId);
            
            builder.Property(e => e.Title)
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(e => e.CreationTime);
            builder.Property(e => e.UpdatedTime);

            builder.HasData(Enumerable.Range(1,5)
                .Select(x => new Todo
                {
                    TodoId = x,
                    Title = $"Title {x}"
                }).ToList());
        }
    }
}
