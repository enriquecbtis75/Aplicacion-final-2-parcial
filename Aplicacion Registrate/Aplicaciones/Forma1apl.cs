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
    public partial class Forma1apl : System.Windows.Forms.Form
    {
        public Forma1apl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String name = textBox1.Text;
                String num = textBox5.Text;
                String numem = textBox3.Text;
                String tit = textBox6.Text;
                String dep = textBox2.Text;
                String sal = textBox7.Text;
                String numcuen = textBox4.Text;
                String corre = textBox8.Text;

                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(num) || string.IsNullOrWhiteSpace(numem) || string.IsNullOrWhiteSpace(tit) || string.IsNullOrWhiteSpace(dep) || string.IsNullOrWhiteSpace(sal) || string.IsNullOrWhiteSpace(numcuen) || string.IsNullOrWhiteSpace(corre))
                {
                    MessageBox.Show("Complete todos los campos.", "Error al ingresar");
                }

                else
                {
                    MessageBox.Show("\nNombre: " + name + "\nNúmero de telefono: " + num + "\nNúmero de empleado: "
                                       + numem + "\n Titulo del puesto: " + tit + "\nDepartamento: " + dep +
                                       "\nSalario: " + sal + "\n Número de cuenta: " + numcuen + "\nCorreo: " + corre);
                }
               
            }
            catch
            {
                MessageBox.Show("Error");
            }

        }
    }
}
