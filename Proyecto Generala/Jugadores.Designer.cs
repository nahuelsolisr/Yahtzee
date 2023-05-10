namespace Proyecto_Generala
{
    partial class Jugadores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jugadores));
            this.cmb_select_players = new System.Windows.Forms.ComboBox();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.txt_nombre1 = new System.Windows.Forms.TextBox();
            this.txt_nombre2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmb_select_players
            // 
            this.cmb_select_players.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_select_players.Font = new System.Drawing.Font("Verdana", 12F);
            this.cmb_select_players.FormattingEnabled = true;
            this.cmb_select_players.Items.AddRange(new object[] {
            "1 Jugador",
            "2 Jugadores"});
            this.cmb_select_players.Location = new System.Drawing.Point(15, 41);
            this.cmb_select_players.Name = "cmb_select_players";
            this.cmb_select_players.Size = new System.Drawing.Size(121, 26);
            this.cmb_select_players.TabIndex = 16;
            this.cmb_select_players.SelectedIndexChanged += new System.EventHandler(this.cmb_select_players_SelectedIndexChanged);
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_confirmar.Font = new System.Drawing.Font("Verdana", 12F);
            this.btn_confirmar.Location = new System.Drawing.Point(264, 171);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(90, 28);
            this.btn_confirmar.TabIndex = 15;
            this.btn_confirmar.Text = "JUGAR";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // txt_nombre1
            // 
            this.txt_nombre1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.txt_nombre1.Location = new System.Drawing.Point(12, 141);
            this.txt_nombre1.MaxLength = 8;
            this.txt_nombre1.Name = "txt_nombre1";
            this.txt_nombre1.Size = new System.Drawing.Size(96, 27);
            this.txt_nombre1.TabIndex = 14;
            // 
            // txt_nombre2
            // 
            this.txt_nombre2.Font = new System.Drawing.Font("Verdana", 12F);
            this.txt_nombre2.Location = new System.Drawing.Point(12, 173);
            this.txt_nombre2.MaxLength = 8;
            this.txt_nombre2.Name = "txt_nombre2";
            this.txt_nombre2.Size = new System.Drawing.Size(96, 27);
            this.txt_nombre2.TabIndex = 13;
            this.txt_nombre2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "CANTIDAD DE JUGADORES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F);
            this.label2.Location = new System.Drawing.Point(12, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "TAGS";
            // 
            // Jugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(366, 211);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_select_players);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.txt_nombre1);
            this.Controls.Add(this.txt_nombre2);
            this.Controls.Add(this.label1);
            this.Name = "Jugadores";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jugadores";
            this.Load += new System.EventHandler(this.Jugadores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cmb_select_players;
        private System.Windows.Forms.Button btn_confirmar;
        public System.Windows.Forms.TextBox txt_nombre1;
        public System.Windows.Forms.TextBox txt_nombre2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

    }
}