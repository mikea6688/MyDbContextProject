using Microsoft.EntityFrameworkCore;

namespace MyDbContextPro;

public class MyDbContext : DbContext
{
    public MyDbContext(DbContextOptions<MyDbContext> options): base(options)
    {
    }
    
    
}