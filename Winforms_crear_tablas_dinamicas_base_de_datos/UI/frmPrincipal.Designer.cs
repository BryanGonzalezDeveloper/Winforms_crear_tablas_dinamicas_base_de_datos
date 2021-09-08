
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
            this.OPCIONES = new System.Windows.Forms.ToolStripMenuItem();
            this.crearTablaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcion_crearTabla = new System.Windows.Forms.ToolStripMenuItem();
            this.opcion_eliminarTabla = new System.Windows.Forms.ToolStripMenuItem();
            this.cAMPOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcion_añadirCampo = new System.Windows.Forms.ToolStripMenuItem();
            this.opcioneliminarCampo = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.controlColumna1 = new Winforms_crear_tablas_dinamicas_base_de_datos.Controles.controlColumna();
            this.controlColumna2 = new Winforms_crear_tablas_dinamicas_base_de_datos.Controles.controlColumna();
            this.controlColumna3 = new Winforms_crear_tablas_dinamicas_base_de_datos.Controles.controlColumna();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreTabla = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            // OPCIONES
            // 
            this.OPCIONES.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearTablaToolStripMenuItem,
            this.cAMPOSToolStripMenuItem});
            this.OPCIONES.Name = "OPCIONES";
            this.OPCIONES.Size = new System.Drawing.Size(102, 25);
            this.OPCIONES.Text = "OPCIONES";
            // 
            // crearTablaToolStripMenuItem
            // 
            this.crearTablaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcion_crearTabla,
            this.opcion_eliminarTabla});
            this.crearTablaToolStripMenuItem.Name = "crearTablaToolStripMenuItem";
            this.crearTablaToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.crearTablaToolStripMenuItem.Text = "TABLAS";
            // 
            // opcion_crearTabla
            // 
            this.opcion_crearTabla.Name = "opcion_crearTabla";
            this.opcion_crearTabla.Size = new System.Drawing.Size(187, 26);
            this.opcion_crearTabla.Text = "Crear tabla";
            this.opcion_crearTabla.Click += new System.EventHandler(this.opcion_crearTabla_Click);
            // 
            // opcion_eliminarTabla
            // 
            this.opcion_eliminarTabla.Name = "opcion_eliminarTabla";
            this.opcion_eliminarTabla.Size = new System.Drawing.Size(187, 26);
            this.opcion_eliminarTabla.Text = "Eliminar tabla";
            this.opcion_eliminarTabla.Click += new System.EventHandler(this.opcion_eliminarTabla_Click);
            // 
            // cAMPOSToolStripMenuItem
            // 
            this.cAMPOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcion_añadirCampo,
            this.opcioneliminarCampo});
            this.cAMPOSToolStripMenuItem.Name = "cAMPOSToolStripMenuItem";
            this.cAMPOSToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.cAMPOSToolStripMenuItem.Text = "CAMPOS (columnas)";
            // 
            // opcion_añadirCampo
            // 
            this.opcion_añadirCampo.Name = "opcion_añadirCampo";
            this.opcion_añadirCampo.Size = new System.Drawing.Size(200, 26);
            this.opcion_añadirCampo.Text = "Añadir campo";
            this.opcion_añadirCampo.Click += new System.EventHandler(this.opcion_añadirCampo_Click);
            // 
            // opcioneliminarCampo
            // 
            this.opcioneliminarCampo.Name = "opcioneliminarCampo";
            this.opcioneliminarCampo.Size = new System.Drawing.Size(200, 26);
            this.opcioneliminarCampo.Text = "Eliminar campo";
            this.opcioneliminarCampo.Click += new System.EventHandler(this.opcioneliminarCampo_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
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
            this.tabPage1.Controls.Add(this.txtNombreTabla);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.controlColumna3);
            this.tabPage1.Controls.Add(this.controlColumna2);
            this.tabPage1.Controls.Add(this.controlColumna1);
            this.tabPage1.Controls.Add(this.btnLimpiar);
            this.tabPage1.Controls.Add(this.btnCrear);
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
            // btnCrear
            // 
            this.btnCrear.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnCrear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCrear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.Location = new System.Drawing.Point(188, 265);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(177, 34);
            this.btnCrear.TabIndex = 3;
            this.btnCrear.Text = "CREAR TABLA";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Location = new System.Drawing.Point(423, 265);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(177, 34);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // controlColumna1
            // 
            this.controlColumna1.Columna = "";
            this.controlColumna1.Location = new System.Drawing.Point(41, 60);
            this.controlColumna1.Name = "controlColumna1";
            this.controlColumna1.Size = new System.Drawing.Size(670, 59);
            this.controlColumna1.TabIndex = 5;
            this.controlColumna1.tipoDato = "";
            // 
            // controlColumna2
            // 
            this.controlColumna2.Columna = "";
            this.controlColumna2.Location = new System.Drawing.Point(41, 200);
            this.controlColumna2.Name = "controlColumna2";
            this.controlColumna2.Size = new System.Drawing.Size(670, 59);
            this.controlColumna2.TabIndex = 6;
            this.controlColumna2.tipoDato = "";
            // 
            // controlColumna3
            // 
            this.controlColumna3.Columna = "";
            this.controlColumna3.Location = new System.Drawing.Point(41, 125);
            this.controlColumna3.Name = "controlColumna3";
            this.controlColumna3.Size = new System.Drawing.Size(670, 59);
            this.controlColumna3.TabIndex = 7;
            this.controlColumna3.tipoDato = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre de la tabla:";
            // 
            // txtNombreTabla
            // 
            this.txtNombreTabla.Location = new System.Drawing.Point(237, 34);
            this.txtNombreTabla.MaxLength = 150;
            this.txtNombreTabla.Name = "txtNombreTabla";
            this.txtNombreTabla.Size = new System.Drawing.Size(267, 20);
            this.txtNombreTabla.TabIndex = 9;
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
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
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
        private Controles.controlColumna controlColumna3;
        private Controles.controlColumna controlColumna2;
        private Controles.controlColumna controlColumna1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.TextBox txtNombreTabla;
        private System.Windows.Forms.Label label1;
    }
}