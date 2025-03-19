using Data.interfaces;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;
namespace Data.DataBase
{
    public class AppDbContext: DbContext
    {
        private string _dbConfig;
        private ISafety _passwordManger;
        public AppDbContext(string dbconnectionstring, ISafety passwordManger)
        {
            if (string.IsNullOrWhiteSpace(dbconnectionstring)) throw new ArgumentNullException(nameof(dbconnectionstring));
            _dbConfig = dbconnectionstring;
            _passwordManger = passwordManger;
            if (!Database.EnsureCreated())
            {
                Database.EnsureCreated();
            }
            else
            {
                Database.Migrate();
            }
           
        }
        public DbSet<User> Users => Set<User>();
        public DbSet<TheoreticalModule> TheoreticalModules => Set<TheoreticalModule>();
        public DbSet<Assignment> Assignments => Set<Assignment>();
        public DbSet<TestModule> TestModules => Set<TestModule>();
        public DbSet<Review> Reviews => Set<Review>();
        public DbSet<Group> Groups => Set<Group>();
        public DbSet<BinaryData> BinaryDatas => Set<BinaryData>();
        public DbSet<Content> Contents => Set<Content>();
        public DbSet<ConfusingAnswers> ConfusingAnswers => Set<ConfusingAnswers>();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(_dbConfig);
            optionsBuilder.UseProjectables();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>()
                 .HasMany(x => x.Groups)
                 .WithOne(x => x.User)
                 .HasForeignKey(x => x.User_id);
            modelBuilder.Entity<User>()
                .HasMany(x => x.Reviews)
                .WithOne(x => x.User)
                .HasForeignKey(x => x.UserId);
            modelBuilder.Entity<User>()
                .HasMany(x => x.TestModules)
                .WithMany(x => x.Users)
                .UsingEntity(j => j.ToTable("BinderTest"));
            modelBuilder.Entity<User>()
                .HasMany(x => x.TheoriesModules)
                .WithMany(x => x.Users)
                .UsingEntity(j => j.ToTable("BinderTheoretical"));
            modelBuilder.Entity<TheoreticalModule>()
                .HasMany(x => x.Modules)
                .WithOne(x => x.TheoreticalModule)
                .HasForeignKey(x => x.ThId);
            modelBuilder.Entity<TheoreticalModule>()
                .HasMany(x => x.Assignments)
                .WithOne(x => x.TheoreticalModel)
                .HasForeignKey(x => x.TheoretiesModuleId);
            modelBuilder.Entity<TestModule>()
                .HasMany(x => x.Assignments)
                .WithOne(x => x.TestModel)
                .HasForeignKey(x => x.TestModuleId);
            modelBuilder.Entity<Assignment>()
                .HasOne(x => x.Content)
                .WithOne(x => x.Assignment)
                .HasForeignKey<Content>(x => x.AssigmentId);
            modelBuilder.Entity<Content>()
                .HasMany(x => x.BinaryDatas)
                .WithOne(x => x.Content)
                .HasForeignKey(x => x.ContentId);
            modelBuilder.Entity<Content>()
                .HasMany(x => x.ConfusingAnswers)
                .WithOne(x => x.Content)
                .HasForeignKey(x => x.ContentId)
                .IsRequired();
            var passwordinfo = _passwordManger.Salt("Admin", 8);
            modelBuilder.Entity<User>().HasData(new User() { Id = 1, Email = "Admin", IsAdmin = true, Name = "Admin", PasswordHash = passwordinfo.hash, Salt = passwordinfo.salt });
        }
    }
}
