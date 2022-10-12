namespace Bill_E_Proyecto_2022
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnVoler2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.Transparent;
            this.btnIniciar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIniciar.BackgroundImage")));
            this.btnIniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIniciar.FlatAppearance.BorderSize = 0;
            this.btnIniciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnIniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Location = new System.Drawing.Point(12, 374);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(174, 64);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            this.btnIniciar.MouseEnter += new System.EventHandler(this.BtnVolver_MouseEnter);
            this.btnIniciar.MouseLeave += new System.EventHandler(this.BtnVolver_MouseLeave);
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
            this.btnVoler2.Location = new System.Drawing.Point(719, 4);
            this.btnVoler2.Name = "btnVoler2";
            this.btnVoler2.Size = new System.Drawing.Size(75, 67);
            this.btnVoler2.TabIndex = 3;
            this.btnVoler2.UseVisualStyleBackColor = false;
            this.btnVoler2.Click += new System.EventHandler(this.BtnVoler2_Click);
            this.btnVoler2.MouseEnter += new System.EventHandler(this.BtnVolver_MouseEnter);
            this.btnVoler2.MouseLeave += new System.EventHandler(this.BtnVolver_MouseLeave);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoler2);
            this.Controls.Add(this.btnIniciar);
            this.DoubleBuffered = true;
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnVoler2;
    }
}