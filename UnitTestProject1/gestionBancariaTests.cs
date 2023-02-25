using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using gestionBancariaApp;

namespace UnitTestProject1
{
    [TestClass]
    public class gestionBancariaTests
    {
        [TestMethod]

        // unit test code [TestMethod]
        public void validarMetodoIngreso()
        {
            // preparación del caso de prueba
            double saldoInicial = 1000;
            double ingreso = 500;
            double saldoActual = 0;
            double saldoEsperado = 1500;
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            // Método a probar
            cuenta.realizarIngreso(ingreso);
            // afirmación de la prueba (valor esperado Vs. Valor obtenido)
            saldoActual = cuenta.obtenerSaldo();
            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }
        [TestMethod]
        //[ExpectedException(typeof(Exception))]
        public void validarMetodoReintrego()
        {
            //preparamos los casos de prueba
            double saldo = 1000;
            double retiro = 500;
            double saldoActual = 0;
            double saldoEsperado = 500;

            gestionBancaria cuenta = new gestionBancaria(saldo);

            //metodo a probar
            cuenta.realizarReintegro(retiro);

            //valor esperado vs valor obtenido
            saldoActual = cuenta.obtenerSaldo();

            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }
    }
} 


