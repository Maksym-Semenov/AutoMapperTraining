using Microsoft.EntityFrameworkCore;

namespace AutoMapperTraining.EF;

public class AutoMapperContext : DbContext
{
    public AutoMapperContext(DbContextOptions<AutoMapperContext> options) : base(options){ }
}