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

namespace BLL
{
   public class GestorUsuarios{


        public int [] agregarUsuario(String _nombre, String _contra, String _email, DateTime? _registro = null)
        {
            try
            {
                Usuario usuario = new Usuario(0, _nombre, _contra, _email, _registro);

                if (usuario.IsValid)
                {
                    UsuarioRepositorio.Instance.Insert(usuario);
                    return UsuarioRepositorio.Instance.SaveUserData();
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (RuleViolation rv in usuario.GetRuleViolations())
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


        public void editarUsuario(int _id, String _nombre, String _contra, String _email)
        {

            try
            {

                Usuario Usuario = UsuarioRepositorio.Instance.GetById(_id);

                Usuario.Nombre   = _nombre;
                Usuario.Password = _contra;
                Usuario.Email    = _email;


                UsuarioRepositorio.Instance.Update(Usuario);
                UsuarioRepositorio.Instance.Save();
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



        public IEnumerable<Usuario> consultarUsuarios()
        {
            try
            {

                return UsuarioRepositorio.Instance.GetAll();
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

        public Usuario consultarUsuarioId(int idUsuario)
        {
            try
            {

                return UsuarioRepositorio.Instance.GetById(idUsuario);
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


        public Usuario validarUsuario(string _email)
        {
            try
            {

                return UsuarioRepositorio.Instance.Validate(_email);
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


        public int recuperarPassword(string _email, string _password)
        {

           try
            {

                return UsuarioRepositorio.Instance.SetNewPassword(_email, _password);
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
