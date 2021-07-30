
namespace CheckNationalityGame
{
    partial class CheckNationalityGame
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
            this.components = new System.ComponentModel.Container();
            this.ChinesePicBox = new System.Windows.Forms.PictureBox();
            this.JapanesePicBox = new System.Windows.Forms.PictureBox();
            this.ThaiPicBox = new System.Windows.Forms.PictureBox();
            this.KoreanPicBox = new System.Windows.Forms.PictureBox();
            this.lblChinese = new System.Windows.Forms.Label();
            this.Japaneselbl = new System.Windows.Forms.Label();
            this.Koreanlbl = new System.Windows.Forms.Label();
            this.Thailbl = new System.Windows.Forms.Label();
            this.RandomPic = new System.Windows.Forms.PictureBox();
            this.RepeatTimer = new System.Windows.Forms.Timer(this.components);
            this.BtnStart = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblRating = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ChinesePicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JapanesePicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThaiPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KoreanPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RandomPic)).BeginInit();
            this.SuspendLayout();
            // 
            // ChinesePicBox
            // 
            this.ChinesePicBox.Image = global::CheckNationalityGame.Properties.Resources.Box;
            this.ChinesePicBox.Location = new System.Drawing.Point(12, 12);
            this.ChinesePicBox.Name = "ChinesePicBox";
            this.ChinesePicBox.Size = new System.Drawing.Size(80, 80);
            this.ChinesePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ChinesePicBox.TabIndex = 0;
            this.ChinesePicBox.TabStop = false;
            // 
            // JapanesePicBox
            // 
            this.JapanesePicBox.Image = global::CheckNationalityGame.Properties.Resources.Box;
            this.JapanesePicBox.Location = new System.Drawing.Point(656, 12);
            this.JapanesePicBox.Name = "JapanesePicBox";
            this.JapanesePicBox.Size = new System.Drawing.Size(80, 80);
            this.JapanesePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.JapanesePicBox.TabIndex = 1;
            this.JapanesePicBox.TabStop = false;
            // 
            // ThaiPicBox
            // 
            this.ThaiPicBox.Image = global::CheckNationalityGame.Properties.Resources.Box;
            this.ThaiPicBox.Location = new System.Drawing.Point(656, 423);
            this.ThaiPicBox.Name = "ThaiPicBox";
            this.ThaiPicBox.Size = new System.Drawing.Size(80, 80);
            this.ThaiPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ThaiPicBox.TabIndex = 2;
            this.ThaiPicBox.TabStop = false;
            // 
            // KoreanPicBox
            // 
            this.KoreanPicBox.Image = global::CheckNationalityGame.Properties.Resources.Box;
            this.KoreanPicBox.Location = new System.Drawing.Point(12, 423);
            this.KoreanPicBox.Name = "KoreanPicBox";
            this.KoreanPicBox.Size = new System.Drawing.Size(80, 80);
            this.KoreanPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.KoreanPicBox.TabIndex = 3;
            this.KoreanPicBox.TabStop = false;
            // 
            // lblChinese
            // 
            this.lblChinese.AutoSize = true;
            this.lblChinese.Location = new System.Drawing.Point(25, 95);
            this.lblChinese.Name = "lblChinese";
            this.lblChinese.Size = new System.Drawing.Size(49, 15);
            this.lblChinese.TabIndex = 4;
            this.lblChinese.Text = "Chinese";
            // 
            // Japaneselbl
            // 
            this.Japaneselbl.AutoSize = true;
            this.Japaneselbl.Location = new System.Drawing.Point(674, 95);
            this.Japaneselbl.Name = "Japaneselbl";
            this.Japaneselbl.Size = new System.Drawing.Size(54, 15);
            this.Japaneselbl.TabIndex = 5;
            this.Japaneselbl.Text = "Japanese";
            // 
            // Koreanlbl
            // 
            this.Koreanlbl.AutoSize = true;
            this.Koreanlbl.Location = new System.Drawing.Point(31, 405);
            this.Koreanlbl.Name = "Koreanlbl";
            this.Koreanlbl.Size = new System.Drawing.Size(44, 15);
            this.Koreanlbl.TabIndex = 6;
            this.Koreanlbl.Text = "Korean";
            // 
            // Thailbl
            // 
            this.Thailbl.AutoSize = true;
            this.Thailbl.Location = new System.Drawing.Point(680, 405);
            this.Thailbl.Name = "Thailbl";
            this.Thailbl.Size = new System.Drawing.Size(29, 15);
            this.Thailbl.TabIndex = 7;
            this.Thailbl.Text = "Thai";
            // 
            // RandomPic
            // 
            this.RandomPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RandomPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RandomPic.Location = new System.Drawing.Point(327, 196);
            this.RandomPic.Name = "RandomPic";
            this.RandomPic.Size = new System.Drawing.Size(130, 130);
            this.RandomPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RandomPic.TabIndex = 8;
            this.RandomPic.TabStop = false;
            this.RandomPic.Visible = false;
            this.RandomPic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RandomPic_MouseDown);
            this.RandomPic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RandomPic_MouseMove);
            // 
            // RepeatTimer
            // 
            this.RepeatTimer.Tick += new System.EventHandler(this.RepeatTimer_Tick);
            // 
            // BtnStart
            // 
            this.BtnStart.BackgroundImage = global::CheckNationalityGame.Properties.Resources.Start;
            this.BtnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnStart.Location = new System.Drawing.Point(10, 192);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(45, 45);
            this.BtnStart.TabIndex = 9;
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImage = global::CheckNationalityGame.Properties.Resources.Reset;
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReset.Location = new System.Drawing.Point(10, 243);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(45, 45);
            this.btnReset.TabIndex = 10;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRating.ForeColor = System.Drawing.Color.Green;
            this.lblRating.Location = new System.Drawing.Point(403, 12);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(17, 19);
            this.lblRating.TabIndex = 11;
            this.lblRating.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(316, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Your Score";
            // 
            // CheckNationalityGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 515);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.RandomPic);
            this.Controls.Add(this.Thailbl);
            this.Controls.Add(this.Koreanlbl);
            this.Controls.Add(this.Japaneselbl);
            this.Controls.Add(this.lblChinese);
            this.Controls.Add(this.KoreanPicBox);
            this.Controls.Add(this.ThaiPicBox);
            this.Controls.Add(this.JapanesePicBox);
            this.Controls.Add(this.ChinesePicBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CheckNationalityGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckNationality";
            ((System.ComponentModel.ISupportInitialize)(this.ChinesePicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JapanesePicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThaiPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KoreanPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RandomPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ChinesePicBox;
        private System.Windows.Forms.PictureBox JapanesePicBox;
        private System.Windows.Forms.PictureBox ThaiPicBox;
        private System.Windows.Forms.PictureBox KoreanPicBox;
        private System.Windows.Forms.Label lblChinese;
        private System.Windows.Forms.Label Japaneselbl;
        private System.Windows.Forms.Label Koreanlbl;
        private System.Windows.Forms.Label Thailbl;
        private System.Windows.Forms.PictureBox RandomPic;
        private System.Windows.Forms.Timer RepeatTimer;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label label1;
    }
}

