using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Banca.Controllers;
using System.Web.Mvc;
namespace Banca.Tests
{
    [TestClass]
    public class AutenticarseTest
    {
        [TestMethod]
        public void login_usuario_valido()
        {
            //Assert
            String usuario = "admin";
            String password = "admin";
            var usuarioController = new UsuarioController();
            //Act
            var logueado = usuarioController.Autenticarse(usuario,password) as ViewResult;
            //Arrange
            //Assert.IsTrue(logueado);
        }
    }
}
