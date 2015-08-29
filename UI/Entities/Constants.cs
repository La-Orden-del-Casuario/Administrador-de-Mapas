using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{

    /**
     * Esta clase encapsula las differentes constantes utilizadas en la aplicacion
     * como la asignacion de provincias y de preferencias de cada local.
     * 
     * */

    public class Constants
    {

        /**
         * Constantes para los valores de cada provincia.
         * 
         * SJ = San Jose
         * CA = Cartago
         * AL = Alajuela
         * HE = Heredia
         * LI = Limon
         * PU = Puntarenas
         * GU = Guanacaste
         * 
         * */

        public const int SJ = 1;
        public const int CA = 2;
        public const int AL = 3;
        public const int HE = 4;
        public const int LI = 5;
        public const int PU = 6;
        public const int GU = 7;

        /**
         * Constantes para los valores de las preferencias de usuario
         * y el tipo de servicio del local.
         * 
         * 1 = M/F
         * 2 = M/M
         * 3 = F/F
         * 
         * */

        public const int MF = 1;
        public const int MM = 2;
        public const int FF = 3;

        /**
         *  Constante para el rango de un local.
         *  Determina el numero de estrellas a dibujar.
         * 
         *  Es simplemente un promedio. Sólo se debe de sumar todos los votos y dividir por el número
         *  (es decir, recuento) de las calificaciones para obtener el promedio. Después redondear 
         *  donde sea necesario.
         *
         *   Ej:
         *
         *   Valoraciones de 3, 4, 3, 2, 1, 5, 2
         *
         *   Suma = 20
         *   Contador votos = 7
         *
         *   Promedio = (20/7) = 2,86
         *   Redondea a 3
         * 
         * */

        public const int ZERO = 0;
        public const int UNO = 1;
        public const int DOS = 2;
        public const int TRES = 3;
        public const int CUATRO = 4;
        public const int CINCO = 5;

    }
}
