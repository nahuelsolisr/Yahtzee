using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Generala
{
    public partial class Jugadores : Form
    {

        public bool unJ = false, dosJ = false;
        
        public Jugadores()
        {
            InitializeComponent();
        }

        private void Jugadores_Load(object sender, EventArgs e)
        {
            cmb_select_players.SelectedItem = "1 Jugador";

        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            Juego FormularioJuego = new Juego();

            switch (cmb_select_players.Text)
            {
                case "1 Jugador":
                    {
                        unJ = true;
                        dosJ = false;
                        FormularioJuego.dosJ = dosJ;
                        FormularioJuego.unJ = unJ;
                        if (txt_nombre1.Text.Trim() == "")
                            txt_nombre1.Text = "Jugador 1";
                        FormularioJuego.lbl_jugador1.Text = txt_nombre1.Text;
                        break;
                    }
                case "2 Jugadores":
                    {
                        unJ = false;
                        dosJ = true;
                        FormularioJuego.dosJ = dosJ;
                        FormularioJuego.unJ = unJ;
                        if (txt_nombre1.Text.Trim() == "")
                            txt_nombre1.Text = "Jugador 1";
                        if (txt_nombre2.Text.Trim() == "")
                            txt_nombre2.Text = "Jugador 2";
                        FormularioJuego.lbl_jugador1.Text = txt_nombre1.Text;
                        FormularioJuego.lbl_jugador2.Text = txt_nombre2.Text;
                        break;
                    }
            }

            FormularioJuego.ShowDialog();
            this.Close();
          
        }

        private void cmb_select_players_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_select_players.SelectedItem == "2 Jugadores")
            {
                txt_nombre2.Visible = true;
              
            }
            if (cmb_select_players.SelectedItem == "1 Jugador")
            {
                txt_nombre2.Visible = false;

            }
        }


    }
}
