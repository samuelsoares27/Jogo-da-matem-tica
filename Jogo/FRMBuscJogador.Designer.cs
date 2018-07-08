namespace Jogo
{
    partial class FRMBuscJogador
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbnomebusc = new System.Windows.Forms.TextBox();
            this.imgjogador = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbnome = new System.Windows.Forms.Label();
            this.lbtxtponto = new System.Windows.Forms.Label();
            this.lbtempo = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lbponto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgjogador)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(23, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // tbnomebusc
            // 
            this.tbnomebusc.Location = new System.Drawing.Point(72, 28);
            this.tbnomebusc.Name = "tbnomebusc";
            this.tbnomebusc.Size = new System.Drawing.Size(121, 20);
            this.tbnomebusc.TabIndex = 1;
            // 
            // imgjogador
            // 
            this.imgjogador.Image = global::Jogo.Properties.Resources.photo;
            this.imgjogador.Location = new System.Drawing.Point(21, 74);
            this.imgjogador.Name = "imgjogador";
            this.imgjogador.Size = new System.Drawing.Size(115, 114);
            this.imgjogador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgjogador.TabIndex = 2;
            this.imgjogador.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(199, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 20);
            this.button1.TabIndex = 3;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbnome
            // 
            this.lbnome.AutoSize = true;
            this.lbnome.BackColor = System.Drawing.Color.Transparent;
            this.lbnome.ForeColor = System.Drawing.SystemColors.Window;
            this.lbnome.Location = new System.Drawing.Point(148, 79);
            this.lbnome.Name = "lbnome";
            this.lbnome.Size = new System.Drawing.Size(38, 13);
            this.lbnome.TabIndex = 4;
            this.lbnome.Text = "Nome:";
            // 
            // lbtxtponto
            // 
            this.lbtxtponto.AutoSize = true;
            this.lbtxtponto.BackColor = System.Drawing.Color.Transparent;
            this.lbtxtponto.ForeColor = System.Drawing.SystemColors.Window;
            this.lbtxtponto.Location = new System.Drawing.Point(148, 131);
            this.lbtxtponto.Name = "lbtxtponto";
            this.lbtxtponto.Size = new System.Drawing.Size(43, 13);
            this.lbtxtponto.TabIndex = 5;
            this.lbtxtponto.Text = "Pontos:";
            // 
            // lbtempo
            // 
            this.lbtempo.AutoSize = true;
            this.lbtempo.BackColor = System.Drawing.Color.Transparent;
            this.lbtempo.ForeColor = System.Drawing.SystemColors.Window;
            this.lbtempo.Location = new System.Drawing.Point(148, 104);
            this.lbtempo.Name = "lbtempo";
            this.lbtempo.Size = new System.Drawing.Size(43, 13);
            this.lbtempo.TabIndex = 6;
            this.lbtempo.Text = "Tempo:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button2.Location = new System.Drawing.Point(21, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(240, 44);
            this.button2.TabIndex = 7;
            this.button2.Text = "Voltar ao Menu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbponto
            // 
            this.lbponto.AutoSize = true;
            this.lbponto.Font = new System.Drawing.Font("Microsoft Sans Serif", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbponto.ForeColor = System.Drawing.Color.DarkRed;
            this.lbponto.Location = new System.Drawing.Point(198, 136);
            this.lbponto.Name = "lbponto";
            this.lbponto.Size = new System.Drawing.Size(49, 52);
            this.lbponto.TabIndex = 8;
            this.lbponto.Text = "0";
            // 
            // FRMBuscJogador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Jogo.Properties.Resources.video_game_background_1405076_960_720;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lbponto);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbtempo);
            this.Controls.Add(this.lbtxtponto);
            this.Controls.Add(this.lbnome);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.imgjogador);
            this.Controls.Add(this.tbnomebusc);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FRMBuscJogador";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Jogador";
            ((System.ComponentModel.ISupportInitialize)(this.imgjogador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbnomebusc;
        private System.Windows.Forms.PictureBox imgjogador;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbnome;
        private System.Windows.Forms.Label lbtxtponto;
        private System.Windows.Forms.Label lbtempo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbponto;
    }
}