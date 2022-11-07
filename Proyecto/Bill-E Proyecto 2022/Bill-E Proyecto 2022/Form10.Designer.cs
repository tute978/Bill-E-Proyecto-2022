namespace Bill_E_Proyecto_2022
{
    partial class Form10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnJuegos = new System.Windows.Forms.Button();
            this.lblTuTiempo = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.BackColor = System.Drawing.Color.Transparent;
            this.btnReiniciar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReiniciar.BackgroundImage")));
            this.btnReiniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReiniciar.FlatAppearance.BorderSize = 0;
            this.btnReiniciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnReiniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnReiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReiniciar.Location = new System.Drawing.Point(205, 409);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(176, 154);
            this.btnReiniciar.TabIndex = 0;
            this.btnReiniciar.UseVisualStyleBackColor = false;
            this.btnReiniciar.Click += new System.EventHandler(this.BtnReiniciar_Click);
            this.btnReiniciar.MouseEnter += new System.EventHandler(this.MouseEnter_btn);
            this.btnReiniciar.MouseLeave += new System.EventHandler(this.MouseLeave_btn);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHome.BackgroundImage")));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Location = new System.Drawing.Point(572, 409);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(176, 154);
            this.btnHome.TabIndex = 1;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.BtnHome_Click);
            this.btnHome.MouseEnter += new System.EventHandler(this.MouseEnter_btn);
            this.btnHome.MouseLeave += new System.EventHandler(this.MouseLeave_btn);
            // 
            // btnJuegos
            // 
            this.btnJuegos.BackColor = System.Drawing.Color.Transparent;
            this.btnJuegos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnJuegos.BackgroundImage")));
            this.btnJuegos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnJuegos.FlatAppearance.BorderSize = 0;
            this.btnJuegos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnJuegos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnJuegos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJuegos.Location = new System.Drawing.Point(936, 409);
            this.btnJuegos.Name = "btnJuegos";
            this.btnJuegos.Size = new System.Drawing.Size(176, 154);
            this.btnJuegos.TabIndex = 2;
            this.btnJuegos.UseVisualStyleBackColor = false;
            this.btnJuegos.Click += new System.EventHandler(this.BtnJuegos_Click);
            this.btnJuegos.MouseEnter += new System.EventHandler(this.MouseEnter_btn);
            this.btnJuegos.MouseLeave += new System.EventHandler(this.MouseLeave_btn);
            // 
            // lblTuTiempo
            // 
            this.lblTuTiempo.AutoSize = true;
            this.lblTuTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuTiempo.Location = new System.Drawing.Point(302, 655);
            this.lblTuTiempo.Name = "lblTuTiempo";
            this.lblTuTiempo.Size = new System.Drawing.Size(0, 20);
            this.lblTuTiempo.TabIndex = 3;
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.BackColor = System.Drawing.Color.Transparent;
            this.lblTiempo.Cursor = System.Windows.Forms.Cursors.No;
            this.lblTiempo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.Location = new System.Drawing.Point(295, 644);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(0, 31);
            this.lblTiempo.TabIndex = 4;
            this.lblTiempo.Click += new System.EventHandler(this.LblTiempo_Click);
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.lblTuTiempo);
            this.Controls.Add(this.btnJuegos);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnReiniciar);
            this.DoubleBuffered = true;
            this.Name = "Form10";
            this.Text = "Form10";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnJuegos;
        private System.Windows.Forms.Label lblTuTiempo;
        private System.Windows.Forms.Label lblTiempo;
    }
}