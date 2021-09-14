
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
            this.txtNombreTabla = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpiarCamposColumna = new System.Windows.Forms.Button();
            this.btnCrearTabla = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cboListaTablas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEliminarTabla = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnModificarCampos = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cboTablas = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.cboEliminarCampo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.controlColumna3 = new Winforms_crear_tablas_dinamicas_base_de_datos.Controles.controlColumna();
            this.controlColumna2 = new Winforms_crear_tablas_dinamicas_base_de_datos.Controles.controlColumna();
            this.controlColumna1 = new Winforms_crear_tablas_dinamicas_base_de_datos.Controles.controlColumna();
            this.btnEliminarCampos = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
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
            this.opcion_añadirCampo.Size = new System.Drawing.Size(210, 26);
            this.opcion_añadirCampo.Text = "Modificar campo";
            this.opcion_añadirCampo.Click += new System.EventHandler(this.opcion_añadirCampo_Click);
            // 
            // opcioneliminarCampo
            // 
            this.opcioneliminarCampo.Name = "opcioneliminarCampo";
            this.opcioneliminarCampo.Size = new System.Drawing.Size(210, 26);
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
            this.tabPage1.Controls.Add(this.btnLimpiarCamposColumna);
            this.tabPage1.Controls.Add(this.btnCrearTabla);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(881, 409);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CREAR TABLA";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtNombreTabla
            // 
            this.txtNombreTabla.Location = new System.Drawing.Point(237, 34);
            this.txtNombreTabla.MaxLength = 150;
            this.txtNombreTabla.Name = "txtNombreTabla";
            this.txtNombreTabla.Size = new System.Drawing.Size(267, 20);
            this.txtNombreTabla.TabIndex = 9;
            this.txtNombreTabla.Text = "TEST";
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
            // btnLimpiarCamposColumna
            // 
            this.btnLimpiarCamposColumna.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnLimpiarCamposColumna.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLimpiarCamposColumna.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnLimpiarCamposColumna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarCamposColumna.Location = new System.Drawing.Point(423, 265);
            this.btnLimpiarCamposColumna.Name = "btnLimpiarCamposColumna";
            this.btnLimpiarCamposColumna.Size = new System.Drawing.Size(177, 34);
            this.btnLimpiarCamposColumna.TabIndex = 4;
            this.btnLimpiarCamposColumna.Text = "LIMPIAR";
            this.btnLimpiarCamposColumna.UseVisualStyleBackColor = true;
            this.btnLimpiarCamposColumna.Click += new System.EventHandler(this.btnLimpiarCamposColumna_Click);
            // 
            // btnCrearTabla
            // 
            this.btnCrearTabla.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnCrearTabla.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCrearTabla.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnCrearTabla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearTabla.Location = new System.Drawing.Point(188, 265);
            this.btnCrearTabla.Name = "btnCrearTabla";
            this.btnCrearTabla.Size = new System.Drawing.Size(177, 34);
            this.btnCrearTabla.TabIndex = 3;
            this.btnCrearTabla.Text = "CREAR TABLA";
            this.btnCrearTabla.UseVisualStyleBackColor = true;
            this.btnCrearTabla.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cboListaTablas);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.btnEliminarTabla);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(881, 409);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ELIMINAR TABLA";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cboListaTablas
            // 
            this.cboListaTablas.FormattingEnabled = true;
            this.cboListaTablas.Location = new System.Drawing.Point(215, 30);
            this.cboListaTablas.Name = "cboListaTablas";
            this.cboListaTablas.Size = new System.Drawing.Size(201, 21);
            this.cboListaTablas.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Seleccione una tabla:";
            // 
            // btnEliminarTabla
            // 
            this.btnEliminarTabla.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnEliminarTabla.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminarTabla.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnEliminarTabla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarTabla.Location = new System.Drawing.Point(215, 93);
            this.btnEliminarTabla.Name = "btnEliminarTabla";
            this.btnEliminarTabla.Size = new System.Drawing.Size(177, 34);
            this.btnEliminarTabla.TabIndex = 11;
            this.btnEliminarTabla.Text = "ELIMINAR TABLA";
            this.btnEliminarTabla.UseVisualStyleBackColor = true;
            this.btnEliminarTabla.Click += new System.EventHandler(this.btnEliminarTabla_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnModificarCampos);
            this.tabPage3.Controls.Add(this.flowLayoutPanel1);
            this.tabPage3.Controls.Add(this.cboTablas);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(881, 409);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "MODIFICAR CAMPO";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnModificarCampos
            // 
            this.btnModificarCampos.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnModificarCampos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnModificarCampos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnModificarCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarCampos.Location = new System.Drawing.Point(34, 367);
            this.btnModificarCampos.Name = "btnModificarCampos";
            this.btnModificarCampos.Size = new System.Drawing.Size(177, 34);
            this.btnModificarCampos.TabIndex = 18;
            this.btnModificarCampos.Text = "MODIFICAR CAMPOS";
            this.btnModificarCampos.UseVisualStyleBackColor = true;
            this.btnModificarCampos.Click += new System.EventHandler(this.btnModificarCampos_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(34, 47);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(690, 306);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // cboTablas
            // 
            this.cboTablas.FormattingEnabled = true;
            this.cboTablas.Location = new System.Drawing.Point(255, 20);
            this.cboTablas.Name = "cboTablas";
            this.cboTablas.Size = new System.Drawing.Size(201, 21);
            this.cboTablas.TabIndex = 16;
            this.cboTablas.SelectedIndexChanged += new System.EventHandler(this.cboTablas_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Seleccione una tabla:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnEliminarCampos);
            this.tabPage4.Controls.Add(this.flowLayoutPanel2);
            this.tabPage4.Controls.Add(this.cboEliminarCampo);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(881, 409);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "ELIMINAR CAMPO";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(19, 63);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(718, 282);
            this.flowLayoutPanel2.TabIndex = 19;
            // 
            // cboEliminarCampo
            // 
            this.cboEliminarCampo.FormattingEnabled = true;
            this.cboEliminarCampo.Location = new System.Drawing.Point(235, 27);
            this.cboEliminarCampo.Name = "cboEliminarCampo";
            this.cboEliminarCampo.Size = new System.Drawing.Size(201, 21);
            this.cboEliminarCampo.TabIndex = 18;
            this.cboEliminarCampo.SelectedIndexChanged += new System.EventHandler(this.cboEliminarCampo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Seleccione una tabla:";
            // 
            // controlColumna3
            // 
            this.controlColumna3.Location = new System.Drawing.Point(41, 125);
            this.controlColumna3.Name = "controlColumna3";
            this.controlColumna3.Nombre = "";
            this.controlColumna3.Size = new System.Drawing.Size(670, 59);
            this.controlColumna3.TabIndex = 7;
            this.controlColumna3.tipoDato = "";
            // 
            // controlColumna2
            // 
            this.controlColumna2.Location = new System.Drawing.Point(41, 200);
            this.controlColumna2.Name = "controlColumna2";
            this.controlColumna2.Nombre = "";
            this.controlColumna2.Size = new System.Drawing.Size(670, 59);
            this.controlColumna2.TabIndex = 6;
            this.controlColumna2.tipoDato = "";
            // 
            // controlColumna1
            // 
            this.controlColumna1.Location = new System.Drawing.Point(41, 60);
            this.controlColumna1.Name = "controlColumna1";
            this.controlColumna1.Nombre = "";
            this.controlColumna1.Size = new System.Drawing.Size(670, 59);
            this.controlColumna1.TabIndex = 5;
            this.controlColumna1.tipoDato = "";
            // 
            // btnEliminarCampos
            // 
            this.btnEliminarCampos.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnEliminarCampos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminarCampos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnEliminarCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCampos.Location = new System.Drawing.Point(19, 367);
            this.btnEliminarCampos.Name = "btnEliminarCampos";
            this.btnEliminarCampos.Size = new System.Drawing.Size(177, 34);
            this.btnEliminarCampos.TabIndex = 20;
            this.btnEliminarCampos.Text = "Eliminar campos";
            this.btnEliminarCampos.UseVisualStyleBackColor = true;
            this.btnEliminarCampos.Click += new System.EventHandler(this.btnEliminarCampos_Click);
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
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
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
        private System.Windows.Forms.Button btnLimpiarCamposColumna;
        private System.Windows.Forms.Button btnCrearTabla;
        private System.Windows.Forms.TextBox txtNombreTabla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminarTabla;
        private System.Windows.Forms.ComboBox cboListaTablas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboTablas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnModificarCampos;
        private System.Windows.Forms.ComboBox cboEliminarCampo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnEliminarCampos;
    }
}