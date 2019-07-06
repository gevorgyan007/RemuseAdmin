using Microsoft.EntityFrameworkCore;
using RemuseWebApplication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RemuseWebApplication.Repositories
{
    public class AppRepository : DbContext
    {
        public AppRepository(DbContextOptions<AppRepository> options)
          : base(options)
        {


        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=AppDatabase.db");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Music> Musics { get; set; }
    }
}