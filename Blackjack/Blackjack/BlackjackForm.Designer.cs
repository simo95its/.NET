namespace Blackjack
{
    partial class BlackjackForm
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
            this.DealerLabel = new System.Windows.Forms.Label();
            this.DealerCardsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.PlayerLabel = new System.Windows.Forms.Label();
            this.PlayerCardsFlowLayoutpanel = new System.Windows.Forms.FlowLayoutPanel();
            this.StartButton = new System.Windows.Forms.Button();
            this.DoubleDownButton = new System.Windows.Forms.Button();
            this.SplitButton = new System.Windows.Forms.Button();
            this.InsuranceButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DealerLabel
            // 
            this.DealerLabel.AutoSize = true;
            this.DealerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DealerLabel.Location = new System.Drawing.Point(13, 13);
            this.DealerLabel.Name = "DealerLabel";
            this.DealerLabel.Size = new System.Drawing.Size(75, 25);
            this.DealerLabel.TabIndex = 0;
            this.DealerLabel.Text = "Dealer";
            // 
            // DealerCardsFlowLayoutPanel
            // 
            this.DealerCardsFlowLayoutPanel.Location = new System.Drawing.Point(18, 42);
            this.DealerCardsFlowLayoutPanel.Name = "DealerCardsFlowLayoutPanel";
            this.DealerCardsFlowLayoutPanel.Size = new System.Drawing.Size(814, 100);
            this.DealerCardsFlowLayoutPanel.TabIndex = 1;
            // 
            // PlayerLabel
            // 
            this.PlayerLabel.AutoSize = true;
            this.PlayerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerLabel.Location = new System.Drawing.Point(13, 149);
            this.PlayerLabel.Name = "PlayerLabel";
            this.PlayerLabel.Size = new System.Drawing.Size(73, 25);
            this.PlayerLabel.TabIndex = 2;
            this.PlayerLabel.Text = "Player";
            // 
            // PlayerCardsFlowLayoutpanel
            // 
            this.PlayerCardsFlowLayoutpanel.Location = new System.Drawing.Point(18, 178);
            this.PlayerCardsFlowLayoutpanel.Name = "PlayerCardsFlowLayoutpanel";
            this.PlayerCardsFlowLayoutpanel.Size = new System.Drawing.Size(814, 100);
            this.PlayerCardsFlowLayoutpanel.TabIndex = 3;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(18, 285);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 4;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            // 
            // DoubleDownButton
            // 
            this.DoubleDownButton.Location = new System.Drawing.Point(18, 315);
            this.DoubleDownButton.Name = "DoubleDownButton";
            this.DoubleDownButton.Size = new System.Drawing.Size(75, 23);
            this.DoubleDownButton.TabIndex = 5;
            this.DoubleDownButton.Text = "Double Down";
            this.DoubleDownButton.UseVisualStyleBackColor = true;
            // 
            // SplitButton
            // 
            this.SplitButton.Location = new System.Drawing.Point(18, 345);
            this.SplitButton.Name = "SplitButton";
            this.SplitButton.Size = new System.Drawing.Size(75, 23);
            this.SplitButton.TabIndex = 6;
            this.SplitButton.Text = "Split";
            this.SplitButton.UseVisualStyleBackColor = true;
            // 
            // InsuranceButton
            // 
            this.InsuranceButton.Location = new System.Drawing.Point(18, 375);
            this.InsuranceButton.Name = "InsuranceButton";
            this.InsuranceButton.Size = new System.Drawing.Size(75, 23);
            this.InsuranceButton.TabIndex = 7;
            this.InsuranceButton.Text = "Insurance";
            this.InsuranceButton.UseVisualStyleBackColor = true;
            // 
            // BlackjackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(848, 496);
            this.Controls.Add(this.InsuranceButton);
            this.Controls.Add(this.SplitButton);
            this.Controls.Add(this.DoubleDownButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.PlayerCardsFlowLayoutpanel);
            this.Controls.Add(this.PlayerLabel);
            this.Controls.Add(this.DealerCardsFlowLayoutPanel);
            this.Controls.Add(this.DealerLabel);
            this.Name = "BlackjackForm";
            this.Text = "Blackjack";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DealerLabel;
        private System.Windows.Forms.FlowLayoutPanel DealerCardsFlowLayoutPanel;
        private System.Windows.Forms.Label PlayerLabel;
        private System.Windows.Forms.FlowLayoutPanel PlayerCardsFlowLayoutpanel;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button DoubleDownButton;
        private System.Windows.Forms.Button SplitButton;
        private System.Windows.Forms.Button InsuranceButton;
    }
}

