using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace DAL
{
    public class Parcial2Db : DbContext
    {
        public Parcial2Db() : base("name=ConStr")
        {

        }
        public virtual DbSet<Clientes> Cliente { get; set; }
        public virtual DbSet<ClientesTelefonos> ClientesTelefono { get; set; }
        public virtual DbSet<TiposTelefonos> TiposTelefono { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{ 
        //    modelBuilder.Entity<Clientes>()
        //        .HasMany<ClientesTelefonos>(f => f.ClientesTelefono)
        //        .WithMany(d => d.Clientes)
        //        .Map(FD =>
        //        {
        //            FD.MapLeftKey("Id");
        //            FD.MapRightKey("ClienteId");
        //            FD.ToTable("TipoId");
        //        });
        //}
    }
}
