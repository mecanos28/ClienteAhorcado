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
        ECCI_Ahorcado.ECCI_AhorcadoPortClient ahorcadoService;
        int intentosRestantes;
        bool yaGano = false;
        String nombre = "";

        public Ahorcado()
        {
            InitializeComponent();
            ahorcadoService = new ECCI_Ahorcado.ECCI_AhorcadoPortClient();
        }

        private void Ahorcado_Load(object sender, EventArgs e)
        {
            while (nombre == "") {
                nombre = Microsoft.VisualBasic.Interaction.InputBox("Digite su nombre", "Ahorcado", "Mi nombre", -1, -1);
            }
            nombrelabel.Text = nombre;
            ahorcadoService.setNombre(this.nombre);
            palabraEscondida.Text = ahorcadoService.getPalabraEscondida();
            letrasUsadas.Text = ahorcadoService.getLetrasUtilizadas();
            intentosRestantes = Convert.ToInt32(ahorcadoService.getIntentos()); 
            imagen.Image = Properties.Resources._6; //cambiar a 6
            imagen.Refresh();
            imagen.Visible = true;
        }

        public void actualizarJuego()
        {
            palabraEscondida.Text = ahorcadoService.getPalabraEscondida();
            letrasUsadas.Text = ahorcadoService.getLetrasUtilizadas();
            intentosRestantes = Convert.ToInt32(ahorcadoService.getIntentos());
            switch (intentosRestantes)
            {
                case 0:
                    imagen.Image = Properties.Resources._0;
                    break;
                case 1:
                    imagen.Image = Properties.Resources._1;
                    break;
                case 2:
                    imagen.Image = Properties.Resources._2;
                    break;
                case 3:
                    imagen.Image = Properties.Resources._3;
                    break;
                case 4:
                    imagen.Image = Properties.Resources._4;
                    break;
                case 5:
                    imagen.Image = Properties.Resources._5;
                    break;
                case 6:
                    imagen.Image = Properties.Resources._6;
                    break;
            }
            yaGano = ahorcadoService.getVictoria();
            if (yaGano)
            {
                gana();
            }
            if (intentosRestantes == 0 && !yaGano)
            {
                pierde();
            }
        }

        private void gana()
        {
            Form2 ganadialog = new Form2();
            ganadialog.ShowDialog(this);
        }

        private void pierde()
        {
            Form3 pierdedialog = new Form3();
            pierdedialog.ShowDialog(this);
        }


        private void buttonA_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = false;
            ahorcadoService.intentarLetra("A");
            actualizarJuego();
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            buttonB.Enabled = false;
            ahorcadoService.intentarLetra("B");
            actualizarJuego();
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            buttonC.Enabled = false;
            ahorcadoService.intentarLetra("C");
            actualizarJuego();
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            buttonD.Enabled = false;
            ahorcadoService.intentarLetra("D");
            actualizarJuego();
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            buttonE.Enabled = false;
            ahorcadoService.intentarLetra("E");
            actualizarJuego();
        }

        private void buttonF_Click(object sender, EventArgs e)
        {
            buttonF.Enabled = false;
            ahorcadoService.intentarLetra("F");
            actualizarJuego();
        }

        private void buttonG_Click(object sender, EventArgs e)
        {
            buttonG.Enabled = false;
            ahorcadoService.intentarLetra("G");
            actualizarJuego();
        }

        private void buttonH_Click(object sender, EventArgs e)
        {
            buttonH.Enabled = false;
            ahorcadoService.intentarLetra("H");
            actualizarJuego();
        }

        private void buttonI_Click(object sender, EventArgs e)
        {
            buttonI.Enabled = false;
            ahorcadoService.intentarLetra("I");
            actualizarJuego();
        }

        private void buttonJ_Click(object sender, EventArgs e)
        {
            buttonJ.Enabled = false;
            ahorcadoService.intentarLetra("J");
            actualizarJuego();
        }

        private void buttonK_Click(object sender, EventArgs e)
        {
            buttonK.Enabled = false;
            ahorcadoService.intentarLetra("K");
            actualizarJuego();
        }

        private void buttonL_Click(object sender, EventArgs e)
        {
            buttonL.Enabled = false;
            ahorcadoService.intentarLetra("L");
            actualizarJuego();
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            buttonM.Enabled = false;
            ahorcadoService.intentarLetra("M");
            actualizarJuego();
        }

        private void buttonN_Click(object sender, EventArgs e)
        {
            buttonN.Enabled = false;
            ahorcadoService.intentarLetra("N");
            actualizarJuego();
        }

        private void buttonÑ_Click(object sender, EventArgs e)
        {
            buttonÑ.Enabled = false;
            ahorcadoService.intentarLetra("Ñ");
            actualizarJuego();
        }

        private void buttonO_Click(object sender, EventArgs e)
        {
            buttonO.Enabled = false;
            ahorcadoService.intentarLetra("O");
            actualizarJuego();
        }

        private void buttonP_Click(object sender, EventArgs e)
        {
            buttonP.Enabled = false;
            ahorcadoService.intentarLetra("P");
            actualizarJuego();
        }

        private void buttonQ_Click(object sender, EventArgs e)
        {
            buttonQ.Enabled = false;
            ahorcadoService.intentarLetra("Q");
            actualizarJuego();
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            buttonR.Enabled = false;
            ahorcadoService.intentarLetra("R");
            actualizarJuego();
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            buttonS.Enabled = false;
            ahorcadoService.intentarLetra("S");
            actualizarJuego();
        }

        private void buttonT_Click(object sender, EventArgs e)
        {
            buttonT.Enabled = false;
            ahorcadoService.intentarLetra("T");
            actualizarJuego();
        }

        private void buttonU_Click(object sender, EventArgs e)
        {
            buttonU.Enabled = false;
            ahorcadoService.intentarLetra("U");
            actualizarJuego();
        }

        private void buttonV_Click(object sender, EventArgs e)
        {
            buttonV.Enabled = false;
            ahorcadoService.intentarLetra("V");
            actualizarJuego();
        }

        private void buttonW_Click(object sender, EventArgs e)
        {
            buttonW.Enabled = false;
            ahorcadoService.intentarLetra("W");
            actualizarJuego();
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            buttonX.Enabled = false;
            ahorcadoService.intentarLetra("X");
            actualizarJuego();
        }

        private void buttonY_Click(object sender, EventArgs e)
        {
            buttonY.Enabled = false;
            ahorcadoService.intentarLetra("Y");
            actualizarJuego();
        }

        private void buttonZ_Click(object sender, EventArgs e)
        {
            buttonZ.Enabled = false;
            ahorcadoService.intentarLetra("Z");
            actualizarJuego();
        }

        private void mejoresPuntuaciones_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Marcador marcadorF = new Marcador(this.ahorcadoService.getMarcadores());
            marcadorF.ShowDialog(this);
        }
    }
}
