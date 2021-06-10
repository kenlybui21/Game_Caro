
namespace Game_Caro
{
    partial class CaroView
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
            this.pnlChessBoard = new System.Windows.Forms.Panel();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.prcbCoolDown = new System.Windows.Forms.ProgressBar();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.btnLAN = new System.Windows.Forms.Button();
            this.lbLaw = new System.Windows.Forms.Label();
            this.pbMark = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnlLogo.SuspendLayout();
            this.pnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlChessBoard
            // 
            this.pnlChessBoard.BackColor = System.Drawing.SystemColors.Control;
            this.pnlChessBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlChessBoard.Location = new System.Drawing.Point(13, 13);
            this.pnlChessBoard.Name = "pnlChessBoard";
            this.pnlChessBoard.Size = new System.Drawing.Size(922, 778);
            this.pnlChessBoard.TabIndex = 0;
            // 
            // pnlLogo
            // 
            this.pnlLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLogo.BackColor = System.Drawing.SystemColors.Control;
            this.pnlLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLogo.Controls.Add(this.pbLogo);
            this.pnlLogo.Location = new System.Drawing.Point(958, 13);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(400, 400);
            this.pnlLogo.TabIndex = 1;
            // 
            // pnlControl
            // 
            this.pnlControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlControl.BackColor = System.Drawing.SystemColors.Control;
            this.pnlControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlControl.Controls.Add(this.lbLaw);
            this.pnlControl.Controls.Add(this.btnLAN);
            this.pnlControl.Controls.Add(this.tbIP);
            this.pnlControl.Controls.Add(this.pbMark);
            this.pnlControl.Controls.Add(this.prcbCoolDown);
            this.pnlControl.Controls.Add(this.tbUser);
            this.pnlControl.Location = new System.Drawing.Point(958, 419);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(400, 379);
            this.pnlControl.TabIndex = 0;
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(4, 15);
            this.tbUser.Name = "tbUser";
            this.tbUser.ReadOnly = true;
            this.tbUser.Size = new System.Drawing.Size(159, 22);
            this.tbUser.TabIndex = 0;
            // 
            // prcbCoolDown
            // 
            this.prcbCoolDown.Location = new System.Drawing.Point(4, 64);
            this.prcbCoolDown.Name = "prcbCoolDown";
            this.prcbCoolDown.Size = new System.Drawing.Size(159, 23);
            this.prcbCoolDown.TabIndex = 1;
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(4, 112);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(159, 22);
            this.tbIP.TabIndex = 3;
            this.tbIP.Text = "127.0.0.1";
            // 
            // btnLAN
            // 
            this.btnLAN.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLAN.Location = new System.Drawing.Point(4, 161);
            this.btnLAN.Name = "btnLAN";
            this.btnLAN.Size = new System.Drawing.Size(159, 23);
            this.btnLAN.TabIndex = 4;
            this.btnLAN.Text = "LAN";
            this.btnLAN.UseVisualStyleBackColor = true;
            // 
            // lbLaw
            // 
            this.lbLaw.AutoSize = true;
            this.lbLaw.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLaw.Location = new System.Drawing.Point(56, 266);
            this.lbLaw.Name = "lbLaw";
            this.lbLaw.Size = new System.Drawing.Size(288, 43);
            this.lbLaw.TabIndex = 0;
            this.lbLaw.Text = "5 in line to win";
            // 
            // pbMark
            // 
            this.pbMark.BackgroundImage = global::Game_Caro.Properties.Resources.IMG_20201107_221901_471;
            this.pbMark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbMark.Location = new System.Drawing.Point(213, 15);
            this.pbMark.Name = "pbMark";
            this.pbMark.Size = new System.Drawing.Size(170, 170);
            this.pbMark.TabIndex = 2;
            this.pbMark.TabStop = false;
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImage = global::Game_Caro.Properties.Resources.Logo_BK;
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLogo.Image = global::Game_Caro.Properties.Resources.Logo_BK;
            this.pbLogo.Location = new System.Drawing.Point(4, 23);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(390, 353);
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // CaroView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1425, 810);
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.pnlLogo);
            this.Controls.Add(this.pnlChessBoard);
            this.Name = "CaroView";
            this.Text = "Game Caro";
            this.pnlLogo.ResumeLayout(false);
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlChessBoard;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Button btnLAN;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.PictureBox pbMark;
        private System.Windows.Forms.ProgressBar prcbCoolDown;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.Label lbLaw;
    }
}

