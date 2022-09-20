namespace Bill_E_Proyecto_2022
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.btnIniciar2 = new System.Windows.Forms.Button();
            this.btnVolver5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIniciar2
            // 
            this.btnIniciar2.BackColor = System.Drawing.Color.Transparent;
            this.btnIniciar2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIniciar2.BackgroundImage")));
            this.btnIniciar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIniciar2.FlatAppearance.BorderSize = 0;
            this.btnIniciar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar2.Location = new System.Drawing.Point(12, 374);
            this.btnIniciar2.Name = "btnIniciar2";
            this.btnIniciar2.Size = new System.Drawing.Size(174, 64);
            this.btnIniciar2.TabIndex = 0;
            this.btnIniciar2.UseVisualStyleBackColor = false;
            this.btnIniciar2.Click += new System.EventHandler(this.BtnIniciar2_Click);
            // 
            // btnVolver5
            // 
            this.btnVolver5.BackColor = System.Drawing.Color.Transparent;
            this.btnVolver5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVolver5.BackgroundImage")));
            this.btnVolver5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolver5.FlatAppearance.BorderSize = 0;
            this.btnVolver5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver5.Location = new System.Drawing.Point(706, 12);
            this.btnVolver5.Name = "btnVolver5";
            this.btnVolver5.Size = new System.Drawing.Size(82, 67);
            this.btnVolver5.TabIndex = 1;
            this.btnVolver5.UseVisualStyleBackColor = false;
            this.btnVolver5.Click += new System.EventHandler(this.BtnVolver5_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolver5);
            this.Controls.Add(this.btnIniciar2);
            this.DoubleBuffered = true;
            this.Name = "Form6";
            this.Text = "Form6";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIniciar2;
        private System.Windows.Forms.Button btnVolver5;
    }
}