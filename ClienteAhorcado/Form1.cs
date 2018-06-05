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
        ECCI_Ahorcado.ECCI_AhorcadoPortClient ahoracoService;
        int intentosRestantes;
        bool yaGano = false;
        String nombre = "";

        public Ahorcado()
        {
            InitializeComponent();
            ahoracoService = new ECCI_Ahorcado.ECCI_AhorcadoPortClient();
        }

        private void Ahorcado_Load(object sender, EventArgs e)
        {
            while (nombre == "") {
                nombre = Microsoft.VisualBasic.Interaction.InputBox("Digite su nombre", "Ahorcado", "Mi nombre", -1, -1);
            }
            nombrelabel.Text = nombre;
            ahoracoService.setNombre(this.nombre);
            palabraEscondida.Text = ahoracoService.getPalabraEscondida();
            letrasUsadas.Text = ahoracoService.getLetrasUtilizadas();
            intentosRestantes = Convert.ToInt32(ahoracoService.getIntentos()); 
            imagen.Image = Properties.Resources._0; //cambiar a 6
            imagen.Refresh();
            imagen.Visible = true;
        }

        public void actualizarJuego()
        {
            palabraEscondida.Text = ahoracoService.getPalabraEscondida();
            letrasUsadas.Text = ahoracoService.getLetrasUtilizadas();
            intentosRestantes = Convert.ToInt32(ahoracoService.getIntentos());
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
            yaGano = ahoracoService.getVictoria();
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
            ahoracoService.intentarLetra("A");
            actualizarJuego();
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            buttonB.Enabled = false;
            ahoracoService.intentarLetra("B");
            actualizarJuego();
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            buttonC.Enabled = false;
            ahoracoService.intentarLetra("C");
            actualizarJuego();
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            buttonD.Enabled = false;
            ahoracoService.intentarLetra("D");
            actualizarJuego();
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            buttonE.Enabled = false;
            ahoracoService.intentarLetra("E");
            actualizarJuego();
        }

        private void buttonF_Click(object sender, EventArgs e)
        {
            buttonF.Enabled = false;
            ahoracoService.intentarLetra("F");
            actualizarJuego();
        }

        private void buttonG_Click(object sender, EventArgs e)
        {
            buttonG.Enabled = false;
            ahoracoService.intentarLetra("G");
            actualizarJuego();
        }

        private void buttonH_Click(object sender, EventArgs e)
        {
            buttonH.Enabled = false;
            ahoracoService.intentarLetra("H");
            actualizarJuego();
        }

        private void buttonI_Click(object sender, EventArgs e)
        {
            buttonI.Enabled = false;
            ahoracoService.intentarLetra("I");
            actualizarJuego();
        }

        private void buttonJ_Click(object sender, EventArgs e)
        {
            buttonJ.Enabled = false;
            ahoracoService.intentarLetra("J");
            actualizarJuego();
        }

        private void buttonK_Click(object sender, EventArgs e)
        {
            buttonK.Enabled = false;
            ahoracoService.intentarLetra("K");
            actualizarJuego();
        }

        private void buttonL_Click(object sender, EventArgs e)
        {
            buttonL.Enabled = false;
            ahoracoService.intentarLetra("L");
            actualizarJuego();
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            buttonM.Enabled = false;
            ahoracoService.intentarLetra("M");
            actualizarJuego();
        }

        private void buttonN_Click(object sender, EventArgs e)
        {
            buttonN.Enabled = false;
            ahoracoService.intentarLetra("N");
            actualizarJuego();
        }

        private void buttonÑ_Click(object sender, EventArgs e)
        {
            buttonÑ.Enabled = false;
            ahoracoService.intentarLetra("Ñ");
            actualizarJuego();
        }

        private void buttonO_Click(object sender, EventArgs e)
        {
            buttonO.Enabled = false;
            ahoracoService.intentarLetra("O");
            actualizarJuego();
        }

        private void buttonP_Click(object sender, EventArgs e)
        {
            buttonP.Enabled = false;
            ahoracoService.intentarLetra("P");
            actualizarJuego();
        }

        private void buttonQ_Click(object sender, EventArgs e)
        {
            buttonQ.Enabled = false;
            ahoracoService.intentarLetra("Q");
            actualizarJuego();
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            buttonR.Enabled = false;
            ahoracoService.intentarLetra("R");
            actualizarJuego();
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            buttonS.Enabled = false;
            ahoracoService.intentarLetra("S");
            actualizarJuego();
        }

        private void buttonT_Click(object sender, EventArgs e)
        {
            buttonT.Enabled = false;
            ahoracoService.intentarLetra("T");
            actualizarJuego();
        }

        private void buttonU_Click(object sender, EventArgs e)
        {
            buttonU.Enabled = false;
            ahoracoService.intentarLetra("U");
            actualizarJuego();
        }

        private void buttonV_Click(object sender, EventArgs e)
        {
            buttonV.Enabled = false;
            ahoracoService.intentarLetra("V");
            actualizarJuego();
        }

        private void buttonW_Click(object sender, EventArgs e)
        {
            buttonW.Enabled = false;
            ahoracoService.intentarLetra("W");
            actualizarJuego();
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            buttonX.Enabled = false;
            ahoracoService.intentarLetra("X");
            actualizarJuego();
        }

        private void buttonY_Click(object sender, EventArgs e)
        {
            buttonY.Enabled = false;
            ahoracoService.intentarLetra("Y");
            actualizarJuego();
        }

        private void buttonZ_Click(object sender, EventArgs e)
        {
            buttonZ.Enabled = false;
            ahoracoService.intentarLetra("Z");
            actualizarJuego();
        }

       
    }
}
