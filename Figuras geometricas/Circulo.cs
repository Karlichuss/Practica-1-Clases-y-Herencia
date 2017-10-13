using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras_geometricas
{
    /// <summary>
    /// Clase Circulo hija de Figura.
    /// </summary>
    class Circulo :Figura
    {
        /*DEFINICION DE ATRIBUTOS*/

        private float radio;

        /*CONSTRUCTOR*/

        public Circulo(float radio)
        {
            this.radio = radio;
        }

        /*METODOS*/

        /// <summary>
        /// Metodo que calcula el perimetro del circulo.
        /// </summary>
        /// <returns>El perimetro del circulo en decimales.</returns>
        public override float Perimetro()
        {
            // Para sacar el perimetro de un circulo debemos conocer su radio y aplicar la siguiente formula:
            return (float)(2 * Math.PI * radio);
        }

        /// <summary>
        /// Metodo que calcula el area del circulo.
        /// </summary>
        /// <returns>El area del circulo en decimales.</returns>
        public override float Area()
        {
            // Para sacar el area de un circulo debemos conocer su radio y aplicar la siguiente formula:
            return (float)Math.Pow(Math.PI * radio, 2);
        }
    }
}
