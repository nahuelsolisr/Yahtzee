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
    public partial class Historial : Form
    {
        public Historial()
        {
            InitializeComponent();

        }

        private void Historial_Load(object sender, EventArgs e)
        {
            Cargargrilla();
        }

        public void Cargargrilla()
        {
            ConectaDB.AbrirDB();
            string Consulta = "SELECT * from Puntajes";
            ConectaDB.LecturaDB(Consulta);
            while (DB.lector.Read())
            {

                grilla.Rows.Add();
                grilla[0, grilla.Rows.Count - 2].Value = DB.lector["Nombre"].ToString();
                grilla[1, grilla.Rows.Count - 2].Value = DB.lector["Puntaje"].ToString();     
            }

            grilla.ClearSelection();
            DB.lector.Close();
        }
    }
}
