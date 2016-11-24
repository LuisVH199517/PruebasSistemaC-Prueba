using NUnit.Framework;
using AppCrud1.ViewModel;
namespace UnitTestProject2
{
    [TestFixture]
    public class LstAlumnosViewModelTest
    {
        public LstAlumnosViewModelTest()
        {

        }
        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        [Test]
        public void Flujo()
        {
            LstAlumnosViewModel objLstAlumnosViewModel = new LstAlumnosViewModel();
            objLstAlumnosViewModel.Fill();
            Assert.IsNotNull(objLstAlumnosViewModel);
        }
    }
}
