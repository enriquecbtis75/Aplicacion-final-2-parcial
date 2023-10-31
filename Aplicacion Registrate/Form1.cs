using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aplicacion_Registrate.Aplicaciones;

namespace Aplicacion_Registrate
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            string nom =  textBox1.Text;
            string nom2 = textBox2.Text;
            string nom3 = textBox3.Text;
            string nom4 = textBox4.Text;
            string nom5 = textBox5.Text;

                if (string.IsNullOrWhiteSpace(nom) || string.IsNullOrWhiteSpace(nom2) || string.IsNullOrWhiteSpace(nom3) || string.IsNullOrWhiteSpace(nom4) || string.IsNullOrWhiteSpace(nom5))
                {
                    MessageBox.Show("Complete todos los campos.", "Error al ingresar al sistema");
                    return;
                }

                if (comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione una region.", "Error al Registrarse");
                    return;
                }

                string reg = comboBox1.SelectedItem.ToString();


                string genero = string.Empty;
                if (radioButton1.Checked)
                {
                    genero = "Hombre";
                }
                else if (radioButton2.Checked)
                {
                    genero = "Mujer";
                }
                else
                {
                    MessageBox.Show("Seleccione un género.", "Error al registrarse");
                    return;
                }

                MessageBox.Show("Primer nombre: " + nom + "\nPrimer apellido: " + nom2   + "\nUsuario: " + nom5 + "\nemail: " + nom3 + "\nContraseña: " + nom4 + "\nRegion: " + reg + "\nGenero: " + genero, "Inicio");
        }
            catch
            {
                MessageBox.Show("error");
            }
            }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            iniciarsesion form2 = new iniciarsesion();
            form2.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Forma1apl formas = new Forma1apl();
            formas.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 formra = new Form2();
            formra.Show();
        }
    }
}
