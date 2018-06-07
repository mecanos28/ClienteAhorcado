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
    public partial class Marcador : Form
    {
        String marcadores;
        String[,] marcadorCompleto;


        public Marcador(String marcadores)
        {
            InitializeComponent();
            this.marcadores = marcadores;
            marcadorCompleto = new String[10,2];

            for (int i = 0; i<10 ; i++)
            {
                for (int j = 0; j<2 ; j++)
                {
                    marcadorCompleto[i, j] = "VACIO";
                }
            }

            this.setMarcador();
            this.setLabels();
        }


        private void setMarcador()
        {
            String[] puntajes = this.marcadores.Split(',');
            for(int i = 0; i<puntajes.Length ; i++)
            {
                String[] par = puntajes[i].Split(':');
                if (par.Length > 1)
                {
                    this.marcadorCompleto[i, 0] = par[0];
                    this.marcadorCompleto[i, 1] = par[1];
                }
            }
        }

        private void setLabels()
        {

            var labelarray = new Label[10,2];

            // putting labels into matrix form

            int c = 0;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    var lbl = new Label();

                    lbl.Text = this.marcadorCompleto[i,j];

                    //lbl.Top = i * 100;
                    //lbl.Left = j * 100;

                    labelarray[i, j] = lbl;
               
                    c++;
                }
            }

            // adding labels to form
            foreach (var item in labelarray)
            {
                this.layoutMarcadores.Controls.Add(item);
              
            }
        }

        private void Marcador_Load(object sender, EventArgs e)
        {
            
        }
    }
}
