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
            this.StandButton = new System.Windows.Forms.Button();
            this.HitButton = new System.Windows.Forms.Button();
            this.ScoreButton = new System.Windows.Forms.Button();
            this.PlayerPointLabel = new System.Windows.Forms.Label();
            this.DealerPointLabel = new System.Windows.Forms.Label();
            this.PlayerSplitLabel = new System.Windows.Forms.Label();
            this.PlayerSplitPointLabel = new System.Windows.Forms.Label();
            this.PlayerSplitFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.CashLabel = new System.Windows.Forms.Label();
            this.CashTextBox = new System.Windows.Forms.TextBox();
            this.BetLabel = new System.Windows.Forms.Label();
            this.BetTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DealerLabel
            // 
            this.DealerLabel.AutoSize = true;
            this.DealerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DealerLabel.Location = new System.Drawing.Point(15, 13);
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
            this.PlayerLabel.Location = new System.Drawing.Point(15, 145);
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
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(18, 423);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(200, 60);
            this.StartButton.TabIndex = 4;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Visible = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // DoubleDownButton
            // 
            this.DoubleDownButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoubleDownButton.Location = new System.Drawing.Point(224, 423);
            this.DoubleDownButton.Name = "DoubleDownButton";
            this.DoubleDownButton.Size = new System.Drawing.Size(170, 60);
            this.DoubleDownButton.TabIndex = 5;
            this.DoubleDownButton.Text = "Double Down";
            this.DoubleDownButton.UseVisualStyleBackColor = true;
            this.DoubleDownButton.Visible = false;
            // 
            // SplitButton
            // 
            this.SplitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SplitButton.Location = new System.Drawing.Point(400, 489);
            this.SplitButton.Name = "SplitButton";
            this.SplitButton.Size = new System.Drawing.Size(200, 60);
            this.SplitButton.TabIndex = 6;
            this.SplitButton.Text = "Split";
            this.SplitButton.UseVisualStyleBackColor = true;
            this.SplitButton.Visible = false;
            // 
            // InsuranceButton
            // 
            this.InsuranceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsuranceButton.Location = new System.Drawing.Point(224, 489);
            this.InsuranceButton.Name = "InsuranceButton";
            this.InsuranceButton.Size = new System.Drawing.Size(170, 60);
            this.InsuranceButton.TabIndex = 7;
            this.InsuranceButton.Text = "Insurance";
            this.InsuranceButton.UseVisualStyleBackColor = true;
            this.InsuranceButton.Visible = false;
            // 
            // StandButton
            // 
            this.StandButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StandButton.Location = new System.Drawing.Point(400, 423);
            this.StandButton.Name = "StandButton";
            this.StandButton.Size = new System.Drawing.Size(95, 60);
            this.StandButton.TabIndex = 8;
            this.StandButton.Text = "Stand";
            this.StandButton.UseVisualStyleBackColor = true;
            this.StandButton.Visible = false;
            this.StandButton.Click += new System.EventHandler(this.StandButton_Click);
            // 
            // HitButton
            // 
            this.HitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HitButton.Location = new System.Drawing.Point(505, 423);
            this.HitButton.Name = "HitButton";
            this.HitButton.Size = new System.Drawing.Size(95, 60);
            this.HitButton.TabIndex = 9;
            this.HitButton.Text = "Hit";
            this.HitButton.UseVisualStyleBackColor = true;
            this.HitButton.Visible = false;
            this.HitButton.Click += new System.EventHandler(this.HitButton_Click);
            // 
            // ScoreButton
            // 
            this.ScoreButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreButton.Location = new System.Drawing.Point(18, 489);
            this.ScoreButton.Name = "ScoreButton";
            this.ScoreButton.Size = new System.Drawing.Size(200, 60);
            this.ScoreButton.TabIndex = 10;
            this.ScoreButton.Text = "Score";
            this.ScoreButton.UseVisualStyleBackColor = true;
            this.ScoreButton.Click += new System.EventHandler(this.ScoreButton_Click);
            // 
            // PlayerPointLabel
            // 
            this.PlayerPointLabel.AutoSize = true;
            this.PlayerPointLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerPointLabel.Location = new System.Drawing.Point(808, 145);
            this.PlayerPointLabel.Name = "PlayerPointLabel";
            this.PlayerPointLabel.Size = new System.Drawing.Size(24, 25);
            this.PlayerPointLabel.TabIndex = 11;
            this.PlayerPointLabel.Text = "0";
            this.PlayerPointLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // DealerPointLabel
            // 
            this.DealerPointLabel.AutoSize = true;
            this.DealerPointLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DealerPointLabel.Location = new System.Drawing.Point(808, 13);
            this.DealerPointLabel.Name = "DealerPointLabel";
            this.DealerPointLabel.Size = new System.Drawing.Size(24, 25);
            this.DealerPointLabel.TabIndex = 12;
            this.DealerPointLabel.Text = "0";
            this.DealerPointLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // PlayerSplitLabel
            // 
            this.PlayerSplitLabel.AutoSize = true;
            this.PlayerSplitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerSplitLabel.Location = new System.Drawing.Point(15, 281);
            this.PlayerSplitLabel.Name = "PlayerSplitLabel";
            this.PlayerSplitLabel.Size = new System.Drawing.Size(122, 25);
            this.PlayerSplitLabel.TabIndex = 13;
            this.PlayerSplitLabel.Text = "Player Split";
            this.PlayerSplitLabel.Visible = false;
            // 
            // PlayerSplitPointLabel
            // 
            this.PlayerSplitPointLabel.AutoSize = true;
            this.PlayerSplitPointLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerSplitPointLabel.Location = new System.Drawing.Point(808, 281);
            this.PlayerSplitPointLabel.Name = "PlayerSplitPointLabel";
            this.PlayerSplitPointLabel.Size = new System.Drawing.Size(24, 25);
            this.PlayerSplitPointLabel.TabIndex = 14;
            this.PlayerSplitPointLabel.Text = "0";
            this.PlayerSplitPointLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.PlayerSplitPointLabel.Visible = false;
            // 
            // PlayerSplitFlowLayoutPanel
            // 
            this.PlayerSplitFlowLayoutPanel.Location = new System.Drawing.Point(18, 309);
            this.PlayerSplitFlowLayoutPanel.Name = "PlayerSplitFlowLayoutPanel";
            this.PlayerSplitFlowLayoutPanel.Size = new System.Drawing.Size(814, 100);
            this.PlayerSplitFlowLayoutPanel.TabIndex = 15;
            this.PlayerSplitFlowLayoutPanel.Visible = false;
            // 
            // CashLabel
            // 
            this.CashLabel.AutoSize = true;
            this.CashLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashLabel.Location = new System.Drawing.Point(607, 423);
            this.CashLabel.Name = "CashLabel";
            this.CashLabel.Size = new System.Drawing.Size(70, 25);
            this.CashLabel.TabIndex = 16;
            this.CashLabel.Text = "Cash: ";
            // 
            // CashTextBox
            // 
            this.CashTextBox.Location = new System.Drawing.Point(610, 463);
            this.CashTextBox.MaxLength = 10;
            this.CashTextBox.Name = "CashTextBox";
            this.CashTextBox.Size = new System.Drawing.Size(222, 20);
            this.CashTextBox.TabIndex = 17;
            this.CashTextBox.Text = "Insert your cash...";
            this.CashTextBox.Click += new System.EventHandler(this.CashTextBox_Click);
            this.CashTextBox.TextChanged += new System.EventHandler(this.CashTextBox_TextChanged);
            // 
            // BetLabel
            // 
            this.BetLabel.AutoSize = true;
            this.BetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BetLabel.Location = new System.Drawing.Point(607, 489);
            this.BetLabel.Name = "BetLabel";
            this.BetLabel.Size = new System.Drawing.Size(52, 25);
            this.BetLabel.TabIndex = 18;
            this.BetLabel.Text = "Bet: ";
            this.BetLabel.Visible = false;
            // 
            // BetTextBox
            // 
            this.BetTextBox.Location = new System.Drawing.Point(610, 529);
            this.BetTextBox.MaxLength = 10;
            this.BetTextBox.Name = "BetTextBox";
            this.BetTextBox.Size = new System.Drawing.Size(222, 20);
            this.BetTextBox.TabIndex = 19;
            this.BetTextBox.Text = "Insert your bet...";
            this.BetTextBox.Visible = false;
            this.BetTextBox.Click += new System.EventHandler(this.BetTextBox_Click);
            this.BetTextBox.TextChanged += new System.EventHandler(this.BetTextBox_TextChanged);
            // 
            // BlackjackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(849, 561);
            this.Controls.Add(this.BetTextBox);
            this.Controls.Add(this.BetLabel);
            this.Controls.Add(this.CashTextBox);
            this.Controls.Add(this.CashLabel);
            this.Controls.Add(this.PlayerSplitFlowLayoutPanel);
            this.Controls.Add(this.PlayerSplitPointLabel);
            this.Controls.Add(this.PlayerSplitLabel);
            this.Controls.Add(this.DealerPointLabel);
            this.Controls.Add(this.PlayerPointLabel);
            this.Controls.Add(this.ScoreButton);
            this.Controls.Add(this.HitButton);
            this.Controls.Add(this.StandButton);
            this.Controls.Add(this.InsuranceButton);
            this.Controls.Add(this.SplitButton);
            this.Controls.Add(this.DoubleDownButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.PlayerCardsFlowLayoutpanel);
            this.Controls.Add(this.PlayerLabel);
            this.Controls.Add(this.DealerCardsFlowLayoutPanel);
            this.Controls.Add(this.DealerLabel);
            this.Name = "BlackjackForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blackjack";
            this.Load += new System.EventHandler(this.BlackjackForm_Load);
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
        private System.Windows.Forms.Button StandButton;
        private System.Windows.Forms.Button HitButton;
        private System.Windows.Forms.Button ScoreButton;
        private System.Windows.Forms.Label PlayerPointLabel;
        private System.Windows.Forms.Label DealerPointLabel;
        private System.Windows.Forms.Label PlayerSplitLabel;
        private System.Windows.Forms.Label PlayerSplitPointLabel;
        private System.Windows.Forms.FlowLayoutPanel PlayerSplitFlowLayoutPanel;
        private System.Windows.Forms.Label CashLabel;
        private System.Windows.Forms.TextBox CashTextBox;
        private System.Windows.Forms.Label BetLabel;
        private System.Windows.Forms.TextBox BetTextBox;
    }
}

