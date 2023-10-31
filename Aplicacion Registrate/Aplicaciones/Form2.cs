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
    public partial class Form2 : System.Windows.Forms.Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow renglon = (DataGridViewRow)dataestudiante.Rows[0].Clone();
                renglon.Cells[0].Value = textBox1.Text;
                renglon.Cells[1].Value = textBox5.Text;
                renglon.Cells[2].Value = textBox3.Text;
                renglon.Cells[3].Value = textBox6.Text;
                renglon.Cells[4].Value = textBox2.Text;
                renglon.Cells[5].Value = textBox7.Text;
                renglon.Cells[6].Value = textBox4.Text;
                renglon.Cells[7].Value = textBox8.Text;


                dataestudiante.Rows.Add(renglon);
            }
            catch (Exception error)
            {

            }
        }
    }
}
