
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
                /*
                var cursos = db.Curso.Include(p => p.PrecioPromocion).AsNoTracking();

                foreach (var curso in cursos)
                {
                    Console.WriteLine(curso.Titulo+ "----"+ curso.PrecioPromocion.PrecioActual);
                }
                */
                //asnotrackgines para no tener en cache la data que se devuelva 
                var cursos = db.Curso.Include(c=>c.ComentarioLista).AsNoTracking();

                foreach (var item in cursos)
                {
                    Console.WriteLine("Nombre curso " + item.Titulo);
                    foreach (var comen in item.ComentarioLista)
                    {
                        Console.WriteLine("Alumno :" + comen.Alumno + "- Comentario : " + comen.ComentarioTexto);
                    }
                    Console.WriteLine("****************+");
                }


            }
            Console.ReadKey();
        }
    }

}