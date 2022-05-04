using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using BlockBusted;
using BlockBusted.Models;

namespace BlockTest
{
    [TestClass]
    public class FunctionalTest
    {
        //Funcionales
        [TestMethod]
        public void Unit_loginTest()
        {
            BlockBusted.Models.Usuario usuario = new BlockBusted.Models.Usuario();
            usuario.email = "freddy@gmail.com";
            usuario.clave = "12345";
            Assert.IsNotNull(usuario.Login(usuario), "Usuario incorrecto");
        }
        [TestMethod]
        public void Unit_Transfer()
        {
            BlockBusted.Models.Pelicula mdl = new BlockBusted.Models.Pelicula();
            int res = (int)mdl.transferir("freddy@gmail.com", "soluna@gmail.com", 1).Tables[0].Rows[0].ItemArray[0];
            Assert.AreEqual(0, res, "Envio correcto");
        }
        [TestMethod]
        public void Unit_Historial()
        {
            BlockBusted.Models.Pelicula mdl = new BlockBusted.Models.Pelicula();
            int res = (int)mdl.getPeliculasHistorial("soluna@gmail.com").Tables[0].Rows.Count;
            Assert.AreNotEqual(0, res, "Mostrando historial");
        }
        [TestMethod]
        public void Unit_Registrar()
        {
            BlockBusted.Models.Pelicula mdl = new BlockBusted.Models.Pelicula();
            int res = (int)mdl.insertarUsuario("email2@gmail.com", "test1", "1234", "Testist", "Testost", 33, "0000000"); ;
            Assert.AreEqual(1, res, "Usuario registrado");
        }


    }

    [TestClass]
    public class NoFunctionalTest
    {

        //No funcionales
        [TestMethod]
        public void Unit_loginTest()
        {
            BlockBusted.Models.Usuario usuario = new BlockBusted.Models.Usuario();
            usuario.email = "freddy@gmail.com";
            usuario.clave = "12345xxxx";
            String res = usuario.Login(usuario).Tables[0].Rows[0].ItemArray[0] + "";
            Assert.AreSame("0", res, "Usuario incorrecto");
        }
        [TestMethod]
        public void Unit_Transfer_NoMovie()
        {
            BlockBusted.Models.Pelicula mdl = new BlockBusted.Models.Pelicula();
            int res = (int)mdl.transferir("coreo1", "correo2", 0).Tables[0].Rows[0].ItemArray[0];
            Assert.AreEqual(1, res, "Pelicula no existe");
        }
        [TestMethod]
        public void Unit_Transfer_NoEmail()
        {
            BlockBusted.Models.Pelicula mdl = new BlockBusted.Models.Pelicula();
            int res = (int)mdl.transferir("coreo1", "correo2", 1).Tables[0].Rows[0].ItemArray[0];
            Assert.AreEqual(1, res, "Correo de usuario inexistente");
        }
        [TestMethod]
        public void Unit_Transfer_NoFriend()
        {
            BlockBusted.Models.Pelicula mdl = new BlockBusted.Models.Pelicula();
            int res = (int)mdl.transferir("freddy@gmail.com", "correo2", 1).Tables[0].Rows[0].ItemArray[0];
            Assert.AreEqual(1, res, "Correo de amigo inexistente");
        }
    }
}
