using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class eticaretContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-DMD5S6B7 ;Initial Catalog=ETicaretSitesi; Integrated Security=True");
        }
        public DbSet<Kullanicis> Musteri { get; set; }

    }
}
