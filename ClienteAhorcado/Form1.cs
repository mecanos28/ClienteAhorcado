using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteAhorcado
{
    public partial class Ahorcado : Form
    {
        public Ahorcado()
        {
            InitializeComponent();
        }

        private void Ahorcado_Load(object sender, EventArgs e)
        {
            imagen.Image = Properties.Resources._0; //cambiar a 6
            imagen.Refresh();
            imagen.Visible = true;
        }

        public void actualizarJuego()
        {
            //actualizar palabra
            //actualizar actualizar letras usadas
            //actualizar imagen
            //verificar gane con servicios, llamar a popup si perdió o ganó
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = false;
            //llamar a servicio con 'A'
            actualizarJuego();
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            buttonB.Enabled = false;
            //llamar a servicio con 'B'
            actualizarJuego();
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            buttonC.Enabled = false;
            //llamar a servicio con letra
            actualizarJuego();
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            buttonD.Enabled = false;
            //llamar a servicio con letra
            actualizarJuego();
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            buttonE.Enabled = false;
            //llamar a servicio con letra
            actualizarJuego();
        }

        private void buttonF_Click(object sender, EventArgs e)
        {
            buttonF.Enabled = false;
            //llamar a servicio con letra
            actualizarJuego();
        }

        private void buttonG_Click(object sender, EventArgs e)
        {
            buttonG.Enabled = false;
            //llamar a servicio con letra
            actualizarJuego();
        }

        private void buttonH_Click(object sender, EventArgs e)
        {
            buttonH.Enabled = false;
            //llamar a servicio con letra
            actualizarJuego();
        }

        private void buttonI_Click(object sender, EventArgs e)
        {
            buttonI.Enabled = false;
            //llamar a servicio con letra
            actualizarJuego();
        }

        private void buttonJ_Click(object sender, EventArgs e)
        {
            buttonJ.Enabled = false;
            //llamar a servicio con letra
            actualizarJuego();
        }

        private void buttonK_Click(object sender, EventArgs e)
        {
            buttonK.Enabled = false;
            //llamar a servicio con letra
            actualizarJuego();
        }

        private void buttonL_Click(object sender, EventArgs e)
        {
            buttonL.Enabled = false;
            //llamar a servicio con letra
            actualizarJuego();
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            buttonM.Enabled = false;
            //llamar a servicio con letra
            actualizarJuego();
        }

        private void buttonN_Click(object sender, EventArgs e)
        {
            buttonN.Enabled = false;
            //llamar a servicio con letra
            actualizarJuego();
        }

        private void buttonÑ_Click(object sender, EventArgs e)
        {
            buttonÑ.Enabled = false;
            //llamar a servicio con letra
            actualizarJuego();
        }

        private void buttonO_Click(object sender, EventArgs e)
        {
            buttonO.Enabled = false;
            //llamar a servicio con letra
            actualizarJuego();
        }

        private void buttonP_Click(object sender, EventArgs e)
        {
            buttonP.Enabled = false;
            //llamar a servicio con letra
            actualizarJuego();
        }

        private void buttonQ_Click(object sender, EventArgs e)
        {
            buttonQ.Enabled = false;
            //llamar a servicio con letra
            actualizarJuego();
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            buttonR.Enabled = false;
            //llamar a servicio con letra
            actualizarJuego();
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            buttonS.Enabled = false;
            //llamar a servicio con letra
            actualizarJuego();
        }

        private void buttonT_Click(object sender, EventArgs e)
        {
            buttonT.Enabled = false;
            //llamar a servicio con letra
            actualizarJuego();
        }

        private void buttonU_Click(object sender, EventArgs e)
        {
            buttonU.Enabled = false;
            //llamar a servicio con letra
            actualizarJuego();
        }

        private void buttonV_Click(object sender, EventArgs e)
        {
            buttonV.Enabled = false;
            //llamar a servicio con letra
            actualizarJuego();
        }

        private void buttonW_Click(object sender, EventArgs e)
        {
            buttonW.Enabled = false;
            //llamar a servicio con letra
            actualizarJuego();
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            buttonX.Enabled = false;
            //llamar a servicio con letra
            actualizarJuego();
        }

        private void buttonY_Click(object sender, EventArgs e)
        {
            buttonY.Enabled = false;
            //llamar a servicio con letra
            actualizarJuego();
        }

        private void buttonZ_Click(object sender, EventArgs e)
        {
            buttonZ.Enabled = false;
            //llamar a servicio con letra
            actualizarJuego();
        }
    }
}
