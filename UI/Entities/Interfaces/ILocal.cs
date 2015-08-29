using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Interface ILocal, define los servicios exigidos que todos los locales deben de proveer.
 * 
 * */

namespace Entities.Interfaces
{
    interface ILocal
    {

        /**
         * Obtiene el ID de cada local.
         * 
         * */

        int Id { set; get; }

        /**
         * Obtiene el nombre del local, es obligatorio que cada local tenga un nombre.
         * 
         * */

        String Name { set; get; }

        /**
         * Obtiene el telefono del local, es obligatorio que cada local tenga un telefono.
         * 
         * */
        String Tel { set; get; }

        /**
         *  Obtiene la direccion del local, todo local debe de tener una provincia.
         * 
         * */

        int Provincia { set; get; }


        /**
         * Obtiene el publico meta del local, es obligatorio que un local tenga al menos un publico meta.
         * 
         * 1 = M/F
         * 2 = M/M
         * 3 = F/F
         * 
         * */

        int Preferencia { set; get; }




        /**
         *  Obtiene el GoogleMap del local, es obligatorio que un local tenga mapa.
         *  Comentado hasta definir el tipo de dato.
         * 
         * */


        String Url { set; get; }



    } //END Interface.


} //END Namespace.

