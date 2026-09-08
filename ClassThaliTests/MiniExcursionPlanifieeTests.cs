using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassThali;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassThali.Tests
{
    [TestClass()]
    public class MiniExcursionPlanifieeTests
    {
        [TestMethod()]
        public void MiniExcursionPlanifieeTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetCodeTest()
        {
            MiniExcursion ME = new MiniExcursion(1, "Visite de l'ile au large de THALI", 20);
            MiniExcursionPlanifiee MEP = new MiniExcursionPlanifiee("1", ME, DateTime.Parse("14:00"));
            Assert.AreEqual("1", MEP.GetCode());
        }

        [TestMethod()]
        public void SetNombreInscritsTest()
        {
            MiniExcursion ME = new MiniExcursion(1, "Visite de l'ile au large de THALI", 20);
            MiniExcursionPlanifiee MEP = new MiniExcursionPlanifiee("1", ME, DateTime.Parse("14:00"));
            Assert.AreEqual(0, MEP.GetNombreInscrit());
            MEP.SetNombreInscrits(1);
            Assert.AreEqual(1, MEP.GetNombreInscrit());
            MEP.SetNombreInscrits(1);
            Assert.AreEqual(2, MEP.GetNombreInscrit());
        }

        [TestMethod()]
        public void GetNombreInscritTest()
        {
            MiniExcursion ME = new MiniExcursion(1, "Visite de l'ile au large de THALI", 20);
            MiniExcursionPlanifiee MEP = new MiniExcursionPlanifiee("1", ME, DateTime.Parse("14:0"));
            Assert.AreEqual(0, MEP.GetNombreInscrit());
            MEP.SetNombreInscrits(1);
            Assert.AreEqual(1, MEP.GetNombreInscrit());
        }

        [TestMethod()]
        public void EstCompleteTest()
        {
            MiniExcursion ME = new MiniExcursion(1, "Visite de l'ile au large de THALI", 20);
            MiniExcursionPlanifiee MEP = new MiniExcursionPlanifiee("1", ME, DateTime.Parse("14:0"));
            Assert.AreEqual(false, MEP.EstComplete());
            MEP.SetNombreInscrits(20);
            Assert.AreEqual(true, MEP.EstComplete());
        }

        [TestMethod()]
        public void HeureRetourPrevueTest()
        {
            Assert.Fail();
        }
     }
    }
