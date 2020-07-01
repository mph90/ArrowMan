namespace ArrowMan
{
    partial class Form1
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
            this.GameWindow = new System.Windows.Forms.PictureBox();
            this.FrameTick = new System.Windows.Forms.Timer(this.components);
            this.SpawnTick = new System.Windows.Forms.Timer(this.components);
            this.BobTick = new System.Windows.Forms.Timer(this.components);
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.GameOverLabel = new System.Windows.Forms.Label();
            this.FinalScoreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GameWindow)).BeginInit();
            this.SuspendLayout();
            // 
            // GameWindow
            // 
            this.GameWindow.BackColor = System.Drawing.Color.Black;
            this.GameWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GameWindow.Location = new System.Drawing.Point(0, 0);
            this.GameWindow.Name = "GameWindow";
            this.GameWindow.Size = new System.Drawing.Size(1305, 745);
            this.GameWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.GameWindow.TabIndex = 0;
            this.GameWindow.TabStop = false;
            this.GameWindow.Paint += new System.Windows.Forms.PaintEventHandler(this.GameWindow_Paint);
            // 
            // FrameTick
            // 
            this.FrameTick.Enabled = true;
            this.FrameTick.Interval = 20;
            this.FrameTick.Tick += new System.EventHandler(this.FrameTick_Tick);
            // 
            // SpawnTick
            // 
            this.SpawnTick.Enabled = true;
            this.SpawnTick.Interval = 5000;
            this.SpawnTick.Tick += new System.EventHandler(this.SpawnTick_Tick);
            // 
            // BobTick
            // 
            this.BobTick.Enabled = true;
            this.BobTick.Interval = 1000;
            this.BobTick.Tick += new System.EventHandler(this.BobTick_Tick);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.ScoreLabel.Font = new System.Drawing.Font("Visitor TT1 BRK", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.ForeColor = System.Drawing.Color.White;
            this.ScoreLabel.Location = new System.Drawing.Point(12, 9);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(104, 19);
            this.ScoreLabel.TabIndex = 1;
            this.ScoreLabel.Text = "Score: 0";
            // 
            // GameOverLabel
            // 
            this.GameOverLabel.AutoSize = true;
            this.GameOverLabel.BackColor = System.Drawing.Color.Transparent;
            this.GameOverLabel.Font = new System.Drawing.Font("Visitor TT1 BRK", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameOverLabel.ForeColor = System.Drawing.Color.White;
            this.GameOverLabel.Location = new System.Drawing.Point(360, 285);
            this.GameOverLabel.Name = "GameOverLabel";
            this.GameOverLabel.Size = new System.Drawing.Size(559, 86);
            this.GameOverLabel.TabIndex = 2;
            this.GameOverLabel.Text = "Game Over";
            this.GameOverLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GameOverLabel.Visible = false;
            // 
            // FinalScoreLabel
            // 
            this.FinalScoreLabel.AutoSize = true;
            this.FinalScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.FinalScoreLabel.Font = new System.Drawing.Font("Visitor TT1 BRK", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalScoreLabel.ForeColor = System.Drawing.Color.White;
            this.FinalScoreLabel.Location = new System.Drawing.Point(378, 384);
            this.FinalScoreLabel.Name = "FinalScoreLabel";
            this.FinalScoreLabel.Size = new System.Drawing.Size(524, 19);
            this.FinalScoreLabel.TabIndex = 3;
            this.FinalScoreLabel.Text = "Your score was 0. Press SPACE to restart.";
            this.FinalScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FinalScoreLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1305, 745);
            this.Controls.Add(this.FinalScoreLabel);
            this.Controls.Add(this.GameOverLabel);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.GameWindow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.GameWindow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox GameWindow;
        private System.Windows.Forms.Timer FrameTick;
        private System.Windows.Forms.Timer SpawnTick;
        private System.Windows.Forms.Timer BobTick;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label GameOverLabel;
        private System.Windows.Forms.Label FinalScoreLabel;
    }
}

