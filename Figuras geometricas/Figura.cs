using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras_geometricas
{
    /// <summary>
    /// Clase padre Figura. Esta clase solo sirve como contenedor de los metodos que deben sobrescribir las clases hijas.
    /// </summary>
    class Figura
    {
        /*METODOS*/

        /// <summary>
        /// Metodo virtual que te devuelve el perimetro de la figura.
        /// </summary>
        /// <returns>El perimetro de la figura en decimales.</returns>
        public virtual float Perimetro()
        {
            return 0;
        }

        /// <summary>
        /// Metodo virtual que te devuelve el area de la figura.
        /// </summary>
        /// <returns>El area de la figura en decimales.</returns>
        public virtual float Area()
        {
            return 0;
        }
    }
}
