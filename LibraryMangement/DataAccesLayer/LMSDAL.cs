using System.Data.Entity;
using LibraryMangement.Models;


namespace LibraryMangement.DataAccesLayer
{
    public class LDB : DbContext
    {
        public DbSet<Role> Roles { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().ToTable("RoleTable");

            //modelBuilder.Entity<BookDetailModel>().ToTable("BookDetailTable");

            //modelBuilder.Entity<UserModel>().ToTable("UserTable");
            base.OnModelCreating(modelBuilder);


        }
        //DbSet will represent all the employees that can be queried from the database
       
        //public DbSet<BookDetailModel> BookDetail { get; set; }
        //public DbSet<UserModel> User { get; set; }
    }
}