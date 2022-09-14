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
            this.SuspendLayout();
            // 
            // btnLaberinto
            // 
            this.btnLaberinto.BackColor = System.Drawing.Color.Transparent;
            this.btnLaberinto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLaberinto.BackgroundImage")));
            this.btnLaberinto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLaberinto.Location = new System.Drawing.Point(60, 155);
            this.btnLaberinto.Name = "btnLaberinto";
            this.btnLaberinto.Size = new System.Drawing.Size(214, 78);
            this.btnLaberinto.TabIndex = 0;
            this.btnLaberinto.UseVisualStyleBackColor = false;
            // 
            // btnContrarreloj
            // 
            this.btnContrarreloj.BackColor = System.Drawing.Color.Transparent;
            this.btnContrarreloj.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnContrarreloj.BackgroundImage")));
            this.btnContrarreloj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnContrarreloj.Location = new System.Drawing.Point(516, 155);
            this.btnContrarreloj.Name = "btnContrarreloj";
            this.btnContrarreloj.Size = new System.Drawing.Size(214, 78);
            this.btnContrarreloj.TabIndex = 1;
            this.btnContrarreloj.UseVisualStyleBackColor = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnContrarreloj);
            this.Controls.Add(this.btnLaberinto);
            this.DoubleBuffered = true;
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLaberinto;
        private System.Windows.Forms.Button btnContrarreloj;
    }
}