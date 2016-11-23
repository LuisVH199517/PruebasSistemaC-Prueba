using System;
using NUnit.Framework;
using AppCrud1.Models;
using AppCrud1.ViewModel;

namespace UnitTestProject1
{
    [TestFixture]
    public class AddEditAlumnoViewModelTest
    {


        [Test]
        public void Flujo()
        {
            Alumno objAlumno = new Alumno();
            objAlumno.AlumnoId = 22;
            objAlumno.ApellidoMaterno = "ddd";
            objAlumno.ApellidoPaterno = "dds";
            objAlumno.Celular = 33422232;
            objAlumno.DNI = 22311112;
            objAlumno.Edad = 12;
            objAlumno.NombreApoderado = "kdssd";
            objAlumno.Nombres = "fkfod";
            objAlumno.Telefono = 24232233;


            AddEditAlumnoViewModel objAlumnoViewModel = new AddEditAlumnoViewModel();
            objAlumnoViewModel.Fill(1);
            Assert.AreEqual(objAlumnoViewModel.AlumnoId,1);


        }

    }
}

