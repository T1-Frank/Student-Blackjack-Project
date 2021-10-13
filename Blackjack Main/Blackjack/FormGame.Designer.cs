namespace Blackjack {
    partial class FormGame {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame));
            this.configurationGroupBox = new System.Windows.Forms.GroupBox();
            this.allowUnnaturalSplitsCheckBox = new System.Windows.Forms.CheckBox();
            this.blackjackPayoutNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.blackjackPayoutLabel = new System.Windows.Forms.Label();
            this.deckNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.decksLabel = new System.Windows.Forms.Label();
            this.bankGroupBox = new System.Windows.Forms.GroupBox();
            this.lblLosses = new System.Windows.Forms.Label();
            this.lblTies = new System.Windows.Forms.Label();
            this.lblWins = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.bankrollTextBox = new System.Windows.Forms.TextBox();
            this.dealButton = new System.Windows.Forms.Button();
            this.bankrollLabel = new System.Windows.Forms.Label();
            this.betAmountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.betAmountLabel = new System.Windows.Forms.Label();
            this.doubleButton = new System.Windows.Forms.Button();
            this.splitButton = new System.Windows.Forms.Button();
            this.standButton = new System.Windows.Forms.Button();
            this.hitButton = new System.Windows.Forms.Button();
            this.playerHandPanel4 = new Blackjack.BlackjackHandPanel();
            this.playerHandPanel3 = new Blackjack.BlackjackHandPanel();
            this.playerHandPanel1 = new Blackjack.BlackjackHandPanel();
            this.playerHandPanel2 = new Blackjack.BlackjackHandPanel();
            this.dealerHandPanel = new Blackjack.BlackjackHandPanel();
            this.configurationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blackjackPayoutNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deckNumericUpDown)).BeginInit();
            this.bankGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.betAmountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // configurationGroupBox
            // 
            this.configurationGroupBox.BackColor = System.Drawing.Color.SeaGreen;
            this.configurationGroupBox.Controls.Add(this.allowUnnaturalSplitsCheckBox);
            this.configurationGroupBox.Controls.Add(this.blackjackPayoutNumericUpDown);
            this.configurationGroupBox.Controls.Add(this.blackjackPayoutLabel);
            this.configurationGroupBox.Controls.Add(this.deckNumericUpDown);
            this.configurationGroupBox.Controls.Add(this.decksLabel);
            this.configurationGroupBox.ForeColor = System.Drawing.Color.Yellow;
            this.configurationGroupBox.Location = new System.Drawing.Point(905, 22);
            this.configurationGroupBox.Name = "configurationGroupBox";
            this.configurationGroupBox.Size = new System.Drawing.Size(178, 99);
            this.configurationGroupBox.TabIndex = 16;
            this.configurationGroupBox.TabStop = false;
            this.configurationGroupBox.Text = "Configuration";
            // 
            // allowUnnaturalSplitsCheckBox
            // 
            this.allowUnnaturalSplitsCheckBox.AutoSize = true;
            this.allowUnnaturalSplitsCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.allowUnnaturalSplitsCheckBox.Location = new System.Drawing.Point(38, 71);
            this.allowUnnaturalSplitsCheckBox.Name = "allowUnnaturalSplitsCheckBox";
            this.allowUnnaturalSplitsCheckBox.Size = new System.Drawing.Size(128, 17);
            this.allowUnnaturalSplitsCheckBox.TabIndex = 8;
            this.allowUnnaturalSplitsCheckBox.Text = "Allow Unnatural Splits";
            this.allowUnnaturalSplitsCheckBox.UseVisualStyleBackColor = false;
            // 
            // blackjackPayoutNumericUpDown
            // 
            this.blackjackPayoutNumericUpDown.DecimalPlaces = 2;
            this.blackjackPayoutNumericUpDown.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.blackjackPayoutNumericUpDown.Location = new System.Drawing.Point(111, 45);
            this.blackjackPayoutNumericUpDown.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            65536});
            this.blackjackPayoutNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.blackjackPayoutNumericUpDown.Name = "blackjackPayoutNumericUpDown";
            this.blackjackPayoutNumericUpDown.Size = new System.Drawing.Size(55, 20);
            this.blackjackPayoutNumericUpDown.TabIndex = 7;
            this.blackjackPayoutNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.blackjackPayoutNumericUpDown.Value = new decimal(new int[] {
            15,
            0,
            0,
            65536});
            // 
            // blackjackPayoutLabel
            // 
            this.blackjackPayoutLabel.AutoSize = true;
            this.blackjackPayoutLabel.BackColor = System.Drawing.Color.Transparent;
            this.blackjackPayoutLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.blackjackPayoutLabel.Location = new System.Drawing.Point(24, 47);
            this.blackjackPayoutLabel.Name = "blackjackPayoutLabel";
            this.blackjackPayoutLabel.Size = new System.Drawing.Size(83, 13);
            this.blackjackPayoutLabel.TabIndex = 6;
            this.blackjackPayoutLabel.Text = "Blackjack Pays:";
            // 
            // deckNumericUpDown
            // 
            this.deckNumericUpDown.Location = new System.Drawing.Point(111, 19);
            this.deckNumericUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.deckNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.deckNumericUpDown.Name = "deckNumericUpDown";
            this.deckNumericUpDown.Size = new System.Drawing.Size(55, 20);
            this.deckNumericUpDown.TabIndex = 5;
            this.deckNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.deckNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // decksLabel
            // 
            this.decksLabel.AutoSize = true;
            this.decksLabel.BackColor = System.Drawing.Color.Transparent;
            this.decksLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.decksLabel.Location = new System.Drawing.Point(64, 21);
            this.decksLabel.Name = "decksLabel";
            this.decksLabel.Size = new System.Drawing.Size(41, 13);
            this.decksLabel.TabIndex = 4;
            this.decksLabel.Text = "Decks:";
            // 
            // bankGroupBox
            // 
            this.bankGroupBox.BackColor = System.Drawing.Color.SeaGreen;
            this.bankGroupBox.Controls.Add(this.lblLosses);
            this.bankGroupBox.Controls.Add(this.lblTies);
            this.bankGroupBox.Controls.Add(this.lblWins);
            this.bankGroupBox.Controls.Add(this.btnExit);
            this.bankGroupBox.Controls.Add(this.resultsLabel);
            this.bankGroupBox.Controls.Add(this.bankrollTextBox);
            this.bankGroupBox.Controls.Add(this.dealButton);
            this.bankGroupBox.Controls.Add(this.bankrollLabel);
            this.bankGroupBox.Controls.Add(this.betAmountNumericUpDown);
            this.bankGroupBox.Controls.Add(this.betAmountLabel);
            this.bankGroupBox.ForeColor = System.Drawing.Color.Yellow;
            this.bankGroupBox.Location = new System.Drawing.Point(42, 22);
            this.bankGroupBox.Name = "bankGroupBox";
            this.bankGroupBox.Size = new System.Drawing.Size(200, 224);
            this.bankGroupBox.TabIndex = 17;
            this.bankGroupBox.TabStop = false;
            this.bankGroupBox.Text = "Player Bank";
            // 
            // lblLosses
            // 
            this.lblLosses.BackColor = System.Drawing.Color.Transparent;
            this.lblLosses.Location = new System.Drawing.Point(22, 170);
            this.lblLosses.Name = "lblLosses";
            this.lblLosses.Size = new System.Drawing.Size(160, 20);
            this.lblLosses.TabIndex = 11;
            this.lblLosses.Text = "Losses: 0";
            this.lblLosses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTies
            // 
            this.lblTies.BackColor = System.Drawing.Color.Transparent;
            this.lblTies.Location = new System.Drawing.Point(22, 143);
            this.lblTies.Name = "lblTies";
            this.lblTies.Size = new System.Drawing.Size(160, 20);
            this.lblTies.TabIndex = 10;
            this.lblTies.Text = "Ties: 0";
            this.lblTies.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWins
            // 
            this.lblWins.BackColor = System.Drawing.Color.Transparent;
            this.lblWins.Location = new System.Drawing.Point(22, 115);
            this.lblWins.Name = "lblWins";
            this.lblWins.Size = new System.Drawing.Size(160, 20);
            this.lblWins.TabIndex = 9;
            this.lblWins.Text = "Wins: 0";
            this.lblWins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(107, 76);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Quit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // resultsLabel
            // 
            this.resultsLabel.BackColor = System.Drawing.Color.Transparent;
            this.resultsLabel.Location = new System.Drawing.Point(22, 195);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(160, 20);
            this.resultsLabel.TabIndex = 7;
            this.resultsLabel.Text = "You won $x";
            this.resultsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bankrollTextBox
            // 
            this.bankrollTextBox.Location = new System.Drawing.Point(90, 19);
            this.bankrollTextBox.Name = "bankrollTextBox";
            this.bankrollTextBox.ReadOnly = true;
            this.bankrollTextBox.Size = new System.Drawing.Size(77, 20);
            this.bankrollTextBox.TabIndex = 3;
            this.bankrollTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dealButton
            // 
            this.dealButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dealButton.Location = new System.Drawing.Point(12, 76);
            this.dealButton.Name = "dealButton";
            this.dealButton.Size = new System.Drawing.Size(75, 23);
            this.dealButton.TabIndex = 6;
            this.dealButton.Text = "Deal";
            this.dealButton.UseVisualStyleBackColor = true;
            this.dealButton.Click += new System.EventHandler(this.DealButtonClick);
            // 
            // bankrollLabel
            // 
            this.bankrollLabel.AutoSize = true;
            this.bankrollLabel.BackColor = System.Drawing.Color.Transparent;
            this.bankrollLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bankrollLabel.Location = new System.Drawing.Point(36, 22);
            this.bankrollLabel.Name = "bankrollLabel";
            this.bankrollLabel.Size = new System.Drawing.Size(48, 13);
            this.bankrollLabel.TabIndex = 2;
            this.bankrollLabel.Text = "Bankroll:";
            // 
            // betAmountNumericUpDown
            // 
            this.betAmountNumericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.betAmountNumericUpDown.Location = new System.Drawing.Point(90, 50);
            this.betAmountNumericUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.betAmountNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.betAmountNumericUpDown.Name = "betAmountNumericUpDown";
            this.betAmountNumericUpDown.Size = new System.Drawing.Size(77, 20);
            this.betAmountNumericUpDown.TabIndex = 5;
            this.betAmountNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.betAmountNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // betAmountLabel
            // 
            this.betAmountLabel.AutoSize = true;
            this.betAmountLabel.BackColor = System.Drawing.Color.Transparent;
            this.betAmountLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.betAmountLabel.Location = new System.Drawing.Point(22, 50);
            this.betAmountLabel.Name = "betAmountLabel";
            this.betAmountLabel.Size = new System.Drawing.Size(65, 13);
            this.betAmountLabel.TabIndex = 4;
            this.betAmountLabel.Text = "Bet Amount:";
            // 
            // doubleButton
            // 
            this.doubleButton.Enabled = false;
            this.doubleButton.Location = new System.Drawing.Point(646, 583);
            this.doubleButton.Name = "doubleButton";
            this.doubleButton.Size = new System.Drawing.Size(75, 23);
            this.doubleButton.TabIndex = 21;
            this.doubleButton.Text = "Double";
            this.doubleButton.UseVisualStyleBackColor = true;
            this.doubleButton.Click += new System.EventHandler(this.DoubleButtonClick);
            // 
            // splitButton
            // 
            this.splitButton.Enabled = false;
            this.splitButton.Location = new System.Drawing.Point(565, 583);
            this.splitButton.Name = "splitButton";
            this.splitButton.Size = new System.Drawing.Size(75, 23);
            this.splitButton.TabIndex = 20;
            this.splitButton.Text = "Split";
            this.splitButton.UseVisualStyleBackColor = true;
            this.splitButton.Click += new System.EventHandler(this.SplitButtonClick);
            // 
            // standButton
            // 
            this.standButton.Enabled = false;
            this.standButton.Location = new System.Drawing.Point(483, 583);
            this.standButton.Name = "standButton";
            this.standButton.Size = new System.Drawing.Size(75, 23);
            this.standButton.TabIndex = 19;
            this.standButton.Text = "Stand";
            this.standButton.UseVisualStyleBackColor = true;
            this.standButton.Click += new System.EventHandler(this.StandButtonClick);
            // 
            // hitButton
            // 
            this.hitButton.Enabled = false;
            this.hitButton.Location = new System.Drawing.Point(401, 583);
            this.hitButton.Name = "hitButton";
            this.hitButton.Size = new System.Drawing.Size(75, 23);
            this.hitButton.TabIndex = 18;
            this.hitButton.Text = "Hit";
            this.hitButton.UseVisualStyleBackColor = true;
            this.hitButton.Click += new System.EventHandler(this.HitButtonClick);
            // 
            // playerHandPanel4
            // 
            this.playerHandPanel4.BackColor = System.Drawing.Color.Transparent;
            this.playerHandPanel4.Cards = null;
            this.playerHandPanel4.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerHandPanel4.ForeColor = System.Drawing.Color.Yellow;
            this.playerHandPanel4.Hand = null;
            this.playerHandPanel4.Highlight = false;
            this.playerHandPanel4.Location = new System.Drawing.Point(882, 286);
            this.playerHandPanel4.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.playerHandPanel4.Name = "playerHandPanel4";
            this.playerHandPanel4.Size = new System.Drawing.Size(277, 140);
            this.playerHandPanel4.TabIndex = 26;
            // 
            // playerHandPanel3
            // 
            this.playerHandPanel3.BackColor = System.Drawing.Color.Transparent;
            this.playerHandPanel3.Cards = null;
            this.playerHandPanel3.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerHandPanel3.ForeColor = System.Drawing.Color.Yellow;
            this.playerHandPanel3.Hand = null;
            this.playerHandPanel3.Highlight = false;
            this.playerHandPanel3.Location = new System.Drawing.Point(768, 416);
            this.playerHandPanel3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.playerHandPanel3.Name = "playerHandPanel3";
            this.playerHandPanel3.Size = new System.Drawing.Size(354, 140);
            this.playerHandPanel3.TabIndex = 25;
            // 
            // playerHandPanel1
            // 
            this.playerHandPanel1.BackColor = System.Drawing.Color.Transparent;
            this.playerHandPanel1.Cards = null;
            this.playerHandPanel1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerHandPanel1.ForeColor = System.Drawing.Color.Yellow;
            this.playerHandPanel1.Hand = null;
            this.playerHandPanel1.Highlight = false;
            this.playerHandPanel1.Location = new System.Drawing.Point(235, 416);
            this.playerHandPanel1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.playerHandPanel1.Name = "playerHandPanel1";
            this.playerHandPanel1.Size = new System.Drawing.Size(405, 159);
            this.playerHandPanel1.TabIndex = 24;
            // 
            // playerHandPanel2
            // 
            this.playerHandPanel2.BackColor = System.Drawing.Color.Transparent;
            this.playerHandPanel2.Cards = null;
            this.playerHandPanel2.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerHandPanel2.ForeColor = System.Drawing.Color.Yellow;
            this.playerHandPanel2.Hand = null;
            this.playerHandPanel2.Highlight = false;
            this.playerHandPanel2.Location = new System.Drawing.Point(72, 311);
            this.playerHandPanel2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.playerHandPanel2.Name = "playerHandPanel2";
            this.playerHandPanel2.Size = new System.Drawing.Size(385, 140);
            this.playerHandPanel2.TabIndex = 23;
            // 
            // dealerHandPanel
            // 
            this.dealerHandPanel.BackColor = System.Drawing.Color.Transparent;
            this.dealerHandPanel.Cards = null;
            this.dealerHandPanel.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealerHandPanel.ForeColor = System.Drawing.Color.Yellow;
            this.dealerHandPanel.Hand = null;
            this.dealerHandPanel.Highlight = false;
            this.dealerHandPanel.Location = new System.Drawing.Point(483, 98);
            this.dealerHandPanel.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dealerHandPanel.Name = "dealerHandPanel";
            this.dealerHandPanel.Size = new System.Drawing.Size(170, 279);
            this.dealerHandPanel.TabIndex = 22;
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1124, 643);
            this.Controls.Add(this.playerHandPanel4);
            this.Controls.Add(this.playerHandPanel3);
            this.Controls.Add(this.playerHandPanel1);
            this.Controls.Add(this.playerHandPanel2);
            this.Controls.Add(this.dealerHandPanel);
            this.Controls.Add(this.doubleButton);
            this.Controls.Add(this.splitButton);
            this.Controls.Add(this.standButton);
            this.Controls.Add(this.hitButton);
            this.Controls.Add(this.bankGroupBox);
            this.Controls.Add(this.configurationGroupBox);
            this.Name = "FormGame";
            this.Text = "Blackjack";
            this.Load += new System.EventHandler(this.FormGameLoad);
            this.configurationGroupBox.ResumeLayout(false);
            this.configurationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blackjackPayoutNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deckNumericUpDown)).EndInit();
            this.bankGroupBox.ResumeLayout(false);
            this.bankGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.betAmountNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox configurationGroupBox;
        private System.Windows.Forms.CheckBox allowUnnaturalSplitsCheckBox;
        private System.Windows.Forms.NumericUpDown blackjackPayoutNumericUpDown;
        private System.Windows.Forms.Label blackjackPayoutLabel;
        private System.Windows.Forms.NumericUpDown deckNumericUpDown;
        private System.Windows.Forms.Label decksLabel;
        private System.Windows.Forms.GroupBox bankGroupBox;
        private System.Windows.Forms.Label resultsLabel;
        private System.Windows.Forms.TextBox bankrollTextBox;
        private System.Windows.Forms.Button dealButton;
        private System.Windows.Forms.Label bankrollLabel;
        private System.Windows.Forms.NumericUpDown betAmountNumericUpDown;
        private System.Windows.Forms.Label betAmountLabel;
        private System.Windows.Forms.Button doubleButton;
        private System.Windows.Forms.Button splitButton;
        private System.Windows.Forms.Button standButton;
        private System.Windows.Forms.Button hitButton;
        private BlackjackHandPanel dealerHandPanel;
        private BlackjackHandPanel playerHandPanel2;
        private BlackjackHandPanel playerHandPanel1;
        private BlackjackHandPanel playerHandPanel3;
        private BlackjackHandPanel playerHandPanel4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblLosses;
        private System.Windows.Forms.Label lblTies;
        private System.Windows.Forms.Label lblWins;
    }
}

