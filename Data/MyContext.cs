using System;
using Microsoft.EntityFrameworkCore;
using pagination.Models;
namespace pagination.Data{
    public class MyContext:DbContext{
public MyContext(DbContextOptions<MyContext> options):base(options)
{
    
}
public DbSet<User> users { get; set; }


    }
}