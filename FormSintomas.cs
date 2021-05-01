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
    public partial class FormSintomas : Form
    {
        DatosPersonales myPaciente = new DatosPersonales();
        public FormSintomas()
        {
            InitializeComponent();
            
        }

        private void FormSintomas_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rbTos_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbDolorCorporal_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void cbFiebre_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //cerrar aplicación
            Application.Exit();
        }

        public void btnConsultar_Click(object sender, EventArgs e)
        {

            // Declaro variables
            // Double Bronquitis_Aguda = 0;
            // Double Resfriado_Comun = 0;
            // Double Infeccion_Oido = 0;
            //Double Influenza = 0;
            //Double Sinusitis = 0;
            // Double Infecciones_Piel = 0;
            // Double Dolor_Garganta = 0;
            // Double Infeccion_Urinaria = 0;

            //BRONQUITIS
            if (cbTos.Checked == true && cbMucosidadCongestion.Checked == true && cbFiebre.Checked == false && cbEstornudos.Checked == false
                && cbDolorGarganta.Checked == false && cbDolorOido.Checked == false && cbDolorCorporal.Checked == false && cbDolorCabeza.Checked == false
                && cbDolorCara.Checked == false && cbDoloroArdorOrinar.Checked == false && cbPiquiñaPiel.Checked == false && cbEnrojecimientoPiel.Checked == false
                && cbRonquera.Checked == false && cbNecesidadOrinarFrecuencia.Checked == false)
            {
                MessageBox.Show("Dados los síntomas se puede dar un diagnostico preliminar de que tienes *BRONQUITIS AGUDA*", "BRONQUITIS AGUDA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form FormBronquitis = new FormBronquitis_Aguda();
                FormBronquitis.Show();
            }
            else
            //RESFRIADO COMÚN

            if (cbEstornudos.Checked == true && cbMucosidadCongestion.Checked == true && cbDolorGarganta.Checked == true 
                && cbTos.Checked == true && cbDolorCabeza.Checked == false && cbDolorCara.Checked == false && cbFiebre.Checked == false
                && cbDolorCorporal.Checked ==false &&cbDolorOido.Checked == false && cbDoloroArdorOrinar.Checked == false && cbPiquiñaPiel.Checked == false
                && cbEnrojecimientoPiel.Checked == false && cbRonquera.Checked == false && cbNecesidadOrinarFrecuencia.Checked == false|| cbEstornudos.Checked == true 
                && cbMucosidadCongestion.Checked == true && cbDolorGarganta.Checked == true && cbDolorCabeza.Checked == false && cbDolorCara.Checked == false && cbFiebre.Checked == false
                && cbDolorCorporal.Checked == false && cbDolorOido.Checked == false && cbDoloroArdorOrinar.Checked == false && cbPiquiñaPiel.Checked == false
                && cbEnrojecimientoPiel.Checked == false && cbRonquera.Checked == false && cbNecesidadOrinarFrecuencia.Checked == false || cbEstornudos.Checked == true && cbMucosidadCongestion.Checked == true && cbDolorGarganta.Checked == false
                && cbTos.Checked == true && cbDolorCabeza.Checked == false && cbDolorCara.Checked == false && cbFiebre.Checked == false
                && cbDolorCorporal.Checked == false && cbDolorOido.Checked == false && cbDoloroArdorOrinar.Checked == false && cbPiquiñaPiel.Checked == false
                && cbEnrojecimientoPiel.Checked == false && cbRonquera.Checked == false && cbNecesidadOrinarFrecuencia.Checked == false || cbEstornudos.Checked == true && cbMucosidadCongestion.Checked == true && cbDolorGarganta.Checked == false
                && cbTos.Checked == true && cbDolorCabeza.Checked == false && cbDolorCara.Checked == false && cbFiebre.Checked == true
                && cbDolorCorporal.Checked == false && cbDolorOido.Checked == false && cbDoloroArdorOrinar.Checked == false && cbPiquiñaPiel.Checked == false
                && cbEnrojecimientoPiel.Checked == false && cbRonquera.Checked == false && cbNecesidadOrinarFrecuencia.Checked == false)
            {
                
                MessageBox.Show("Dados los síntomas se puede dar un diagnostico preliminar de que tienes *Resfriado común*", "RESFRIADO COMÚN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form FormResfriado = new FormResfriado_Comun();
                FormResfriado.Show();
            }
            else
            //INFECCION DE OIDO

             if (cbTos.Checked == false && cbMucosidadCongestion.Checked == false && cbFiebre.Checked == true && cbEstornudos.Checked == false
               && cbDolorGarganta.Checked == false && cbDolorOido.Checked == true && cbDolorCorporal.Checked == false && cbDolorCabeza.Checked == false
               && cbDolorCara.Checked == false && cbDoloroArdorOrinar.Checked == false && cbPiquiñaPiel.Checked == false && cbEnrojecimientoPiel.Checked == false
               && cbRonquera.Checked == false && cbNecesidadOrinarFrecuencia.Checked == false || cbTos.Checked == false && cbMucosidadCongestion.Checked == false && cbFiebre.Checked == false && cbEstornudos.Checked == false
               && cbDolorGarganta.Checked == false && cbDolorOido.Checked == true && cbDolorCorporal.Checked == false && cbDolorCabeza.Checked == false
               && cbDolorCara.Checked == false && cbDoloroArdorOrinar.Checked == false && cbPiquiñaPiel.Checked == false && cbEnrojecimientoPiel.Checked == false
               && cbRonquera.Checked == false && cbNecesidadOrinarFrecuencia.Checked == false)
            {

                MessageBox.Show("Dados los síntomas se puede dar un diagnostico preliminar de que tienes *INFECCIÓN DE OIDO *", "INFECCIÓN DE OIDO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form FormInfeccionOido = new FormInfecc_Oido();
                FormInfeccionOido.Show();
            }
           else
           //INFLUENZA
            if (cbTos.Checked == true && cbMucosidadCongestion.Checked == true && cbFiebre.Checked == true && cbEstornudos.Checked == false
               && cbDolorGarganta.Checked == true && cbDolorOido.Checked == false && cbDolorCorporal.Checked == true && cbDolorCabeza.Checked == false
               && cbDolorCara.Checked == false && cbDoloroArdorOrinar.Checked == false && cbPiquiñaPiel.Checked == false && cbEnrojecimientoPiel.Checked == false
               && cbRonquera.Checked == false && cbNecesidadOrinarFrecuencia.Checked == false || cbTos.Checked == true && cbMucosidadCongestion.Checked == true && cbFiebre.Checked == true && cbEstornudos.Checked == true
               && cbDolorGarganta.Checked == true && cbDolorOido.Checked == false && cbDolorCorporal.Checked == true && cbDolorCabeza.Checked == false
               && cbDolorCara.Checked == false && cbDoloroArdorOrinar.Checked == false && cbPiquiñaPiel.Checked == false && cbEnrojecimientoPiel.Checked == false
               && cbRonquera.Checked == false && cbNecesidadOrinarFrecuencia.Checked == false || cbTos.Checked == true && cbMucosidadCongestion.Checked == true && cbFiebre.Checked == false && cbEstornudos.Checked == true
               && cbDolorGarganta.Checked == true && cbDolorOido.Checked == false && cbDolorCorporal.Checked == true && cbDolorCabeza.Checked == false
               && cbDolorCara.Checked == false && cbDoloroArdorOrinar.Checked == false && cbPiquiñaPiel.Checked == false && cbEnrojecimientoPiel.Checked == false
               && cbRonquera.Checked == false && cbNecesidadOrinarFrecuencia.Checked == false || cbTos.Checked == true && cbMucosidadCongestion.Checked == true && cbFiebre.Checked == true && cbEstornudos.Checked == true
               && cbDolorGarganta.Checked == true && cbDolorOido.Checked == false && cbDolorCorporal.Checked == false && cbDolorCabeza.Checked == false
               && cbDolorCara.Checked == false && cbDoloroArdorOrinar.Checked == false && cbPiquiñaPiel.Checked == false && cbEnrojecimientoPiel.Checked == false
               && cbRonquera.Checked == false && cbNecesidadOrinarFrecuencia.Checked == false)
            {
                
                

                MessageBox.Show("Dados los síntomas se puede dar un diagnostico preliminar de que tienes *INFLUENZA *", "INFLUENZA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form FormInfluenza = new FormInfluenza();
                FormInfluenza.Show();
            }
        

           else
            //SINUSITIS
            if (cbTos.Checked == false && cbMucosidadCongestion.Checked == true && cbFiebre.Checked == false && cbEstornudos.Checked == false
               && cbDolorGarganta.Checked == false && cbDolorOido.Checked == false && cbDolorCorporal.Checked == false && cbDolorCabeza.Checked == true
               && cbDolorCara.Checked == true && cbDoloroArdorOrinar.Checked == false && cbPiquiñaPiel.Checked == false && cbEnrojecimientoPiel.Checked == false
               && cbRonquera.Checked == false && cbNecesidadOrinarFrecuencia.Checked == false || cbTos.Checked == false && cbMucosidadCongestion.Checked == true
               && cbFiebre.Checked == false && cbEstornudos.Checked == false
               && cbDolorGarganta.Checked == false && cbDolorOido.Checked == false && cbDolorCorporal.Checked == false && cbDolorCabeza.Checked == true
               && cbDolorCara.Checked == false && cbDoloroArdorOrinar.Checked == false && cbPiquiñaPiel.Checked == false && cbEnrojecimientoPiel.Checked == false
               && cbRonquera.Checked == false && cbNecesidadOrinarFrecuencia.Checked == false || cbTos.Checked == false && cbMucosidadCongestion.Checked == true 
               && cbFiebre.Checked == false && cbEstornudos.Checked == false
               && cbDolorGarganta.Checked == true && cbDolorOido.Checked == false && cbDolorCorporal.Checked == false && cbDolorCabeza.Checked == false
               && cbDolorCara.Checked == false && cbDoloroArdorOrinar.Checked == false && cbPiquiñaPiel.Checked == false && cbEnrojecimientoPiel.Checked == false
               && cbRonquera.Checked == false && cbNecesidadOrinarFrecuencia.Checked == false || cbTos.Checked == false && cbMucosidadCongestion.Checked == true 
               && cbFiebre.Checked == false && cbEstornudos.Checked == false
               && cbDolorGarganta.Checked == false && cbDolorOido.Checked == false && cbDolorCorporal.Checked == false && cbDolorCabeza.Checked == false
               && cbDolorCara.Checked == true && cbDoloroArdorOrinar.Checked == false && cbPiquiñaPiel.Checked == false && cbEnrojecimientoPiel.Checked == false
               && cbRonquera.Checked == false && cbNecesidadOrinarFrecuencia.Checked == false
               || cbTos.Checked == false && cbMucosidadCongestion.Checked == true && cbFiebre.Checked == false && cbEstornudos.Checked == false
               && cbDolorGarganta.Checked == true && cbDolorOido.Checked == false && cbDolorCorporal.Checked == false && cbDolorCabeza.Checked == false
               && cbDolorCara.Checked == true && cbDoloroArdorOrinar.Checked == false && cbPiquiñaPiel.Checked == false && cbEnrojecimientoPiel.Checked == false
               && cbRonquera.Checked == false && cbNecesidadOrinarFrecuencia.Checked == false || cbTos.Checked == false && cbMucosidadCongestion.Checked == true
               && cbFiebre.Checked == false && cbEstornudos.Checked == false
               && cbDolorGarganta.Checked == true && cbDolorOido.Checked == false && cbDolorCorporal.Checked == false && cbDolorCabeza.Checked == true
               && cbDolorCara.Checked == false && cbDoloroArdorOrinar.Checked == false && cbPiquiñaPiel.Checked == false && cbEnrojecimientoPiel.Checked == false
               && cbRonquera.Checked == false && cbNecesidadOrinarFrecuencia.Checked == false || cbTos.Checked == false && cbMucosidadCongestion.Checked == true 
               && cbFiebre.Checked == false && cbEstornudos.Checked == false
               && cbDolorGarganta.Checked == true && cbDolorOido.Checked == false && cbDolorCorporal.Checked == false && cbDolorCabeza.Checked == true
               && cbDolorCara.Checked == true && cbDoloroArdorOrinar.Checked == false && cbPiquiñaPiel.Checked == false && cbEnrojecimientoPiel.Checked == false
               && cbRonquera.Checked == false && cbNecesidadOrinarFrecuencia.Checked == false)
            {

                MessageBox.Show("Dados los síntomas se puede dar un diagnostico preliminar de que tienes *SINUSITIS *", "SINUSITIS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form FormSinusitis = new FormSinusitis();
                FormSinusitis.Show();
            }
        
            else
            //INFECCIONES DE LA PIEL
            if (cbTos.Checked == false && cbMucosidadCongestion.Checked == false && cbFiebre.Checked == false && cbEstornudos.Checked == false
               && cbDolorGarganta.Checked == false && cbDolorOido.Checked == false && cbDolorCorporal.Checked == false && cbDolorCabeza.Checked == false
               && cbDolorCara.Checked == false && cbDoloroArdorOrinar.Checked == false && cbPiquiñaPiel.Checked == true && cbEnrojecimientoPiel.Checked == true
               && cbRonquera.Checked == false && cbNecesidadOrinarFrecuencia.Checked == false || cbTos.Checked == false && cbMucosidadCongestion.Checked == false && cbFiebre.Checked == false && cbEstornudos.Checked == false
               && cbDolorGarganta.Checked == false && cbDolorOido.Checked == false && cbDolorCorporal.Checked == false && cbDolorCabeza.Checked == false
               && cbDolorCara.Checked == false && cbDoloroArdorOrinar.Checked == false && cbPiquiñaPiel.Checked == false && cbEnrojecimientoPiel.Checked == true
               && cbRonquera.Checked == false && cbNecesidadOrinarFrecuencia.Checked == false || cbTos.Checked == false && cbMucosidadCongestion.Checked == false && cbFiebre.Checked == false && cbEstornudos.Checked == false
               && cbDolorGarganta.Checked == false && cbDolorOido.Checked == false && cbDolorCorporal.Checked == false && cbDolorCabeza.Checked == false
               && cbDolorCara.Checked == false && cbDoloroArdorOrinar.Checked == false && cbPiquiñaPiel.Checked == true && cbEnrojecimientoPiel.Checked == false
               && cbRonquera.Checked == false && cbNecesidadOrinarFrecuencia.Checked == false)

            {

                MessageBox.Show("Dados los síntomas se puede dar un diagnostico preliminar de que tienes alguna *INFECCIÓN EN LA PIEL*", "INFECCIÓN EN LA PIEL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form FormInfeccionPiel = new FormInfecciones_Piel();
                FormInfeccionPiel.Show();
            }
        
            else
            //INFECCIÓN DE GARGANTA
            if (cbTos.Checked == false && cbMucosidadCongestion.Checked == false && cbFiebre.Checked == false && cbEstornudos.Checked == false
               && cbDolorGarganta.Checked == true && cbDolorOido.Checked == false && cbDolorCorporal.Checked == false && cbDolorCabeza.Checked == false
               && cbDolorCara.Checked == false && cbDoloroArdorOrinar.Checked == false && cbPiquiñaPiel.Checked == false && cbEnrojecimientoPiel.Checked == false
               && cbRonquera.Checked == true && cbNecesidadOrinarFrecuencia.Checked == false || cbTos.Checked == false && cbMucosidadCongestion.Checked == false && cbFiebre.Checked == false && cbEstornudos.Checked == false
               && cbDolorGarganta.Checked == true && cbDolorOido.Checked == false && cbDolorCorporal.Checked == false && cbDolorCabeza.Checked == false
               && cbDolorCara.Checked == false && cbDoloroArdorOrinar.Checked == false && cbPiquiñaPiel.Checked == false && cbEnrojecimientoPiel.Checked == false
               && cbRonquera.Checked == false && cbNecesidadOrinarFrecuencia.Checked == false)
            {

                MessageBox.Show("Dados los síntomas se puede dar un diagnostico preliminar de que tienes alguna *INFECCIÓN DE GARGANTA*", "INFECCIÓN DE GARGANTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form FormInfeccionGarganta = new FormInfecc_Garganta();
                FormInfeccionGarganta.Show();
            }
            else
            //INFECCIÓN URINARIA
            if (cbTos.Checked == false && cbMucosidadCongestion.Checked == false && cbFiebre.Checked == false && cbEstornudos.Checked == false
               && cbDolorGarganta.Checked == false && cbDolorOido.Checked == false && cbDolorCorporal.Checked == false && cbDolorCabeza.Checked == false
               && cbDolorCara.Checked == false && cbDoloroArdorOrinar.Checked == true && cbPiquiñaPiel.Checked == false && cbEnrojecimientoPiel.Checked == false
               && cbRonquera.Checked == false && cbNecesidadOrinarFrecuencia.Checked == true || cbTos.Checked == false && cbMucosidadCongestion.Checked == false && cbFiebre.Checked == false && cbEstornudos.Checked == false
               && cbDolorGarganta.Checked == false && cbDolorOido.Checked == false && cbDolorCorporal.Checked == false && cbDolorCabeza.Checked == false
               && cbDolorCara.Checked == false && cbDoloroArdorOrinar.Checked == true && cbPiquiñaPiel.Checked == false && cbEnrojecimientoPiel.Checked == false
               && cbRonquera.Checked == false && cbNecesidadOrinarFrecuencia.Checked == false || cbTos.Checked == false && cbMucosidadCongestion.Checked == false && cbFiebre.Checked == false && cbEstornudos.Checked == false
               && cbDolorGarganta.Checked == false && cbDolorOido.Checked == false && cbDolorCorporal.Checked == false && cbDolorCabeza.Checked == false
               && cbDolorCara.Checked == false && cbDoloroArdorOrinar.Checked == false && cbPiquiñaPiel.Checked == false && cbEnrojecimientoPiel.Checked == false
               && cbRonquera.Checked == false && cbNecesidadOrinarFrecuencia.Checked == true)
            {
                MessageBox.Show("Dados los síntomas se puede dar un diagnostico preliminar de que tienes alguna *INFECCIÓN URINARIA*", "INFECCIÓN URINARIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form FormInfeccionUrinaria = new FormInfecc_Urinaria();
                FormInfeccionUrinaria.Show();

            }
            else
            {
                //RESPUESTA A CONSULTA
                MessageBox.Show("Dados los síntomas no puede dar un diagnostico preliminar ");
            }
                


            

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
           
        }

        private void txtNombreFormIngreso_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiarCasillas_Click(object sender, EventArgs e)
        {
            
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
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
    }
    
}
