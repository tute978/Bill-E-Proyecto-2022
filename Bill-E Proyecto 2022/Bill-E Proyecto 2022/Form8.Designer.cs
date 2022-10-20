namespace Bill_E_Proyecto_2022
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.btnVoler2 = new System.Windows.Forms.Button();
            this.moveTimer = new System.Windows.Forms.Timer(this.components);
            this.Player = new System.Windows.Forms.PictureBox();
            this.Red = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoler2
            // 
            this.btnVoler2.BackColor = System.Drawing.Color.Transparent;
            this.btnVoler2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoler2.BackgroundImage")));
            this.btnVoler2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoler2.FlatAppearance.BorderSize = 0;
            this.btnVoler2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnVoler2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnVoler2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoler2.Location = new System.Drawing.Point(718, 5);
            this.btnVoler2.Name = "btnVoler2";
            this.btnVoler2.Size = new System.Drawing.Size(75, 67);
            this.btnVoler2.TabIndex = 6;
            this.btnVoler2.UseVisualStyleBackColor = false;
            this.btnVoler2.Click += new System.EventHandler(this.BtnVoler2_Click);
            this.btnVoler2.MouseEnter += new System.EventHandler(this.BtnVolver_MouseEnter);
            this.btnVoler2.MouseLeave += new System.EventHandler(this.BtnVolver_MouseLeave);
            // 
            // moveTimer
            // 
            this.moveTimer.Enabled = true;
            this.moveTimer.Interval = 1;
            this.moveTimer.Tick += new System.EventHandler(this.EventoMoveTimer);
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Player.BackgroundImage")));
            this.Player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Player.Location = new System.Drawing.Point(112, 131);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(60, 60);
            this.Player.TabIndex = 7;
            this.Player.TabStop = false;
            // 
            // Red
            // 
            this.Red.BackColor = System.Drawing.Color.Transparent;
            this.Red.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Red.BackgroundImage")));
            this.Red.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Red.Location = new System.Drawing.Point(235, 237);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(35, 35);
            this.Red.TabIndex = 8;
            this.Red.TabStop = false;
            this.Red.Tag = "redBall";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(383, 208);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "redBall";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(511, 131);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "redBall";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(297, 71);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 35);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "redBall";
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Red);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.btnVoler2);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "Form8";
            this.Text = "Form8";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form8_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form8_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVoler2;
        private System.Windows.Forms.Timer moveTimer;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox Red;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}