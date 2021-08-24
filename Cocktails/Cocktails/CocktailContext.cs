using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails
{
    class CocktailContext : DbContext
    {
        public CocktailContext(): base("CocktailDB")
        {
            Console.WriteLine(Database.Connection.ConnectionString);
        }

        public DbSet<Drink> Drinks { get; set; }
        public DbSet<Garnish> Garnishes { get; set; }
        public DbSet<Alcohol> Alcohols { get; set; }
        public DbSet<Mixer> Mixers { get; set; }
    }
}
