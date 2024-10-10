﻿using EntityLayer.WebApplication.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Configuration.WebApplication
{
    public class ContactUsConfig : IEntityTypeConfiguration<ContactUs>
    {
        public void Configure(EntityTypeBuilder<ContactUs> builder)
        {
            builder.Property(x => x.CreatedDate).IsRequired().HasMaxLength(10);
            builder.Property(x => x.UpdatedDate).HasMaxLength(10);
            builder.Property(x => x.RowVersion).IsRowVersion();
            builder.Property(x => x.Location).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Call).IsRequired().HasMaxLength(17);
            builder.Property(x => x.Map).IsRequired();

            builder.HasData(new ContactUs
            {
                Id = 1,
                CreatedDate = "05/05/2025",
                Call = "1246556956",
                Email = "test@try.com",
                Location = "Iron streen, Brave Avenue, KD1 2CF, London",
                Map = "TestLink Here"

            });


        }
    }
}
