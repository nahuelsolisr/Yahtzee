using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
namespace Proyecto_Generala
{
    public partial class Juego : Form
    {



        Random aleatorio = new Random();
        int vuelta = 0;
        bool mezclando = false;
        bool[] vaso = new bool[5];
        int[] dados = new int[5];
        Random random = new Random();
        int dado1 = 0, dado2 = 0, dado3 = 0, dado4 = 0, dado5 = 0, dado6 = 0, esc = 0, full = 0, poker = 0, gen = 0, gen2 = 0;
        int dado2_1 = 0, dado2_2 = 0, dado2_3 = 0, dado2_4 = 0, dado2_5 = 0, dado2_6 = 0, esc_2 = 0, full_2 = 0, poker_2 = 0, gen_2 = 0, gen2_2 = 0;
        int[] JUGADAS = new int[11];
        int[] JUGADAS2 = new int [11];
        public bool unJ, dosJ;
        bool[] guardar = new bool[11];
        bool[] guardar2 = new bool[11];
        bool jugador;
        int contador = 0, ronda = 1;
        int turno = 1;
        int lblturno = 3;
        string jugador1="", jugador2="";

        public Juego()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Jugadores players = new Jugadores();
            jugador1= lbl_jugador1.Text;
            jugador2 = lbl_jugador2.Text;

            if (unJ)
            {
                Size = new Size(680, 534);
            }
            else
            {
                Size = new Size(906, 534);
            }
    
            vaso[0] = true; guardar[0] = true; guardar[6] = true;
            vaso[1] = true; guardar[1] = true; guardar[7] = true;
            vaso[2] = true; guardar[2] = true; guardar[8] = true;
            vaso[3] = true; guardar[3] = true; guardar[9] = true;
            vaso[4] = true; guardar[4] = true; guardar[10] = true;
            jugador = true; guardar[5] = true;
            guardar2[0] = true; guardar2[6] = true;
            guardar2[1] = true; guardar2[7] = true;
            guardar2[2] = true; guardar2[8] = true;
            guardar2[3] = true; guardar2[9] = true;
            guardar2[4] = true; guardar2[10] = true;
            guardar2[5] = true;
            grup_jugador2.Enabled = false;
            lbl_lanza.Text = lbl_jugador1.Text;
        }

        //TIRA LOS DADOS
         
        private void Tirar_Click(object sender, EventArgs e)
        {
                picture_d1.Enabled = true;
                picture_d2.Enabled = true;
                picture_d3.Enabled = true;
                picture_d4.Enabled = true;
                picture_d5.Enabled = true;
            
           
            //DOS JUGADORES 
            if(dosJ)
            {
               

                if (turno == 2 || turno == 4 || turno == 6 || turno == 8 || turno == 10 || turno == 12 || turno == 14 || turno == 16 || turno == 18 || turno == 20 || turno == 22)
                {
                    lbl_lanza.Text = lbl_jugador2.Text;
                    grup_jugador1.Enabled = false;
                    grup_jugador2.Enabled = true;
                    jugador = false;
                }
                else
                {
                    grup_jugador1.Enabled = true;
                    grup_jugador2.Enabled = false;
                    jugador = true;
                }
            }

           

            if (unJ)
            {
               

                grup_jugador1.Enabled = true;
                lbl_lanza.Text = lbl_jugador1.Text;
            }

            if (contador == 2)
            {      
               Tirar.Visible = false;
               if (contador == 3)
               {
                  ronda++;
                  contador = 0;
                  turno++;       
               }
            }

           
            contador++;
           
            picture_d1.Visible = true;
            picture_d2.Visible = true;
            picture_d3.Visible = true;
            picture_d4.Visible = true;
            picture_d5.Visible = true;
            Thread.Sleep(350);
            timer1.Start();
       
            lbl_restantes.Text = Convert.ToString(lblturno - contador);
            lbl_turno.Text = Convert.ToString(ronda);
        }

        //JUGADAS POSIBLES 

        public void Numeros(int[] dados)
        {
            
           dado1 = 0;dado2 = 0; dado3 = 0; dado4 = 0; dado5 = 0; dado6 = 0;
           
            for (int i = 0; i < dados.Length; i++)
            {
                if (guardar[0] == true)
                {
                    if (dados[i] == 1)
                    {
                        dado1++;
                       
                    }
                        lbl_cara1.Visible = true;
                        lbl_cara1.Text = Convert.ToString(dado1);

                }
                
                
                if (guardar[1] == true)
                {
                    if (dados[i] == 2)
                    {
                        dado2 = dado2 + 2;
                    }                   
                        lbl_cara2.Visible = true;
                        lbl_cara2.Text = Convert.ToString(dado2);                    
                    
                }
                
                if (guardar[2] == true)
                {
                    if (dados[i] == 3)
                    {
                        dado3 = dado3 + 3;
                    }
                        lbl_cara3.Visible = true;
                        lbl_cara3.Text = Convert.ToString(dado3);
                    

                }
               
                if (guardar[3] == true)
                {
                    if (dados[i] == 4)
                    {
                        dado4 = dado4 + 4;
                    }
                    
                        lbl_cara4.Visible = true;
                        lbl_cara4.Text = Convert.ToString(dado4);
        
                }
                if (guardar[4] == true)
                {
                    if (dados[i] == 5)
                    {
                        dado5 = dado5 + 5;
                    }
                    
                        lbl_cara5.Visible = true;
                        lbl_cara5.Text = Convert.ToString(dado5);
                    
                }
                if (guardar[5] == true)
                {
                    if (dados[i] == 6)
                    {
                        dado6 = dado6 + 6;
                    }
                  
                    
                        lbl_cara6.Visible = true;
                        lbl_cara6.Text = Convert.ToString(dado6);
                   
                }
            }

           
        }
        public void Numeros2(int[] dados)
        {

            dado2_1 = 0; dado2_2 = 0; dado2_3 = 0; dado2_4 = 0; dado2_5 = 0; dado2_6 = 0;

            for (int i = 0; i < dados.Length; i++)
            {
                if (guardar2[0] == true)
                {
                    if (dados[i] == 1)
                    {
                        dado2_1++;

                    }
                    lbl2_cara1.Visible = true;
                    lbl2_cara1.Text = Convert.ToString(dado2_1);

                }


                if (guardar2[1] == true)
                {
                    if (dados[i] == 2)
                    {
                        dado2_2 = dado2_2 + 2;
                    }
                    lbl2_cara2.Visible = true;
                    lbl2_cara2.Text = Convert.ToString(dado2_2);

                }

                if (guardar2[2] == true)
                {
                    if (dados[i] == 3)
                    {
                        dado2_3 = dado2_3 + 3;
                    }
                    lbl2_cara3.Visible = true;
                    lbl2_cara3.Text = Convert.ToString(dado2_3);


                }

                if (guardar2[3] == true)
                {
                    if (dados[i] == 4)
                    {
                        dado2_4 = dado2_4 + 4;
                    }

                    lbl2_cara4.Visible = true;
                    lbl2_cara4.Text = Convert.ToString(dado2_4);

                }
                if (guardar2[4] == true)
                {
                    if (dados[i] == 5)
                    {
                        dado2_5 = dado2_5 + 5;
                    }

                    lbl2_cara5.Visible = true;
                    lbl2_cara5.Text = Convert.ToString(dado2_5);

                }
                if (guardar2[5] == true)
                {
                    if (dados[i] == 6)
                    {
                        dado2_6 = dado2_6 + 6;
                    }


                    lbl2_cara6.Visible = true;
                    lbl2_cara6.Text = Convert.ToString(dado2_6);

                }
            }
        }

        public void Escalera(int[] dados)
        {
            esc = 0;
            if (guardar[6] == true)
            {
                int[] numeros = new int[7];
                int escalera = 0;
                for (int i = 0; i < dados.Length; i++)
                {

                    if (dados[i] == 1)
                    {
                        numeros[1]++;
                    }
                    if (dados[i] == 2)
                    {
                        numeros[2]++;
                    }
                    if (dados[i] == 3)
                    {
                        numeros[3]++;
                    }
                    if (dados[i] == 4)
                    {
                        numeros[4]++;
                    }
                    if (dados[i] == 5)
                    {
                        numeros[5]++;
                    }
                    if (dados[i] == 6)
                    {
                        numeros[6]++;
                    }
                }
                if (numeros[1] == 1 && numeros[2] == 1 && numeros[3] == 1 && numeros[4] == 1 && numeros[5] == 1)
                {
                    escalera = 1;
                }
                if (numeros[2] == 1 && numeros[3] == 1 && numeros[4] == 1 && numeros[5] == 1 && numeros[6] == 1)
                {
                    escalera = 2;
                }
                if (escalera == 1)
                {
                    esc = 20;
                    
                  

                }
                if (escalera == 2)
                {
                    esc = 25;
                    
                }
                lbl_escalera.Text = Convert.ToString(esc);
                lbl_escalera.Visible = true;
            }
        }
        public void Escalera2(int[] dados)
        {
            esc_2 = 0;

            if (guardar2[6] == true)
            {
                int[] numeros = new int[7];
                int escalera = 0;
                for (int i = 0; i < dados.Length; i++)
                {

                    if (dados[i] == 1)
                    {
                        numeros[1]++;
                    }
                    if (dados[i] == 2)
                    {
                        numeros[2]++;
                    }
                    if (dados[i] == 3)
                    {
                        numeros[3]++;
                    }
                    if (dados[i] == 4)
                    {
                        numeros[4]++;
                    }
                    if (dados[i] == 5)
                    {
                        numeros[5]++;
                    }
                    if (dados[i] == 6)
                    {
                        numeros[6]++;
                    }
                }
                if (numeros[1] == 1 && numeros[2] == 1 && numeros[3] == 1 && numeros[4] == 1 && numeros[5] == 1)
                {
                    escalera = 1;
                }
                if (numeros[2] == 1 && numeros[3] == 1 && numeros[4] == 1 && numeros[5] == 1 && numeros[6] == 1)
                {
                    escalera = 2;
                }
                if (escalera == 1)
                {
                    esc_2 = 20;
         
                }
                if (escalera == 2)
                {
                    esc_2 = 25;
                  
                }
                lbl2_escalera.Text = Convert.ToString(esc_2);
                lbl2_escalera.Visible = true;
            }
        }

        public void Full(int[] dados)
        {
            full = 0;
            if (guardar[7] == true)
            {
                int[] numeros = new int[7];
                int numerocon3 = 0;
                int numerocon2 = 0;
                for (int i = 0; i < dados.Length; i++)
                {
                    if (dados[i] == 1)
                    {
                        numeros[1]++;
                    }
                    if (dados[i] == 2)
                    {
                        numeros[2]++;
                    }
                    if (dados[i] == 3)
                    {
                        numeros[3]++;
                    }
                    if (dados[i] == 4)
                    {
                        numeros[4]++;
                    }
                    if (dados[i] == 5)
                    {
                        numeros[5]++;
                    }
                    if (dados[i] == 6)
                    {
                        numeros[6]++;
                    }
                }
                for (int i = 0; i < numeros.Length; i++)
                {
                    if (numeros[i] == 3)
                    {
                        numerocon3 = 1;
                    }
                }
                if (numerocon3 == 1)
                {
                    for (int i = 0; i < numeros.Length; i++)
                    {
                        if (numeros[i] == 2)
                        {
                            numerocon2 = 1;
                        }
                    }
                }
                if (numerocon3 == 1 && numerocon2 == 1)
                {
                    full = 30;
                    
                }
                lbl_full.Text = Convert.ToString(full);
                lbl_full.Visible = true;
            }
        
        }
        public void Full2(int[] dados)
        {
            full_2 = 0;
            if (guardar2[7] == true)
            {
                int[] numeros = new int[7];
                int numerocon3 = 0;
                int numerocon2 = 0;
                for (int i = 0; i < dados.Length; i++)
                {
                    if (dados[i] == 1)
                    {
                        numeros[1]++;
                    }
                    if (dados[i] == 2)
                    {
                        numeros[2]++;
                    }
                    if (dados[i] == 3)
                    {
                        numeros[3]++;
                    }
                    if (dados[i] == 4)
                    {
                        numeros[4]++;
                    }
                    if (dados[i] == 5)
                    {
                        numeros[5]++;
                    }
                    if (dados[i] == 6)
                    {
                        numeros[6]++;
                    }
                }
                for (int i = 0; i < numeros.Length; i++)
                {
                    if (numeros[i] == 3)
                    {
                        numerocon3 = 1;
                    }
                }
                if (numerocon3 == 1)
                {
                    for (int i = 0; i < numeros.Length; i++)
                    {
                        if (numeros[i] == 2)
                        {
                            numerocon2 = 1;
                        }
                    }
                }
                if (numerocon3 == 1 && numerocon2 == 1)
                {
                    full_2 = 30;
                  
                }
                lbl2_full.Visible = true;
                lbl2_full.Text = Convert.ToString(full_2);
            }

        }

        public void Poker(int[] dados)
        {
            poker = 0; 
            int pok = 0;
            if (guardar[8] == true)
            {
                int[] numeros = new int[7];
                int i = 0;
             
                for (i = 0; i < dados.Length; i++)
                {
                    if (dados[i] == 1)
                    {
                        numeros[1]++;
                    }
                    if (dados[i] == 2)
                    {
                        numeros[2]++;
                    }
                    if (dados[i] == 3)
                    {
                        numeros[3]++;
                    }
                    if (dados[i] == 4)
                    {
                        numeros[4]++;
                    }
                    if (dados[i] == 5)
                    {
                        numeros[5]++;
                    }
                    if (dados[i] == 6)
                    {
                        numeros[6]++;
                    }
                }
                for (i = 0; i < numeros.Length; i++)
                {
                    if (numeros[i] == 4)
                    {
                        pok++;
                    }
                }

                if (pok == 1)
                {

                    poker = 40;
                    
                }
                lbl_poker.Text = Convert.ToString(poker);
                lbl_poker.Visible = true;
            }
        }
        public void Poker2(int[] dados)
        {
            poker_2 = 0;
            int pok = 0;
            if (guardar2[8] == true)
            {
                int[] numeros = new int[7];
                int i = 0;
                
                for (i = 0; i < dados.Length; i++)
                {
                    if (dados[i] == 1)
                    {
                        numeros[1]++;
                    }
                    if (dados[i] == 2)
                    {
                        numeros[2]++;
                    }
                    if (dados[i] == 3)
                    {
                        numeros[3]++;
                    }
                    if (dados[i] == 4)
                    {
                        numeros[4]++;
                    }
                    if (dados[i] == 5)
                    {
                        numeros[5]++;
                    }
                    if (dados[i] == 6)
                    {
                        numeros[6]++;
                    }
                }
                for (i = 0; i < numeros.Length; i++)
                {
                    if (numeros[i] == 4)
                    {
                        pok++;
                    }
                }

                if (pok == 1)
                {

                    poker_2 = 40;
                 
                }
                lbl2_poker.Visible = true;
                lbl2_poker.Text = Convert.ToString(poker_2);
            }
        }

        public void Generala(int [] dados)
        {
            
            if (guardar[9] == true)
            {
                int[] numeros = new int[7];
                int i = 0;
                int generala = 0;

                for (i = 0; i < dados.Length; i++)
                {
                    if (dados[i] == 1)
                    {
                        numeros[1]++;
                    }
                    if (dados[i] == 2)
                    {
                        numeros[2]++;
                    }
                    if (dados[i] == 3)
                    {
                        numeros[3]++;
                    }
                    if (dados[i] == 4)
                    {
                        numeros[4]++;
                    }
                    if (dados[i] == 5)
                    {
                        numeros[5]++;
                    }
                    if (dados[i] == 6)
                    {
                        numeros[6]++;
                    }
                }

                for (i = 0; i < numeros.Length; i++)
                {
                    if (numeros[i] == 5)
                    {
                        generala++;

                    }
                }

                if (generala == 1)
                {
                    gen = 50;
                    
                }
                lbl_generala.Visible = true;
                lbl_generala.Text = Convert.ToString(gen);
            }
        }
        public void Generala1(int[] dados)
        {
            gen_2 = 0;
            if (guardar2[9] == true)
            {
                int[] numeros = new int[7];
                int i = 0;
                int generala = 0;

                for (i = 0; i < dados.Length; i++)
                {
                    if (dados[i] == 1)
                    {
                        numeros[1]++;
                    }
                    if (dados[i] == 2)
                    {
                        numeros[2]++;
                    }
                    if (dados[i] == 3)
                    {
                        numeros[3]++;
                    }
                    if (dados[i] == 4)
                    {
                        numeros[4]++;
                    }
                    if (dados[i] == 5)
                    {
                        numeros[5]++;
                    }
                    if (dados[i] == 6)
                    {
                        numeros[6]++;
                    }
                }

                for (i = 0; i < numeros.Length; i++)
                {
                    if (numeros[i] == 5)
                    {
                        generala++;

                    }
                }

                if (generala == 1)
                {
                    gen_2 = 50;
                
                }
                lbl2_generala.Visible = true;
                lbl2_generala.Text = Convert.ToString(gen_2);
            }
        }

        public void Generala2(int[] dados)
        {
            gen2 = 0;
            if (contador == 1)
            {
                if (guardar[10] == true)
                {
                    int[] numeros = new int[7];
                    int i = 0;
                    int generala = 0;

                    for (i = 0; i < dados.Length; i++)
                    {
                        if (dados[i] == 1)
                        {
                            numeros[1]++;
                        }
                        if (dados[i] == 2)
                        {
                            numeros[2]++;
                        }
                        if (dados[i] == 3)
                        {
                            numeros[3]++;
                        }
                        if (dados[i] == 4)
                        {
                            numeros[4]++;
                        }
                        if (dados[i] == 5)
                        {
                            numeros[5]++;
                        }
                        if (dados[i] == 6)
                        {
                            numeros[6]++;
                        }
                    }

                    for (i = 0; i < numeros.Length; i++)
                    {
                        if (numeros[i] == 5)
                        {
                            generala++;

                        }
                    }

                    if (generala == 1)
                    {
                        gen2 = 80;
                      
                    }
                    lbl_generala2.Visible = true;
                    lbl_generala.Text = Convert.ToString(gen2);
                }
            }
        }
        public void Generala3(int[] dados)
        {
            gen2_2 = 0;
            if (contador == 1)
            {
                if (guardar2[10] == true)
                {
                    int[] numeros = new int[7];
                    int i = 0;
                    int generala = 0;

                    for (i = 0; i < dados.Length; i++)
                    {
                        if (dados[i] == 1)
                        {
                            numeros[1]++;
                        }
                        if (dados[i] == 2)
                        {
                            numeros[2]++;
                        }
                        if (dados[i] == 3)
                        {
                            numeros[3]++;
                        }
                        if (dados[i] == 4)
                        {
                            numeros[4]++;
                        }
                        if (dados[i] == 5)
                        {
                            numeros[5]++;
                        }
                        if (dados[i] == 6)
                        {
                            numeros[6]++;
                        }
                    }

                    for (i = 0; i < numeros.Length; i++)
                    {
                        if (numeros[i] == 5)
                        {
                            generala++;

                        }
                    }

                    if (generala == 1)
                    {
                        gen2_2 = 80;
                    }
                    lbl2_generala2.Visible = true;
                    lbl2_generala.Text = Convert.ToString(gen2_2);

                }
            }
        }

        //GUARDAR LOS VASOS EN LOS DADOS

        private void picture_d1_Click(object sender, EventArgs e)
        {

            
            if (vaso[0] == false)
            {
                lbl_pic1.Visible = false;
                vaso[0] = true;
               
            }
            else
            {
                vaso[0] = false;
                
                lbl_pic1.Visible = true;
            }
        
        }

        private void picture_d2_Click(object sender, EventArgs e)
        {

            if (vaso[1] == false)
            {
                lbl_pic2.Visible = false;
                vaso[1] = true;
            }
            else
            {
                lbl_pic2.Visible = true;
                vaso[1] = false;
            }
        }

        private void picture_d3_Click(object sender, EventArgs e)
        {
            if (vaso[2] == false)
            {
                lbl_pic3.Visible = false;
                vaso[2] = true;
            }
            else
            {
                lbl_pic3.Visible = true;
                vaso[2] = false;
            }
        }

        private void picture_d5_Click(object sender, EventArgs e)
        {
            
            if (vaso[4] == false)
            {
                lbl_pic4.Visible = false;
                vaso[4] = true;
            }
            else
            {
                lbl_pic4.Visible = true;
                vaso[4] = false;
            }
        }

        private void picture_d4_Click(object sender, EventArgs e)
        {
            if (vaso[3] == false)
            {
                lbl_pic5.Visible = false;
                vaso[3] = true;
            }
            else
            {
                lbl_pic5.Visible = true;
                vaso[3] = false;
            }
        }

        //TIMER PARA LANZAR LOS DADOS

        private void timer1_Tick(object sender, EventArgs e)
        {
            mezclando = true;
            vuelta++;
            Mezclar();

            if (vuelta >= 10)
            {
                mezclando = false;
                vuelta = 0;
                timer1.Stop();
                if (jugador)
                {
                    Generala2(dados);
                    Generala(dados);
                    Escalera(dados);
                    Full(dados);
                    Poker(dados);
                    Numeros(dados);
                }
                if (jugador == false)
                {
                    Generala3(dados);
                    Generala1(dados);
                    Escalera2(dados);
                    Full2(dados);
                    Poker2(dados);
                    Numeros2(dados);
                }
            }
           
        }

        //DOY IMAGEN A LOS DADOS

        private void Mezclar()
           {
               if (vaso[0] == true)
               {
                   dados[0] = aleatorio.Next(1, 7);
                   picture_d1.Image = imageList1.Images[dados[0] - 1];
               }
               if (vaso[1] == true)
               {
                   dados[1] = aleatorio.Next(1, 7);
                   picture_d2.Image = imageList1.Images[dados[1] - 1];
               }
               if (vaso[2] == true)
               {
                   dados[2] = aleatorio.Next(1, 7);
                   picture_d3.Image = imageList1.Images[dados[2] - 1];
               }
               if (vaso[3] == true)
               {
                   dados[3] = aleatorio.Next(1, 7);
                   picture_d4.Image = imageList1.Images[dados[3] - 1];
               }
               if (vaso[4] == true)
               {
                   dados[4] = aleatorio.Next(1, 7);
                   picture_d5.Image = imageList1.Images[dados[4] - 1];
               }

           }

        //CAMBIA LOS LABEL POR SU VALOR

        private void lbl_cara1_Click(object sender, EventArgs e)
        {
            JUGADAS[0] = dado1; 
            lbl_cara1.BackColor = Color.LightGray;
            lbl_cara1.Enabled = false;
            guardar[0] = false;
            finalizarturno();
        }

        private void lbl_cara2_Click(object sender, EventArgs e)
        {
            JUGADAS[1] = dado2;
            lbl_cara2.BackColor = Color.LightGray;
            guardar[1] = false;
            lbl_cara2.Enabled = false;
            finalizarturno();
        }

        private void lbl_cara3_Click(object sender, EventArgs e)
        {
            JUGADAS[2] = dado3;
            lbl_cara3.BackColor = Color.LightGray;
            guardar[2] = false;
            lbl_cara3.Enabled = false;
            finalizarturno();
        }

        private void lbl_cara4_Click(object sender, EventArgs e)
        {
            JUGADAS[3] = dado4;
            lbl_cara4.BackColor = Color.LightGray;
            guardar[3] = false;
            lbl_cara4.Enabled = false;
            finalizarturno();
        }

        private void lbl_cara5_Click(object sender, EventArgs e)
        {
            JUGADAS[4] = dado5;
            lbl_cara5.BackColor = Color.LightGray;
            guardar[4] = false;
            lbl_cara5.Enabled = false;
            finalizarturno();
        }

        private void lbl_cara6_Click(object sender, EventArgs e)
        {
            JUGADAS[5] = dado6;
            lbl_cara6.BackColor = Color.LightGray;
            guardar[5] = false;
            lbl_cara6.Enabled = false;
            finalizarturno();
        }

        private void lbl_escalera_Click(object sender, EventArgs e)
        {
            JUGADAS[6] = esc;
            lbl_escalera.BackColor = Color.LightGray;
            guardar[6] = false;
            lbl_escalera.Enabled = false;
            finalizarturno();
        }

        private void lbl_full_Click(object sender, EventArgs e)
        {
            JUGADAS[7] = full;
            lbl_full.BackColor = Color.LightGray;
            guardar[7] = false;
            lbl_full.Enabled = false;
            finalizarturno();
        }

        private void lbl_poker_Click(object sender, EventArgs e)
        {
            JUGADAS[8] = poker;
            lbl_poker.BackColor = Color.LightGray;
            guardar[8] = false;
            lbl_poker.Enabled = false;
            finalizarturno();
        }

        private void lbl_generala_Click(object sender, EventArgs e)
        {
            JUGADAS[9] = gen;
            lbl_generala.BackColor = Color.LightGray;
            guardar[9] = false;
            lbl_generala.Enabled = false;
            finalizarturno();
        }

        private void lbl_generala2_Click(object sender, EventArgs e)
        {
            JUGADAS[10] = gen2;
            lbl_generala2.BackColor = Color.LightGray;
            lbl_generala2.Enabled = false;
            guardar[10] = false;
            finalizarturno();
        }

        //FINALIZO JUGADAS

      //CAMBIO PARA LOS JUGADORES

        private void lbl2_cara1_Click(object sender, EventArgs e)
        {
            JUGADAS2[0] = dado2_1;
            lbl2_cara1.BackColor = Color.LightGray;
            lbl2_cara1.Enabled = false;
            guardar2[0] = false;
            finalizarturno2();
        }

        private void lbl2_cara2_Click(object sender, EventArgs e)
        {
            JUGADAS2[1] = dado2_2;
            lbl2_cara2.BackColor = Color.LightGray;
            lbl2_cara2.Enabled = false;
            guardar2[1] = false;
            finalizarturno2();
        }

        private void lbl2_cara3_Click(object sender, EventArgs e)
        {
            JUGADAS2[2] = dado2_3;
            lbl2_cara3.BackColor = Color.LightGray;
            lbl2_cara3.Enabled = false;
            guardar2[2] = false;
            finalizarturno2();
        }

        private void lbl2_cara4_Click(object sender, EventArgs e)
        {
            JUGADAS2[3] = dado2_4;
            lbl2_cara4.BackColor = Color.LightGray;
            lbl2_cara4.Enabled = false;
            guardar2[3] = false;
            finalizarturno2();
        }

        private void lbl2_cara5_Click(object sender, EventArgs e)
        {
            JUGADAS2[4] = dado2_5;
            lbl2_cara5.BackColor = Color.LightGray;
            lbl2_cara5.Enabled = false;
            guardar2[4] = false;
            finalizarturno2();
        }

        private void lbl2_cara6_Click(object sender, EventArgs e)
        {
            JUGADAS2[5] = dado2_6;
            lbl2_cara6.BackColor = Color.LightGray;
            lbl2_cara6.Enabled = false;
            guardar2[5] = false;
            finalizarturno2();
        }

        private void lbl2_escalera_Click(object sender, EventArgs e)
        {
            JUGADAS2[6] = esc_2;
            lbl2_escalera.BackColor = Color.LightGray;
            lbl2_escalera.Enabled = false;
            guardar2[6] = false;
            finalizarturno2();
        }

        private void lbl2_full_Click(object sender, EventArgs e)
        {
            JUGADAS2[7] = full_2;
            lbl2_full.BackColor = Color.LightGray;
            lbl2_full.Enabled = false;
            guardar2[7] = false;
            finalizarturno2();
        }

        private void lbl2_poker_Click(object sender, EventArgs e)
        {

            JUGADAS2[8] = poker_2;
            lbl2_poker.BackColor = Color.LightGray;
            lbl2_poker.Enabled = false;
            guardar2[8] = false;
            finalizarturno2();
        }

        private void lbl2_generala_Click(object sender, EventArgs e)
        {

            JUGADAS2[9] = gen_2;
            lbl2_generala.BackColor = Color.LightGray;
            lbl2_generala.Enabled = false;
            guardar2[9] = false;
            finalizarturno2();
        }

        private void lbl2_generala2_Click(object sender, EventArgs e)
        {
            JUGADAS2[10] = gen2_2;
            lbl2_generala2.BackColor = Color.LightGray;
            lbl2_generala2.Enabled = false;
            guardar2[10] = false;
            finalizarturno2();
        }

        public void finalizarturno()
        {

            picture_d1.Enabled = false;
            picture_d2.Enabled = false;
            picture_d3.Enabled = false;
            picture_d4.Enabled = false;
            picture_d5.Enabled = false;


            if (unJ)
            {
                ronda++;
            }

            grup_jugador1.Enabled = false;
            Tirar.Visible = true;
            vaso[0] = true;
            vaso[1] = true;
            vaso[2] = true;
            vaso[3] = true;
            vaso[4] = true;
            lbl_pic1.Visible = false;
            lbl_pic2.Visible = false;
            lbl_pic3.Visible = false;
            lbl_pic4.Visible = false;
            lbl_pic5.Visible = false;
            contador = 0;
            turno++;
            lbl_restantes.Text = Convert.ToString(3);

            if (dosJ)
            {
                lbl_lanza.Text = lbl_jugador2.Text;

            }
            if (unJ)
            {
                if (turno > 11)
                {
                    Tirar.Visible = false;
                    MessageBox.Show("FIN DEL JUEGO");

                    int sumatotal1 = 0;

                    for (int i = 0; i < JUGADAS.Length; i++)
                    {
                        sumatotal1 = sumatotal1 + JUGADAS[i];

                    }

                    MessageBox.Show(Convert.ToString("PUNTUACION DEL JUGADOR : " + sumatotal1));
                    lbl_lanza.Text = lbl_jugador1.Text;
                    grup_jugador1.Enabled = true;
                    grup_jugador2.Enabled = false;
                    lbl_lanza.Visible = false;
                    lbl_lanza2.Visible = false;
                    jugador = true;
                    EnviarBD(sumatotal1);
                }
            }
        }
        public void finalizarturno2()
        {
            picture_d1.Enabled = false;
            picture_d2.Enabled = false;
            picture_d3.Enabled = false;
            picture_d4.Enabled = false;
            picture_d5.Enabled = false;

            grup_jugador2.Enabled = false;
            Tirar.Visible = true;
            vaso[0] = true;
            vaso[1] = true;
            vaso[2] = true;
            vaso[3] = true;
            vaso[4] = true;
            lbl_pic1.Visible = false;
            lbl_pic2.Visible = false;
            lbl_pic3.Visible = false;
            lbl_pic4.Visible = false;
            lbl_pic5.Visible = false;
            contador = 0;
            turno++;
            lbl_restantes.Text = Convert.ToString(3);
            ronda++;
            lbl_lanza.Text = lbl_jugador1.Text;


           

            if (turno > 22)
            {
                MessageBox.Show("FIN DEL JUEGO");
                int sumatotal = 0;
                int sumatotal2 = 0;

                for (int i = 0; i < JUGADAS.Length; i++)
                {
                    sumatotal = sumatotal + JUGADAS[i];
                    sumatotal2 = sumatotal2 + JUGADAS2[i];
                }

                MessageBox.Show(Convert.ToString("LA PUNTUACION DE "+ jugador1 +" ES: "+ sumatotal + "   LA PUNTUACION DE "+jugador2+" ES: "+ sumatotal2));

                if (sumatotal > sumatotal2)
                {
                    MessageBox.Show("EL GANADOR ES: "+ jugador1);
                }
                else
                {
                    MessageBox.Show("EL GANADOR ES: " + jugador2);
                }

                EnviarBD(sumatotal);
                EnviarBD2(sumatotal2);
            }

            
        }
        public void EnviarBD(int sumatotal1)
        {
            ConectaDB.AbrirDB();
            string insertPer = "INSERT INTO Puntajes(nombre, puntaje) VALUES (' " + jugador1 + " ' , ' " +
            sumatotal1 + " ' ) ; ";
            ConectaDB.CargarDB(insertPer);

            
        }
        public void EnviarBD2(int sumatotal2)
        {
            ConectaDB.AbrirDB();
            string insertPer = "INSERT INTO Puntajes(nombre, puntaje) VALUES (' " + jugador2 + " ' , ' " +
            sumatotal2 + " ' ) ; ";
            ConectaDB.CargarDB(insertPer);
        }


        private void btn_historial_Click(object sender, EventArgs e)
        {
            Historial FormularioHistorial = new Historial();
            FormularioHistorial.ShowDialog();
        }    
     }
}
