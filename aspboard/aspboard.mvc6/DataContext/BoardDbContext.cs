using aspboard.mvc6.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspboard.mvc6.DataContext
{
    public class BoardDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Board> Boards { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // @ : connection string을 있는 그대로 전달하기 위해 사용
            optionsBuilder.UseSqlServer(@"Server=20420HJW\SQLEXPRESS;Database=aspboard;User Id=sa;Password = saserver; ");
        }
    }
}
