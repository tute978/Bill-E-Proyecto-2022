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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.btnVolver6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVolver6
            // 
            this.btnVolver6.BackColor = System.Drawing.Color.Transparent;
            this.btnVolver6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVolver6.BackgroundImage")));
            this.btnVolver6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolver6.FlatAppearance.BorderSize = 0;
            this.btnVolver6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver6.Location = new System.Drawing.Point(706, 2);
            this.btnVolver6.Name = "btnVolver6";
            this.btnVolver6.Size = new System.Drawing.Size(82, 67);
            this.btnVolver6.TabIndex = 0;
            this.btnVolver6.UseVisualStyleBackColor = false;
            this.btnVolver6.Click += new System.EventHandler(this.BtnVolver6_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolver6);
            this.DoubleBuffered = true;
            this.Name = "Form8";
            this.Text = "Form8";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolver6;
    }
}