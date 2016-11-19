using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using AppCrud1.Models;

namespace AppCrud1.ViewModel
{
    public class AddEditAlumnoViewModel
    {
        public int? AlumnoId { get; set; }
        public String Nombres { get; set; }
        public String ApellidoPaterno { get; set; }
        public String ApellidoMaterno { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public int? Edad { get; set; }
        public int? DNI { get; set; }
        public String NombreApoderado { get; set; }
        public int? Telefono { get; set; }
        public int? Celular { get; set; }

        public AddEditAlumnoViewModel()
        {

        }
        public void Fill(int? AlumnoId)
        {
            this.AlumnoId = AlumnoId;

            if (AlumnoId.HasValue)
            {
                AlumnosEntities1 context = new AlumnosEntities1();
                Alumno objAlumno = context.Alumno.FirstOrDefault(
                                        x => x.AlumnoId == AlumnoId);

                //if(objAlumno!=null)
                //{
                //    context.Alumno.Remove(objAlumno);
                //    context.SaveChanges();
                //}

              
                this.Nombres = objAlumno.Nombres;
                this.ApellidoMaterno = objAlumno.ApellidoMaterno;
                this.ApellidoPaterno = objAlumno.ApellidoPaterno;
                this.Edad = objAlumno.Edad;
                this.DNI = objAlumno.DNI;
                this.NombreApoderado = objAlumno.NombreApoderado;
                this.Telefono = objAlumno.Telefono;
                this.Celular = objAlumno.Celular;
                this.FechaNacimiento = objAlumno.FechaNacimiento;



               
                //var fn = FechaNacimiento.Date;
                //this.FechaNacimiento = fn ;
            }
        }
    }
}