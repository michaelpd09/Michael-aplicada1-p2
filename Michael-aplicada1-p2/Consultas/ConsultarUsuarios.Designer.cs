namespace Michael_aplicada1_p2.Consultas
{
    partial class ConsultarUsuarios
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
            this.SalirButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.EditarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.CamposComboBox = new System.Windows.Forms.ComboBox();
            this.FiltroTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DatosDataGridView = new System.Windows.Forms.DataGridView();
            this.Buscarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SalirButton
            // 
            this.SalirButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SalirButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalirButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SalirButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SalirButton.Location = new System.Drawing.Point(393, 307);
            this.SalirButton.Name = "SalirButton";
            this.SalirButton.Size = new System.Drawing.Size(116, 52);
            this.SalirButton.TabIndex = 76;
            this.SalirButton.Text = "Salir";
            this.SalirButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SalirButton.UseVisualStyleBackColor = true;
            this.SalirButton.Click += new System.EventHandler(this.SalirButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EliminarButton.Enabled = false;
            this.EliminarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EliminarButton.Location = new System.Drawing.Point(271, 307);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(116, 52);
            this.EliminarButton.TabIndex = 75;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // EditarButton
            // 
            this.EditarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EditarButton.Enabled = false;
            this.EditarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditarButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EditarButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EditarButton.Location = new System.Drawing.Point(149, 307);
            this.EditarButton.Name = "EditarButton";
            this.EditarButton.Size = new System.Drawing.Size(116, 52);
            this.EditarButton.TabIndex = 74;
            this.EditarButton.Text = "Editar";
            this.EditarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EditarButton.UseVisualStyleBackColor = true;
            this.EditarButton.Click += new System.EventHandler(this.EditarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.NuevoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NuevoButton.Location = new System.Drawing.Point(27, 307);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(116, 52);
            this.NuevoButton.TabIndex = 73;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // CamposComboBox
            // 
            this.CamposComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CamposComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CamposComboBox.FormattingEnabled = true;
            this.CamposComboBox.Items.AddRange(new object[] {
            "Nombre y Fecha"});
            this.CamposComboBox.Location = new System.Drawing.Point(82, 16);
            this.CamposComboBox.Name = "CamposComboBox";
            this.CamposComboBox.Size = new System.Drawing.Size(121, 28);
            this.CamposComboBox.TabIndex = 72;
            // 
            // FiltroTextBox
            // 
            this.FiltroTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FiltroTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.FiltroTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltroTextBox.Location = new System.Drawing.Point(209, 18);
            this.FiltroTextBox.Name = "FiltroTextBox";
            this.FiltroTextBox.Size = new System.Drawing.Size(160, 26);
            this.FiltroTextBox.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(23, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 71;
            this.label1.Text = "Filtrar ";
            // 
            // DatosDataGridView
            // 
            this.DatosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosDataGridView.Location = new System.Drawing.Point(27, 86);
            this.DatosDataGridView.Name = "DatosDataGridView";
            this.DatosDataGridView.Size = new System.Drawing.Size(482, 215);
            this.DatosDataGridView.TabIndex = 69;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Buscarbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscarbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(374, 18);
            this.Buscarbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(135, 52);
            this.Buscarbutton.TabIndex = 77;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // ConsultarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 377);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.SalirButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.EditarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.CamposComboBox);
            this.Controls.Add(this.FiltroTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DatosDataGridView);
            this.Name = "ConsultarUsuarios";
            this.Text = "ConsultarUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SalirButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button EditarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.ComboBox CamposComboBox;
        private System.Windows.Forms.TextBox FiltroTextBox;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView DatosDataGridView;
        private System.Windows.Forms.Button Buscarbutton;
    }
}