using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApp.Formulario
{
    public partial class Form1 : Form
    {

        private Operaciones operaciones = new Operaciones();
        private object idioma;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            int x = 0;
            int y = 0;


            if (String.IsNullOrEmpty(txtVar1.Text) == false)
            {
                x = int.Parse(txtVar1.Text);
            }

            if (String.IsNullOrEmpty(txtVar2.Text) == false)
            {
                y = int.Parse(txtVar2.Text);
            }

            //Operaciones.Sumar(x, y);
            var mensaje = Operaciones.GenerarMensaje(idioma);

            //label1.Text = mensaje;

           
        }

       

        private void Español_Click(object sender, EventArgs e)
        {
           // Operaciones.Idioma = Idioma.Español;
        }
    }
}
