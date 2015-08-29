using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Transactions;
using System.Data.SqlClient;
using System.Data;
using TIL.CustomExceptions;
using DAL;
using Entities.Interfaces;

namespace Entities.Repositorio
{
   public class LocalRepositorio : IRepository<Local> {

    /// <author>Jean Maradiaga</author>
    /// <summary>
    /// Repositorio de locales
    /// Objeto encargado de levantar objetos de locales bajo demanda del gestor.
    /// Permite la comunicacion entre el gestor y los datos mediante objetos.
    /// </summary>

        private List<ILocal> _insertItems;
        private List<ILocal> _deleteItems;
        private List<ILocal> _updateItems;

        private static LocalRepositorio instance;

        public static LocalRepositorio Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LocalRepositorio();
                }
                return instance;
            }
        }


        /// <summary>Crea listas para insertar, eliminar y modificar locales.</summary>
        private LocalRepositorio()
        {
            _insertItems = new List<ILocal>();
            _deleteItems = new List<ILocal>();
            _updateItems = new List<ILocal>();
        }

        public void Insert(Local entity)
        {
            _insertItems.Add(entity);
        }


        public void Delete(Local entity)
        {
            _deleteItems.Add(entity);
        }


        public void Update(Local entity)
        {
            _updateItems.Add(entity);
        }



        public IEnumerable<Local> GetAll()
        {
            List<Local> lista = new List<Local>();
            try
            {

                DataTable tablaResultado = DataBaseAccess.advanceStoredProcedureRequest("pa_local_listar");
                foreach (DataRow fila in tablaResultado.Rows)
                {
                    lista.Add(new Local(

                        int.Parse(fila.ItemArray[0].ToString()),
                        fila.ItemArray[1].ToString(),
                        fila.ItemArray[2].ToString(),
                        fila.ItemArray[3].ToString(),
                        fila.ItemArray[4].ToString(),
                        int.Parse(fila.ItemArray[5].ToString()),
                        int.Parse(fila.ItemArray[6].ToString())


                    ));
                }

            }
            catch (Exception ex)
            {
                throw new DataAccessException(String.Format("SQL Error: {0}", ex.Message));
            }

            return lista;

        }


        public Local GetById(int idLocal)
        {
            Local local = null;

            try
            {
                DataTable tablaResultado = DataBaseAccess.advanceStoredProcedureRequest("pa_local_buscar_id", new SPP[] { 
                new SPP("loc_id", idLocal.ToString())
            });

                local = new Local(

                    int.Parse(tablaResultado.Rows[0].ItemArray[0].ToString()),
                    tablaResultado.Rows[0].ItemArray[1].ToString(),
                    tablaResultado.Rows[0].ItemArray[2].ToString(),
                    tablaResultado.Rows[0].ItemArray[3].ToString(),
                    tablaResultado.Rows[0].ItemArray[4].ToString(),
                    int.Parse(tablaResultado.Rows[0].ItemArray[5].ToString()),
                    int.Parse(tablaResultado.Rows[0].ItemArray[6].ToString())

                );
            }

            catch (Exception ex)
            {
                throw new Exception(String.Format("SQL Error: {0}", ex.Message));
            }

            return local;
        }



        public IEnumerable<Local> getByName(String nombre) {

            List<Local> lista = new List<Local>();
            

            try
            {
                DataTable tablaResultado = DataBaseAccess.advanceStoredProcedureRequest("pa_local_buscar_nombre", new SPP[] { 
                new SPP("loc_nombre", nombre.ToString())
                });

                if (tablaResultado.Rows.Count > 0)
                {

                    foreach (DataRow fila in tablaResultado.Rows)
                    {
                        lista.Add(new Local(

                            int.Parse(fila.ItemArray[0].ToString()),
                            fila.ItemArray[1].ToString(),
                            fila.ItemArray[2].ToString(),
                            fila.ItemArray[3].ToString(),
                            fila.ItemArray[4].ToString(),
                            int.Parse(fila.ItemArray[5].ToString()),
                            int.Parse(fila.ItemArray[6].ToString())


                        ));
                    }
                }
                else
                {
                    lista.Add(new Local());
                }

            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("SQL Error: {0}", ex.Message));
            }

            return lista;

        }


        public void Save()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    if (_insertItems.Count > 0)
                    {
                        foreach (Local local in _insertItems)
                        {
                            InsertLocal(local);
                        }
                    }

                    if (_updateItems.Count > 0)
                    {
                        foreach (Local local in _updateItems)
                        {
                            UpdateLocal(local);
                        }
                    }

                    if (_deleteItems.Count > 0)
                    {
                        foreach (Local local in _deleteItems)
                        {
                            DeleteLocal(local);
                        }
                    }

                    scope.Complete();
                }
                catch (TransactionAbortedException ex)
                {
                    throw new TransactionAbortedException(String.Format("Transaction Error: {0}", ex.Message));
                }
                catch (ApplicationException ex)
                {
                    throw ex;
                }
                finally
                {
                    Clear();
                }

            }
        }

        /// <summary>
        /// Limpia los datos que tiene _insertItems, _deleteItems y _updateItems.
        /// </summary>

        public void Clear()
        {
            _insertItems.Clear();
            _deleteItems.Clear();
            _updateItems.Clear();
        }


        private void InsertLocal(Local local)
        {

            try
            {
                DataBaseAccess.simpleStoredProcedureRequest("pa_local_agregar", new SPP[] {
                    new SPP("nombre", local.Name),
                    new SPP("telefono", local.Tel),
                    new SPP("preferencia", local.Preferencia.ToString()),
                    new SPP("provincia", local.Provincia.ToString()),
                    new SPP("url", local.Url),
                    new SPP("descripcion", local.Descrip)
                });
            }
            catch (Exception ex)
            {
                throw new DataAccessException(String.Format("SQL Error: {0}", ex.Message));
            }
        }


        private void UpdateLocal(Local local)
        {
            try
            {
                DataBaseAccess.simpleStoredProcedureRequest("pa_local_modificar", new SPP[] { 

                    new SPP("loc_id", local.Id.ToString()),
                    new SPP("loc_nombre", local.Name),
                    new SPP("loc_telefono", local.Tel),
                    new SPP("loc_preferencia", local.Preferencia.ToString()),
                    new SPP("loc_provincia", local.Provincia.ToString()),
                    new SPP("loc_url", local.Url),
                    new SPP("loc_descripcion", local.Descrip)
                });
            }
            catch (Exception ex)
            {
                throw new DataAccessException(String.Format("SQL Error: {0}", ex.Message));
            }
        }

        private void DeleteLocal(Local local)
        {
            try
            {
                DataBaseAccess.simpleStoredProcedureRequest("pa_local_eliminar", new SPP[] { 
                    new SPP("loc_id", local.Id.ToString()),
                });
            }
            catch (Exception ex)
            {
                throw new DataAccessException(String.Format("SQL Error: {0}", ex.Message));
            }

        }//fin método

    }
}
