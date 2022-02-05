using System;
using Microsoft.EntityFrameworkCore;
using pagination.Models;
namespace pagination.Data
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }
        public DbSet<User> users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Name = "Mohammad",
                    Family = "Nojoumy",
                    Age = 21,
                    CreateDate = DateTime.Now
                },
                  new User
                  {
                      Id = 2,
                      Name = "Ali",
                      Family = "Saei",
                      Age = 21,
                      CreateDate = DateTime.Now
                  }, new User
                  {
                      Id = 3,
                      Name = "Hosein",
                      Family = "Rezaei",
                      Age = 21,
                      CreateDate = DateTime.Now
                  }, new User
                  {
                      Id = 4,
                      Name = "Arash",
                      Family = "Khani",
                      Age = 21,
                      CreateDate = DateTime.Now
                  }, new User
                  {
                      Id = 5,
                      Name = "Saeed",
                      Family = "Sami",
                      Age = 21,
                      CreateDate = DateTime.Now
                  }, new User
                  {
                      Id = 6,
                      Name = "Sahar",
                      Family = "Ghari",
                      Age = 21,
                      CreateDate = DateTime.Now
                  }, new User
                  {
                      Id = 7,
                      Name = "Shima",
                      Family = "Samiei",
                      Age = 21,
                      CreateDate = DateTime.Now
                  }, new User
                  {
                      Id = 8,
                      Name = "Zahra",
                      Family = "Bahari",
                      Age = 21,
                      CreateDate = DateTime.Now
                  }, new User
                  {
                      Id = 9,
                      Name = "Fatemeh",
                      Family = "Asghari",
                      Age = 21,
                      CreateDate = DateTime.Now
                  }, new User
                  {
                      Id = 10,
                      Name = "Sofia",
                      Family = "Abdi",
                      Age = 21,
                      CreateDate = DateTime.Now
                  }, new User
                  {
                      Id = 11,
                      Name = "Hanie",
                      Family = "Irani",
                      Age = 21,
                      CreateDate = DateTime.Now
                  }
            );
        }
    }
}