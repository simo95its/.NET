namespace MineSweeper
{
    partial class LevelForm
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.beginnerButton = new System.Windows.Forms.Button();
            this.intermediateButton = new System.Windows.Forms.Button();
            this.expertButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // beginnerButton
            // 
            this.beginnerButton.Location = new System.Drawing.Point(10, 10);
            this.beginnerButton.Name = "beginnerButton";
            this.beginnerButton.Size = new System.Drawing.Size(260, 70);
            this.beginnerButton.TabIndex = 0;
            this.beginnerButton.Text = "Beginner";
            this.beginnerButton.UseVisualStyleBackColor = true;
            this.beginnerButton.Click += new System.EventHandler(this.beginnerButton_Click);
            // 
            // intermediateButton
            // 
            this.intermediateButton.Location = new System.Drawing.Point(10, 90);
            this.intermediateButton.Name = "intermediateButton";
            this.intermediateButton.Size = new System.Drawing.Size(260, 70);
            this.intermediateButton.TabIndex = 1;
            this.intermediateButton.Text = "Intermediate";
            this.intermediateButton.UseVisualStyleBackColor = true;
            this.intermediateButton.Click += new System.EventHandler(this.intermediateButton_Click);
            // 
            // expertButton
            // 
            this.expertButton.Location = new System.Drawing.Point(10, 170);
            this.expertButton.Name = "expertButton";
            this.expertButton.Size = new System.Drawing.Size(260, 70);
            this.expertButton.TabIndex = 2;
            this.expertButton.Text = "Expert";
            this.expertButton.UseVisualStyleBackColor = true;
            this.expertButton.Click += new System.EventHandler(this.expertButton_Click);
            // 
            // LevelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.expertButton);
            this.Controls.Add(this.intermediateButton);
            this.Controls.Add(this.beginnerButton);
            this.Name = "LevelForm";
            this.Text = "MineSweeper";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button beginnerButton;
        private System.Windows.Forms.Button intermediateButton;
        private System.Windows.Forms.Button expertButton;
    }
}

