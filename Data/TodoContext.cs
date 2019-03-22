using Microsoft.EntityFrameworkCore;
using webApiBaseAspNetCore2._1.Models;

namespace webApiBaseAspNetCore2._1.Data{
    
    public  class TodoContext : DbContext{

        public TodoContext(DbContextOptions<TodoContext> options)
         :base(options)
        {   
        }

        public DbSet<Usuario> Usuarios { get; set;}

    }

}