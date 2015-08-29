using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Entities.Repositorio;
using TIL.CustomExceptions;

namespace BLL {
    public class GestorLocales {


        public void agregarLocal(String _nombre, String _telefono, int _preferencia, int _provincia, String _url, String _descripcion = "")
        {
            try
            {
                Local local = new Local(0,_nombre, _url, _telefono, _descripcion, _preferencia, _provincia);

                if (local.IsValid)
                {
                   LocalRepositorio.Instance.Insert(local);
                   LocalRepositorio.Instance.Save();
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (RuleViolation rv in local.GetRuleViolations())
                    {
                        sb.AppendLine(rv.ErrorMessage);
                    }
                    throw new ApplicationException(sb.ToString());
                }

            }
            catch (DataAccessException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("Error: {0}", ex.Message));
            }
        }


        public IEnumerable<Local> consultarLocales()
        {
            try
            {
                return LocalRepositorio.Instance.GetAll();
            }

            catch (DataAccessException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("Error: {0}", ex.Message));
            }

        }


        public void editarLocal(int _id, String _nombre, String _telefono, int _preferencia, int _provincia, String _url, String _descripcion = "")
        {


            try
            {
                Local local = LocalRepositorio.Instance.GetById(_id);

                local.Name = _nombre;
                local.Tel = _telefono;
                local.Preferencia = _preferencia;
                local.Provincia = _provincia;
                local.Url = _url;
                local.Descrip = _descripcion;

                LocalRepositorio.Instance.Update(local);
                LocalRepositorio.Instance.Save();
            }

            catch (DataAccessException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("Error: {0}", ex.Message));
            }
        
        
        }


        public void eliminarLocal(int id)
        {
            try
            {
                Local local = LocalRepositorio.Instance.GetById(id);
                LocalRepositorio.Instance.Delete(local);
                LocalRepositorio.Instance.Save();
            }
            catch (DataAccessException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("Error: {0}", ex.Message));
            }
        }

        public Local consultarLocalById(int id)
        {
            Local local = null;

            try
            {
                local = LocalRepositorio.Instance.GetById(id);
            }

            catch (DataAccessException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("Error: {0}", ex.Message));
            }

            return local;
        }


        public IEnumerable<Local> buscarLocal(String nombre)
        {
            try
            {
                return LocalRepositorio.Instance.getByName(nombre);
            }

            catch (DataAccessException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("Error: {0}", ex.Message));
            }

        }


    }
}
