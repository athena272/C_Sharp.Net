using DogAndPeople.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DogAndPeople.Context
{
    public class Context : DbContext
    {
        public DbSet<Dono> Dono { get; set; }
        public DbSet<Cao> Cao { get; set; }
        public DbSet<Raca> Raca { get; set; }
    }
}