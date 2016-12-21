namespace UzayYolu
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
            this.Rocket = new System.Windows.Forms.PictureBox();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Rocket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Rocket
            // 
            this.Rocket.BackColor = System.Drawing.Color.Transparent;
            this.Rocket.Image = global::UzayYolu.Properties.Resources.Pokemon_Go_01_128;
            this.Rocket.Location = new System.Drawing.Point(150, 265);
            this.Rocket.Name = "Rocket";
            this.Rocket.Size = new System.Drawing.Size(114, 114);
            this.Rocket.TabIndex = 1;
            this.Rocket.TabStop = false;
            // 
            // PictureBox
            // 
            this.PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox.Image = global::UzayYolu.Properties.Resources._91__Ice_Skating__winter_christmas_holiday_1281;
            this.PictureBox.Location = new System.Drawing.Point(12, 192);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(132, 240);
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.BackgroundImage = global::UzayYolu.Properties.Resources.forest_at_night_background_wallpaper_2;
            this.ClientSize = new System.Drawing.Size(726, 444);
            this.Controls.Add(this.Rocket);
            this.Controls.Add(this.PictureBox);
            this.Name = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Rocket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox SpaceShip;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.PictureBox Rocket;
        private System.Windows.Forms.Timer timer1;
    }
}

