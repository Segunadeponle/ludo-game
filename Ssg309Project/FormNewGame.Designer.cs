namespace Ssg309Project
{
    partial class FormNewGame
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
            this.tbxYellowPlayer = new System.Windows.Forms.TextBox();
            this.tbxGreenPlayer = new System.Windows.Forms.TextBox();
            this.tbxRedPlayer = new System.Windows.Forms.TextBox();
            this.tbxBluePlayer = new System.Windows.Forms.TextBox();
            this.cbxYellowPlayer = new System.Windows.Forms.CheckBox();
            this.cbxGreenPlayer = new System.Windows.Forms.CheckBox();
            this.cbxRedPlayer = new System.Windows.Forms.CheckBox();
            this.cbxBluePlayer = new System.Windows.Forms.CheckBox();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tbxYellowPlayer);
            this.groupBox1.Controls.Add(this.tbxGreenPlayer);
            this.groupBox1.Controls.Add(this.tbxRedPlayer);
            this.groupBox1.Controls.Add(this.tbxBluePlayer);
            this.groupBox1.Controls.Add(this.cbxYellowPlayer);
            this.groupBox1.Controls.Add(this.cbxGreenPlayer);
            this.groupBox1.Controls.Add(this.cbxRedPlayer);
            this.groupBox1.Controls.Add(this.cbxBluePlayer);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 252);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Players and Name";
            // 
            // tbxYellowPlayer
            // 
            this.tbxYellowPlayer.Location = new System.Drawing.Point(317, 157);
            this.tbxYellowPlayer.Name = "tbxYellowPlayer";
            this.tbxYellowPlayer.Size = new System.Drawing.Size(196, 32);
            this.tbxYellowPlayer.TabIndex = 3;
            // 
            // tbxGreenPlayer
            // 
            this.tbxGreenPlayer.Location = new System.Drawing.Point(27, 157);
            this.tbxGreenPlayer.Name = "tbxGreenPlayer";
            this.tbxGreenPlayer.Size = new System.Drawing.Size(196, 32);
            this.tbxGreenPlayer.TabIndex = 3;
            // 
            // tbxRedPlayer
            // 
            this.tbxRedPlayer.Location = new System.Drawing.Point(317, 69);
            this.tbxRedPlayer.Name = "tbxRedPlayer";
            this.tbxRedPlayer.Size = new System.Drawing.Size(196, 32);
            this.tbxRedPlayer.TabIndex = 3;
            // 
            // tbxBluePlayer
            // 
            this.tbxBluePlayer.Location = new System.Drawing.Point(27, 69);
            this.tbxBluePlayer.Name = "tbxBluePlayer";
            this.tbxBluePlayer.Size = new System.Drawing.Size(196, 32);
            this.tbxBluePlayer.TabIndex = 3;
            // 
            // cbxYellowPlayer
            // 
            this.cbxYellowPlayer.AutoSize = true;
            this.cbxYellowPlayer.Font = new System.Drawing.Font("Buxton Sketch", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxYellowPlayer.ForeColor = System.Drawing.Color.Yellow;
            this.cbxYellowPlayer.Location = new System.Drawing.Point(297, 122);
            this.cbxYellowPlayer.Name = "cbxYellowPlayer";
            this.cbxYellowPlayer.Size = new System.Drawing.Size(144, 30);
            this.cbxYellowPlayer.TabIndex = 2;
            this.cbxYellowPlayer.Text = "Yellow Player";
            this.cbxYellowPlayer.UseVisualStyleBackColor = true;
            this.cbxYellowPlayer.CheckedChanged += new System.EventHandler(this.cbxYellowPlayer_CheckedChanged);
            // 
            // cbxGreenPlayer
            // 
            this.cbxGreenPlayer.AutoSize = true;
            this.cbxGreenPlayer.Font = new System.Drawing.Font("Buxton Sketch", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGreenPlayer.ForeColor = System.Drawing.Color.Green;
            this.cbxGreenPlayer.Location = new System.Drawing.Point(6, 122);
            this.cbxGreenPlayer.Name = "cbxGreenPlayer";
            this.cbxGreenPlayer.Size = new System.Drawing.Size(138, 30);
            this.cbxGreenPlayer.TabIndex = 2;
            this.cbxGreenPlayer.Text = "Green Player";
            this.cbxGreenPlayer.UseVisualStyleBackColor = true;
            this.cbxGreenPlayer.CheckedChanged += new System.EventHandler(this.cbxGreenPlayer_CheckedChanged);
            // 
            // cbxRedPlayer
            // 
            this.cbxRedPlayer.AutoSize = true;
            this.cbxRedPlayer.Font = new System.Drawing.Font("Buxton Sketch", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxRedPlayer.ForeColor = System.Drawing.Color.Red;
            this.cbxRedPlayer.Location = new System.Drawing.Point(297, 33);
            this.cbxRedPlayer.Name = "cbxRedPlayer";
            this.cbxRedPlayer.Size = new System.Drawing.Size(121, 30);
            this.cbxRedPlayer.TabIndex = 1;
            this.cbxRedPlayer.Text = "Red Player";
            this.cbxRedPlayer.UseVisualStyleBackColor = true;
            this.cbxRedPlayer.CheckedChanged += new System.EventHandler(this.cbxRedPlayer_CheckedChanged);
            // 
            // cbxBluePlayer
            // 
            this.cbxBluePlayer.AutoSize = true;
            this.cbxBluePlayer.Font = new System.Drawing.Font("Buxton Sketch", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxBluePlayer.ForeColor = System.Drawing.Color.Blue;
            this.cbxBluePlayer.Location = new System.Drawing.Point(6, 34);
            this.cbxBluePlayer.Name = "cbxBluePlayer";
            this.cbxBluePlayer.Size = new System.Drawing.Size(127, 30);
            this.cbxBluePlayer.TabIndex = 0;
            this.cbxBluePlayer.Text = "Blue Player";
            this.cbxBluePlayer.UseVisualStyleBackColor = true;
            this.cbxBluePlayer.CheckedChanged += new System.EventHandler(this.cbxBluePlayer_CheckedChanged);
            // 
            // btnStartGame
            // 
            this.btnStartGame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.Location = new System.Drawing.Point(329, 287);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(151, 63);
            this.btnStartGame.TabIndex = 3;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClearAll);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnStartGame);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 385);
            this.panel1.TabIndex = 1;
            // 
            // btnClearAll
            // 
            this.btnClearAll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.Location = new System.Drawing.Point(39, 287);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(151, 63);
            this.btnClearAll.TabIndex = 4;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // FormNewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 385);
            this.Controls.Add(this.panel1);
            this.Name = "FormNewGame";
            this.Text = "FormNewGame";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxYellowPlayer;
        private System.Windows.Forms.TextBox tbxGreenPlayer;
        private System.Windows.Forms.TextBox tbxRedPlayer;
        private System.Windows.Forms.TextBox tbxBluePlayer;
        private System.Windows.Forms.CheckBox cbxYellowPlayer;
        private System.Windows.Forms.CheckBox cbxGreenPlayer;
        private System.Windows.Forms.CheckBox cbxRedPlayer;
        private System.Windows.Forms.CheckBox cbxBluePlayer;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClearAll;
    }
}