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
            this.Heart = new System.Windows.Forms.PictureBox();
            this.Heart1 = new System.Windows.Forms.PictureBox();
            this.Heart2 = new System.Windows.Forms.PictureBox();
            this.bar = new System.Windows.Forms.PictureBox();
            this.gameTick = new System.Windows.Forms.Timer(this.components);
            this.CContenedor = new System.Windows.Forms.PictureBox();
            this.DColor = new System.Windows.Forms.PictureBox();
            this.Contador = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Heart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Heart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Heart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CContenedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DColor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoler2
            // 
            this.btnVoler2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoler2.BackColor = System.Drawing.Color.Transparent;
            this.btnVoler2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoler2.BackgroundImage")));
            this.btnVoler2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoler2.FlatAppearance.BorderSize = 0;
            this.btnVoler2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnVoler2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnVoler2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoler2.Location = new System.Drawing.Point(1257, 12);
            this.btnVoler2.Name = "btnVoler2";
            this.btnVoler2.Size = new System.Drawing.Size(70, 75);
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
            this.Player.Location = new System.Drawing.Point(29, 202);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(80, 80);
            this.Player.TabIndex = 7;
            this.Player.TabStop = false;
            // 
            // Heart
            // 
            this.Heart.BackColor = System.Drawing.Color.Transparent;
            this.Heart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Heart.BackgroundImage")));
            this.Heart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Heart.Location = new System.Drawing.Point(10, 10);
            this.Heart.Name = "Heart";
            this.Heart.Size = new System.Drawing.Size(45, 45);
            this.Heart.TabIndex = 8;
            this.Heart.TabStop = false;
            this.Heart.Tag = "life";
            // 
            // Heart1
            // 
            this.Heart1.BackColor = System.Drawing.Color.Transparent;
            this.Heart1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Heart1.BackgroundImage")));
            this.Heart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Heart1.Location = new System.Drawing.Point(57, 10);
            this.Heart1.Name = "Heart1";
            this.Heart1.Size = new System.Drawing.Size(45, 45);
            this.Heart1.TabIndex = 9;
            this.Heart1.TabStop = false;
            this.Heart1.Tag = "life";
            // 
            // Heart2
            // 
            this.Heart2.BackColor = System.Drawing.Color.Transparent;
            this.Heart2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Heart2.BackgroundImage")));
            this.Heart2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Heart2.Location = new System.Drawing.Point(103, 10);
            this.Heart2.Name = "Heart2";
            this.Heart2.Size = new System.Drawing.Size(45, 45);
            this.Heart2.TabIndex = 10;
            this.Heart2.TabStop = false;
            this.Heart2.Tag = "life";
            // 
            // bar
            // 
            this.bar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bar.BackColor = System.Drawing.Color.Transparent;
            this.bar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bar.BackgroundImage")));
            this.bar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bar.Location = new System.Drawing.Point(475, 47);
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(472, 28);
            this.bar.TabIndex = 12;
            this.bar.TabStop = false;
            // 
            // gameTick
            // 
            this.gameTick.Enabled = true;
            this.gameTick.Interval = 1;
            this.gameTick.Tick += new System.EventHandler(this.GameTick_Tick);
            // 
            // CContenedor
            // 
            this.CContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CContenedor.BackColor = System.Drawing.Color.Transparent;
            this.CContenedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CContenedor.BackgroundImage")));
            this.CContenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CContenedor.Location = new System.Drawing.Point(4, 661);
            this.CContenedor.Name = "CContenedor";
            this.CContenedor.Size = new System.Drawing.Size(159, 63);
            this.CContenedor.TabIndex = 13;
            this.CContenedor.TabStop = false;
            this.CContenedor.Tag = "";
            // 
            // DColor
            // 
            this.DColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DColor.Location = new System.Drawing.Point(94, 673);
            this.DColor.Name = "DColor";
            this.DColor.Size = new System.Drawing.Size(51, 32);
            this.DColor.TabIndex = 14;
            this.DColor.TabStop = false;
            // 
            // Contador
            // 
            this.Contador.Enabled = true;
            this.Contador.Interval = 1000;
            this.Contador.Tick += new System.EventHandler(this.Contador_Tick);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.DColor);
            this.Controls.Add(this.CContenedor);
            this.Controls.Add(this.bar);
            this.Controls.Add(this.Heart2);
            this.Controls.Add(this.Heart1);
            this.Controls.Add(this.Heart);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.btnVoler2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Form8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form8";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form8_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form8_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Heart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Heart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Heart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CContenedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DColor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVoler2;
        private System.Windows.Forms.Timer moveTimer;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox Heart;
        private System.Windows.Forms.PictureBox Heart1;
        private System.Windows.Forms.PictureBox Heart2;
        private System.Windows.Forms.PictureBox bar;
        private System.Windows.Forms.Timer gameTick;
        private System.Windows.Forms.PictureBox CContenedor;
        private System.Windows.Forms.PictureBox DColor;
        private System.Windows.Forms.Timer Contador;
    }
}