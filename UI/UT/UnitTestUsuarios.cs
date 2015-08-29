using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entities;
using BLL;
using System.Collections;
using System.Diagnostics;

namespace UT
{
    [TestClass]
    public class UnitTestUsuarios
    {

        GestorUsuarios gestor = new GestorUsuarios();
        


        [TestMethod]
        public void TestMethodAddUser()
        {

            string password = PasswordHash.CreateHash("12345");

            int[] resul = gestor.agregarUsuario("Korra", password, "wateravatar506@gmail.com");

            try
            {
                if (resul[0] < 1)
                {
                    switch (resul[0])
                    {
                        case -1:
                            Console.WriteLine("Username en uso.");
                            break;

                        case -2:
                            Console.WriteLine("Email en uso.");
                            break;
                    }

                    Console.WriteLine("User added.");
                }

                Assert.IsTrue(true);

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.ToString());

            }
        }

        [TestMethod]
        public void TestMethodValidatePassword()
        {

            string password = "12345";

            Usuario usuario = gestor.validarUsuario("hpottere@ucenfotec.ac.cr");

            string userPass = usuario.Password;

            bool match = PasswordHash.ValidatePassword(password, usuario.Password);

            Assert.IsTrue(match);

        }



        [TestMethod]
        public void TestMethodReadUsers()
        {

            IEnumerable lstUsuarios = gestor.consultarUsuarios();

            Assert.IsNotNull(lstUsuarios);

        }

        [TestMethod]
        public void TestMethodSearchUserID()
        {

            try
            {

                Usuario usuario = gestor.consultarUsuarioId(1);
   

                Console.WriteLine("Se ha consultado por el usuario ID.1, Nombre: " + usuario.Nombre);


            }
            catch (Exception ex)
            {

                Assert.Fail(ex.ToString());

            }


        }


        [TestMethod]
        public void TestMethodUpdateUser()
        {

            try
            {

                Usuario usuario = gestor.consultarUsuarioId(5);
                Usuario antiguoUsuario = usuario;
                string password = PasswordHash.CreateHash("12345");

                gestor.editarUsuario(antiguoUsuario.Id, antiguoUsuario.Nombre, password, antiguoUsuario.Email);

                Usuario nuevoUsuario = gestor.consultarUsuarioId(1);

                Assert.AreNotEqual(antiguoUsuario, nuevoUsuario);



            }
            catch (Exception ex)
            {

                Assert.Fail(ex.ToString());

            } 

        }



        [TestMethod]
        public void TestMethodRecoverPass()
        {

            try {

                Cartero cartero = new Cartero { ReceiversAddress = "jeanmaradiaga@yahoo.com", subject = "Prueba", body = "Sos groso, sabelo!" };
                cartero.enviarCarta();
            }
            catch (Exception ex)
            {

                Assert.Fail(ex.ToString());

            } 
            

        }


        [TestMethod]
        public void TestMethodDeleteUser()
        {


        }



    }
}
