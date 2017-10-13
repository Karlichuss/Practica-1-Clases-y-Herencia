using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras_geometricas
{
    /// <summary>
    /// Clase Triangulo hija de Figura.
    /// </summary>
    class Triangulo :Figura
    {
        /*DEFINICION DE ATRIBUTOS*/

        private float lado1, lado2, lado3;

        /*CONSTRUCTOR*/

        public Triangulo(float lado1, float lado2, float lado3)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
            this.lado3 = lado3;
        }

        /*METODOS*/

        /// <summary>
        /// Metodo que calcula el perimetro del triangulo.
        /// </summary>
        /// <returns>El perimetro del triangulo en decimales.</returns>
        public override float Perimetro()
        {
            // Para sacar el perimetro de un triangulo, debemos sumar sus 3 lados.
            return lado1 + lado2 + lado3;
        }

        /// <summary>
        /// Metodo que calcula el area del triangulo.
        /// </summary>
        /// <returns>El area del triangulo en decimales.</returns>
        public override float Area()
        {
            // Para sacar el area de un triangulo, debemos usar el teorema de Herón.
            return (float)Math.Sqrt((Perimetro() / 2) * ((Perimetro() / 2 - lado1) * (Perimetro() / 2 - lado2) * (Perimetro() / 2 - lado3)));
        }
    }
}
