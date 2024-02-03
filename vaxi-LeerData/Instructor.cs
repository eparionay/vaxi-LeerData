namespace vaxi_LeerData
{
    public class Instructor
    {
        public int InstructorId { get; set; }
        public string nombre { get; set; }  
        public string Apellidos { get; set; }   
        public string Grado { get; set; }
        public byte[] FotoPerfil { get; set; }  

        public ICollection<CursoInstructor> CursoLinea { get; set; }    

    }
}
