using Microsoft.EntityFrameworkCore;
using System;
using Todo_API.Models;

namespace Todo_API.Data
{
    public class TodoDbContext : DbContext
    {
        public  TodoDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Todo> Todos { get; set; }

    }
}
