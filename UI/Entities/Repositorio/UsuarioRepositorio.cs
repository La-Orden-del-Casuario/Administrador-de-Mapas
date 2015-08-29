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
    public class UsuarioRepositorio : IRepository<Usuario>
    {

        /// <author>Jean Maradiaga</author>
        /// <summary>
        /// Repositorio de usuarios
        /// Objeto encargado de levantar objetos de usuario bajo demanda del gestor.
        /// Permite la comunicacion entre el gestor y los datos mediante objetos.
        /// </summary>

        private List<IEntity> _insertItems;
        private List<IEntity> _deleteItems;
        private List<IEntity> _updateItems;

        private static UsuarioRepositorio instance;

        public static UsuarioRepositorio Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UsuarioRepositorio();
                }
                return instance;
            }
        }


        private UsuarioRepositorio()
        {
            _insertItems = new List<IEntity>();
            _deleteItems = new List<IEntity>();
            _updateItems = new List<IEntity>();
        }

        public void Insert(Usuario entity)
        {
            _insertItems.Add(entity);
        }


        public void Delete(Usuario entity)
        {
            _deleteItems.Add(entity);
        }


        public void Update(Usuario entity)
        {
            _updateItems.Add(entity);
        }



        public IEnumerable<Usuario> GetAll()
        {
            List<Usuario> lista = new List<Usuario>();
            try
            {

                DataTable tablaResultado = DataBaseAccess.advanceStoredProcedureRequest("pa_usuario_listar");
                foreach (DataRow fila in tablaResultado.Rows)
                {
                    lista.Add(new Usuario(

                        int.Parse(fila.ItemArray[0].ToString()),
                        fila.ItemArray[1].ToString(),
                        fila.ItemArray[2].ToString(),
                        fila.ItemArray[3].ToString(),
                        DateTime.Parse(fila.ItemArray[4].ToString())

                    ));
                }

            }
            catch (Exception ex)
            {
                throw new DataAccessException(String.Format("SQL Error: {0}", ex.Message));
            }

            return lista;

        }


        public Usuario GetById(int idUsuario)
        {
            Usuario usuario = null;

            try
            {
                DataTable tablaResultado = DataBaseAccess.advanceStoredProcedureRequest("pa_usuario_buscar_id", new SPP[] { 
                new SPP("us_id", idUsuario.ToString())
            });

                usuario = new Usuario(

                    int.Parse(tablaResultado.Rows[0].ItemArray[0].ToString()),
                    tablaResultado.Rows[0].ItemArray[1].ToString(),
                    tablaResultado.Rows[0].ItemArray[2].ToString(),
                    tablaResultado.Rows[0].ItemArray[3].ToString(),
                    DateTime.Parse(tablaResultado.Rows[0].ItemArray[4].ToString())

                );
            }

            catch (Exception ex)
            {
                throw new Exception(String.Format("SQL Error: {0}", ex.Message));
            }

            return usuario;
        }


        public Usuario Validate(string _email)
        {
            Usuario usuario = new Usuario();

            try
            {

                DataTable tablaResultado = DataBaseAccess.advanceStoredProcedureRequest("pa_usuarios_validar", new SPP[] { 
                    new SPP("us_email", _email)
                    
                });

                if (tablaResultado.Rows.Count > 0)
                {
                    if (tablaResultado.Rows[0] != null)
                    {
                        usuario = new Usuario(

                            int.Parse(tablaResultado.Rows[0].ItemArray[0].ToString()),
                            tablaResultado.Rows[0].ItemArray[1].ToString(),
                            tablaResultado.Rows[0].ItemArray[2].ToString(),
                            tablaResultado.Rows[0].ItemArray[3].ToString(),
                            DateTime.Parse(tablaResultado.Rows[0].ItemArray[4].ToString())
                        );
                    }
                }

                return usuario;

            }
            catch (Exception ex)
            {

                throw new Exception(String.Format("SQL Error: {0}", ex.Message));

            }

        }


        public void Save()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    if (_insertItems.Count > 0)
                    {
                        foreach (Usuario usuario in _insertItems)
                        {
                            InsertUsuario(usuario);
                        }
                    }

                    if (_updateItems.Count > 0)
                    {
                        foreach (Usuario usuario in _updateItems)
                        {
                            UpdateUsuario(usuario);
                        }
                    }

                    if (_deleteItems.Count > 0)
                    {
                        foreach (Usuario usuario in _deleteItems)
                        {
                            DeleteUsuario(usuario);
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




        public int[] SaveUserData() {

            int length = _insertItems.Count + _insertItems.Count;
            int contador = 0;
            int[] result = new int[length]; 

            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    if (_insertItems.Count > 0)
                    {
                        foreach (Usuario usuario in _insertItems)
                        {
                            result[contador] = InsertUsuario(usuario);
                            contador++;
                        }
                    }

//                   if (_updateItems.Count > 0)
//                    {
//                       foreach (Usuario usuario in _updateItems)
//                        {
//                            result[contador] = UpdateUsuario(usuario);
//                            contador++;
//                       }
//                   }

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

                return result;

            }
        
        
        }

        public void Clear()
        {
            _insertItems.Clear();
            _deleteItems.Clear();
            _updateItems.Clear();
        }


        /// <summary>
        /// Este metodo agrega un nuevo usuario al sistema.
        /// </summary>
        /// <param name="usuario">Objeto Usuario</param>
        /// <returns>Retorna -1 si el nombre usuario ya existe, retorna -2 si el correo ya existe o 
        ///          retorna el ID de usuario si fue exitoso.
        /// </returns>
        private int InsertUsuario(Usuario usuario)
        {

            int result = 0;

            try
            {

                DataTable tablaResultado = DataBaseAccess.advanceStoredProcedureRequest("pa_usuario_agregar", new SPP[] { 

                new SPP("us_nombre", usuario.Nombre),
                new SPP("us_contra",   usuario.Password),
                new SPP("us_email",   usuario.Email)
            });

                if (tablaResultado.Rows.Count > 0)
                {
                    if (tablaResultado.Rows[0] != null)
                    {

                        result = (int.Parse(tablaResultado.Rows[0].ItemArray[0].ToString()));

                    }

                }

                return result;
            }

            catch (System.Data.SqlClient.SqlException sqlException)
            {

                throw sqlException;


            }

        }


        private void UpdateUsuario(Usuario usuario)
        {

            try
            {
                DataBaseAccess.simpleStoredProcedureRequest("pa_usuario_modificar", new SPP[] { 

                new SPP("us_id", usuario.Id.ToString()),   //0
                new SPP("us_nombre", usuario.Nombre),
                new SPP("us_contra",   usuario.Password),
                new SPP("us_email",   usuario.Email)
                });
            }
            catch (Exception ex)
            {

                throw new Exception(String.Format("Error: {0}", ex.Message));

            }

        }

        private void DeleteUsuario(Usuario usuario)
        {
            try
            {

                //TODO

            }
            catch (Exception ex)
            {
                throw new DataAccessException(String.Format("SQL Error: {0}", ex.Message));
            }

        }//fin método


        public int SetNewPassword(string _correo, string _password)
        {

            int result = 0;

            try
            {

                DataTable tablaResultado = DataBaseAccess.advanceStoredProcedureRequest("pa_usuario_recuperar_contra", new SPP[] { 

                new SPP("us_contra",   _password),
                new SPP("us_email",    _correo)
            });

                if (tablaResultado.Rows.Count > 0)
                {
                    if (tablaResultado.Rows[0] != null)
                    {

                        result = (int.Parse(tablaResultado.Rows[0].ItemArray[0].ToString()));

                    }

                }

                return result;
            }

            catch (System.Data.SqlClient.SqlException sqlException)
            {

                throw sqlException;

            }
        }


    }
}
