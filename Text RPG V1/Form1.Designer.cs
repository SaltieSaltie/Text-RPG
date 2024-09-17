namespace Text_RPG_V1
{
    partial class Game
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblName = new Label();
            txtInputName = new TextBox();
            btnConfirmName = new Button();
            txtOutputGame = new RichTextBox();
            lblPlayerHealth = new Label();
            txtOutputPlayerHealth = new RichTextBox();
            lblPlayerMana = new Label();
            txtOutputPlayerMana = new RichTextBox();
            btnStartGame = new Button();
            lblCurrentRoom = new Label();
            txtOutputCurrentRoom = new RichTextBox();
            lblGoldCount = new Label();
            txtOutputGoldCount = new RichTextBox();
            btnGoNextRoom = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.Black;
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(12, 9);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            lblName.Click += lblName_Click;
            // 
            // txtInputName
            // 
            txtInputName.Location = new Point(59, 10);
            txtInputName.Name = "txtInputName";
            txtInputName.Size = new Size(100, 23);
            txtInputName.TabIndex = 1;
            txtInputName.TextChanged += txtInputName_TextChanged;
            // 
            // btnConfirmName
            // 
            btnConfirmName.Location = new Point(171, 13);
            btnConfirmName.Name = "btnConfirmName";
            btnConfirmName.Size = new Size(75, 23);
            btnConfirmName.TabIndex = 2;
            btnConfirmName.Text = "Confirm Name";
            btnConfirmName.UseVisualStyleBackColor = true;
            btnConfirmName.Click += btnConfirmName_Click;
            // 
            // txtOutputGame
            // 
            txtOutputGame.BackColor = Color.FromArgb(0, 0, 64);
            txtOutputGame.ForeColor = Color.White;
            txtOutputGame.Location = new Point(21, 71);
            txtOutputGame.Name = "txtOutputGame";
            txtOutputGame.ReadOnly = true;
            txtOutputGame.Size = new Size(769, 524);
            txtOutputGame.TabIndex = 3;
            txtOutputGame.Text = "";
            // 
            // lblPlayerHealth
            // 
            lblPlayerHealth.AutoSize = true;
            lblPlayerHealth.ForeColor = Color.Red;
            lblPlayerHealth.Location = new Point(302, 19);
            lblPlayerHealth.Name = "lblPlayerHealth";
            lblPlayerHealth.Size = new Size(45, 15);
            lblPlayerHealth.TabIndex = 4;
            lblPlayerHealth.Text = "Health:";
            // 
            // txtOutputPlayerHealth
            // 
            txtOutputPlayerHealth.BackColor = Color.Black;
            txtOutputPlayerHealth.BorderStyle = BorderStyle.None;
            txtOutputPlayerHealth.ForeColor = Color.Red;
            txtOutputPlayerHealth.Location = new Point(353, 17);
            txtOutputPlayerHealth.Name = "txtOutputPlayerHealth";
            txtOutputPlayerHealth.ReadOnly = true;
            txtOutputPlayerHealth.Size = new Size(53, 23);
            txtOutputPlayerHealth.TabIndex = 5;
            txtOutputPlayerHealth.Text = "";
            txtOutputPlayerHealth.TextChanged += txtOutputPlayerHealth_TextChanged;
            // 
            // lblPlayerMana
            // 
            lblPlayerMana.AutoSize = true;
            lblPlayerMana.ForeColor = Color.Blue;
            lblPlayerMana.Location = new Point(412, 19);
            lblPlayerMana.Name = "lblPlayerMana";
            lblPlayerMana.Size = new Size(40, 15);
            lblPlayerMana.TabIndex = 6;
            lblPlayerMana.Text = "Mana:";
            // 
            // txtOutputPlayerMana
            // 
            txtOutputPlayerMana.BackColor = Color.Black;
            txtOutputPlayerMana.BorderStyle = BorderStyle.None;
            txtOutputPlayerMana.ForeColor = Color.Blue;
            txtOutputPlayerMana.Location = new Point(458, 18);
            txtOutputPlayerMana.Name = "txtOutputPlayerMana";
            txtOutputPlayerMana.ReadOnly = true;
            txtOutputPlayerMana.Size = new Size(68, 18);
            txtOutputPlayerMana.TabIndex = 7;
            txtOutputPlayerMana.Text = "";
            txtOutputPlayerMana.TextChanged += txtOutputPlayerMana_TextChanged;
            // 
            // btnStartGame
            // 
            btnStartGame.Location = new Point(811, 19);
            btnStartGame.Name = "btnStartGame";
            btnStartGame.Size = new Size(116, 23);
            btnStartGame.TabIndex = 8;
            btnStartGame.Text = "Start Game";
            btnStartGame.UseVisualStyleBackColor = true;
            btnStartGame.Click += btnStartGame_Click;
            // 
            // lblCurrentRoom
            // 
            lblCurrentRoom.AutoSize = true;
            lblCurrentRoom.ForeColor = Color.White;
            lblCurrentRoom.Location = new Point(303, 44);
            lblCurrentRoom.Name = "lblCurrentRoom";
            lblCurrentRoom.Size = new Size(42, 15);
            lblCurrentRoom.TabIndex = 9;
            lblCurrentRoom.Text = "Room:";
            // 
            // txtOutputCurrentRoom
            // 
            txtOutputCurrentRoom.BackColor = Color.Black;
            txtOutputCurrentRoom.BorderStyle = BorderStyle.None;
            txtOutputCurrentRoom.ForeColor = Color.White;
            txtOutputCurrentRoom.Location = new Point(342, 41);
            txtOutputCurrentRoom.Name = "txtOutputCurrentRoom";
            txtOutputCurrentRoom.ReadOnly = true;
            txtOutputCurrentRoom.Size = new Size(47, 21);
            txtOutputCurrentRoom.TabIndex = 10;
            txtOutputCurrentRoom.Text = "";
            // 
            // lblGoldCount
            // 
            lblGoldCount.AutoSize = true;
            lblGoldCount.ForeColor = Color.Yellow;
            lblGoldCount.Location = new Point(414, 47);
            lblGoldCount.Name = "lblGoldCount";
            lblGoldCount.Size = new Size(35, 15);
            lblGoldCount.TabIndex = 11;
            lblGoldCount.Text = "Gold:";
            // 
            // txtOutputGoldCount
            // 
            txtOutputGoldCount.BackColor = Color.Black;
            txtOutputGoldCount.BorderStyle = BorderStyle.None;
            txtOutputGoldCount.ForeColor = Color.Yellow;
            txtOutputGoldCount.Location = new Point(449, 47);
            txtOutputGoldCount.Name = "txtOutputGoldCount";
            txtOutputGoldCount.ReadOnly = true;
            txtOutputGoldCount.Size = new Size(42, 18);
            txtOutputGoldCount.TabIndex = 12;
            txtOutputGoldCount.Text = "";
            // 
            // btnGoNextRoom
            // 
            btnGoNextRoom.Location = new Point(811, 71);
            btnGoNextRoom.Name = "btnGoNextRoom";
            btnGoNextRoom.Size = new Size(116, 23);
            btnGoNextRoom.TabIndex = 13;
            btnGoNextRoom.Text = "Next Room";
            btnGoNextRoom.UseVisualStyleBackColor = true;
            btnGoNextRoom.Click += btnGoNextRoom_Click;
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(972, 617);
            Controls.Add(btnGoNextRoom);
            Controls.Add(txtOutputGoldCount);
            Controls.Add(lblGoldCount);
            Controls.Add(txtOutputCurrentRoom);
            Controls.Add(lblCurrentRoom);
            Controls.Add(btnStartGame);
            Controls.Add(txtOutputPlayerMana);
            Controls.Add(lblPlayerMana);
            Controls.Add(txtOutputPlayerHealth);
            Controls.Add(lblPlayerHealth);
            Controls.Add(txtOutputGame);
            Controls.Add(btnConfirmName);
            Controls.Add(txtInputName);
            Controls.Add(lblName);
            Name = "Game";
            Text = "Game";
            Load += Game_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private TextBox txtInputName;
        private Button btnConfirmName;
        private RichTextBox txtOutputGame;
        private Label lblPlayerHealth;
        private RichTextBox txtOutputPlayerHealth;
        private Label lblPlayerMana;
        private RichTextBox txtOutputPlayerMana;
        private Button btnStartGame;
        private Label lblCurrentRoom;
        private RichTextBox txtOutputCurrentRoom;
        private Label lblGoldCount;
        private RichTextBox txtOutputGoldCount;
        private Button btnGoNextRoom;
    }
}
