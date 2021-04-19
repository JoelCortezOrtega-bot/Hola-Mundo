using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labtec
{
    public partial class FrInicio : Form
    {
        public FrInicio()
        {
            InitializeComponent();
            //Muestra una breve descripcion en los cuadros de texto
            //Indica que debe colocar su ID y Contraseña
            ttlpMensajes.SetToolTip(txtIDUsuario, "Ingrese su ID.");
            ttlpMensajes.SetToolTip(txtClave, "Ingrese su contraseña.");
            //Indica que ese es el boton de salida
            ttlpMensajes.SetToolTip(pBoxCerrar, "Salir.");
        }

        private void pBoxCerrar_Click(object sender, EventArgs e)
        {
            //Cerrar la Aplicacion
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Objeto de la clase Operaciones
            Operaciones op = new Operaciones();

            try
            {
                //Asigna los valor capturadores de los txtbox en las variables 
                op.IDUsuario1 = Convert.ToInt32(txtIDUsuario.Text);
                op.Clave1 = Convert.ToInt32(txtClave.Text);
                //Llama al metodo Login de la clase Operaciones
                op.Login();
            }
            //Se encarga de atrapar cualquier error relacionado con valores no validos
            catch (FormatException)
            {
                //Verifica si alguno de los txt se encuentra vacio
                if (txtIDUsuario.Text == "" || txtClave.Text == "")
                {
                    //Llamamos al metodo static txtVacios
                    txtVacios(txtIDUsuario.Text, txtClave.Text);
                }
                //En caso de ninguno se encuentre vacio, mostrara el siguiente mensaje
                else
                {
                    string mensaje = "Por favor, solamente se aceptan numeros enteros.";
                    MessageBox.Show(mensaje, "Error de formato");
                }
            }
            finally
            {
                //Limpia los txt 
                txtIDUsuario.Clear();
                txtClave.Clear();
            }
        }//Fin del BotonAceptar

        //Excepcion personalizada
        static void txtVacios(string x,string y)//Recibe el ID y Contraseña
        {
            //Verifica si los cuadros de txt ambos estan vacios
            if (x == "" && y == "")
            {
                //Envia el siguiente mensaje.
                MessageBox.Show("Por favor rellenar ambos cuadros de texto");
            }
            else
            {
                //Verifica si el txt de la contraseña esta vacio
                if(y == "")
                {
                    MessageBox.Show("Por favor, no deje el recuadro de contraseña vacio.");
                }
                //Verifica si el txt de la usuario esta vacio
                else
                {
                    MessageBox.Show("Por favor, no deje el recuadro de usuario vacio.");
                }
                
            }
        }

        private void lblContraOl_MouseHover(object sender, EventArgs e)
        {
            lblContraOl.ForeColor = Color.Blue;
            lblContraOl.Font = new System.Drawing.Font(lblContraOl.Font, FontStyle.Underline);
        }

        private void lblContraOl_MouseLeave(object sender, EventArgs e)
        {
            lblContraOl.ForeColor = Color.Black;
            lblContraOl.Font = new System.Drawing.Font(lblContraOl.Font, FontStyle.Regular);
        }

        private void lblContraOl_Click(object sender, EventArgs e)
        {
            FrRecuperarClave fr = new FrRecuperarClave();
            fr.Show();
        }
    }
}
