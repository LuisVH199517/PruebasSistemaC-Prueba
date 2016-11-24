using System;
using System.Collections.Generic;
using System.Linq;
using AppCrud1.Models;
namespace AppCrud1.ViewModel
{
    public class LstAlumnosViewModel
    {
        public String Filtro { get; set; }
        public List<Alumno> LstAlumnos { get; set; }

        public LstAlumnosViewModel()
        {
        }
        public void Fill()
        {
            AlumnosEntities1 context = new AlumnosEntities1();
            var query = context.Alumno.AsQueryable();

            if (!String.IsNullOrEmpty(Filtro))
                query = query.Where(x => x.Nombres.Contains(Filtro.ToUpper()));

            LstAlumnos = query.ToList();
        }
    }
}