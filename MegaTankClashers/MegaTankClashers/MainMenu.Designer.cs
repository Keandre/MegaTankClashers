namespace MegaTankClashers
{
    partial class MainMenu
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPlay = new System.Windows.Forms.Label();
            this.lblControls = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(98, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(554, 47);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Welcome to Mega Tank Clashers";
            // 
            // lblPlay
            // 
            this.lblPlay.AutoSize = true;
            this.lblPlay.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlay.Location = new System.Drawing.Point(321, 186);
            this.lblPlay.Name = "lblPlay";
            this.lblPlay.Size = new System.Drawing.Size(97, 47);
            this.lblPlay.TabIndex = 1;
            this.lblPlay.Text = "Play ";
            this.lblPlay.Click += new System.EventHandler(this.LblPlay_Click);
            this.lblPlay.MouseLeave += new System.EventHandler(this.LblPlay_MouseLeave);
            this.lblPlay.MouseHover += new System.EventHandler(this.LblPlay_MouseHover);
            // 
            // lblControls
            // 
            this.lblControls.AutoSize = true;
            this.lblControls.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControls.Location = new System.Drawing.Point(287, 247);
            this.lblControls.Name = "lblControls";
            this.lblControls.Size = new System.Drawing.Size(159, 47);
            this.lblControls.TabIndex = 2;
            this.lblControls.Text = "Controls";
            this.lblControls.Click += new System.EventHandler(this.LblControls_Click);
            this.lblControls.MouseLeave += new System.EventHandler(this.LblControls_MouseLeave);
            this.lblControls.MouseHover += new System.EventHandler(this.LblControls_MouseHover);
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.Location = new System.Drawing.Point(323, 311);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(78, 47);
            this.lblExit.TabIndex = 3;
            this.lblExit.Text = "Exit";
            this.lblExit.Click += new System.EventHandler(this.LblExit_Click);
            this.lblExit.MouseEnter += new System.EventHandler(this.LblExit_MouseEnter);
            this.lblExit.MouseLeave += new System.EventHandler(this.LblExit_MouseLeave);
            this.lblExit.MouseHover += new System.EventHandler(this.LblExit_MouseHover);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 557);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.lblControls);
            this.Controls.Add(this.lblPlay);
            this.Controls.Add(this.lblTitle);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPlay;
        private System.Windows.Forms.Label lblControls;
        private System.Windows.Forms.Label lblExit;
    }
}