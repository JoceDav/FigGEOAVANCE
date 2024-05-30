using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace figurageometrica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void POLIGONOREGULAR_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ESPERA_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LIMPIAR_Click(object sender, EventArgs e)
        {
                Datos.Clear();
                Rectangulo.Checked = false;
                Prisma.Checked = false;
                Cuadrado.Checked = false;
                Poligonoirregular.Checked = false;
                Poligonoregular.Checked = false;
                Esfera.Checked = false;
                Cubo.Checked = false;
                Circulo.Checked = false;
                Triangulo.Checked = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void GUARDAR_Click(object sender, EventArgs e)
        {
            if (Cuadrado.Checked)
            {
                MessageBox.Show("¡Los datos se han guardado correctamente!");
            }
            if (Triangulo.Checked)
            {
                MessageBox.Show("¡Los datos se han guardado correctamente!");
            }
            if (Circulo.Checked)
            {
                MessageBox.Show("¡Los datos se han guardado correctamente!");
            }
            if (Cubo.Checked)
            {
                MessageBox.Show("¡Los datos se han guardado correctamente!");
            }
            if (Esfera.Checked)
            {
                MessageBox.Show("¡Los datos se han guardado correctamente!");
            }
            if (Poligonoirregular.Checked)
            {
                MessageBox.Show("¡Los datos se han guardado correctamente!");
            }
            if (Poligonoregular.Checked)
            {
                MessageBox.Show("¡Los datos se han guardado correctamente!");
            }
            if (Prisma.Checked)
            {
                MessageBox.Show("¡Los datos se han guardado correctamente!");
            }
            if (Rectangulo.Checked)
            {
                MessageBox.Show("¡Los datos se han guardado correctamentes!");
            }
        }

        private void CALCULAR_Click(object sender, EventArgs e)
        {

        }

        private void CONSTRUCTOR_Click(object sender, EventArgs e)
        {

        }

        private void CAJA_TEXTO_TextChanged(object sender, EventArgs e)
        {

        }

        private void DIBUJAR_Click(object sender, EventArgs e)
        {
            if (Cuadrado.Checked)
            {
                string rutaImagen = "C:\\Users\\chipi\\Downloads\\imagenees\\FIGEO-main (1)\\FIGEO-main\\figurageometrica\\Imagenes\\cuadrado.png";
                IMAGEN.BackgroundImage = System.Drawing.Image.FromFile(rutaImagen);
            }
            if (Triangulo.Checked)
            {
                string rutaImagen = "C:\\Users\\chipi\\Downloads\\imagenees\\FIGEO-main (1)\\FIGEO-main\\figurageometrica\\Imagenes\\triangulo.png";
                IMAGEN.BackgroundImage = System.Drawing.Image.FromFile(rutaImagen);
            }
            if (Circulo.Checked)
            {
                string rutaImagen = "C:\\Users\\chipi\\Downloads\\imagenees\\FIGEO-main (1)\\FIGEO-main\\figurageometrica\\Imagenes\\circulo.png";
                IMAGEN.BackgroundImage = System.Drawing.Image.FromFile(rutaImagen);
            }
            if (Cubo.Checked)
            {
                string rutaImagen = "C:\\Users\\chipi\\Downloads\\imagenees\\FIGEO-main (1)\\FIGEO-main\\figurageometrica\\Imagenes\\cubo.jpg";
                IMAGEN.BackgroundImage = System.Drawing.Image.FromFile(rutaImagen);
            }
            if (Esfera.Checked)
            {
                string rutaImagen = "C:\\Users\\chipi\\Downloads\\imagenees\\FIGEO-main (1)\\FIGEO-main\\figurageometrica\\Imagenes\\esfera.png";
                IMAGEN.BackgroundImage = System.Drawing.Image.FromFile(rutaImagen);
            }
            if (Poligonoirregular.Checked)
            {
                string rutaImagen = "C:\\Users\\chipi\\Downloads\\imagenees\\FIGEO-main (1)\\FIGEO-main\\figurageometrica\\Imagenes\\poliIRR.png";
                IMAGEN.BackgroundImage = System.Drawing.Image.FromFile(rutaImagen);
            }
            if (Poligonoregular.Checked)
            {
                string rutaImagen = "C:\\Users\\chipi\\Downloads\\imagenees\\FIGEO-main (1)\\FIGEO-main\\figurageometrica\\Imagenes\\poliReg.jpg";
                IMAGEN.BackgroundImage = System.Drawing.Image.FromFile(rutaImagen);
            }
            if (Prisma.Checked)
            {
                string rutaImagen = "C:\\Users\\chipi\\Downloads\\imagenees\\FIGEO-main (1)\\FIGEO-main\\figurageometrica\\Imagenes\\prisma.jpg";
                IMAGEN.BackgroundImage = System.Drawing.Image.FromFile(rutaImagen);
            }
            if (Rectangulo.Checked)
            {
                string rutaImagen = "C:\\Users\\chipi\\Downloads\\imagenees\\FIGEO-main (1)\\FIGEO-main\\figurageometrica\\Imagenes\\rectammgulo.png";
                IMAGEN.BackgroundImage = System.Drawing.Image.FromFile(rutaImagen);
            }
        }
    }
}
