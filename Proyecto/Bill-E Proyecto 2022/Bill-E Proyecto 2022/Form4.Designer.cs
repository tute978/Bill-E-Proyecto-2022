namespace Bill_E_Proyecto_2022
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.btnLaberinto = new System.Windows.Forms.Button();
            this.btnContrarreloj = new System.Windows.Forms.Button();
            this.btnVoler2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLaberinto
            // 
            this.btnLaberinto.BackColor = System.Drawing.Color.Transparent;
            this.btnLaberinto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLaberinto.BackgroundImage")));
            this.btnLaberinto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLaberinto.FlatAppearance.BorderSize = 0;
            this.btnLaberinto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLaberinto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLaberinto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaberinto.Location = new System.Drawing.Point(154, 263);
            this.btnLaberinto.Name = "btnLaberinto";
            this.btnLaberinto.Size = new System.Drawing.Size(291, 96);
            this.btnLaberinto.TabIndex = 0;
            this.btnLaberinto.UseVisualStyleBackColor = false;
            this.btnLaberinto.Click += new System.EventHandler(this.BtnLaberinto_Click);
            this.btnLaberinto.MouseEnter += new System.EventHandler(this.BtnJugar_MouseEnter);
            this.btnLaberinto.MouseLeave += new System.EventHandler(this.BtnJugar_MouseLeave);
            // 
            // btnContrarreloj
            // 
            this.btnContrarreloj.BackColor = System.Drawing.Color.Transparent;
            this.btnContrarreloj.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnContrarreloj.BackgroundImage")));
            this.btnContrarreloj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnContrarreloj.FlatAppearance.BorderSize = 0;
            this.btnContrarreloj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnContrarreloj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnContrarreloj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContrarreloj.Location = new System.Drawing.Point(905, 263);
            this.btnContrarreloj.Name = "btnContrarreloj";
            this.btnContrarreloj.Size = new System.Drawing.Size(313, 96);
            this.btnContrarreloj.TabIndex = 1;
            this.btnContrarreloj.UseVisualStyleBackColor = false;
            this.btnContrarreloj.Click += new System.EventHandler(this.BtnContrarreloj_Click);
            this.btnContrarreloj.MouseEnter += new System.EventHandler(this.BtnJugar_MouseEnter);
            this.btnContrarreloj.MouseLeave += new System.EventHandler(this.BtnJugar_MouseLeave);
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
            this.btnVoler2.Location = new System.Drawing.Point(1233, 12);
            this.btnVoler2.Name = "btnVoler2";
            this.btnVoler2.Size = new System.Drawing.Size(105, 103);
            this.btnVoler2.TabIndex = 2;
            this.btnVoler2.UseVisualStyleBackColor = false;
            this.btnVoler2.Click += new System.EventHandler(this.BtnVoler2_Click);
            this.btnVoler2.MouseEnter += new System.EventHandler(this.BtnJugar_MouseEnter);
            this.btnVoler2.MouseLeave += new System.EventHandler(this.BtnJugar_MouseLeave);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.btnVoler2);
            this.Controls.Add(this.btnContrarreloj);
            this.Controls.Add(this.btnLaberinto);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLaberinto;
        private System.Windows.Forms.Button btnContrarreloj;
        private System.Windows.Forms.Button btnVoler2;
    }
}