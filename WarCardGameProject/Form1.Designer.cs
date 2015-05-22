namespace WarCardGameProject {
    partial class Form1 {
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
            this.btn_exit = new System.Windows.Forms.Button();
            this.player1 = new System.Windows.Forms.Label();
            this.player2 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.score2 = new System.Windows.Forms.TextBox();
            this.score1 = new System.Windows.Forms.TextBox();
            this.p1 = new System.Windows.Forms.GroupBox();
            this.p2 = new System.Windows.Forms.GroupBox();
            this.finalScore = new System.Windows.Forms.GroupBox();
            this.fsp1 = new System.Windows.Forms.Label();
            this.fsp2 = new System.Windows.Forms.Label();
            this.fstb1 = new System.Windows.Forms.TextBox();
            this.fstb2 = new System.Windows.Forms.TextBox();
            this.p1.SuspendLayout();
            this.p2.SuspendLayout();
            this.finalScore.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(497, 326);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // player1
            // 
            this.player1.AutoSize = true;
            this.player1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1.ForeColor = System.Drawing.Color.DimGray;
            this.player1.Location = new System.Drawing.Point(44, 99);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(70, 19);
            this.player1.TabIndex = 1;
            this.player1.Text = "Player 1";
            // 
            // player2
            // 
            this.player2.AutoSize = true;
            this.player2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2.ForeColor = System.Drawing.Color.DimGray;
            this.player2.Location = new System.Drawing.Point(43, 99);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(70, 19);
            this.player2.TabIndex = 2;
            this.player2.Text = "Player 2";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(195, 210);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(200, 30);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Starn Game";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btn_play
            // 
            this.btn_play.Location = new System.Drawing.Point(195, 210);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(200, 30);
            this.btn_play.TabIndex = 4;
            this.btn_play.Text = "Play";
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // score2
            // 
            this.score2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score2.Location = new System.Drawing.Point(72, 35);
            this.score2.Name = "score2";
            this.score2.Size = new System.Drawing.Size(58, 33);
            this.score2.TabIndex = 5;
            // 
            // score1
            // 
            this.score1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score1.Location = new System.Drawing.Point(73, 35);
            this.score1.Name = "score1";
            this.score1.Size = new System.Drawing.Size(56, 33);
            this.score1.TabIndex = 6;
            // 
            // p1
            // 
            this.p1.Controls.Add(this.score1);
            this.p1.Controls.Add(this.player1);
            this.p1.Location = new System.Drawing.Point(40, 45);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(200, 145);
            this.p1.TabIndex = 9;
            this.p1.TabStop = false;
            this.p1.Text = "Player 1";
            // 
            // p2
            // 
            this.p2.Controls.Add(this.score2);
            this.p2.Controls.Add(this.player2);
            this.p2.Location = new System.Drawing.Point(340, 45);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(200, 145);
            this.p2.TabIndex = 10;
            this.p2.TabStop = false;
            this.p2.Text = "Player 2";
            // 
            // finalScore
            // 
            this.finalScore.Controls.Add(this.fstb2);
            this.finalScore.Controls.Add(this.fstb1);
            this.finalScore.Controls.Add(this.fsp2);
            this.finalScore.Controls.Add(this.fsp1);
            this.finalScore.Location = new System.Drawing.Point(175, 25);
            this.finalScore.Name = "finalScore";
            this.finalScore.Size = new System.Drawing.Size(241, 159);
            this.finalScore.TabIndex = 8;
            this.finalScore.TabStop = false;
            this.finalScore.Text = "Final Score";
            // 
            // fsp1
            // 
            this.fsp1.AutoSize = true;
            this.fsp1.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fsp1.Location = new System.Drawing.Point(30, 55);
            this.fsp1.Name = "fsp1";
            this.fsp1.Size = new System.Drawing.Size(68, 19);
            this.fsp1.TabIndex = 0;
            this.fsp1.Text = "Player 1:";
            // 
            // fsp2
            // 
            this.fsp2.AutoSize = true;
            this.fsp2.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fsp2.Location = new System.Drawing.Point(30, 103);
            this.fsp2.Name = "fsp2";
            this.fsp2.Size = new System.Drawing.Size(68, 19);
            this.fsp2.TabIndex = 1;
            this.fsp2.Text = "Player 2:";
            // 
            // fstb1
            // 
            this.fstb1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fstb1.Location = new System.Drawing.Point(131, 56);
            this.fstb1.Name = "fstb1";
            this.fstb1.Size = new System.Drawing.Size(57, 26);
            this.fstb1.TabIndex = 2;
            // 
            // fstb2
            // 
            this.fstb2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fstb2.Location = new System.Drawing.Point(131, 100);
            this.fstb2.Name = "fstb2";
            this.fstb2.Size = new System.Drawing.Size(57, 26);
            this.fstb2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.finalScore);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btn_exit);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "War Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.p1.ResumeLayout(false);
            this.p1.PerformLayout();
            this.p2.ResumeLayout(false);
            this.p2.PerformLayout();
            this.finalScore.ResumeLayout(false);
            this.finalScore.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label player1;
        private System.Windows.Forms.Label player2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.TextBox score2;
        private System.Windows.Forms.TextBox score1;
        private System.Windows.Forms.GroupBox p1;
        private System.Windows.Forms.GroupBox p2;
        private System.Windows.Forms.GroupBox finalScore;
        private System.Windows.Forms.TextBox fstb2;
        private System.Windows.Forms.TextBox fstb1;
        private System.Windows.Forms.Label fsp2;
        private System.Windows.Forms.Label fsp1;
    }
}

