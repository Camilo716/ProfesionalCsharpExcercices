using System;

namespace Variables.Ejercicios
{
    /*
    En este problema vas a declarar e inicializar una variable de tipo DateTime con una fecha y hora específica.

    Entonces, debajo del comentario, pero encima del return, debes:

    1) Declarar una variable de tipo DateTime y nombre fecha

    2) Asignarle la fecha 12 de mayo a las 10 de la mañana. El año puede ser cualquiera (puedes poner el año actual).

    Remueve las dos líneas indicadas más abajo para descomentar el código y comenzar el ejercicio.
    */

    public class IntroduccionADateTime
    {
        public DateTime Ejercicio()
        {
            DateTime fecha = new DateTime(2023, 5, 12, 10, 2, 3);

            return fecha;
        }
    }
}
