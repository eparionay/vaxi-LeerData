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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Definimos que la entidad CursoInstructor tiene 2 llaves primarias
            modelBuilder.
                 Entity<CursoInstructor>().HasKey(ci => new { ci.InstructorId, ci.CursoId });


        }

        public DbSet<Curso> Curso { get; set; }
        public DbSet<Precio> Precio { get; set; }
        public DbSet<Comentario> Comentario { get; set; }   
        public DbSet<Instructor> Instructor { get; set; }

        public DbSet<CursoInstructor> CursoInstructor { get; set; }





        

    }
}
