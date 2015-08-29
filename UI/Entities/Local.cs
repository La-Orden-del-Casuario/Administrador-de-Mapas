using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Entities
{
    public class Local : ILocal
    {

        public int Id { set; get; }

        public String Name { set; get; }

        public String Tel { set; get; }

        public String Horario { set; get; }

        public String Descrip { set; get; }

        public int Preferencia { set; get; }

        public String Url { set; get; }

        public int Provincia { set; get; }

        public int Rango { set; get; }


        /**
         * Constructor: Local
         * Todos los parametros con valores por default son opcionales.
         * 
         * */

        public Local(int _id = 0, String _nombre = "", String _url = "", String _tel = "", string _descrip = "",
                     int _pref = 1, int _provincia = 0)
        {

            Id = _id;
            Name = _nombre;
            Tel = _tel;
            Descrip = _descrip;
            Preferencia = _pref;
            Provincia = _provincia;
            Url = _url;


        }

        /**
         *  El nombre del metodo getRuleViolations se obtiene si ocurrió una violación
         *  a la hora de llenar los campos requeridos, ultima barrera de validacion de datos antes de ser 
         *  ingresados a la base de datos.
         * 
         * */

        public bool IsValid
        {
            get { return (GetRuleViolations().Count() == 0); }
        }

        public IEnumerable<RuleViolation> GetRuleViolations()
        {
            if (String.IsNullOrEmpty(Name))
            {
                yield return new RuleViolation("Nombre requerido", "Nombre");
            }
            else if (String.IsNullOrEmpty(Tel))
            {
                yield return new RuleViolation("Telefono requerido", "Telefono");
            }

            else if (Preferencia < 0)
            {
                yield return new RuleViolation("Publico meta requerido", "Preferencia");
            }

            else if (Provincia < 0)
            {
                yield return new RuleViolation("Provincia requerida", "Provincia");
            }
            else if (String.IsNullOrEmpty(Url))
            {
                yield return new RuleViolation("Url requerida", "URL");
            }

            yield break;
        }


    } //END Local


} //END Namespace.
