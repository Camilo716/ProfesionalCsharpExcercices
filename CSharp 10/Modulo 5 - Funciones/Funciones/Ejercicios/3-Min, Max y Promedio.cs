using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones.Ejercicios
{
    /*
    Implementa una función, llamada ObtenerMinMaxPromedio, que reciba un arreglo de enteros, y devuelva el valor máximo de dicho arreglo, 
    el valor mínimo, y el valor promedio.

    Para este ejercicio, utilizaremos parámetros out para extraer los tres valores.

    La función devolverá true si el arreglo de enteros tiene al menos un elemento, si tiene cero elementos devolverá false.

    El orden de los parámetros es: int[] nums, int min, int max, double promedio

    Nota: debes de colocar out en los parámetros adecuados.
     */

    public class MinMaxPromedio
    {
        public bool ObtenerMinMaxPromedio(int[] nums, out int min, out int max, out double promedio)
        {
            min = 0;
            max = 0;
            promedio = 0.0;

            if (nums.Length == 0)
            {
                return false;
            }

            max = nums[0];
            min = nums[0];
            var addition = 0.0;

            foreach (var num in nums)
            {
                if (num > max)
                {
                    max = num;
                }
                if (num < min)
                {
                    min = num;
                }

                addition += num;
            }

            promedio = addition / nums.Length;

            return true;
        }
    }
}
