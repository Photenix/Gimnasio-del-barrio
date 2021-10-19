//directivas
using Microsoft.EntityFrameworkCore;
using GimMiBarrio.App.Dominio;
//Listo validado
namespace GimMiBarrio.App.Persistencia.AppRepositorios
{
    public class AppContext : DbContext
    {
        public DbSet<UsuarioRecurrente> UsuarioRecurrentes { get; set; }
        public DbSet<Plan> Planes { get; set; }
        public DbSet<Entrenador> Entrenadores { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Gimnasio> Gimnasios { get; set; }
        public DbSet<Maquina> Maquinas { get; set; }
        public DbSet<Transaccion> Transacciones { get; set; }
        public DbSet<PlanDia> PlanDias { get; set; }
        public DbSet<Login> Logins { get; set; }
        //crear el deContext
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                //usar este
                //.UseSqlServer("Server=localhost; Database=Default; user id=sa; Initial Catalog = ProyectoG60");
                //.UseSqlServer("Server=localhost; Database=Default; user id=sa; password=12345; Initial Catalog = ProyectoG60");
               //.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog =GimMiBarrioData");
               //.UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=GimMiBarrioData;/*User Id=sa;Password=12345*/");
               .UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=GimMiBarrioData");
               
            }
        }
    }
}