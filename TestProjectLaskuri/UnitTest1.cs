using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoreKonsoliTestiDemo;
// using System.Diagnostics; testien debuggaus

namespace TestProjectLaskuri
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void KerroKympit()
        {
            Laskuri la = new Laskuri();
            double tulos = la.kerro("10*10");
            Assert.AreEqual(tulos, 100);
        }

        [TestMethod]
        public void KerroDesimaaleilla()
        {
            Laskuri la = new Laskuri();
            double tulos = la.kerro("12,31*5,87");
            //Debug.WriteLine(tulos.ToString());
            Assert.AreEqual(tulos, 72,25970000000001);
        }
    }
}
