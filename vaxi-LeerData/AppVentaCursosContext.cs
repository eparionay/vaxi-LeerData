using Microsoft.EntityFrameworkCore;

namespace vaxi_LeerData
{
    public class AppVentaCursosContext : DbContext
    {
        //Una instancia de DBContext representa una sesion de conexion a bd
        private const string connectionString = @"Data Source=.; Initial Catalog=CursosOnline; uid=sa; pwd=sistemas;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<Curso> Curso { get; set; }
        public DbSet<Precio> Precio { get; set; }
        public DbSet<Comentario> Comentario { get; set; }   



        

    }
}
