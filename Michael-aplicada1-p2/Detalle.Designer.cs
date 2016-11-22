namespace Michael_aplicada1_p2
{
    partial class Detalle
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.registrarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteTelefonosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telefonoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarTelefonosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteTelefonosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telefonosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarClienteToolStripMenuItem,
            this.clienteTelefonosToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(167, 48);
            // 
            // registrarClienteToolStripMenuItem
            // 
            this.registrarClienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.telefonoToolStripMenuItem});
            this.registrarClienteToolStripMenuItem.Name = "registrarClienteToolStripMenuItem";
            this.registrarClienteToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.registrarClienteToolStripMenuItem.Text = "Registrar Cliente";
            // 
            // clienteTelefonosToolStripMenuItem
            // 
            this.clienteTelefonosToolStripMenuItem.Name = "clienteTelefonosToolStripMenuItem";
            this.clienteTelefonosToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.clienteTelefonosToolStripMenuItem.Text = "Cliente Telefonos";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // telefonoToolStripMenuItem
            // 
            this.telefonoToolStripMenuItem.Name = "telefonoToolStripMenuItem";
            this.telefonoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.telefonoToolStripMenuItem.Text = "Telefono";
            // 
            // registrarTelefonosToolStripMenuItem
            // 
            this.registrarTelefonosToolStripMenuItem.Name = "registrarTelefonosToolStripMenuItem";
            this.registrarTelefonosToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.registrarTelefonosToolStripMenuItem.Text = "Registrar Telefonos";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(647, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registarClienteToolStripMenuItem,
            this.clienteTelefonosToolStripMenuItem1});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // registarClienteToolStripMenuItem
            // 
            this.registarClienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.telefonosToolStripMenuItem});
            this.registarClienteToolStripMenuItem.Name = "registarClienteToolStripMenuItem";
            this.registarClienteToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.registarClienteToolStripMenuItem.Text = "Registar";
            // 
            // clienteTelefonosToolStripMenuItem1
            // 
            this.clienteTelefonosToolStripMenuItem1.Name = "clienteTelefonosToolStripMenuItem1";
            this.clienteTelefonosToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.clienteTelefonosToolStripMenuItem1.Text = "Cliente Telefonos";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // telefonosToolStripMenuItem
            // 
            this.telefonosToolStripMenuItem.Name = "telefonosToolStripMenuItem";
            this.telefonosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.telefonosToolStripMenuItem.Text = "Telefonos";
            this.telefonosToolStripMenuItem.Click += new System.EventHandler(this.telefonosToolStripMenuItem_Click);
            // 
            // Detalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 349);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Detalle";
            this.Text = "Detalle";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteTelefonosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem telefonoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarTelefonosToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem telefonosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteTelefonosToolStripMenuItem1;
    }
}