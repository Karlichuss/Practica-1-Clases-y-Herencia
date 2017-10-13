using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras_geometricas
{
    /// <summary>
    /// Clase Rectangulo hija de Figura.
    /// </summary>
    class Rectangulo:Figura
    {
        /*DEFINICION DE ATRIBUTOS*/

        private float lado1, lado2;

        /*CONSTRUCTOR*/

        public Rectangulo(float lado1, float lado2)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
        }

        /*METODOS*/

        /// <summary>
        /// Metodo que calcula el perimetro del rectangulo.
        /// </summary>
        /// <returns>El perimetro del rectangulo en decimales.</returns>
        public override float Perimetro()
        {
            // Para sacar el perimetro de un rectangulo, debemos sumar sus 4 lados.
            return lado1 * 2 + lado2 * 2; ;   
        }

        /// <summary>
        /// Metodo que calcula el area del rectangulo.
        /// </summary>
        /// <returns>El area del rectangulo en decimales.</returns>
        public override float Area()
        {
            // Para sacar el area de un rectangulo, debemos multiplicar el ancho por el alto.
            return lado1 * lado2;
        }
    }
}
