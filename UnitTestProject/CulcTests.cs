using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConvertorCore;

namespace Calculation.Tests
{
    [TestClass()]
    public class CulcTests
    {
        [TestMethod()]
        public void CulcTest()
        {            
            Assert.Fail();
        }

        [TestMethod()]
        public void CulcRadianTest()
        {
            
            int degree = 40;
            double radian = 0.698;

            Culc culc = new Culc();            
            double result= culc.CulcRadian(degree);

            Assert.AreEqual(radian, result);
        }

        [TestMethod()]
        public void CulcDegreeTest()
        {
            int degree = 30;
            double radian = 0.698;

            Culc culc = new Culc();
            int result = culc.CulcDegree(radian);

            Assert.AreEqual(degree, result);
        }

        [TestMethod()]
        public void CulcMillTest()
        {
            int km = 10;
            double mille = 6.21504;

            Culc culc = new Culc();
            double result = Math.Round(culc.CulcMill(km),5);

            Assert.AreEqual(mille, result);
        }

        [TestMethod()]
        public void CulcKMTest()
        {
            int km = 10;
            double mille = 6.21504;

            Culc culc = new Culc();
            int result =culc.CulcKM(mille);


            Assert.AreEqual(mille, km);
        }
    }
}