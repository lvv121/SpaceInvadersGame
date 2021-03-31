namespace Projekt
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.heart1 = new System.Windows.Forms.PictureBox();
            this.heart2 = new System.Windows.Forms.PictureBox();
            this.heart3 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.manLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.heart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // textScore
            // 
            this.textScore.AutoSize = true;
            this.textScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textScore.ForeColor = System.Drawing.Color.White;
            this.textScore.Location = new System.Drawing.Point(12, 525);
            this.textScore.Name = "textScore";
            this.textScore.Size = new System.Drawing.Size(89, 24);
            this.textScore.TabIndex = 1;
            this.textScore.Text = "Wynik: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(482, 525);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Życia: ";
            // 
            // heart1
            // 
            this.heart1.Image = global::Projekt.Properties.Resources.heart;
            this.heart1.Location = new System.Drawing.Point(560, 521);
            this.heart1.Name = "heart1";
            this.heart1.Size = new System.Drawing.Size(50, 28);
            this.heart1.TabIndex = 5;
            this.heart1.TabStop = false;
            // 
            // heart2
            // 
            this.heart2.Image = global::Projekt.Properties.Resources.heart;
            this.heart2.Location = new System.Drawing.Point(616, 521);
            this.heart2.Name = "heart2";
            this.heart2.Size = new System.Drawing.Size(50, 28);
            this.heart2.TabIndex = 4;
            this.heart2.TabStop = false;
            // 
            // heart3
            // 
            this.heart3.Image = global::Projekt.Properties.Resources.heart;
            this.heart3.Location = new System.Drawing.Point(672, 521);
            this.heart3.Name = "heart3";
            this.heart3.Size = new System.Drawing.Size(50, 28);
            this.heart3.TabIndex = 2;
            this.heart3.TabStop = false;
            // 
            // player
            // 
            this.player.Image = global::Projekt.Properties.Resources._1;
            this.player.Location = new System.Drawing.Point(302, 455);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(100, 94);
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // manLabel
            // 
            this.manLabel.AutoSize = true;
            this.manLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.manLabel.Location = new System.Drawing.Point(12, 111);
            this.manLabel.Name = "manLabel";
            this.manLabel.Size = new System.Drawing.Size(88, 20);
            this.manLabel.TabIndex = 7;
            this.manLabel.Text = "Instrukcja";
            this.manLabel.Click += new System.EventHandler(this.manLabelClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(734, 561);
            this.Controls.Add(this.manLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.heart1);
            this.Controls.Add(this.heart2);
            this.Controls.Add(this.heart3);
            this.Controls.Add(this.player);
            this.Controls.Add(this.textScore);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyUp);
            ((System.ComponentModel.ISupportInitialize)(this.heart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Label textScore;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox heart3;
        private System.Windows.Forms.PictureBox heart2;
        private System.Windows.Forms.PictureBox heart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label manLabel;
    }
}

