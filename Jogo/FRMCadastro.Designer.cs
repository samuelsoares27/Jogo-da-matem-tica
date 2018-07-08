namespace Jogo
{
    partial class FRMCadastro
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
            this.pbimg = new System.Windows.Forms.PictureBox();
            this.lbtxtnome = new System.Windows.Forms.Label();
            this.tbnome = new System.Windows.Forms.TextBox();
            this.btconfirmar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbimg)).BeginInit();
            this.SuspendLayout();
            // 
            // pbimg
            // 
            this.pbimg.Image = global::Jogo.Properties.Resources.photo;
            this.pbimg.Location = new System.Drawing.Point(71, 26);
            this.pbimg.Name = "pbimg";
            this.pbimg.Size = new System.Drawing.Size(147, 143);
            this.pbimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbimg.TabIndex = 0;
            this.pbimg.TabStop = false;
            this.pbimg.Click += new System.EventHandler(this.pbimg_Click);
            // 
            // lbtxtnome
            // 
            this.lbtxtnome.AutoSize = true;
            this.lbtxtnome.BackColor = System.Drawing.Color.Transparent;
            this.lbtxtnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtxtnome.ForeColor = System.Drawing.SystemColors.Window;
            this.lbtxtnome.Location = new System.Drawing.Point(68, 182);
            this.lbtxtnome.Name = "lbtxtnome";
            this.lbtxtnome.Size = new System.Drawing.Size(53, 16);
            this.lbtxtnome.TabIndex = 1;
            this.lbtxtnome.Text = "Nome:";
            // 
            // tbnome
            // 
            this.tbnome.Location = new System.Drawing.Point(127, 180);
            this.tbnome.Name = "tbnome";
            this.tbnome.Size = new System.Drawing.Size(91, 20);
            this.tbnome.TabIndex = 2;
            // 
            // btconfirmar
            // 
            this.btconfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btconfirmar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btconfirmar.Location = new System.Drawing.Point(53, 210);
            this.btconfirmar.Name = "btconfirmar";
            this.btconfirmar.Size = new System.Drawing.Size(189, 39);
            this.btconfirmar.TabIndex = 3;
            this.btconfirmar.Text = "Confirmar";
            this.btconfirmar.UseVisualStyleBackColor = true;
            this.btconfirmar.Click += new System.EventHandler(this.btconfirmar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(80, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Clique na foto para alterar.";
            // 
            // FRMCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Jogo.Properties.Resources.video_game_background_1405076_960_720;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btconfirmar);
            this.Controls.Add(this.tbnome);
            this.Controls.Add(this.lbtxtnome);
            this.Controls.Add(this.pbimg);
            this.MaximizeBox = false;
            this.Name = "FRMCadastro";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            ((System.ComponentModel.ISupportInitialize)(this.pbimg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbimg;
        private System.Windows.Forms.Label lbtxtnome;
        private System.Windows.Forms.TextBox tbnome;
        private System.Windows.Forms.Button btconfirmar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
    }
}