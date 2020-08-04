using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace Cocktails
{
    class CocktailContext : DbContext
    {
        public CocktailContext() : base("CocktailDB")
        {
            Console.WriteLine(Database.Connection.ConnectionString);
        }

        public DbSet<Liquid> Liquids { get; set; }
        public DbSet<Garnish> Garnishes { get; set; }
        public DbSet<Drink> Drinks { get; set; }
    }
}
