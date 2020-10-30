using KBeavin.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace KBeavin.Business.Repositories
{
    public interface ITestRepository : IRepository<Test>
    {
        //new ValueTask<Test> GetByIdAsync(int id); // New keyword hides base member

        // Examples
        //Task<IEnumerable<Music>> GetAllWithArtistAsync();
        //Task<Music> GetWithArtistByIdAsync(int id);
        //Task<IEnumerable<Music>> GetAllWithArtistByArtistIdAsync(int artistId);
    }
}
