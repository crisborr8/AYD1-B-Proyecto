using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using BlockBusted;
using BlockBusted.Models;

namespace BlockTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Christofer_loginTest()
        {
            BlockBusted.Models.Usuario usuario = new BlockBusted.Models.Usuario();
            usuario.email = "freddy@gmail.com";
            usuario.clave = "12345";
            Assert.IsNotNull(usuario.Login(usuario), "Usuario incorrecto");
        }
        [TestMethod]
        public void Christofer_BadloginTest()
        {
            BlockBusted.Models.Usuario usuario = new BlockBusted.Models.Usuario();
            usuario.email = "freddy@gmail.com";
            usuario.clave = "12345xxxx";
            String res = usuario.Login(usuario).Tables[0].Rows[0].ItemArray[0] + "";
            Assert.AreSame("0", res, "Usuario incorrecto");
        }
    }
}
