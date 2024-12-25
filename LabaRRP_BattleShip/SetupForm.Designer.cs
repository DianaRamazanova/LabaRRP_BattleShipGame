namespace LabaRRP_BattleShip
{
    partial class SetupForm
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
        /// 

        private System.Windows.Forms.Label lblFourDeck;
        private System.Windows.Forms.Label lblThreeDeck;
        private System.Windows.Forms.Label lblTwoDeck;
        private System.Windows.Forms.Label lblOneDeck;
        private void InitializeComponent()
        {
            this.lblFourDeck = new System.Windows.Forms.Label();
            this.lblThreeDeck = new System.Windows.Forms.Label();
            this.lblTwoDeck = new System.Windows.Forms.Label();
            this.lblOneDeck = new System.Windows.Forms.Label();

            // lblFourDeck
            this.lblFourDeck.AutoSize = true;
            this.lblFourDeck.Location = new System.Drawing.Point(12, 350);
            this.lblFourDeck.Name = "lblFourDeck";
            this.lblFourDeck.Size = new System.Drawing.Size(130, 13);
            this.lblFourDeck.TabIndex = 3;
            this.lblFourDeck.Text = "Четырехпалубных: 1";

            // lblThreeDeck
            this.lblThreeDeck.AutoSize = true;
            this.lblThreeDeck.Location = new System.Drawing.Point(12, 370);
            this.lblThreeDeck.Name = "lblThreeDeck";
            this.lblThreeDeck.Size = new System.Drawing.Size(120, 13);
            this.lblThreeDeck.TabIndex = 4;
            this.lblThreeDeck.Text = "Трехпалубных: 2";

            // lblTwoDeck
            this.lblTwoDeck.AutoSize = true;
            this.lblTwoDeck.Location = new System.Drawing.Point(12, 390);
            this.lblTwoDeck.Name = "lblTwoDeck";
            this.lblTwoDeck.Size = new System.Drawing.Size(110, 13);
            this.lblTwoDeck.TabIndex = 5;
            this.lblTwoDeck.Text = "Двухпалубных: 3";

            // lblOneDeck
            this.lblOneDeck.AutoSize = true;
            this.lblOneDeck.Location = new System.Drawing.Point(12, 410);
            this.lblOneDeck.Name = "lblOneDeck";
            this.lblOneDeck.Size = new System.Drawing.Size(100, 13);
            this.lblOneDeck.TabIndex = 6;
            this.lblOneDeck.Text = "Однопалубных: 4";

            // Добавление элементов на форму
            this.Controls.Add(this.lblFourDeck);
            this.Controls.Add(this.lblThreeDeck);
            this.Controls.Add(this.lblTwoDeck);
            this.Controls.Add(this.lblOneDeck);
        }

        #endregion

        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.Button btnDone;
    }
}
