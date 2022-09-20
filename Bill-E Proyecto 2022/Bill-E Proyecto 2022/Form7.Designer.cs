namespace Bill_E_Proyecto_2022
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.btnVolver4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVolver4
            // 
            this.btnVolver4.BackColor = System.Drawing.Color.Transparent;
            this.btnVolver4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVolver4.BackgroundImage")));
            this.btnVolver4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolver4.FlatAppearance.BorderSize = 0;
            this.btnVolver4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver4.Location = new System.Drawing.Point(713, 13);
            this.btnVolver4.Name = "btnVolver4";
            this.btnVolver4.Size = new System.Drawing.Size(82, 67);
            this.btnVolver4.TabIndex = 0;
            this.btnVolver4.UseVisualStyleBackColor = false;
            this.btnVolver4.Click += new System.EventHandler(this.BtnVolver4_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolver4);
            this.DoubleBuffered = true;
            this.Name = "Form7";
            this.Text = "Form7";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolver4;
    }
}