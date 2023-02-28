using AutoMapperTraining.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoMapperTraining.EF;

public class AutoMapperContext : DbContext
{
    public AutoMapperContext(){ }
    public AutoMapperContext(DbContextOptions<AutoMapperContext> options) : base(options){ }

    public virtual DbSet<Branch> Branches { get; set; }
    public virtual DbSet<Contact> Contacts { get; set; }
    public virtual DbSet<Project> Projects { get; set; }
    public virtual DbSet<User> Users { get; set; }
}