
namespace PiedraPapelTijeraLagartoSpock
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btn_piedra = new System.Windows.Forms.Button();
            this.btn_papel = new System.Windows.Forms.Button();
            this.btn_tijera = new System.Windows.Forms.Button();
            this.btn_lagarto = new System.Windows.Forms.Button();
            this.btn_spock = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_vos_elegiste = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_yo_elegi = new System.Windows.Forms.Label();
            this.lbl_leyenda = new System.Windows.Forms.Label();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.lbl_score = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_score_vos = new System.Windows.Forms.Label();
            this.btn_reset_score = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_score_yo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lbl_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(86)))), ((int)(((byte)(93)))));
            this.lbl_titulo.Location = new System.Drawing.Point(47, 35);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(631, 43);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Piedra Papel Tijera Lagarto Spock";
            // 
            // btn_piedra
            // 
            this.btn_piedra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(224)))), ((int)(((byte)(179)))));
            this.btn_piedra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(86)))), ((int)(((byte)(93)))));
            this.btn_piedra.Location = new System.Drawing.Point(36, 105);
            this.btn_piedra.Name = "btn_piedra";
            this.btn_piedra.Size = new System.Drawing.Size(101, 77);
            this.btn_piedra.TabIndex = 1;
            this.btn_piedra.Text = "Piedra";
            this.btn_piedra.UseVisualStyleBackColor = false;
            this.btn_piedra.Click += new System.EventHandler(this.btn_piedra_Click);
            // 
            // btn_papel
            // 
            this.btn_papel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(224)))), ((int)(((byte)(179)))));
            this.btn_papel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(86)))), ((int)(((byte)(93)))));
            this.btn_papel.Location = new System.Drawing.Point(178, 105);
            this.btn_papel.Name = "btn_papel";
            this.btn_papel.Size = new System.Drawing.Size(101, 77);
            this.btn_papel.TabIndex = 2;
            this.btn_papel.Text = "Papel";
            this.btn_papel.UseVisualStyleBackColor = false;
            this.btn_papel.Click += new System.EventHandler(this.btn_papel_Click);
            // 
            // btn_tijera
            // 
            this.btn_tijera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(224)))), ((int)(((byte)(179)))));
            this.btn_tijera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(86)))), ((int)(((byte)(93)))));
            this.btn_tijera.Location = new System.Drawing.Point(321, 105);
            this.btn_tijera.Name = "btn_tijera";
            this.btn_tijera.Size = new System.Drawing.Size(101, 77);
            this.btn_tijera.TabIndex = 3;
            this.btn_tijera.Text = "Tijera";
            this.btn_tijera.UseVisualStyleBackColor = false;
            this.btn_tijera.Click += new System.EventHandler(this.btn_tijera_Click);
            // 
            // btn_lagarto
            // 
            this.btn_lagarto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(224)))), ((int)(((byte)(179)))));
            this.btn_lagarto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(86)))), ((int)(((byte)(93)))));
            this.btn_lagarto.Location = new System.Drawing.Point(452, 105);
            this.btn_lagarto.Name = "btn_lagarto";
            this.btn_lagarto.Size = new System.Drawing.Size(101, 77);
            this.btn_lagarto.TabIndex = 4;
            this.btn_lagarto.Text = "Lagarto";
            this.btn_lagarto.UseVisualStyleBackColor = false;
            this.btn_lagarto.Click += new System.EventHandler(this.btn_lagarto_Click);
            // 
            // btn_spock
            // 
            this.btn_spock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(224)))), ((int)(((byte)(179)))));
            this.btn_spock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(86)))), ((int)(((byte)(93)))));
            this.btn_spock.Location = new System.Drawing.Point(587, 105);
            this.btn_spock.Name = "btn_spock";
            this.btn_spock.Size = new System.Drawing.Size(101, 77);
            this.btn_spock.TabIndex = 5;
            this.btn_spock.Text = "Spock";
            this.btn_spock.UseVisualStyleBackColor = false;
            this.btn_spock.Click += new System.EventHandler(this.btn_spock_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(178, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 36);
            this.label2.TabIndex = 6;
            this.label2.Text = "Vos elegiste:";
            // 
            // lbl_vos_elegiste
            // 
            this.lbl_vos_elegiste.AutoSize = true;
            this.lbl_vos_elegiste.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_vos_elegiste.ForeColor = System.Drawing.Color.Black;
            this.lbl_vos_elegiste.Location = new System.Drawing.Point(400, 227);
            this.lbl_vos_elegiste.Name = "lbl_vos_elegiste";
            this.lbl_vos_elegiste.Size = new System.Drawing.Size(0, 36);
            this.lbl_vos_elegiste.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(178, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 36);
            this.label4.TabIndex = 8;
            this.label4.Text = "Yo elegi:";
            // 
            // lbl_yo_elegi
            // 
            this.lbl_yo_elegi.AutoSize = true;
            this.lbl_yo_elegi.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_yo_elegi.Location = new System.Drawing.Point(400, 278);
            this.lbl_yo_elegi.Name = "lbl_yo_elegi";
            this.lbl_yo_elegi.Size = new System.Drawing.Size(0, 36);
            this.lbl_yo_elegi.TabIndex = 9;
            // 
            // lbl_leyenda
            // 
            this.lbl_leyenda.AutoSize = true;
            this.lbl_leyenda.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_leyenda.Location = new System.Drawing.Point(187, 327);
            this.lbl_leyenda.Name = "lbl_leyenda";
            this.lbl_leyenda.Size = new System.Drawing.Size(0, 37);
            this.lbl_leyenda.TabIndex = 10;
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_resultado.Location = new System.Drawing.Point(187, 387);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(0, 37);
            this.lbl_resultado.TabIndex = 11;
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_score.Location = new System.Drawing.Point(47, 501);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(87, 37);
            this.lbl_score.TabIndex = 0;
            this.lbl_score.Text = "Score";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(223, 461);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 33);
            this.label10.TabIndex = 2;
            this.label10.Text = "Vos:";
            // 
            // lbl_score_vos
            // 
            this.lbl_score_vos.AutoSize = true;
            this.lbl_score_vos.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_score_vos.Location = new System.Drawing.Point(347, 461);
            this.lbl_score_vos.Name = "lbl_score_vos";
            this.lbl_score_vos.Size = new System.Drawing.Size(0, 33);
            this.lbl_score_vos.TabIndex = 3;
            // 
            // btn_reset_score
            // 
            this.btn_reset_score.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(224)))), ((int)(((byte)(179)))));
            this.btn_reset_score.Location = new System.Drawing.Point(556, 446);
            this.btn_reset_score.Name = "btn_reset_score";
            this.btn_reset_score.Size = new System.Drawing.Size(144, 115);
            this.btn_reset_score.TabIndex = 5;
            this.btn_reset_score.Text = "Reset Score";
            this.btn_reset_score.UseVisualStyleBackColor = false;
            this.btn_reset_score.Click += new System.EventHandler(this.btn_reset_score_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(235, 537);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 33);
            this.label1.TabIndex = 12;
            this.label1.Text = "Yo:";
            // 
            // lbl_score_yo
            // 
            this.lbl_score_yo.AutoSize = true;
            this.lbl_score_yo.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_score_yo.Location = new System.Drawing.Point(347, 537);
            this.lbl_score_yo.Name = "lbl_score_yo";
            this.lbl_score_yo.Size = new System.Drawing.Size(0, 33);
            this.lbl_score_yo.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(62)))), ((int)(((byte)(182)))));
            this.ClientSize = new System.Drawing.Size(738, 594);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_score_yo);
            this.Controls.Add(this.btn_reset_score);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbl_score_vos);
            this.Controls.Add(this.lbl_leyenda);
            this.Controls.Add(this.lbl_yo_elegi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.lbl_vos_elegiste);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_spock);
            this.Controls.Add(this.btn_lagarto);
            this.Controls.Add(this.btn_tijera);
            this.Controls.Add(this.btn_papel);
            this.Controls.Add(this.btn_piedra);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "Form1";
            this.Text = ".:. Piedra Papel Tijera Lagarto Spock .:.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btn_piedra;
        private System.Windows.Forms.Button btn_papel;
        private System.Windows.Forms.Button btn_tijera;
        private System.Windows.Forms.Button btn_lagarto;
        private System.Windows.Forms.Button btn_spock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_vos_elegiste;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_yo_elegi;
        private System.Windows.Forms.Label lbl_leyenda;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_score_vos;
        private System.Windows.Forms.Button btn_reset_score;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_score_yo;
    }
}

