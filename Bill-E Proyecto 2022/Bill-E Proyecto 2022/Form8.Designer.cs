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
            this.redBall = new System.Windows.Forms.PictureBox();
            this.yellowBall = new System.Windows.Forms.PictureBox();
            this.blueBall = new System.Windows.Forms.PictureBox();
            this.greenBall = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenBall)).BeginInit();
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
            this.Player.Location = new System.Drawing.Point(117, 171);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(60, 60);
            this.Player.TabIndex = 7;
            this.Player.TabStop = false;
            // 
            // redBall
            // 
            this.redBall.BackColor = System.Drawing.Color.Transparent;
            this.redBall.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("redBall.BackgroundImage")));
            this.redBall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.redBall.Location = new System.Drawing.Point(383, 286);
            this.redBall.Name = "redBall";
            this.redBall.Size = new System.Drawing.Size(35, 35);
            this.redBall.TabIndex = 8;
            this.redBall.TabStop = false;
            this.redBall.Tag = "redBall";
            // 
            // yellowBall
            // 
            this.yellowBall.BackColor = System.Drawing.Color.Transparent;
            this.yellowBall.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("yellowBall.BackgroundImage")));
            this.yellowBall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.yellowBall.Location = new System.Drawing.Point(436, 208);
            this.yellowBall.Name = "yellowBall";
            this.yellowBall.Size = new System.Drawing.Size(35, 35);
            this.yellowBall.TabIndex = 10;
            this.yellowBall.TabStop = false;
            this.yellowBall.Tag = "yellowBall";
            // 
            // blueBall
            // 
            this.blueBall.BackColor = System.Drawing.Color.Transparent;
            this.blueBall.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("blueBall.BackgroundImage")));
            this.blueBall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.blueBall.Location = new System.Drawing.Point(383, 208);
            this.blueBall.Name = "blueBall";
            this.blueBall.Size = new System.Drawing.Size(35, 35);
            this.blueBall.TabIndex = 12;
            this.blueBall.TabStop = false;
            this.blueBall.Tag = "blueBall";
            // 
            // greenBall
            // 
            this.greenBall.BackColor = System.Drawing.Color.Transparent;
            this.greenBall.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("greenBall.BackgroundImage")));
            this.greenBall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.greenBall.Location = new System.Drawing.Point(436, 286);
            this.greenBall.Name = "greenBall";
            this.greenBall.Size = new System.Drawing.Size(35, 35);
            this.greenBall.TabIndex = 13;
            this.greenBall.TabStop = false;
            this.greenBall.Tag = "greenBall";
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.greenBall);
            this.Controls.Add(this.blueBall);
            this.Controls.Add(this.yellowBall);
            this.Controls.Add(this.redBall);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.btnVoler2);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "Form8";
            this.Text = "Form8";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form8_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form8_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenBall)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVoler2;
        private System.Windows.Forms.Timer moveTimer;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox redBall;
        private System.Windows.Forms.PictureBox yellowBall;
        private System.Windows.Forms.PictureBox blueBall;
        private System.Windows.Forms.PictureBox greenBall;
    }
}