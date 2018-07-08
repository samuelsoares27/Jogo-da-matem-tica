namespace Jogo
{
    partial class FRMJogo
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbnivel = new System.Windows.Forms.Label();
            this.lbponto = new System.Windows.Forms.Label();
            this.lbtxtpontos = new System.Windows.Forms.Label();
            this.lbtxtop = new System.Windows.Forms.Label();
            this.lbnome = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbop = new System.Windows.Forms.Label();
            this.lbval2 = new System.Windows.Forms.Label();
            this.lbval1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btconfirmar = new System.Windows.Forms.Button();
            this.lbtime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbresp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.Controls.Add(this.lbnivel);
            this.panel1.Controls.Add(this.lbponto);
            this.panel1.Controls.Add(this.lbtxtpontos);
            this.panel1.Controls.Add(this.lbtxtop);
            this.panel1.Controls.Add(this.lbnome);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 79);
            this.panel1.TabIndex = 0;
            // 
            // lbnivel
            // 
            this.lbnivel.AutoSize = true;
            this.lbnivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnivel.Location = new System.Drawing.Point(14, 33);
            this.lbnivel.Name = "lbnivel";
            this.lbnivel.Size = new System.Drawing.Size(48, 16);
            this.lbnivel.TabIndex = 4;
            this.lbnivel.Text = "Nível:";
            // 
            // lbponto
            // 
            this.lbponto.AutoSize = true;
            this.lbponto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbponto.ForeColor = System.Drawing.Color.Crimson;
            this.lbponto.Location = new System.Drawing.Point(258, 37);
            this.lbponto.Name = "lbponto";
            this.lbponto.Size = new System.Drawing.Size(25, 25);
            this.lbponto.TabIndex = 3;
            this.lbponto.Text = "0";
            // 
            // lbtxtpontos
            // 
            this.lbtxtpontos.AutoSize = true;
            this.lbtxtpontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtxtpontos.Location = new System.Drawing.Point(242, 18);
            this.lbtxtpontos.Name = "lbtxtpontos";
            this.lbtxtpontos.Size = new System.Drawing.Size(56, 16);
            this.lbtxtpontos.TabIndex = 2;
            this.lbtxtpontos.Text = "Pontos";
            // 
            // lbtxtop
            // 
            this.lbtxtop.AutoSize = true;
            this.lbtxtop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtxtop.Location = new System.Drawing.Point(13, 55);
            this.lbtxtop.Name = "lbtxtop";
            this.lbtxtop.Size = new System.Drawing.Size(81, 16);
            this.lbtxtop.TabIndex = 1;
            this.lbtxtop.Text = "Operação:";
            // 
            // lbnome
            // 
            this.lbnome.AutoSize = true;
            this.lbnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnome.Location = new System.Drawing.Point(13, 8);
            this.lbnome.Name = "lbnome";
            this.lbnome.Size = new System.Drawing.Size(53, 16);
            this.lbnome.TabIndex = 0;
            this.lbnome.Text = "Nome:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.lbop);
            this.panel2.Controls.Add(this.lbval2);
            this.panel2.Controls.Add(this.lbval1);
            this.panel2.Location = new System.Drawing.Point(67, 137);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(178, 55);
            this.panel2.TabIndex = 1;
            // 
            // lbop
            // 
            this.lbop.AutoSize = true;
            this.lbop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbop.ForeColor = System.Drawing.SystemColors.Window;
            this.lbop.Location = new System.Drawing.Point(77, 16);
            this.lbop.Name = "lbop";
            this.lbop.Size = new System.Drawing.Size(25, 25);
            this.lbop.TabIndex = 4;
            this.lbop.Text = "+";
            // 
            // lbval2
            // 
            this.lbval2.AutoSize = true;
            this.lbval2.BackColor = System.Drawing.SystemColors.ControlText;
            this.lbval2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbval2.ForeColor = System.Drawing.SystemColors.Window;
            this.lbval2.Location = new System.Drawing.Point(119, 16);
            this.lbval2.Name = "lbval2";
            this.lbval2.Size = new System.Drawing.Size(25, 25);
            this.lbval2.TabIndex = 3;
            this.lbval2.Text = "0";
            // 
            // lbval1
            // 
            this.lbval1.AutoSize = true;
            this.lbval1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbval1.ForeColor = System.Drawing.SystemColors.Window;
            this.lbval1.Location = new System.Drawing.Point(34, 16);
            this.lbval1.Name = "lbval1";
            this.lbval1.Size = new System.Drawing.Size(25, 25);
            this.lbval1.TabIndex = 2;
            this.lbval1.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(80, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Resolva o problema:";
            // 
            // btconfirmar
            // 
            this.btconfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btconfirmar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btconfirmar.Location = new System.Drawing.Point(67, 229);
            this.btconfirmar.Name = "btconfirmar";
            this.btconfirmar.Size = new System.Drawing.Size(178, 34);
            this.btconfirmar.TabIndex = 3;
            this.btconfirmar.Text = "Confirmar";
            this.btconfirmar.UseVisualStyleBackColor = true;
            this.btconfirmar.Click += new System.EventHandler(this.btconfirmar_Click);
            // 
            // lbtime
            // 
            this.lbtime.AutoSize = true;
            this.lbtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtime.Location = new System.Drawing.Point(124, 91);
            this.lbtime.Name = "lbtime";
            this.lbtime.Size = new System.Drawing.Size(63, 15);
            this.lbtime.TabIndex = 5;
            this.lbtime.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tbresp
            // 
            this.tbresp.Location = new System.Drawing.Point(120, 198);
            this.tbresp.Name = "tbresp";
            this.tbresp.Size = new System.Drawing.Size(125, 20);
            this.tbresp.TabIndex = 6;
            this.tbresp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbresp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbresp_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(64, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Resposta:";
            // 
            // FRMJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Jogo.Properties.Resources.video_game_background_1405076_960_720;
            this.ClientSize = new System.Drawing.Size(310, 279);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbresp);
            this.Controls.Add(this.lbtime);
            this.Controls.Add(this.btconfirmar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "FRMJogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo";
            this.Load += new System.EventHandler(this.Jogo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbtxtop;
        private System.Windows.Forms.Label lbnome;
        private System.Windows.Forms.Label lbponto;
        private System.Windows.Forms.Label lbtxtpontos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbop;
        private System.Windows.Forms.Label lbval2;
        private System.Windows.Forms.Label lbval1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btconfirmar;
        private System.Windows.Forms.Label lbnivel;
        private System.Windows.Forms.Label lbtime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox tbresp;
        private System.Windows.Forms.Label label1;

    }
}