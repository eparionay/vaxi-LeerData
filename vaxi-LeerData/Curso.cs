namespace vaxi_LeerData
{
    public class Curso
    {
        public int CursoId { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; } 
        public DateTime FechaPublicacion { get; set; } 
        
        //Relacion 1 a 1 con Tabla Precio
        public Precio PrecioPromocion { get; set; }
        //Relacion 1 a m con tabla comentario
        public ICollection<Comentario> ComentarioLista { get; set; }
        //Relacion n a m 
        public ICollection<CursoInstructor> InstructorLinea { get; set; }
    }
}
