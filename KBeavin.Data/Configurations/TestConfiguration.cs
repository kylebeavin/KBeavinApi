using KBeavin.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace KBeavin.Data.Configurations
{
    public class TestConfiguration : IEntityTypeConfiguration<Test>
    {
        public void Configure(EntityTypeBuilder<Test> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Id).UseIdentityColumn();

            builder.Property(a => a.Name).IsRequired().HasMaxLength(50);

            //builder
            //.HasOne(m => m.Artist)
            //.WithMany(a => a.Musics)
            //.HasForeignKey(m => m.ArtistId);

            builder.ToTable("Tests");
        }
    }
}
