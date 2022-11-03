namespace Bill_E_Proyecto_2022
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnJugar = new System.Windows.Forms.Button();
            this.btnManejar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnJugar
            // 
            this.btnJugar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnJugar.BackColor = System.Drawing.Color.Transparent;
            this.btnJugar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnJugar.BackgroundImage")));
            this.btnJugar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnJugar.FlatAppearance.BorderSize = 0;
            this.btnJugar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnJugar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnJugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJugar.ForeColor = System.Drawing.Color.Transparent;
            this.btnJugar.Location = new System.Drawing.Point(43, 142);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(156, 65);
            this.btnJugar.TabIndex = 0;
            this.btnJugar.UseVisualStyleBackColor = false;
            this.btnJugar.Click += new System.EventHandler(this.BtnJugar_Click);
            this.btnJugar.MouseEnter += new System.EventHandler(this.BtnJugar_MouseEnter);
            this.btnJugar.MouseLeave += new System.EventHandler(this.BtnJugar_MouseLeave);
            // 
            // btnManejar
            // 
            this.btnManejar.BackColor = System.Drawing.Color.Transparent;
            this.btnManejar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnManejar.BackgroundImage")));
            this.btnManejar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnManejar.FlatAppearance.BorderSize = 0;
            this.btnManejar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnManejar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnManejar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManejar.Location = new System.Drawing.Point(605, 142);
            this.btnManejar.Name = "btnManejar";
            this.btnManejar.Size = new System.Drawing.Size(156, 65);
            this.btnManejar.TabIndex = 1;
            this.btnManejar.UseVisualStyleBackColor = false;
            this.btnManejar.Click += new System.EventHandler(this.BtnManejar_Click);
            this.btnManejar.MouseEnter += new System.EventHandler(this.BtnJugar_MouseEnter);
            this.btnManejar.MouseLeave += new System.EventHandler(this.BtnJugar_MouseLeave);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(13, 13);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(82, 67);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnManejar);
            this.Controls.Add(this.btnJugar);
            this.DoubleBuffered = true;
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Button btnManejar;
        private System.Windows.Forms.Button btnSalir;
    }
}