using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using AppCrud1.Models;

namespace AppCrud1.ViewModel
{
    public class DashboardViewModel
    {
        public Int32 NroAlumnos { get; set; }

        public DashboardViewModel()
        {
            Fill();
        }

        public void Fill()
        {
            AlumnosEntities1 context = new AlumnosEntities1();
            NroAlumnos = context.Alumno.Count();
        }
    }
}