namespace Michael_aplicada1_p2.Registros
{
    partial class RegistroTiposTelefono
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
            this.label1 = new System.Windows.Forms.Label();
            this.TipoIdtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DescripciontextBox = new System.Windows.Forms.TextBox();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Salirbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TipoId";
            // 
            // TipoIdtextBox
            // 
            this.TipoIdtextBox.Enabled = false;
            this.TipoIdtextBox.Location = new System.Drawing.Point(74, 29);
            this.TipoIdtextBox.Name = "TipoIdtextBox";
            this.TipoIdtextBox.Size = new System.Drawing.Size(100, 20);
            this.TipoIdtextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion";
            // 
            // DescripciontextBox
            // 
            this.DescripciontextBox.Enabled = false;
            this.DescripciontextBox.Location = new System.Drawing.Point(102, 69);
            this.DescripciontextBox.Name = "DescripciontextBox";
            this.DescripciontextBox.Size = new System.Drawing.Size(248, 20);
            this.DescripciontextBox.TabIndex = 3;
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Enabled = false;
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.Guardarbutton.Location = new System.Drawing.Point(145, 126);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(95, 52);
            this.Guardarbutton.TabIndex = 4;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Salirbutton
            // 
            this.Salirbutton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.Salirbutton.Location = new System.Drawing.Point(255, 126);
            this.Salirbutton.Name = "Salirbutton";
            this.Salirbutton.Size = new System.Drawing.Size(95, 52);
            this.Salirbutton.TabIndex = 5;
            this.Salirbutton.Text = "Salir";
            this.Salirbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Salirbutton.UseVisualStyleBackColor = true;
            this.Salirbutton.Click += new System.EventHandler(this.Salirbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.Nuevobutton.Location = new System.Drawing.Point(34, 126);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(95, 52);
            this.Nuevobutton.TabIndex = 6;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // RegistroTiposTelefono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 253);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Salirbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.DescripciontextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TipoIdtextBox);
            this.Controls.Add(this.label1);
            this.Name = "RegistroTiposTelefono";
            this.Text = "RegistroTiposTelefono";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TipoIdtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DescripciontextBox;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Salirbutton;
        private System.Windows.Forms.Button Nuevobutton;
    }
}