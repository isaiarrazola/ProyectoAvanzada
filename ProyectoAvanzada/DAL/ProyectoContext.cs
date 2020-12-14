using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ProyectoAvanzada.Models;

namespace ProyectoAvanzada.DAL
{
    public class ProyectoContext:DbContext
    {
        public ProyectoContext() : base("ProyectoContext")
        {

        }

        public DbSet<Producto> productos { get; set; }
     
        public DbSet<Cliente> clientes { get; set; }
       

        public DbSet<Sucursal> sucursales { get; set; }
       
        public DbSet<UMedida> UMedidas { get; set; }
       
        public DbSet<Categoria> Categorias { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        { 
            base.OnModelCreating(modelBuilder);
        }

    }
}