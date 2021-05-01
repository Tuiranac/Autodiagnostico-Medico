using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AUTODIAGNÓSTICO_MÉDICO
{
    public partial class FormIngreso : Form
    {
        //Llamando la clase de los Datos personales
        DatosPersonales myPaciente = new DatosPersonales();
        public FormIngreso()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // Boton para ingresar al formSintomas
            Form Formulario_sintomas = new FormSintomas();
            Formulario_sintomas.Show();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //cerrar aplicación
            Application.Exit();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           


            //Validacion de cuadros de texto vacios
            if (txtCedula.Text == "")
            {
                errorTextoVacio.SetError(txtCedula, "Debe Ingresar una Cédula ");
                txtCedula.Focus();
                return;
            }
            errorTextoVacio.SetError(txtCedula, "");

            if (txtNombre.Text == "")
            {
                errorTextoVacio.SetError(txtNombre, "Debe Ingresar una Nombre ");
                txtNombre.Focus();
                return;
            }
            errorTextoVacio.SetError(txtNombre, "");
            if (txtEdad.Text == "")
            {
                errorTextoVacio.SetError(txtEdad, "Debe Ingresar una Edad ");
                txtEdad.Focus();
                return;
            }
            errorTextoVacio.SetError(txtEdad, "");
            if (txtSexo.Text == "")
            {
                errorTextoVacio.SetError(txtSexo, "Debe Ingresar el Sexo ");
                txtSexo.Focus();
                return;
            }
            errorTextoVacio.SetError(txtSexo, "");

            
            //Leyendo los datos de la clase y llamando los respectivos cuadros de texto del formIngreso

            myPaciente.Cedula = txtCedula.Text;
            myPaciente.Nombre = txtNombre.Text;
            myPaciente.Edad = txtEdad.Text;
            myPaciente.Sexo = txtSexo.Text;
            MessageBox.Show("El registro se ha realizado correctamente, tus datos son: " 
                + " Cédula: "+ txtCedula.Text 
                + " Nombre: " + txtNombre.Text 
                + " Edad: " + txtEdad.Text 
                + " Sexo: " + txtSexo.Text, "REGISTRO EXITOSO", MessageBoxButtons.OK,MessageBoxIcon.Information);

            //PASANDO DATOS AL FORMULARIO INGRESO
            FormSintomas Fsintomas = new FormSintomas();
            Fsintomas.txtNombreFormIngreso.Text = txtNombre.Text;
            Fsintomas.Show();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //Limpiar cada cuadro de texto
            txtCedula.Clear();
            txtNombre.Clear();
            txtEdad.Clear();
            txtSexo.Clear();
        }

 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {

        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {

        }

        private void btnMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void BarraTitulo_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnMaximizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {

        }

        private void btnRestaurar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
