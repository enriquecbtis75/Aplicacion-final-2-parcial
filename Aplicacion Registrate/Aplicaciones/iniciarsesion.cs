using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_Registrate.Aplicaciones
{
    public partial class iniciarsesion : System.Windows.Forms.Form

    {
        private int inten = 0;
        private const int MaxInten = 4;
        private const string UsuarioCorrecto = "Omar";
        private const string ContraseñaCorrecta = "Omar2007";

        public iniciarsesion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBoxUsuario.Text;
            string cont = textBoxContraseña.Text;

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(cont))
            {
                MessageBox.Show("Ingresar el usuario y  su contraseña.", "Error");
            }
            else if (user.Length < 3)
            {
                MessageBox.Show("Como minimo 3 caracteres.", "Error");
            }
            else if (inten >= MaxInten)
            {
                MessageBox.Show("Se acabaron tus intentos", "Error");
                Application.Exit();
            }
            else
            {
                if (user == UsuarioCorrecto && cont == ContraseñaCorrecta)
                {
                    MessageBox.Show("¡Welcome!", "Se ingreso de forma correcta");


                }
                else if (user == UsuarioCorrecto && cont != ContraseñaCorrecta)
                {
                    MessageBox.Show("La contraseña del usuario es incorrecta.", "Error");
                    inten++;
                }
                else if (user != UsuarioCorrecto && cont == ContraseñaCorrecta)
                {
                    MessageBox.Show("El usuario es  incorrecto.", "Error");
                    inten++;
                }
                else
                {
                    MessageBox.Show("Ambos estan incorrectos", "Error");
                    inten++;
                }
            }

        }
    }
}
