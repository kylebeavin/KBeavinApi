using KBeavin.Data.Context;
using KBeavin.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;
using Microsoft.Extensions.Configuration;
using KBeavin.Data.Repository;

namespace KBeavin.Data.Repository
{
    public class TestRepository : Repository<Test>, ITestRepository
    {
        private readonly TestContext _context;

        public TestRepository(TestContext context) : base(context)
        {
            _context = context;
        }

        public Test GetTestById(int id)
        {
            Test test = new Test();
            try
            {
                var query = (from t in _context.Tests
                             where t.Id == id
                             select t).FirstOrDefault();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return test;
        }
    }
}
