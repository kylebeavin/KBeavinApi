using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace KBeavin.Data.Context
{
    public class TestContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public TestContext(DbContextOptions<TestContext> options) : base(options)
        {
        }

        public DbSet<KBeavin.Data.Models.Test> Tests { get; set; }
    }
}
