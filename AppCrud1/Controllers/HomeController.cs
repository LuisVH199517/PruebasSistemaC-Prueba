using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppCrud1.ViewModel;
using AppCrud1.Models;

namespace AppCrud1.Controllers
{
    public class HomeController : Controller
    {
        //public ActionResult Login()
        //{
        //    return View("LoginPartial");
        //}

        public ActionResult Index()
        {
            return View("_Login");
            //return RedirectToAction("Dashboard");
        }
        public ActionResult Dashboard()
        {
            DashboardViewModel objViewModel = new DashboardViewModel();
            return View(objViewModel);
        }

        public ActionResult LstAlumnos()
        {
            LstAlumnosViewModel objViewModel = new LstAlumnosViewModel();
            objViewModel.Fill();
            return View(objViewModel);
        }

     
         [HttpPost]
        public ActionResult DeleteAlumno(AddEditAlumnoViewModel objViewModel)
        {
            
            try
            {
                Alumno objAlumno = null;
                AlumnosEntities1 context = new AlumnosEntities1();

                if (objViewModel.AlumnoId.HasValue)
                    objAlumno = context.Alumno.FirstOrDefault(
                                 x => x.AlumnoId == objViewModel.AlumnoId);
                else
                {
                    objAlumno = new Alumno();
                    context.Alumno.Add(objAlumno);
                }

                context.Alumno.Remove(objAlumno);


                context.SaveChanges();
                return RedirectToAction("LstAlumnos");
            }
            catch (Exception ex)
            {
                return View(objViewModel);
            
        }
    }

        [HttpPost]
        public ActionResult LstAlumnos(LstAlumnosViewModel objViewModel)
        {
            objViewModel.Fill();
            return View(objViewModel);
        }
        ///aqui lleva a la pantalla de editar alumno (primer boton editar) osea que copia los datos y te manda a editar
        ///con los campos llenos
        public ActionResult AddEditAlumno(int? AlumnoId)
        {
            AddEditAlumnoViewModel objViewModel = new AddEditAlumnoViewModel();
            objViewModel.Fill(AlumnoId);
            return View(objViewModel);
        }
        ///aqui agrega un alumno (boton de guardar)
        [HttpPost]
        public ActionResult AddEditAlumno(AddEditAlumnoViewModel objViewModel)
        {
            try
            {
                Alumno objAlumno = null;
                AlumnosEntities1 context = new AlumnosEntities1();

                if (objViewModel.AlumnoId.HasValue)
                    objAlumno = context.Alumno.FirstOrDefault(
                                 x => x.AlumnoId == objViewModel.AlumnoId);
                else
                {
                    objAlumno = new Alumno();
                    context.Alumno.Add(objAlumno);
                }

                objAlumno.Nombres = objViewModel.Nombres;
                objAlumno.ApellidoPaterno = objViewModel.ApellidoPaterno;
                objAlumno.ApellidoMaterno = objViewModel.ApellidoMaterno;
                objAlumno.Edad = objViewModel.Edad;
                objAlumno.DNI = objViewModel.DNI;
                objAlumno.NombreApoderado = objViewModel.NombreApoderado;
                objAlumno.Telefono = objViewModel.Telefono;
                objAlumno.Celular = objViewModel.Celular;
                //objAlumno.FechaNacimiento = objViewModel.FechaNacimiento;
               

                context.SaveChanges();
                return RedirectToAction("LstAlumnos");
            }
            catch (Exception ex)
            {
                return View(objViewModel);
            }
        }
    }
}