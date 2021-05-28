using Cursinho.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Cursinho.Context
{
    public class Context : DbContext
    {

        public DbSet<Turma> dbTurma { get; set; }
        public DbSet<Curso> dbCurso { get; set; }
        public DbSet<Usuario> dbUsuario { get; set; }
    }
}