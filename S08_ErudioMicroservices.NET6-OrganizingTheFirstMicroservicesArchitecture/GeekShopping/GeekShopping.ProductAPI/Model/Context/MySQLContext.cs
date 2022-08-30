using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Model.Context
{
    public class MySQLContext: DbContext
    {
       public MySQLContext(){}
       public MySQLContext(DbContextOptions<MySQLContext> option):base(option){}
       public DbSet<Product> Products { get; set; }
    }
}
