using Microsoft.EntityFrameworkCore;

namespace webapi.Models;

public class DemoContext : DbContext
{
    public DemoContext(DbContextOptions<DemoContext> options) : base(options){}

    public DbSet<Member> members {get; set;} = null!;
}