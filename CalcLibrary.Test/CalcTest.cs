using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalcLibrary.Test
{
    [TestClass]
    public class CalcTest
    {
        [TestMethod]
        public void Calc_Test()
        {
            double numero = 36;
            double numeroaspettato = 6;
            double numerocalcolato = Calc.RadQ(numero);
            Assert.AreEqual(numeroaspettato, numerocalcolato);

        }

        [TestMethod]
        public void Calc_Test2()
        {
            double numero = 0;
            double numeroaspettato = 0;
            double numerocalcolato = Calc.RadQ(numero);
            Assert.AreEqual(numeroaspettato, numerocalcolato);


        }

        [TestMethod]
        public void Calc_Test3()
        {
            double numero = -3;
            double numeroaspettato = double.NaN;
            double numerocalcolato = Calc.RadQ(numero);
            Assert.AreEqual(numeroaspettato, numerocalcolato);


        }
        [TestMethod]
        public void Verticex()
        {
            double numero_a = 2;
            double numero_b = 4;
            double numeroaspettato = -1;
            double numerocalcolato = Calc.Vertx(numero_a, numero_b);
            Assert.AreEqual(numeroaspettato, numerocalcolato);


        }

        [TestMethod]
        public void Verticex2()
        {
            double numero_a = 0;
            double numero_b = 4;
            double numeroaspettato = double.NaN;
            double numerocalcolato = Calc.Vertx(numero_a, numero_b);
            Assert.AreEqual(numeroaspettato, numerocalcolato);


        }
        [TestMethod]
        public void Verticey()
        {
            double numero_a = 3;
            double numero_b = 4;
            double numero_c = 2;
            double numeroaspettato = 0.666666666666667; 
            double numerocalcolato = Calc.Verty(numero_a, numero_b,numero_c);
            Assert.AreEqual(numeroaspettato, numerocalcolato);


        }
    }
}
