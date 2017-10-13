using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras_geometricas
{
    /// <summary>
    /// Clase principal donde se encuentra las llamadas a los eventos y donde van los resultados de los metodos Petrimetro() y Area() de las clases hijas de Figura.
    /// </summary>
    public partial class Form1 : Form
    {
        /*DEFINICION DE VARIABLES*/

        string modo = "Rectangulo";
        Figura figura;

        /*CONSTRUCTOR*/

        public Form1()
        {
            InitializeComponent();
        }

        /*EVENTOS*/

        /// <summary>
        /// Metodo llamado cuando se carga el formulario.
        /// Iniciamos dejando la seleccion Rectangulo y sus correspondientes vistas.
        /// El lblResultado le vaciamos el texto para que no sea visible.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            lblResultado.Text = "";
            lblParametro3.Visible = false;
            txtParametro3.Visible = false;
        }

        /// <summary>
        /// Metodo llamado cuando se hace click sobre el boton btnCalcular
        /// </summary>
        /// <param name="sender">El control desencadenante de la accion que es el que llama al metodo.</param>
        /// <param name="e">Atributos del control.</param>
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            /*Comprobamos primero que los campos estan rellenados correctamente.*/
            if (todoCorrecto())
            {
                /*Si todo esta Ok, mostramos los datos de la fogura.*/
                mostrarDatos();
            }
        }

        /// <summary>
        /// Metodo llamado cuando se hace alguna seleccion del tipo de figura.
        /// Esto afecta a la visibilidad de los campos a rellenar y el titulo de estos campos segun que figura sea.
        /// </summary>
        /// <param name="sender">El control desencadenante de la accion que es el que llama al metodo.</param>
        /// <param name="e">Atributos del control.</param>
        private void cambioDeSeleccion(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                modo = ((RadioButton)sender).Text;
            }

            switch (modo)
            {
                case "Rectangulo":
                    lblParametro1.Text = "Lado 1: ";
                    lblParametro2.Text = "Lado 2: ";
                    lblParametro1.Visible = true;
                    lblParametro2.Visible = true;
                    lblParametro3.Visible = false;
                    txtParametro1.Visible = true;
                    txtParametro2.Visible = true;
                    txtParametro3.Visible = false;

                    break;

                case "Triangulo":
                    lblParametro1.Text = "Lado 1: ";
                    lblParametro2.Text = "Lado 2: ";
                    lblParametro3.Text = "Lado 3: ";
                    lblParametro1.Visible = true;
                    lblParametro2.Visible = true;
                    lblParametro3.Visible = true;
                    txtParametro1.Visible = true;
                    txtParametro2.Visible = true;
                    txtParametro3.Visible = true;

                    break;

                case "Circulo":
                    lblParametro1.Text = "Radio: ";
                    lblParametro1.Visible = true;
                    lblParametro2.Visible = false;
                    lblParametro3.Visible = false;
                    txtParametro1.Visible = true;
                    txtParametro2.Visible = false;
                    txtParametro3.Visible = false;

                    break;

            }
        }

        /*METODOS*/

        /// <summary>
        /// Metodo que comprueba que todos los campos estan rellenados correctamente.
        /// Si hay algun problema con los datos introducidos, en lblResultado dejamos el mensaje de error correspondiente.
        /// </summary>
        /// <returns>Devuelve true si todo es correcto y no hay errores, false si se detecta algun error.</returns>
        private bool todoCorrecto()
        {
            bool ok = true;

            /*Comprobamos que los datos introducidos sean todos numeros decimales.*/
            if (!float.TryParse(txtParametro1.Text, out float i1) || !float.TryParse(txtParametro2.Text, out float i2) || !float.TryParse(txtParametro3.Text, out float i3))
            {
                ok = false;
                lblResultado.Text = "ERROR: Los campos deben ser valores decimales.\n";
            }

            /*Comprobamos que los valores introducidos no sean menor de 1. Por ejemplo un rectangulo no puede tener un lado de longitud 0.*/
            else if (float.Parse(txtParametro1.Text) < 1 || float.Parse(txtParametro2.Text) < 1 || float.Parse(txtParametro3.Text) < 1)
            {
                ok = false;
                lblResultado.Text = "ERROR: No se permiten valores menores de 1.\n";
            }

            /*Comprobamos en caso de que la figura seleccionada sea un triangulo, que no se den resultados a 0, o a infinito, o a un valor no numerico.*/
            else if (modo.Equals("Triangulo"))
            {
                figura = new Triangulo(float.Parse(txtParametro1.Text), float.Parse(txtParametro2.Text), float.Parse(txtParametro3.Text));

                if (float.IsInfinity(((Triangulo)figura).Area()) || float.IsNaN(((Triangulo)figura).Area()) || ((Triangulo)figura).Area() == 0)
                {
                    ok = false;
                    lblResultado.Text = "ERROR: El triangulo esta muy desproporcionado. No sobredimensiones o hagas demasiado pequeño un lado en proporcion a los demas.\n";
                }
            }

            return ok;
        }

        /// <summary>
        /// Metodo que muestra el perimetro y el area de la figura correspondiente.
        /// </summary>
        private void mostrarDatos()
        {
            switch (modo)
            {
                case "Rectangulo":
                    figura = new Rectangulo(float.Parse(txtParametro1.Text), float.Parse(txtParametro2.Text));
                    lblResultado.Text = String.Format("Figura: {0}\nPerimetro: {1}\nArea: {2}", modo, ((Rectangulo)figura).Perimetro(), ((Rectangulo)figura).Area());

                    break;
                case "Triangulo":
                    figura = new Triangulo(float.Parse(txtParametro1.Text), float.Parse(txtParametro2.Text), float.Parse(txtParametro3.Text));
                    lblResultado.Text = String.Format("Figura: {0}\nPerimetro: {1}\nArea: {2}", modo, ((Triangulo)figura).Perimetro(), ((Triangulo)figura).Area());

                    break;
                case "Circulo":
                    figura = new Circulo(float.Parse(txtParametro1.Text));
                    lblResultado.Text = String.Format("Figura: {0}\nPerimetro: {1}\nArea: {2}", modo, ((Circulo)figura).Perimetro(), ((Circulo)figura).Area());

                    break;
            }
        }
    }
}
