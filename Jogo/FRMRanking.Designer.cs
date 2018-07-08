namespace Jogo
{
    partial class FRMRanking
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
            this.lblist = new System.Windows.Forms.ListBox();
            this.btvoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblist
            // 
            this.lblist.FormattingEnabled = true;
            this.lblist.Location = new System.Drawing.Point(18, 13);
            this.lblist.Name = "lblist";
            this.lblist.Size = new System.Drawing.Size(250, 173);
            this.lblist.TabIndex = 0;
            // 
            // btvoltar
            // 
            this.btvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btvoltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btvoltar.Location = new System.Drawing.Point(18, 204);
            this.btvoltar.Name = "btvoltar";
            this.btvoltar.Size = new System.Drawing.Size(250, 39);
            this.btvoltar.TabIndex = 1;
            this.btvoltar.Text = "Voltar ao Menu";
            this.btvoltar.UseVisualStyleBackColor = true;
            this.btvoltar.Click += new System.EventHandler(this.btvoltar_Click);
            // 
            // FRMRanking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Jogo.Properties.Resources.video_game_background_1405076_960_720;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btvoltar);
            this.Controls.Add(this.lblist);
            this.MaximizeBox = false;
            this.Name = "FRMRanking";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ranking";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lblist;
        private System.Windows.Forms.Button btvoltar;
    }
}