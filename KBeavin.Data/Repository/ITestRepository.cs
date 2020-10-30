using KBeavin.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace KBeavin.Data.Repository
{
    public interface ITestRepository : IRepository<Test>
    {
        //Task<IEnumerable<Music>> GetAllWithArtistAsync();
        //Task<Music> GetWithArtistByIdAsync(int id);
        //Task<IEnumerable<Music>> GetAllWithArtistByArtistIdAsync(int artistId);
    }
}
