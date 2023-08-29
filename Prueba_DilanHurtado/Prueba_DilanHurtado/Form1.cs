using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_DilanHurtado
{
    public partial class Form1 : Form
    {
        private List<myclass> listaCalificaciones = new List<myclass>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = txtalumno.Text;
            int calificacion1 = int.Parse(txtn1.Text);
            int calificacion2 = int.Parse(txtn2.Text);
            int calificacion3 = int.Parse(txtn3.Text);

            myclass calif = new myclass(nombre, calificacion1, calificacion2, calificacion3);
            listaCalificaciones.Add(calif);

            ActualizarListView();
        }
        private void ActualizarListView()
        {
            listView1.Items.Clear();

            foreach (myclass calif in listaCalificaciones)
            {
                double promedio = calif.ObtenerPromedio();
                ListViewItem item = new ListViewItem(calif.NombreEstudiante);
                item.SubItems.Add(calif.Calificaciones[0].ToString());
                item.SubItems.Add(calif.Calificaciones[1].ToString());
                item.SubItems.Add(calif.Calificaciones[2].ToString());
                item.SubItems.Add(promedio.ToString());
                listView1.Items.Add(item);
            }
        }
    }
}
