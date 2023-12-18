using FundooModel.Labels;
using FundooModel.Notes;
using FundooModel.User;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FundooRepo.Context
{
    public class UserDbContext : IdentityDbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {

        }
        public DbSet<Register> Register { get; set; }
        public DbSet<Note> Note { get; set; }
        public DbSet<Label> Labels { get; set; }
        public DbSet<Collobrator> Collobrator { get; set; }
    }
}
