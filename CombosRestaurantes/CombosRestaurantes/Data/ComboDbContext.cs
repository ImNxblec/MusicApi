using Microsoft.EntityFrameworkCore;
using CombosRestaurantes.Models;

namespace CombosRestaurantes.Data
{
    public class ComboDbContext : DbContext
    {
        public ComboDbContext(DbContextOptions<ComboDbContext> options)
            : base(options)
        {
        }
        public DbSet<Combo> Menus { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Combo>().HasData(
               new Combo
               {
                   Id = 1,
                   NombreCombo = "PROMO FESTIN FAMILIAR 1",
                   ConteniedoCombo = "8 presas de pollo + 1 papa frita grande + ensalada de col grande + 1 gaseosa 1L",
                   PrecioCombo = "16.99"
               },
               new Combo
               {
                   Id = 2,
                   NombreCombo = "PARTE Y COMPARTE 3 PRESAS 6 ALITAS DE PROMO",
                   ConteniedoCombo = "3 presas de pollo + 6 alitas picantes + 2 papas fritas regulares + 1 gaseosa",
                   PrecioCombo = "9.99"
               },
               new Combo
               {
                   Id = 3,
                   NombreCombo = "MARTES LOCO 7 PRESAS",
                   ConteniedoCombo = "7 presas de pollo",
                   PrecioCombo = "8.99"
               },
               new Combo
               {
                   Id = 4,
                   NombreCombo = "MEGA COMBO 1 ALITAS",
                   ConteniedoCombo = "1 presa de pollo + 3 alitas picantes + arroz + menestras + ensalada + 1 gaseosa 355 ml",
                   PrecioCombo = "4.99"
               },
               new Combo
               {
                   Id = 5,
                   NombreCombo = "15 PRESAS KFC SOLAS PROMO",
                   ConteniedoCombo = "15 presas de pollo",
                   PrecioCombo = "20.99"
               });
        }
    }
}
