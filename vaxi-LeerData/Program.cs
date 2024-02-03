
using Microsoft.EntityFrameworkCore;
using System;
using vaxi_LeerData;
namespace LeerData
{
    class Program
    {
        static void Main(string[] args)
        {
            
            using (var db = new AppVentaCursosContext())
            {
                /*
                var cursos = db.Curso.AsNoTracking();
                foreach (var item in cursos)
                {
                    Console.WriteLine(item.Titulo);
                }*/
                var cursos = db.Curso.Include(p => p.PrecioPromocion).AsNoTracking();

                foreach (var curso in cursos)
                {
                    Console.WriteLine(curso.Titulo+ "----"+ curso.PrecioPromocion.PrecioActual);
                }
            }





            Console.ReadKey();
        }
    }

}