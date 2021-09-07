
namespace Winforms_crear_tablas_dinamicas_base_de_datos.UI
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OPCIONES = new System.Windows.Forms.ToolStripMenuItem();
            this.crearTablaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cAMPOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcion_crearTabla = new System.Windows.Forms.ToolStripMenuItem();
            this.opcion_eliminarTabla = new System.Windows.Forms.ToolStripMenuItem();
            this.opcion_añadirCampo = new System.Windows.Forms.ToolStripMenuItem();
            this.opcioneliminarCampo = new System.Windows.Forms.ToolStripMenuItem();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.materialTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OPCIONES});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(889, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // OPCIONES
            // 
            this.OPCIONES.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearTablaToolStripMenuItem,
            this.cAMPOSToolStripMenuItem});
            this.OPCIONES.Name = "OPCIONES";
            this.OPCIONES.Size = new System.Drawing.Size(76, 20);
            this.OPCIONES.Text = "OPCIONES";
            // 
            // crearTablaToolStripMenuItem
            // 
            this.crearTablaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcion_crearTabla,
            this.opcion_eliminarTabla});
            this.crearTablaToolStripMenuItem.Name = "crearTablaToolStripMenuItem";
            this.crearTablaToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.crearTablaToolStripMenuItem.Text = "TABLAS";
            // 
            // cAMPOSToolStripMenuItem
            // 
            this.cAMPOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcion_añadirCampo,
            this.opcioneliminarCampo});
            this.cAMPOSToolStripMenuItem.Name = "cAMPOSToolStripMenuItem";
            this.cAMPOSToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.cAMPOSToolStripMenuItem.Text = "CAMPOS (columnas)";
            // 
            // opcion_crearTabla
            // 
            this.opcion_crearTabla.Name = "opcion_crearTabla";
            this.opcion_crearTabla.Size = new System.Drawing.Size(180, 22);
            this.opcion_crearTabla.Text = "Crear tabla";
            this.opcion_crearTabla.Click += new System.EventHandler(this.opcion_crearTabla_Click);
            // 
            // opcion_eliminarTabla
            // 
            this.opcion_eliminarTabla.Name = "opcion_eliminarTabla";
            this.opcion_eliminarTabla.Size = new System.Drawing.Size(180, 22);
            this.opcion_eliminarTabla.Text = "Eliminar tabla";
            this.opcion_eliminarTabla.Click += new System.EventHandler(this.opcion_eliminarTabla_Click);
            // 
            // opcion_añadirCampo
            // 
            this.opcion_añadirCampo.Name = "opcion_añadirCampo";
            this.opcion_añadirCampo.Size = new System.Drawing.Size(180, 22);
            this.opcion_añadirCampo.Text = "Añadir campo";
            this.opcion_añadirCampo.Click += new System.EventHandler(this.opcion_añadirCampo_Click);
            // 
            // opcioneliminarCampo
            // 
            this.opcioneliminarCampo.Name = "opcioneliminarCampo";
            this.opcioneliminarCampo.Size = new System.Drawing.Size(180, 22);
            this.opcioneliminarCampo.Text = "Eliminar campo";
            this.opcioneliminarCampo.Click += new System.EventHandler(this.opcioneliminarCampo_Click);
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 29);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(889, 435);
            this.materialTabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(881, 409);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CREAR TABLA";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(881, 409);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ELIMINAR TABLA";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(881, 409);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "AÑADIR CAMPO";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(881, 409);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "ELIMINAR CAMPO";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 464);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "PRACTICA 2 - CREACION DE TABLAS DINAMICAS EN SQL SERVER";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.materialTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem OPCIONES;
        private System.Windows.Forms.ToolStripMenuItem crearTablaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcion_crearTabla;
        private System.Windows.Forms.ToolStripMenuItem opcion_eliminarTabla;
        private System.Windows.Forms.ToolStripMenuItem cAMPOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcion_añadirCampo;
        private System.Windows.Forms.ToolStripMenuItem opcioneliminarCampo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
    }
}