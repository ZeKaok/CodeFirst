using Microsoft.EntityFrameworkCore;

namespace CodeFirstBTKAkademi.Models
{
    public class BTKAkademiDbContext:DbContext
    {

        //Connection open close işlemlerine son verildi.
        public BTKAkademiDbContext(DbContextOptions<BTKAkademiDbContext>options) : base(options) { }

        //Oluşturulacak tablonun adı.

        public DbSet<Movie> Movie { get; set; }

    }
}