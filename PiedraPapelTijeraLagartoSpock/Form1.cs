using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace PiedraPapelTijeraLagartoSpock
{
    public partial class Form1 : Form
    {
        int jugadaBot;
        int auxiliarResultado;
        int contadorHumano = 0;
        int contadorBot = 0;

        private void ActualizarContadores(int resultado)
        {
            switch (resultado)
            {
                case 0:
                    break;
                case 1:
                    contadorBot++;
                    break;
                case 2:
                    contadorHumano++;
                    break;
            }
        }
        public enum LasOpciones
        {
            Piedra = 0, 
            Papel = 1,
            Tijera = 2,
            Lagarto = 3,
            Spock = 4
        }
                
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btn_piedra_Click(object sender, EventArgs e)
        {
           jugadaBot = Juego.CalcularRandom();
           auxiliarResultado =  Juego.Jugar(0, jugadaBot);
            this.lbl_vos_elegiste.Text = LasOpciones.Piedra.ToString();
           this.lbl_yo_elegi.Text = Juego.DevolverNombre(jugadaBot);
           this.lbl_resultado.Text = Juego.DevolverResultado(auxiliarResultado);
            this.lbl_leyenda.Text = Juego.DevolverLeyenda(0, jugadaBot);
            this.ActualizarContadores(auxiliarResultado);
            this.lbl_score_vos.Text = contadorHumano.ToString();
            this.lbl_score_yo.Text = contadorBot.ToString();
        }

        private void btn_papel_Click(object sender, EventArgs e)
        {
            jugadaBot = Juego.CalcularRandom();
            auxiliarResultado = Juego.Jugar(1, jugadaBot);
            this.lbl_vos_elegiste.Text = LasOpciones.Papel.ToString();
            this.lbl_yo_elegi.Text = Juego.DevolverNombre(jugadaBot);
            this.lbl_resultado.Text = Juego.DevolverResultado(auxiliarResultado);
            this.lbl_leyenda.Text = Juego.DevolverLeyenda(1, jugadaBot);
            this.ActualizarContadores(auxiliarResultado);
            this.lbl_score_vos.Text = contadorHumano.ToString();
            this.lbl_score_yo.Text = contadorBot.ToString();
        }

        private void btn_tijera_Click(object sender, EventArgs e)
        {
            jugadaBot = Juego.CalcularRandom();
            auxiliarResultado = Juego.Jugar((int)LasOpciones.Tijera, jugadaBot);
            this.lbl_vos_elegiste.Text = LasOpciones.Tijera.ToString();
            this.lbl_yo_elegi.Text = Juego.DevolverNombre(jugadaBot);
            this.lbl_resultado.Text = Juego.DevolverResultado(auxiliarResultado);
            this.lbl_leyenda.Text = Juego.DevolverLeyenda(2, jugadaBot);
            this.ActualizarContadores(auxiliarResultado);
            this.lbl_score_vos.Text = contadorHumano.ToString();
            this.lbl_score_yo.Text = contadorBot.ToString();
        }

        private void btn_lagarto_Click(object sender, EventArgs e)
        {
            jugadaBot = Juego.CalcularRandom();
            auxiliarResultado = Juego.Jugar((int)LasOpciones.Lagarto, jugadaBot);
            this.lbl_vos_elegiste.Text = LasOpciones.Lagarto.ToString();
            this.lbl_yo_elegi.Text = Juego.DevolverNombre(jugadaBot);
            this.lbl_resultado.Text = Juego.DevolverResultado(auxiliarResultado);
            this.lbl_leyenda.Text = Juego.DevolverLeyenda(3, jugadaBot);
            this.ActualizarContadores(auxiliarResultado);
            this.lbl_score_vos.Text = contadorHumano.ToString();
            this.lbl_score_yo.Text = contadorBot.ToString();
        }

        private void btn_spock_Click(object sender, EventArgs e)
        {
            jugadaBot = Juego.CalcularRandom();
            auxiliarResultado = Juego.Jugar((int)LasOpciones.Spock, jugadaBot);
            this.lbl_vos_elegiste.Text = LasOpciones.Spock.ToString();
            this.lbl_yo_elegi.Text = Juego.DevolverNombre(jugadaBot);
            this.lbl_resultado.Text = Juego.DevolverResultado(auxiliarResultado);
            this.lbl_leyenda.Text = Juego.DevolverLeyenda(4, jugadaBot);
            this.ActualizarContadores(auxiliarResultado);
            this.lbl_score_vos.Text = contadorHumano.ToString();
            this.lbl_score_yo.Text = contadorBot.ToString();
        }

        private void btn_reset_score_Click(object sender, EventArgs e)
        {
            this.contadorBot = 0;
            this.contadorHumano = 0;
            this.lbl_score_vos.Text = contadorHumano.ToString();
            this.lbl_score_yo.Text = contadorBot.ToString();
        }
    }
}
