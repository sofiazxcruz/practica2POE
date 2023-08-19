using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica2POE
{
    public partial class Form1 : Form
    {  
        //arreglo aca para almacenar las fotos
        private Image[] images;
        private int currentIndex = 0;
        public Form1()
        {
            InitializeComponent();
            LoadImages();//para cargar las imagenes 
            UpdateImage(); // para mostrar la imagen
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //tomar etiqueta y asignarle un cambio al contenido 
            //mediante el evento del boton

            label1.Text = "Despues del evento";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Antes del evento";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            //se pone el nombre del evento + el metodo de cambio
            //modificando el color del panel en aleatorio

            Color randomcolor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            panel1.BackColor = randomcolor;
        }
        private void LoadImages()
        {
            images = new Image[]
            {
                // carga las imágenes desde los recursos y
                // las almacena en el arreglo
                Properties.Resources.color1,
                Properties.Resources.color10,
                Properties.Resources.color13,
                Properties.Resources.color2,
                Properties.Resources.color3,
                Properties.Resources.color4,
                Properties.Resources.color5,
                Properties.Resources.color6,
                Properties.Resources.color7,
                Properties.Resources.color8,
                Properties.Resources.color9,


            };
        }
        private void UpdateImage()
        {
            //mostrara la imagen actual del picture box
            pictureBox1.Image = images[currentIndex];
        }

        private void ChangeImage(int delta)
        {
            // cambia la foto actual avanzando
            // o retrocediendo según el valor de 'delta'
            currentIndex = (currentIndex + delta + images.Length) % images.Length;
            UpdateImage();
        }

        private void atras_Click(object sender, EventArgs e)
        {
            //cambia la imagen para atras dando 
            //en el boton 
            ChangeImage(-1);
        }

        private void adelante_Click(object sender, EventArgs e)
        {
            //y esta para adelante 
            ChangeImage(1);
        }
    }
}
