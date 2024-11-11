using EscuelaBOL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EscuelaDAL;
using EscuelaBL;

namespace EscuelaApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TxtGuardar_Click(object sender, EventArgs e)
        {
            Alumnno alumnno= new Alumnno();
            alumnno.Nombre = txtNombre.Text;
            alumnno.ApellidoPAT = txtApellidoPAT.Text;
            alumnno.ApellidoMAT = txtApellidoMAT.Text;
            alumnno.Email = txtEmail.Text;
            alumnno.NumeroMatricula = txtMatricula.Text;


            bool res = EscuelaDAL.EscuelaDAL.InsertarAlumno(alumnno);
            if (res)
            {
                MessageBox.Show("Registro insertado");
            }
            else
            {
                MessageBox.Show("No se pudo guadar");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
