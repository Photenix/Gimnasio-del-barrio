//directivas
using Microsoft.EntityFrameworkCore;
using GimMiBarrio.App.Dominio;
//Listo validado
namespace GimMiBarrio.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<UsuarioRecurrente> UsuarioRecurrente { get; set; }
        public DbSet<Plan> Plan { get; set; }
        public DbSet<Entrenador> Entrenador { get; set; }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Gimnasio> Gimnasio { get; set; }
        public DbSet<Maquina> Maquina { get; set; }
        public DbSet<Transaccion> Transaccion { get; set; }
        public DbSet<PlanDia> PlanDia { get; set; }
        public DbSet<Login> Login { get; set; }
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