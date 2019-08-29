using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBACL
{
    public class AppContext : DBContext
    {
        public AppContext(DbContextOptions<AppContext> options) : base(options)
        {

        }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
    }
}
