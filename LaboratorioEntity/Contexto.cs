using Microsoft.EntityFrameworkCore;
using DbContext = System.Data.Entity.DbContext;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Microsoft.EntityFrameworkCore.Design;

namespace LaboratorioEntity
{
    public class Contexto : DbContext
    {
        // Connection string, more details below 
        private const string connectionString = "Server=localhost;Database=sakila;Uid=root;Pwd=";

        // Initialize a new MySQL connection with the given connection parameters 
        protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(connectionString);
        }

        // Account model class created somewhere else 
        // public    DbSet < Account >    Accounts    {  get ;    set ;    } 
    }
}