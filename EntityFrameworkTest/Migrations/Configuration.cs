
using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace EntityFrameworkTest.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<EntityFrameworkTest.Program>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }
    } 
}