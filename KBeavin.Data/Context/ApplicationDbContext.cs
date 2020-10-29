using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace KBeavin.Data.Context
{
    public class ApplicationDbContext : DbContext // TODO: Rename to KBeavinApiDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        //DbSet<Test> { get; set; }
    }
}
