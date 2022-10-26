namespace Bill_E_Proyecto_2022
{
    partial class yellowBall
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yellowBall));
            this.btnVoler2 = new System.Windows.Forms.Button();
            this.PBLaberinto = new System.Windows.Forms.PictureBox();
            this.moveTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PBLaberinto)).BeginInit();
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
            this.btnVoler2.Location = new System.Drawing.Point(713, 7);
            this.btnVoler2.Name = "btnVoler2";
            this.btnVoler2.Size = new System.Drawing.Size(75, 67);
            this.btnVoler2.TabIndex = 5;
            this.btnVoler2.UseVisualStyleBackColor = false;
            this.btnVoler2.Click += new System.EventHandler(this.BtnVoler2_Click);
            this.btnVoler2.MouseEnter += new System.EventHandler(this.BtnVolver_MouseEnter);
            this.btnVoler2.MouseLeave += new System.EventHandler(this.BtnVolver_MouseLeave);
            // 
            // PBLaberinto
            // 
            this.PBLaberinto.BackColor = System.Drawing.Color.Transparent;
            this.PBLaberinto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PBLaberinto.BackgroundImage")));
            this.PBLaberinto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBLaberinto.Location = new System.Drawing.Point(89, 217);
            this.PBLaberinto.Name = "PBLaberinto";
            this.PBLaberinto.Size = new System.Drawing.Size(50, 50);
            this.PBLaberinto.TabIndex = 6;
            this.PBLaberinto.TabStop = false;
            // 
            // moveTimer
            // 
            this.moveTimer.Enabled = true;
            this.moveTimer.Interval = 1;
            this.moveTimer.Tick += new System.EventHandler(this.EventoMoveTimer);
            // 
            // yellowBall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PBLaberinto);
            this.Controls.Add(this.btnVoler2);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "yellowBall";
            this.Tag = "yellowBall";
            this.Text = "Form7";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form7_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form7_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.PBLaberinto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVoler2;
        private System.Windows.Forms.PictureBox PBLaberinto;
        private System.Windows.Forms.Timer moveTimer;
    }
}