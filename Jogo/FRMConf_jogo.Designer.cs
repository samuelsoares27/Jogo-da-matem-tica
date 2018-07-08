namespace Jogo
{
    partial class FRMConf_jogo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbmultiplicacao = new System.Windows.Forms.RadioButton();
            this.rbdivisao = new System.Windows.Forms.RadioButton();
            this.rbsubitracao = new System.Windows.Forms.RadioButton();
            this.rbsoma = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbdificil = new System.Windows.Forms.RadioButton();
            this.rbfacil = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rbmultiplicacao);
            this.groupBox1.Controls.Add(this.rbdivisao);
            this.groupBox1.Controls.Add(this.rbsubitracao);
            this.groupBox1.Controls.Add(this.rbsoma);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Location = new System.Drawing.Point(26, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 98);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operação";
            // 
            // rbmultiplicacao
            // 
            this.rbmultiplicacao.AutoSize = true;
            this.rbmultiplicacao.Location = new System.Drawing.Point(125, 63);
            this.rbmultiplicacao.Name = "rbmultiplicacao";
            this.rbmultiplicacao.Size = new System.Drawing.Size(87, 17);
            this.rbmultiplicacao.TabIndex = 3;
            this.rbmultiplicacao.TabStop = true;
            this.rbmultiplicacao.Text = "Multiplicação";
            this.rbmultiplicacao.UseVisualStyleBackColor = true;
            // 
            // rbdivisao
            // 
            this.rbdivisao.AutoSize = true;
            this.rbdivisao.Location = new System.Drawing.Point(125, 31);
            this.rbdivisao.Name = "rbdivisao";
            this.rbdivisao.Size = new System.Drawing.Size(60, 17);
            this.rbdivisao.TabIndex = 2;
            this.rbdivisao.TabStop = true;
            this.rbdivisao.Text = "Divisão";
            this.rbdivisao.UseVisualStyleBackColor = true;
            // 
            // rbsubitracao
            // 
            this.rbsubitracao.AutoSize = true;
            this.rbsubitracao.Location = new System.Drawing.Point(17, 63);
            this.rbsubitracao.Name = "rbsubitracao";
            this.rbsubitracao.Size = new System.Drawing.Size(74, 17);
            this.rbsubitracao.TabIndex = 1;
            this.rbsubitracao.TabStop = true;
            this.rbsubitracao.Text = "Subtração";
            this.rbsubitracao.UseVisualStyleBackColor = true;
            // 
            // rbsoma
            // 
            this.rbsoma.AutoSize = true;
            this.rbsoma.Location = new System.Drawing.Point(17, 31);
            this.rbsoma.Name = "rbsoma";
            this.rbsoma.Size = new System.Drawing.Size(52, 17);
            this.rbsoma.TabIndex = 0;
            this.rbsoma.TabStop = true;
            this.rbsoma.Text = "Soma";
            this.rbsoma.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.rbdificil);
            this.groupBox2.Controls.Add(this.rbfacil);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Location = new System.Drawing.Point(73, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(139, 63);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nivel";
            // 
            // rbdificil
            // 
            this.rbdificil.AutoSize = true;
            this.rbdificil.Location = new System.Drawing.Point(80, 31);
            this.rbdificil.Name = "rbdificil";
            this.rbdificil.Size = new System.Drawing.Size(52, 17);
            this.rbdificil.TabIndex = 1;
            this.rbdificil.TabStop = true;
            this.rbdificil.Text = "Difícil";
            this.rbdificil.UseVisualStyleBackColor = true;
            // 
            // rbfacil
            // 
            this.rbfacil.AutoSize = true;
            this.rbfacil.Location = new System.Drawing.Point(18, 31);
            this.rbfacil.Name = "rbfacil";
            this.rbfacil.Size = new System.Drawing.Size(47, 17);
            this.rbfacil.TabIndex = 0;
            this.rbfacil.TabStop = true;
            this.rbfacil.Text = "Fácil";
            this.rbfacil.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.Location = new System.Drawing.Point(43, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FRMConf_jogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Jogo.Properties.Resources.video_game_background_1405076_960_720;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FRMConf_jogo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipo de Jogo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbmultiplicacao;
        private System.Windows.Forms.RadioButton rbdivisao;
        private System.Windows.Forms.RadioButton rbsubitracao;
        private System.Windows.Forms.RadioButton rbsoma;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbdificil;
        private System.Windows.Forms.RadioButton rbfacil;
        private System.Windows.Forms.Button button1;
    }
}