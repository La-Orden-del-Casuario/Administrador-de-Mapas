using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public class Usuario : IEntity{

        public int    Id     { set; get; }

        public String Nombre { set; get; }

        public String Password { set; get; }

        public String Email  { set; get; }

        public DateTime FechaRegistro { set; get; }

        public Usuario(int _id = 0, String _nombre = "", String _contra = "", String _email = "", DateTime? _registro = null)
        {

            Id       = _id;
            Nombre   = _nombre;
            Password = _contra;
            Email    = _email;

            if ( _registro == null ) {

                FechaRegistro = DateTime.MinValue ;

            }else {

                FechaRegistro = _registro.Value;
            }    
        
        }


        public bool IsValid
        {
            get { return (GetRuleViolations().Count() == 0); }
        }

        public IEnumerable<RuleViolation> GetRuleViolations()
        {
            if (String.IsNullOrEmpty(Nombre))
            {
                yield return new RuleViolation("Nombre requerido", "Nombre");
            }
            else if (String.IsNullOrEmpty(Password))
            {
                yield return new RuleViolation("Contraseña requerida", "Contraseña");
            }
            else if (String.IsNullOrEmpty(Email))
            {
                yield return new RuleViolation("Correo requerido", "Email");
            }

            yield break;
        }



    }
}
