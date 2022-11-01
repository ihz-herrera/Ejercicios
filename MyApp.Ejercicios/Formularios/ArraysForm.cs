using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApp.Ejercicios.Formularios
{
    public partial class ArraysForm : Form
    {

        //int[] numeros = new int[10];
        List<int> numeros = new List<int>();
        int contador = 0;

        public ArraysForm()
        {
            InitializeComponent();
            Ejemplo();
            
        }

        public void Ejemplo()
        {
            int[] myArreglo = new int[10];

            

            myArreglo[1] = 5;
            myArreglo[2] = 3;
            myArreglo[3] = 30;
            myArreglo[4] = 30;
            myArreglo[5] = 30;
            myArreglo[6] = 30;

            //var p = myArreglo[1] / myArreglo[2];

            MessageBox.Show(myArreglo.Length.ToString());


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var valor = int.Parse(txtNumero.Text);
            
            //numeros[contador] = valor;

            numeros.Add(valor);

            //contador++;

            lstNumeros.DataSource = null;
            lstNumeros.DataSource = numeros;
            lstNumeros.Refresh();
            

            //lstNumeros.Items
            //    .Add(valor);
        }
    }
}
