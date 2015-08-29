using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System.Collections;
using Entities;


namespace UT
{
    [TestClass]
    public class UnitTestLocales
    {

        private GestorLocales gestor = new GestorLocales();

        [TestMethod]
        public void TestAddLocal() {

            String nombre = "Hotel La Delicia";
            String telefono = "22617851";
            int preferencia = 1;
            int provincia = 1;
            String url = "www.delicias.com";
            String descripcion = "Un paraiso de delicias...solo bueno";

            try
            {

                gestor.agregarLocal(nombre, telefono, preferencia, provincia, url, descripcion);
                Console.Write("Se ha agregado un nuevo local", "Agregar local");
                

            }
            catch (Exception ex)
            {

                Assert.Fail(ex.ToString());

            } 

        }

        [TestMethod]
        public void TestReadLocal() {

            IEnumerable lstLocales= gestor.consultarLocales();

            Assert.IsNotNull(lstLocales);
            Console.Write("Se ha conseguido una lista de locales.");



        }



        [TestMethod]
        public void TestEditLocal() {

            try
            {

                Local local = gestor.consultarLocalById(4);
                Local antiguoLocal = local;

                gestor.editarLocal(4, "Palacio Homosexual del Pelucas", "22677611", 2, 1, "www.elpelucas.com", "1000 delicias anales");

                Local nuevoLocal = gestor.consultarLocalById(4);

                Assert.AreNotEqual(antiguoLocal, nuevoLocal);
              


            }
            catch (Exception ex)
            {

                Assert.Fail(ex.ToString());

            } 

            
        }


        [TestMethod]
        public void TestDeleteLocal() {

            try
            {

                gestor.eliminarLocal(3);
                Console.Write("Se ha eliminado el local No.3", "Eliminar local");


            }
            catch (Exception ex)
            {

                Assert.Fail(ex.ToString());

            } 


        }


        [TestMethod]
        public void TestSearchLocal()
        {
            try
            {

                Local local = gestor.consultarLocalById(1);
                Console.Write("Se ha consultado por el local ID.1, Nombre: " + local.Name);


            }
            catch (Exception ex)
            {

                Assert.Fail(ex.ToString());

            } 


        }




        [TestMethod]
        public void TestSearchLocalNombre()
        {
            try
            {

                IEnumerable lstLocales = gestor.buscarLocal("Cenfotec");
                Assert.IsNotNull(lstLocales);
                Console.Write("Se ha conseguido una lista de locales.");


            }
            catch (Exception ex)
            {

                Assert.Fail(ex.ToString());

            }


        }


    }
}
