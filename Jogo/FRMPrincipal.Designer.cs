namespace Jogo
{
    partial class FRMPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menjogadores = new System.Windows.Forms.ToolStripMenuItem();
            this.menraking = new System.Windows.Forms.ToolStripMenuItem();
            this.mensair = new System.Windows.Forms.ToolStripMenuItem();
            this.btjogar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.menjogadores,
            this.menraking,
            this.mensair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // menjogadores
            // 
            this.menjogadores.Name = "menjogadores";
            this.menjogadores.Size = new System.Drawing.Size(54, 20);
            this.menjogadores.Text = "Buscar";
            this.menjogadores.Click += new System.EventHandler(this.menjogadores_Click);
            // 
            // menraking
            // 
            this.menraking.Name = "menraking";
            this.menraking.Size = new System.Drawing.Size(62, 20);
            this.menraking.Text = "Ranking";
            this.menraking.Click += new System.EventHandler(this.menraking_Click);
            // 
            // mensair
            // 
            this.mensair.Name = "mensair";
            this.mensair.Size = new System.Drawing.Size(38, 20);
            this.mensair.Text = "Sair";
            this.mensair.Click += new System.EventHandler(this.mensair_Click);
            // 
            // btjogar
            // 
            this.btjogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btjogar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btjogar.Location = new System.Drawing.Point(29, 197);
            this.btjogar.Name = "btjogar";
            this.btjogar.Size = new System.Drawing.Size(227, 37);
            this.btjogar.TabIndex = 0;
            this.btjogar.Text = "Jogar";
            this.btjogar.UseVisualStyleBackColor = true;
            this.btjogar.Click += new System.EventHandler(this.btjogar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Jogo.Properties.Resources.logo_jogo;
            this.pictureBox1.Location = new System.Drawing.Point(29, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FRMPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Jogo.Properties.Resources.video_game_background_1405076_960_720;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btjogar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FRMPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menjogadores;
        private System.Windows.Forms.ToolStripMenuItem menraking;
        private System.Windows.Forms.ToolStripMenuItem mensair;
        private System.Windows.Forms.Button btjogar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

