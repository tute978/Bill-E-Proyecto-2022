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
            this.btnVolver3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.Transparent;
            this.btnIniciar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIniciar.BackgroundImage")));
            this.btnIniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIniciar.FlatAppearance.BorderSize = 0;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Location = new System.Drawing.Point(12, 374);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(174, 64);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // btnVolver3
            // 
            this.btnVolver3.BackColor = System.Drawing.Color.Transparent;
            this.btnVolver3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVolver3.BackgroundImage")));
            this.btnVolver3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolver3.FlatAppearance.BorderSize = 0;
            this.btnVolver3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver3.Location = new System.Drawing.Point(706, 12);
            this.btnVolver3.Name = "btnVolver3";
            this.btnVolver3.Size = new System.Drawing.Size(82, 67);
            this.btnVolver3.TabIndex = 1;
            this.btnVolver3.UseVisualStyleBackColor = false;
            this.btnVolver3.Click += new System.EventHandler(this.BtnVolver3_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolver3);
            this.Controls.Add(this.btnIniciar);
            this.DoubleBuffered = true;
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnVolver3;
    }
}