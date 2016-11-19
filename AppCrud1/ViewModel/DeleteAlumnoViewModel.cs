using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using AppCrud1.Models;

namespace AppCrud1.ViewModel
{
    public class DeleteAlumnoViewModel
    {
        public int? AlumnoId { get; set; }
      

        public DeleteAlumnoViewModel()
        {

        }
        public void Delete(int? AlumnoId)
        {
            this.AlumnoId = AlumnoId;

            if (AlumnoId.HasValue)
            {
                AlumnosEntities1 context = new AlumnosEntities1();
                Alumno objAlumno = context.Alumno.FirstOrDefault(
                                        x => x.AlumnoId == AlumnoId);

                if (objAlumno != null)
                {
                    context.Alumno.Remove(objAlumno);
                    context.SaveChanges();
                }


            }
        }
    }
}