﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables.Ejercicios
{
    /*
    Implementa un algoritmo que te permita determinar el número más grande dentro de un arreglo de enteros. 
    Debes asignar el resultado a la variable resultado. Si el arreglo numeros tiene cero elementos, pues debes asignarle null a resultado.

    Tu código va debajo del comentario y encima del return.
     */

    public class NumeroMayor
    {
        public int? DeterminarElNumeroMayor(int[] numeros)
        {
            int? resultado;
            resultado = numeros.Length == 0 ? null : int.MinValue;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > resultado)
                {
                    resultado = numeros[i];
                }
            }

            return resultado;
        }
    }
}
